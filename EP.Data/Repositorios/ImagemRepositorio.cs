using Dapper;
using EP.Data.Interfaces;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using Microsoft.Data.SqlClient;
using System.Text.Json;
using System.Drawing;
using System.Windows.Forms;
using JJ.Helpers.Formatacao;
using static Dapper.SqlMapper;

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

        public Image? ProcurarImagemLocal()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens|*.jpg;*.png";
            openFileDialog.Multiselect = false;

            Image? image = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoImagemSelecionada = openFileDialog.FileName;
                image = Image.FromFile(caminhoImagemSelecionada);
                image.Tag = caminhoImagemSelecionada;
            }

            return image;
        }

        
        public int SalvarImagem(Image img)
        {
            int PK_Imagem = 1;

            if (img == null || img.Tag == null)
                return PK_Imagem;

            try
            {
                Imagem imagem = new Imagem()
                {
                    Nome = Path.GetFileNameWithoutExtension(img.Tag.ToString()),
                    Formato = Path.GetExtension(img.Tag.ToString()),
                    ImgBinary = img.ConvertImageToByteArray()
                };

                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();
                    string sql = "INSERT INTO Imagem (Nome, Formato, ImgBinary) VALUES (@Nome, @Formato, @ImgBinary); SELECT SCOPE_IDENTITY()";
                    PK_Imagem = connection.QuerySingle<int>(sql, imagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar imagem:\n" + ex.Message);
            }

            return PK_Imagem;
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
