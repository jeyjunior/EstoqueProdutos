using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EstoqueProdutos.Ajudantes.Formatacao
{
    public static class Formatar
    {
        public static string RemoverAspas(this string text)
        {
            return text.Replace("'", "''");
        }

        public static string SanitizarTexto(this string texto, int maxLength)
        {
            string textoSanitizado = Regex.Replace(texto, @"[^\w\s]", string.Empty);

            if (textoSanitizado.Length > maxLength)
                textoSanitizado = textoSanitizado.Substring(0, maxLength);

            return textoSanitizado;
        }



        public static string RemoverEspacoVazio(this string text)
        {
            string value = text.Replace(" ", "").Trim();
            return value;
        }

        public static string PrimeiraLetraMaiuscula(this string text)
        {
            string value = String.Empty;
            char primeiraLetra;
            
            if(text.Length >= 2)
            {
                primeiraLetra = text[0];
                value = primeiraLetra.ToString().ToUpper() + text.Substring(1).ToLower();
                
                return value;
            }

            return text.ToUpper().Trim();
        }

        public static string FormatarNomeDoFormatoImagem(this string text)
        {
            string value = text.RemoverEspacoVazio();
            value = value.ToLower();

            if(!text.Contains('.'))
                value = "." + value;
    
            return value;
        }
        
        public static string AplicarMascaraDinheiro(this string text)
        {
            if (!text.Contains("R$ "))
                text = "R$ " + text.Trim();

            return text;
        }

        public static string RemoverMascarDinheiro(this string text)
        {
            if (text.Contains("R$ "))
                text = text.Replace("R$ ", "");

            return text;
        }


    }
}
