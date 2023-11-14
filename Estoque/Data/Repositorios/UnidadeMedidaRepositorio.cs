using Dapper;
using EP.Data.Interfaces;
using EP.Data.sql;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Repositorios
{
    public class UnidadeMedidaRepositorio : IUnidadeMedidaRepositorio
    {
        public virtual IEnumerable<UnidadeMedida> ObterTabela()
        {
            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                string sql = "SELECT * FROM UnidadeMedida";
                return connection.Query<UnidadeMedida>(sql);
            }
        }

        public virtual bool InserirDadosNaTabela(UnidadeMedida  unidadeMedida)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO UnidadeMedida\n" +
                    "VALUES (@Sigla, @Extenso)\n";

                var resultado = connection.Execute(sql, unidadeMedida);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
