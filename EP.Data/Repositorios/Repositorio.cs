using Dapper;
using EP.Data.sql;
using EstoqueProdutos.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;

namespace EstoqueProdutos.Repositorios
{
    /// <summary>
    /// Fornecer os metodos base para consultas na base de dados
    /// </summary>
    /// <typeparam name="T">Entidade Repositorio </typeparam>
    public partial class Repositorio<T> : IRepositorio<T>
    {
        protected readonly string conexao = Conexao.ConexaoBase;

        public IEnumerable<T> ObterTabela()
        {
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();
                string sql = $"SELECT * FROM {typeof(T).Name}";
                IEnumerable<T> resultado = connection.Query<T>(sql);
                return resultado;
            }
        }

        public bool InserirDadosNaTabela(T entity)
        {
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();

                string nomeTabela = typeof(T).Name;
                var propriedades = typeof(T).GetProperties();

                List<string> parametros = new List<string>();

                foreach (var propriedade in propriedades)
                {
                    if(propriedade.Name != $"PK_{nomeTabela}") 
                    { 
                        parametros.Add($"@{propriedade.Name}");
                    }
                }

                string parametrosStr = string.Join(", ", parametros);
                string sql = $"INSERT INTO {nomeTabela} VALUES ({parametrosStr})";
                var resultado = connection.Execute(sql, entity);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
