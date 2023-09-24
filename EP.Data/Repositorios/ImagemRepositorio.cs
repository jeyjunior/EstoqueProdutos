using Dapper;
using EP.Data.Interfaces;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using Microsoft.Data.SqlClient;
using System.Text.Json;
using System.Drawing;
using System.Windows.Forms;
using JJ.Helpers.Formatacao;
using EP.Data.sql;
using EP.Data.Entidades;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Collections.Generic;

namespace EstoqueProdutos.Repositorios
{
    public class ImagemRepositorio : IImagemRepositorio
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

        
        public int SalvarImagemNaBase(Image img)
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

                /*Caso exista uma imagem com mesmo nome no sistema, a mesma passa a ser utilizada ao inves de inserir uma nova*/
                //string sql = "DECLARE @ID_Imagem int \n" +
                //        "SELECT @ID_Imagem = Imagem.PK_Imagem \n" +
                //        "FROM Imagem \n" +
                //        "WHERE Imagem.Nome = @Nome \n" +

                //        "IF @ID_Imagem > 0 \n" +
                //            "BEGIN \n" +
                //                "SELECT * FROM Imagem WHERE PK_Imagem = @ID_Imagem \n" +
                //            "END \n" +
                //        "ELSE \n" +
                //            "BEGIN \n" +
                //                "INSERT INTO Imagem(Nome, Formato, ImgBinary) \n" +
                //                "VALUES(@Nome, @Formato, @ImgBinary); \n" +
                //                "SELECT SCOPE_IDENTITY() \n" +
                //        "END \n";

                //string sql = " \n" +
                //    "DECLARE @Contagem int \n" +

                //    "SELECT @Contagem = COUNT(*)  \n" +
                //    "FROM Imagem \n" +
                //    "WHERE Imagem.Nome = @Nome \n" +

                //    "IF @Contagem = 0 \n" +
                //    "   BEGIN  \n" +
                //    "       INSERT INTO Imagem (Nome, Formato, ImgBinary) \n" +
                //    "       VALUES (@Nome, @Formato, @ImgBinary); \n" +
                //    "       SELECT SCOPE_IDENTITY() \n" +
                //    "   END \n" +
                //    "ELSE \n" +
                //    "   BEGIN \n" +
                //    "       SELECT * FROM Imagem WHERE PK_Imagem = 1 \n" +
                //    "   END \n";

                string sql = "INSERT INTO Imagem (Nome, Formato, ImgBinary) \n" +
                             "VALUES (@Nome, @Formato, @ImgBinary); \n" +
                             "SELECT SCOPE_IDENTITY() \n";

                using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
                {
                    connection.Open();
                    PK_Imagem = connection.QuerySingle<int>(sql, imagem);
                }
            }
            catch
            {
                throw new Exception("Erro ao salvar imagem.");
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

                using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
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

        public IEnumerable<Imagem> ObterTabela()
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                string sql = $"SELECT * FROM Imagem";
                IEnumerable<Imagem> resultado = connection.Query<Imagem>(sql);
                return resultado;
            }
        }

        public IEnumerable<Imagem> ObterObjetoImagem(Imagem imagem)
        {
            string sql = "";
            string where = "";
            string condicao = "";

            sql = "SELECT *\n" +
                  "FROM Imagem\n";

            if (imagem.PK_Imagem > 1)
            {
                condicao += (condicao != "" ? " AND" : "") + " Imagem.PK_Imagem = @PK_Imagem\n";
            }

            where = condicao != "" ? "WHERE " : "";
            sql = sql + where + condicao;

            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                return connection.Query<Imagem>(sql, imagem);
            }
        }

        public Image ObterApenasImagem(int FK_Imagem)
        {
            var imagem = ObterObjetoImagem(new Imagem { PK_Imagem = FK_Imagem });
            Image image = null;

            if(imagem != null && imagem.Count() > 0)
            {
                Imagem img = imagem.FirstOrDefault();

                using (MemoryStream ms = new MemoryStream(img.ImgBinary))
                {
                    image = Image.FromStream(ms);
                }
            }

            return image;
        }

        public bool InserirDadosNaTabela(Imagem imagem)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO Imagem\n" +
                    "VALUES (@Nome, @Formato, @ImgBinary)\n";

                var resultado = connection.Execute(sql, imagem);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
