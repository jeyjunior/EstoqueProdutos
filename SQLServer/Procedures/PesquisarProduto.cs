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
    public static class PesquisarProduto
    {
        //@TipoDePesquisa INT,
        //@ID INT Null,
        //@Nome VARCHAR(120) NULL,
        //@ParametroComplementar VARCHAR(120) NULL


        /// <summary>
        /// Pesquisa Tipo2: retorna um produto
        /// </summary>
        /// <returns></returns>
        public static DataTable ObterProduto(int id)
        {
            int tipo = 2;
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
            {
                connection.Open();
                string procedure = Procedure.prPesquisarProdutos.ToString();

                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@TipoPesquisa", SqlDbType.Int).Value = tipo;
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@Nome", SqlDbType.VarChar, 120).Value = DBNull.Value;
                    command.Parameters.Add("@ParametroComplementar", SqlDbType.VarChar, 120).Value = DBNull.Value;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
            }
            return table;
        }

        /// <summary>
        /// Pesquisa Tipo3: retorna todos os produtos
        /// </summary>
        /// <returns></returns>
        public static DataTable ObterTodosProdutos()
        {
            int tipo = 3;
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
            {
                connection.Open();
                string procedure = Procedure.prPesquisarProdutos.ToString();

                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@TipoPesquisa", SqlDbType.Int).Value = tipo;
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = DBNull.Value;
                    command.Parameters.Add("@Nome", SqlDbType.VarChar, 120).Value = DBNull.Value;
                    command.Parameters.Add("@ParametroComplementar", SqlDbType.VarChar, 120).Value = DBNull.Value;


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
            }
            return table;
        }
    }
}
