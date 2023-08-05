using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Formatacao
{
    public static class Formatacao
    {
        public static string LimparTexto(this string texto) 
        {
            texto = texto.Replace("'", "''");
            return texto.Trim();
        }
    }
}
