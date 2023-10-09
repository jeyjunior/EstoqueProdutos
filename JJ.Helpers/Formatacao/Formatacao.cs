using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace EstoqueProdutos.Formatacao
{
    public static class Formatacao
    {
        public static string? LimparTexto(this TextBox textBox) 
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Replace("'", "''");
                return textBox.Text.Trim();
            }
            else 
            {
                return "";
            }
        }

        /// <summary>
        /// formato limpo sem %%
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static string? TextoFormatoLikeSQL(this TextBox textBox)
        {
            if (textBox.Text.Length > 0)
            {
                return $"{textBox.LimparTexto().Replace("'","").Trim()}";
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// formato limpo com %%
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static string? TextoFormatoLikeSQLComPorcentagem(this TextBox textBox)
        {
            string texto = textBox.LimparTexto().Replace("'", "").Trim();

            if (texto.Length > 0)
            {
                return $"%{texto}%";
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Formatacao: %texto%
        /// </summary>
        /// <returns></returns>
        public static string? AtribuirPorcentagemAoTextoSQL(this string texto)
        {
            if (texto.Length > 0)
            {
                return $"%{texto.Trim()}%";
            }
            else
            {
                return "%%";
            }
        }

        public static decimal? ParaDecimal(this TextBox? textBox) 
        {
            if (textBox.Text.Length > 0)
            {
                return decimal.Parse(textBox.Text);
            }
            else 
            {
                return null;
            }
        }

        public static DateTime? ParaDataPequena(this DateTimePicker? dtp) 
        {
            if (dtp.Enabled)
            {
                return dtp.Value.Date;
            }
            else 
            { 
                return null;
            }
        }

        public static int? ObterValorInt(this ComboBox comboBox) 
        {
            if (comboBox.Enabled && (int)comboBox.SelectedValue > 0)
            {
                return (int)comboBox.SelectedValue;
            }
            else 
            {
                return null;
            }
        }

        /// <summary>
        /// Valida se a entidade(objeto) nao é nula e se existe a propriedade Nome
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public static string ObterNome<T>(T objeto) where T : class
        {
            if (objeto == null)
                return "";

            var propriedade = typeof(T).GetProperty("Nome");
            if (propriedade == null)
                return "";

            var valor = propriedade.GetValue(objeto);
            if (valor == null)
                return "";

            return valor.ToString();
        }

    }
}
