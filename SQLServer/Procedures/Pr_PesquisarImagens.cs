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
    public static class Pr_PesquisarImagens
    {
        private static StringBuilder Select()
        {
            StringBuilder select = new StringBuilder();
            select.AppendLine("EXEC pr_PesquisarImagens");
            select.AppendLine("@TipoPesquisa = @TipoPesquisa");

            return select;
        }

        public static DataTable ObterPrimeiraImagem()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
            {
                using (SqlCommand command = new SqlCommand(Select().ToString(), connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@TipoPesquisa", 1);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable ObterTodasImagens()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
            {
                using (SqlCommand command = new SqlCommand(Select().ToString(), connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@TipoPesquisa", 2);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
