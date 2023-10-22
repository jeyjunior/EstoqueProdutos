using Estoque.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.GerenciamentoTelas
{
    public class GerenciadorTelas : IGerenciadorTelas
    {
        public List<object> TelasAberta;

        public GerenciadorTelas()
        {
            TelasAberta = new List<object>();
        }
    }
}
