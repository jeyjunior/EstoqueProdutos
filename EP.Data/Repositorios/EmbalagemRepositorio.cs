using Dapper;
using EP.Data.Interfaces;
using EP.Data.sql;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Repositorios
{
    public class EmbalagemRepositorio : RepositorioGenerico<Embalagem>, IEmbalagemRepositorio
    {
        public virtual IEnumerable<Embalagem> ObterTabela()
        {
            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                string sql = "SELECT * FROM Embalagem";
                return connection.Query<Embalagem>(sql);
            }
        }

        public virtual bool InserirDadosNaTabela(Embalagem embalagem)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO Embalagem\n" +
                    "VALUES (@Nome, @Descricao)\n";

                var resultado = connection.Execute(sql, embalagem);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
