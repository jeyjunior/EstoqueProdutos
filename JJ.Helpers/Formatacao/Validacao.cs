using System.Text.RegularExpressions;
using System.Net.Mail;

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

        public static bool CompararDuasStrings(this string text1, string text2)
        {
            return text1.Equals(text2);
        }
    }
}
