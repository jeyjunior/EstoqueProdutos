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
        public static bool Guardar(byte[] imgByte)
        {
            return Guardar(null, String.Empty, String.Empty, imgByte);
        }

        public static bool Guardar(string nome, byte[] imgByte)
        {
            return Guardar(null, nome, String.Empty, imgByte);
        }

        public static bool Guardar(int? PK_ID, string nome, string formato, byte[] imgByte)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("EXEC         pr_GuardarImagem");
                sb.AppendLine("             @PK_ID = @PK_ID,");
                sb.AppendLine("             @Nome = @Nome,");
                sb.AppendLine("             @Formato = @Formato,");
                sb.AppendLine("             @Imagem = @Imagem");

                string sql = sb.ToString();

                if (nome.Length > 30)
                    nome = nome.Remove(30);

                using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        var pk_id_sqlParameter = DBNull.Value;

                        if(PK_ID is null)
                            command.Parameters.Add("@PK_ID", SqlDbType.Int).Value = pk_id_sqlParameter;
                        else
                            command.Parameters.Add("@PK_ID", SqlDbType.Int).Value = PK_ID;

                        command.Parameters.Add("@Nome", SqlDbType.VarChar, 30).Value = nome;
                        command.Parameters.Add("@Formato", SqlDbType.VarChar, 30).Value = formato;
                        command.Parameters.Add("@Imagem", SqlDbType.VarBinary, -1).Value = imgByte;

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar produto!\nErro: " + ex.Message, "Cadastro", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}


