using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueProdutos.Formatacao
{
    public static class Eventos
    {
        public static void TextBoxNumerosDecimais_KeyPress(TextBox textBox,KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) && textBox.Text.Contains(',')) 
            {
                int count = textBox.Text.IndexOf(',');
                if (textBox.Text.Length - count > 2) 
                { 
                    e.Handled = true;
                }
            }

            if (e.KeyChar == ';' || e.KeyChar == '.') 
            { 
                e.KeyChar = ',';
            }

            if (textBox.Text.Contains(',') && e.KeyChar == ',') 
            { 
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        public static void AlterarCorButton_EnabledChanged(Button btn, System.Drawing.Color colorEnabled, System.Drawing.Color colorDisabled,EventArgs e) 
        {
            if (btn.Enabled)
            {
                btn.BackColor = colorEnabled;
                btn.FlatAppearance.BorderColor = colorEnabled;
            }
            else
            {
                btn.BackColor = colorDisabled;
                btn.FlatAppearance.BorderColor = colorDisabled;
            }
        }
    }
}
