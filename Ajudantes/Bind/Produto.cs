using Sql.DataAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Ajudantes.Bind
{
    public sealed class Produto
    {
        public string Nome { get; set; }
		public decimal Preco { get; set; }
		public int FK_tblCategoria_ID { get; set; }
        public int FK_tblFornecedor_ID { get; set; }
        public int FK_tblTipoEmbalagem_ID { get; set; }
        public decimal Volume { get; set; }
        public int FK_tblUnidadeMedida_ID { get; set; }
        public int? FK_Imagem_ID { get; set; }
        public string? Descricao { get;set; }
    
    }
}
