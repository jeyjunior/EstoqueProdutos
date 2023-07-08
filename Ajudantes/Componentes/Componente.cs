using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Ajudantes.Componentes
{
    public static class Componente
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
            sender.Enabled = false;

            btnCadastrar.Enabled = false;
            btnCadastrar.BackColor = Color.LightGray;

            return true;
        }

        public static bool Habilitar(this Control sender, Button btnCadastrar)
        {
            sender.Enabled = true;

            btnCadastrar.Enabled = true;
            btnCadastrar.BackColor = Color.Green;

            return true;
        }
    
        public static bool HabilitarBtnCadastrar(this Control sender)
        {
            sender.Enabled = true;
            sender.BackColor = Color.Green;
            sender.ForeColor = Color.White;

            return sender.Enabled;
        }

        public static bool DesabilitarBtnCadastrar(this Control sender)
        {
            sender.Enabled = false;
            sender.BackColor = Color.LightGray;
            sender.ForeColor = Color.White;

            return sender.Enabled;
        }
    }
}
