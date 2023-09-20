using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Windows.Forms;
using System.Drawing;

namespace JJ.Helpers.Formatacao
{
    public static class Validacao
    {
        public static bool EmailValido(this string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}(?:\.[A-Za-z]{2,})?$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool ValidarEmail(this string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public static void ValidarTextDoTextBox(ref TextBox textBox, ref Panel pValidacao, int tamanhoMin)
        {
            pValidacao.BackColor = textBox.Text.Length >= tamanhoMin ? Color.Green: Color.Red;

            if (textBox.Text.Length <= 0)
            {
                pValidacao.BackColor = Color.FromArgb(16, 23, 28);
            }
        }
    }
}
