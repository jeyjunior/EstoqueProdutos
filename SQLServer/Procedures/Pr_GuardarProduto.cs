using EstoqueProdutos.Ajudantes.Bind;
using EstoqueProdutos.SQLServer.Conexao;
using Sql.DataAttributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.SQLServer.Procedures
{
    public static class Pr_GuardarProduto
    {
        public static string? ErroMensagem { get; set; } = String.Empty;

        public static void Guardar(Produto produto)
        {
            ErroMensagem = String.Empty;

            try
            {
                string select = "EXEC pr_GuardarProduto";

                using (SqlConnection connection = new SqlConnection(StringConexao.Conexao))
                {
                    using (SqlCommand command = new SqlCommand(select, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", produto.Nome);
                        command.Parameters.AddWithValue("@Preco", produto.Preco);
                        command.Parameters.AddWithValue("@FK_tblCategoria_ID", produto.FK_tblCategoria_ID);
                        command.Parameters.AddWithValue("@FK_tblFornecedor_ID", produto.FK_tblFornecedor_ID);
                        command.Parameters.AddWithValue("@FK_tblTipoEmbalagem_ID", produto.FK_tblTipoEmbalagem_ID);
                        command.Parameters.AddWithValue("@Volume", produto.Volume);
                        command.Parameters.AddWithValue("@FK_tblUnidadeMedida_ID", produto.FK_tblUnidadeMedida_ID);
                        command.Parameters.AddWithValue("@FK_Imagem_ID", produto.FK_Imagem_ID);
                        command.Parameters.AddWithValue("@Descricao", produto.Descricao);

                        connection.Open();

                        // Definir parâmetro @Erro
                        SqlParameter outputParameter = new SqlParameter("@Erro", SqlDbType.VarChar, 100);
                        outputParameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputParameter);

                        command.ExecuteNonQuery();

                        ErroMensagem = command.Parameters["@Erro"].Value == DBNull.Value ? null : command.Parameters["@Erro"].Value.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao cadastrar produto!\nErro: " + ex.Message, "Falha", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar operação de cadastro de imagem!\nErro: " + ex.Message, "Cadastro", MessageBoxButtons.OK);
            }
        }
    }
}
