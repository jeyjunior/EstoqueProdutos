using EstoqueProdutos.SQLServer.Procedures;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstoqueProdutos.Ajudantes.Bind;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using EstoqueProdutos.Ajudantes.Formatacao;

namespace EstoqueProdutos.Ajudantes.Componentes
{
    public static class ManipularImagem
    {
        public static bool ObterImagemStandard(this PictureBox pictureBox)
        {
            try
            {
                DataTable dt = Pr_ObterImagens.ObterPrimeiraImagem();

                if (dt.Rows.Count <= 0)
                    throw new Exception();

                Imagem imagem = new Imagem
                {
                    PK_ID = Convert.ToInt32(dt.Rows[0]["PK_ID"]),
                    Nome = dt.Rows[0]["NOME"].ToString(),
                    Formato = dt.Rows[0]["FORMATO"].ToString(),
                    ImgByte = (byte[])dt.Rows[0]["IMAGEM"]
                };

                pictureBox.Tag = imagem;

                using (MemoryStream ms = new MemoryStream(((Imagem)pictureBox.Tag).ImgByte))
                {
                    Image imagemFromDB = Image.FromStream(ms);
                    pictureBox.Image = imagemFromDB;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Falha ao carregar imagem do banco de imagens.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar imagem.\nErro: " + ex.Message);
                return false;
            }

            return true;
        }

        public static void BuscarImagemRepositorioLocal(this PictureBox pictureBox)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Imagens PNG e JPEG|*.png;*.jpeg;*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = openFileDialog.FileName;

                    if (!File.Exists(caminhoArquivo))
                        throw new Exception("Falha ao carregar arquivo, verifique se a imagem existe!");

                    Imagem imagem = new Imagem()
                    {
                        PK_ID = 0, //Novo Id sera obtido assim que guarda-la no db
                        Nome = Path.GetFileNameWithoutExtension(caminhoArquivo).PrimeiraLetraMaiuscula(),
                        Formato = Path.GetExtension(caminhoArquivo).FormatarNomeDoFormatoImagem(),
                        Image = Image.FromFile(caminhoArquivo)
                    };

                    using (MemoryStream ms = new MemoryStream())
                    {
                        imagem.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imagem.ImgByte = ms.ToArray();
                    }

                    pictureBox.Tag = imagem;
                    pictureBox.Image = imagem.Image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar imagens!\nErro: " + ex.Message);
            }
        }

        public static int GuardarImagem(this PictureBox pictureBox)
        {
            if (pictureBox.Image is null || ((Imagem)pictureBox.Tag).PK_ID == 100)
            {
                return 100;
            }

            int newID = 100;
            try
            {
                Imagem imagem = (Imagem)pictureBox.Tag;
                newID = Pr_GuardarImagem.Guardar(imagem.Nome, imagem.Formato, imagem.ImgByte);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao registrar imagem no banco!\nErro: " + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no savalmente da imagem!");
            }

            return newID;
        }
    }
}
