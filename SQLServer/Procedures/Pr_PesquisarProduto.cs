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
    public static class Pr_PesquisarProduto
    {
        public static DataTable Obter(string customFilter)
        {
            DataTable dt = new DataTable();

            string select = "EXEC pr_PesquisarProduto @CustomFilter";

            using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
            {
                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@CustomFilter", customFilter);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

    }
}
