using Dapper;
using EP.Data.Interfaces;
using EstoqueProdutos.Entidades;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace EstoqueProdutos.Repositorios
{
    public class ImagemRepositorio : Repositorio<Imagem>, IImagemRepositorio
    {
        private readonly string tempCaminhoConfig = Path.GetTempPath();
        private readonly string nomeArquivo = "imgStandard.json";

        public Image ObterImagemPadrao()
        {
            Imagem imagem = ObterObjetoImagemPadrao();
            Image img;

            using (MemoryStream ms = new MemoryStream(imagem.ImgBinary))
            {
                img = Image.FromStream(ms);
            }

            return img;
        }

        public Imagem ObterObjetoImagemPadrao()
        {
            try
            {
                string caminhoCompleto = tempCaminhoConfig + nomeArquivo;

                if (!File.Exists(caminhoCompleto))
                {
                    SalvarImagemPadraoLocalTemporario();
                }

                string jsonContent = File.ReadAllText(caminhoCompleto);
                Imagem imagem = JsonSerializer.Deserialize<Imagem>(jsonContent);

                return imagem;
            }
            catch (Exception)
            {
                throw new Exception("Falha ao carregar imagem padrão");
            }
        }

        public void SalvarImagemPadraoLocalTemporario() 
        {
            try
            {
                string caminhoCompleto = tempCaminhoConfig + nomeArquivo;

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
                throw new Exception("Falha ao carregar imagem padrão");
            }
        }

    }
}
