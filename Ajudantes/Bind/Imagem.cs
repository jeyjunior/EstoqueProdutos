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
    public class Imagem
    {
        public int PK_ID { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string Formato { get; set; } = String.Empty;
        public byte[]? ImgByte { get; set; } = null;
        public Image Image { get; set; }
    }
}
