using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Entidades
{
    public class Imagem
    {
        public int PK_Imagem { get; set; }
        public string Nome { get; set; }
        public string Formato { get; set; }
        public byte[] Img { get; set; }
    }
}
