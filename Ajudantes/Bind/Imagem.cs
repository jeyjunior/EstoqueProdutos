using EstoqueProdutos.SQLServer.Procedures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Ajudantes.Bind
{
    public static class Imagem
    {
        public static bool ObterImagemStandard(PictureBox pictureBox)
        {
            try
            {
                DataTable dt = Pr_ObterImagens.Obter();

                if (dt.Rows.Count <= 0)
                    throw new Exception();

                byte[] imagemBytes = (byte[])dt.Rows[0]["IMAGEM"];

                using (MemoryStream ms = new MemoryStream(imagemBytes))
                {
                    Image imagem = Image.FromStream(ms);

                    int tag = Convert.ToInt32(dt.Rows[0][0]);
                    pictureBox.Tag = tag; //PK_ID
                    pictureBox.Image = imagem;
                }
            }
            catch (SqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
