using EstoqueProdutos.SQLServer.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.SQLServer.Procedures
{
    public static class Pr_ObterFornecedor
    {
        public static DataTable Obter()
        {
            DataTable dt = new DataTable();

            string select = "EXEC pr_ObterFornecedor";

            using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
            {
                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
