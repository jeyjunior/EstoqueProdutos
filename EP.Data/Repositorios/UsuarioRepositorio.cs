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

        public virtual IEnumerable<Usuario> UsuarioLogin(UsuarioLoginAcess usuarioLoginAcess)
        {
            string sql = "";

            sql = "SELECT TOP 1\n" +
                "   U.*\n" +
                "FROM Usuario U\n" +
                "WHERE U.Email = @Email AND U.Ativo = @Ativo";

            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                return connection.Query<Usuario>(sql, usuarioLoginAcess);
            }
        }

        public virtual IEnumerable<Usuario> ObterUsuario(Usuario usuarioParametros)
        {
            string sql = "";

            sql = "SELECT TOP 1\n" +
                "   U.*,\n" +
                "   S.*,\n" +
                "   C.*\n" +
                "FROM Usuario U\n" +
                "INNER JOIN Setor S ON S.PK_Setor = U.FK_Setor\n" +
                "INNER JOIN Cargo C ON C.PK_Cargo = U.FK_Cargo\n" +

                "WHERE U.Email = @Email";

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
                    usuarioParametros,
                    splitOn: "PK_Usuario, PK_Setor, PK_Cargo");
            }
        }

        public virtual IEnumerable<Usuario> ObterTabelaFiltroTelaUsuarios(Usuario usuarioParametros) 
        {
            string sql = "";
            string where = "";
            string condicao = "";

            where = "WHERE Ativo = @Ativo\n";

            if (usuarioParametros.NomeCompleto != "")
            {
                condicao += "AND U.NomeCompleto LIKE @NomeCompleto\n";
            }

            if (usuarioParametros.FK_Setor > 0)
            {
                condicao += "AND U.FK_Setor = @FK_Setor\n";
            }

            if (usuarioParametros.FK_Cargo > 0)
            {
                condicao += "AND U.FK_Cargo = @FK_Cargo\n";
            }

            sql = "SELECT\n" +
                "   U.PK_Usuario,\n" +
                "   U.NomeCompleto,\n" +
                "   U.NomeAbreviado,\n" +
                "   U.Email,\n" +
                "   U.FK_Setor,\n" +
                "   U.FK_Cargo,\n" +
                "   U.FK_Imagem,\n" +
                "   S.*,\n" +
                "   C.*\n" +
                "FROM Usuario U\n" +
                "INNER JOIN Setor S ON S.PK_Setor = U.FK_Setor\n" +
                "INNER JOIN Cargo C ON C.PK_Cargo = U.FK_Cargo\n" +
                where + (condicao != "" ? condicao : "");

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
                    usuarioParametros,
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

        public virtual bool AtualizarDadosNaTabela(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "UPDATE Usuario \n" +
                    "SET NomeCompleto = @NomeCompleto, \n" +
                    "    NomeAbreviado = @NomeAbreviado, \n" +
                    "    FK_Setor = @FK_Setor, \n" +
                    "    FK_Cargo = @FK_Cargo, \n" +
                    "    Email = @Email, \n" +
                    "    Senha = CASE WHEN @Senha IS NOT NULL AND @Senha <> 0 THEN @Senha ELSE Senha END, \n" +
                    "    FK_Imagem = @FK_Imagem \n" +
                    "WHERE PK_Usuario = @PK_Usuario\n"; // Supondo que PK_Usuario seja a chave primária

                var resultado = connection.Execute(sql, usuario);
                return Convert.ToBoolean(resultado);
            }
        }

        public bool ExcluirUsuario(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "DECLARE @ImagemID INT \n" +
                    "SELECT @ImagemID = FK_Imagem \n" +
                    "FROM Usuario \n" +
                    "WHERE PK_Usuario = @PK_Usuario \n" +


                    "DELETE FROM Usuario\n" +
                    "WHERE PK_Usuario = @PK_Usuario; \n" +

                    "IF @ImagemID > 1 \n" +
                    "BEGIN \n" +
                    "   DELETE FROM Imagem  \n" +
                    "   WHERE PK_Imagem = @ImagemID \n" +
                    "END \n";

                var resultado = connection.Execute(sql, usuario);
                return Convert.ToBoolean(resultado);
            }
        }

        public bool AlterarAtivoUsuario(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "UPDATE Usuario \n" +
                    "SET Ativo = @Ativo \n" +
                    "WHERE PK_Usuario = @PK_Usuario\n";

                var resultado = connection.Execute(sql, usuario);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
