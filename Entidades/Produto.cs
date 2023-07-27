using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Entidades
{
    public class Produto
    {
        public int PK_Produto { get; set; }
        public string Nome { get; set; }
        public decimal Volume { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public int FK_Categoria { get; set; }
        public int FK_Fornecedor { get; set; }
        public int FK_TipoEmbalagem { get; set; }
        public int FK_UnidadeMedida { get; set; }
        public int FK_Imagem { get; set; }

        public virtual Fornecedor tblFornecedor { get; set; }
        public virtual Categoria tblCategoria { get; set; }
        public virtual TipoEmbalagem tblTipoEmbalagem { get; set; }
        public virtual UnidadeMedida tblUnidadeMedida { get; set; }
        public virtual Imagem tblImagem { get; set; }


        public class ProdutoPesquisarPorID
        {
            public int PK_Produto {get; set;}
        }
    }
}
