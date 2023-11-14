using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJ.Helpers.Interfaces
{
    public interface IValidacao
    {
        bool ValidarEmail(string email);
        bool ValidarEmail(ref TextBox textBox, ref Panel pValidacao);
        bool ValidarTextDoTextBox(ref TextBox textBox, ref Panel pValidacao, int tamanhoMin);
        void ObterCorValidacao(ref Panel pValidacao, eValidacao validacao);
    }
}
