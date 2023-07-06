using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Ajudantes.Formatacao
{
    public static class Formatar
    {
        public static string LimpezaPadrao(this string text)
        {
            string value = text.Replace("'", "''").Replace(" ", "").Trim();
            return value;
        }
    }
}
