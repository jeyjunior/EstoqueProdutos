using EstoqueProdutos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Data.Entidades
{
    public class Cargo
    {
        public int PK_Cargo { get; set; }
        public string NomeCargo { get; set; }
        public int FK_Setor { get; set; }
        public virtual Setor Setor { get; set; }
    }
}
