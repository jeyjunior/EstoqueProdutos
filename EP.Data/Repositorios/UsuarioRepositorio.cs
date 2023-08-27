using Dapper;
using EP.Data.Entidades;
using EP.Data.Interfaces;
using EP.Data.sql;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Repositorios;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EP.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public virtual IEnumerable<Usuario> ObterTabela()
        {
            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                string sql = "SELECT * FROM Usuario";
                return connection.Query<Usuario>(sql);
            }
        }

        public virtual IEnumerable<Usuario> ObterTabelaComRelacionamentos() 
        {
            string sql = "SELECT\n" +
                "   U.PK_Usuario,\n" +
                "   U.NomeCompleto,\n" +
                "   U.NomeAbreviado,\n" +
                "   U.Email,\n" +
                "   U.FK_Setor,\n" +
                "   U.FK_Cargo,\n" +
                "   S.*,\n" +
                "   C.*\n" +
                "FROM Usuario U\n" +
                "INNER JOIN Setor S ON S.PK_Setor = U.FK_Setor\n" +
                "INNER JOIN Cargo C ON C.PK_Cargo = U.FK_Cargo\n";

            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                return connection.Query<Usuario, Setor, Cargo, Usuario>(
                    sql: sql,
                    map: (usuario, setor, cargo) =>
                    {
                        usuario.Setor = setor;
                        usuario.Cargo = cargo;

                        return usuario;
                    },
                    splitOn: "PK_Usuario, PK_Setor, PK_Cargo"); 
            }
        }

        public virtual bool InserirDadosNaTabela(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO Usuario (NomeCompleto, NomeAbreviado, FK_Setor, FK_Cargo, Email, Senha, DataCadastro,  FK_Imagem, Ativo)\n" +
                    "VALUES (@NomeCompleto, @NomeAbreviado, @FK_Setor, @FK_Cargo, @Email, @Senha, @DataCadastro,@FK_Imagem , @Ativo)\n";

                var resultado = connection.Execute(sql, usuario);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
