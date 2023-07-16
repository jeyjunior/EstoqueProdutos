using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public static string FormatarNomeDoFormatoImagem(this string texto)
        {
            string value = texto.RemoverEspacoVazio();
            value = value.ToLower();

            if(!texto.Contains('.'))
                value = "." + value;
    
            return value;
        }
        
        public static string AplicarMascaraDinheiro(this TextBox txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
                return String.Empty;

            txt.RemoverMascarDinheiro();
            txt.Text = txt.Text.LimitarCasasDecimais(2);

            if (!txt.Text.Contains("R$ "))
                txt.Text = "R$ " + txt.Text.Trim();

            return txt.Text;
        }

        public static string RemoverMascarDinheiro(this TextBox txt)
        {
            if (txt.Text.Contains("R$ "))
                txt.Text = txt.Text.Replace("R$ ", "");

            return txt.Text;
        }

        public static string TrocarVirgulaPorPonto(this string texto)
        {
            if(texto.Contains(','))
                texto = texto.Replace(',', '.');

            if (texto.Contains(';'))
                texto = texto.Replace(';', '.');

            return texto;
        }
        
        public static string LimitarTamanhoString(this string texto, int tamanho)
        {
            return texto.Length > tamanho ? texto.Remove(tamanho) : texto;
        }

        public static void AplicarMascaraVolume(this TextBox textBox, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (textBox.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
        }

        public static string LimitarCasasDecimais(this string texto, int casasDecimais)
        {
            if(String.IsNullOrWhiteSpace(texto))
                return texto;

            try
            {
                decimal preco = Convert.ToDecimal(texto);
                texto = Math.Round(preco, casasDecimais).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao limitar casas decimais.\nErro: " + ex.Message);
                return String.Empty;
            }

            return texto;
        }
    }
}
