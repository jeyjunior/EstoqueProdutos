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

namespace EstoqueProdutos.Ajudantes.Componentes
{
    public static class ManipularImagem
    {
        public static bool ObterImagemStandard(PictureBox pictureBox)
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

    }
}
