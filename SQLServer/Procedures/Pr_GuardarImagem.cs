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
    public static class Pr_GuardarImagem
    {
        public static int Guardar(string nome, string formato, byte[] imgByte)
        {
            try
            {
                string select = "EXEC pr_GuardarImagem";
                using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
                {
                    using (SqlCommand command = new SqlCommand(select, connection))
                    {
                        SqlParameter ultimoID = ParametroDeSaida();
                        command.Parameters.Add(ultimoID);
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Formato", formato);
                        command.Parameters.AddWithValue("@Imagem", imgByte);

                        connection.Open();
                        command.ExecuteNonQuery();
                        return Convert.ToInt32(ultimoID.Value);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao cadastrar imagem!\nErro: " + ex.Message, "Imagem", MessageBoxButtons.OK);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar operação cadastro imagem!\nErro: " + ex.Message, "Cadastro", MessageBoxButtons.OK);
                return 0;
            }
        }



        private static SqlParameter ParametroDeSaida()
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@UltimoID";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            return parametro;
        }
    }
}


