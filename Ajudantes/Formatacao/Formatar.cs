using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Ajudantes.Formatacao
{
    public static class Formatar
    {
        public static string RemoverEspacoVazioeAspas(this string text)
        {
            string value = text.Replace("'", "''").Replace(" ", "").Trim();
            return value;
        }

        public static string FormatarNomeImagem(this string text)
        {
            string value = text.RemoverEspacoVazioeAspas();
            value = value.ToLower();

            value = value[0].ToString().ToUpper() + value.Substring(1);
            return value;
        }

        public static string FormatarNomeDoFormatoImagem(this string text)
        {
            string value = text.RemoverEspacoVazioeAspas();
            value = value.ToLower();

            if(!text.Contains('.'))
                value = "." + value;
    
            return value;
        }
    }
}
