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
        public static int Guardar(byte[] imgByte)
        {
            return Guardar(null, String.Empty, String.Empty, imgByte);
        }

        public static int Guardar(string nome, byte[] imgByte)
        {
            return Guardar(null, nome, String.Empty, imgByte);
        }

        public static int Guardar(int? PK_ID, string nome, string formato, byte[] imgByte)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
                {
                    using (SqlCommand command = new SqlCommand("pr_GuardarImagem", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();

                        SqlParameter ultimoID = ParametroDeSaida();
                        command.Parameters.Add(ultimoID);

                        if (PK_ID is null)
                            command.Parameters.AddWithValue("@PK_ID", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@PK_ID", PK_ID);

                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Formato", formato);
                        command.Parameters.AddWithValue("@Imagem", imgByte);

                        command.ExecuteNonQuery();

                        int imgPK_ID = Convert.ToInt32(ultimoID.Value);

                        return imgPK_ID;
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


