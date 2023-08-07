using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Entidades
{
    public class Embalagem
    {
        public int PK_Embalagem { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
