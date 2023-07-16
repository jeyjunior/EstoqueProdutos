using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Ajudantes.Componentes
{
    public static class HabilitarComponente
    {
        /// <summary>
        /// Desabilitar componente(s) individualmente
        /// </summary>
        /// <param name="sender">this</param>
        /// <returns></returns>
        public static bool Desabilitar(this Control sender)
        {
            return sender.Enabled = false;
        }

        public static bool Desabilitar(Control[] sender)
        {
            if(sender.Length == 0) 
                return false;

            foreach (Control obj in sender)
            {
                obj.Enabled = false;
            }

            return true;
        }

        public static bool Desabilitar(this Control sender, Button btnCadastrar)
        {
            return sender.Enabled = false;
        }

        public static bool Habilitar(this Control sender, Button btnCadastrar)
        {
            return sender.Enabled = true; 
        }
    
        public static bool HabilitarBtnCadastrar(this Control sender)
        {
            return sender.Enabled = true;
        }

        public static bool DesabilitarBtnCadastrar(this Control sender)
        {
            return sender.Enabled = false;
        }
    }
}
