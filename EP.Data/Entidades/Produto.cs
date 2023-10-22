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
        public string Nome { get; set;}

        public decimal? Volume { get; set; }
        public string? Descricao { get; set;}

        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }

        public decimal? Altura { get; set; }
        public decimal? Largura { get; set; }
        public decimal? Comprimento { get; set; }

        public int? FK_Formato { get; set; }
        public int? FK_Imagem { get; set; }
        public int? FK_Categoria { get; set; }
        public int? FK_Marca { get; set; }
        public int? FK_Embalagem { get; set; }
        public int? FK_UnidadeMedida { get; set; }
        public int? FK_Usuario { get; set; }
        public virtual Formato Formato { get; set; }
        public virtual Imagem Imagem { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Embalagem Embalagem { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
    }

    public class PesquisaProdutoSimples 
    {
        public int PK_Produto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public int? FK_Formato { get; set; }
        public int? FK_Categoria { get; set; }
        public int? FK_Marca { get; set; }
        public int? FK_Embalagem { get; set; }
    }
}
