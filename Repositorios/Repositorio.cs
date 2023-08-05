using EstoqueProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace EstoqueProdutos.Repositorios
{
    public partial class Repositorio<T> : IRepositorio<T>
    {
        private readonly string conexao  = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

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
    }
}
