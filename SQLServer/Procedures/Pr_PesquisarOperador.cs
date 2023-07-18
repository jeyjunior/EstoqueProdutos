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
    public static class Pr_PesquisarOperador
    {
        private static StringBuilder Select()
        {
            StringBuilder select = new StringBuilder();
            select.AppendLine("EXEC    pr_PesquisarOperador");
            select.AppendLine("@TipoOperador = @TipoOperador");

            return select;
        }

        public static DataTable ObterOperadorSimples()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
            {
                using (SqlCommand command = new SqlCommand(Select().ToString(), connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@TipoOperador", 1);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
        
        public static DataTable ObterOperadorEspecial()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
            {
                using (SqlCommand command = new SqlCommand(Select().ToString(), connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@TipoOperador", 2);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
