using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using JJ.Helpers.Interfaces;

namespace JJ.Helpers.Formatacao
{
    public class Validacao : IValidacao
    {
        private Color itemValidado = Color.Green;
        private Color itemNaoValidado = Color.Red;
        private Color itemPadrao = Color.FromArgb(16, 23, 28);

        public bool ValidarEmail(string email)
        {
            string pattern = @"^[A-Za-z0-9._-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}(?:\.[A-Za-z]{2,})?$";
            return Regex.IsMatch(email, pattern);
        }
        public bool ValidarEmail(ref TextBox textBox, ref Panel pValidacao)
        {
            bool emailValidado = false;

            if (ValidarEmail(textBox.Text))
            {
                emailValidado = true;
                pValidacao.BackColor = itemValidado;
            }
            else if(textBox.Text.Length > 0)
            {
                pValidacao.BackColor = itemNaoValidado;
            }
            else
            {
                pValidacao.BackColor = itemPadrao;
            }

            return emailValidado;
        }
        public bool ValidarTextDoTextBox(ref TextBox textBox, ref Panel pValidacao, int tamanhoMin)
        {
            bool textoValidado = false;

            if(textBox.Text.Trim().Length >= tamanhoMin) 
            {
                textoValidado = true;
                pValidacao.BackColor = itemValidado;
            }
            else if(textBox.Text.Length > 0)
            {
                pValidacao.BackColor = itemNaoValidado;
            }
            else
            {
                pValidacao.BackColor = itemPadrao;
            }

            return textoValidado;
        }
        
        public void ObterCorValidacao(ref Panel pValidacao, eValidacao validacao)
        {
            if(validacao == eValidacao.itemValidado)
            {
                pValidacao.BackColor = itemValidado;
            }
            else if(validacao == eValidacao.itemNaoValidado)
            {
                pValidacao.BackColor = itemNaoValidado;
            }
            else
            {
                pValidacao.BackColor = itemPadrao;
            }
        }
    }
}

public enum eValidacao
{ 
    itemValidado,
    itemNaoValidado,
    itemPadrao
}
