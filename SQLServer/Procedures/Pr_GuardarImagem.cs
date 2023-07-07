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
            return Guardar(String.Empty, String.Empty, imgByte);
        }

        public static bool Guardar(string nome, byte[] imgByte)
        {
            return Guardar(nome, String.Empty, imgByte);
        }

        public static bool Guardar(string nome, string formato, byte[] imgByte)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("EXEC         pr_GuardarImagem");
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


