using EstoqueProdutos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Data.Entidades
{
    public class ConfigColunasProduto
    {
        public int PK_ConfigColunasProduto { get; set; }
        public int FK_Usuario { get; set; }
        public bool Nome { get; set; }
        public bool Volume { get; set; }
        public bool Descricao { get; set; }
        public bool Altura { get; set; }
        public bool Largura { get; set; }
        public bool Comprimento { get; set; }
        public bool Formato { get; set; }
        public bool Imagem { get; set; }
        public bool Categoria { get; set; }
        public bool Marca { get; set; }
        public bool Embalagem { get; set; }
        public bool UnidadeMedida { get; set; }
    }
}
