using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Entidades
{
    public class Produto
    {
        public int PK_ID { get; set; }
        public string Nome { get; set; }
        public decimal Volume { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public int FK_Categoria_ID { get; set; }
        public int FK_Fornecedor_ID { get; set; }
        public int FK_TipoEmbalagem_ID { get; set; }
        public int FK_UnidadeMedida_ID { get; set; }
        public int FK_Imagem_ID { get; set; }
    }
}
