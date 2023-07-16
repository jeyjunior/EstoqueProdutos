using EstoqueProdutos.Ajudantes.Bind;
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
    public static class Pr_ObterOperador
    {
        public static DataTable OperadorSimples()
        {
            DataTable dt = new DataTable();

            string select = "pr_ObterOperador";

            using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
            {
                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TipoOperador", 1);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
        public static DataTable OperadorEspecial()
        {
            DataTable dt = new DataTable();

            string select = "pr_ObterOperador";

            using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
            {
                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TipoOperador", 2);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
