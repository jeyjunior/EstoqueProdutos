using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Entidades
{
    public class Imagens
    {
        public int PK_ID { get; set; }
        public string Nome { get; set; }
        public string Formato { get; set; }
        public byte[] Imagem { get; set; }
    }
}
