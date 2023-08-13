using Dapper;
using EstoqueProdutos.Entidades;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EstoqueProdutos.Repositorios
{
    public class ImagemRepositorio : Repositorio<Imagem>
    {
        public void ObterImagemPadrao() 
        {
            try
            {
                string tempCaminhoConfig = "";
                string caminhoCompleto = Environment.ExpandEnvironmentVariables(tempCaminhoConfig);

                if (File.Exists(caminhoCompleto))
                {
                    return;
                }

                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();

                    string query = "SELECT * FROM Imagem WHERE PK_Imagem = @PK_Imagem";
                    var imageData = connection.QuerySingleOrDefault<Imagem>(query, new { PK_Imagem = 1 });

                    if (imageData != null)
                    {
                        string json = JsonSerializer.Serialize(imageData);
                        File.WriteAllText(caminhoCompleto, json);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
