using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Entidades
{
    public class Estoque
    {
        public int PK_ID { get; set; }
        public int FK_Produto_ID { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
