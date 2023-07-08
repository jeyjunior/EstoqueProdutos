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
        /// Desabilitar componente individualmente
        /// </summary>
        /// <param name="sender">this</param>
        /// <returns></returns>
        public static bool Desabilitar(this Control sender)
        {
            return sender.Enabled = false;
        }

        /// <summary>
        /// Desabilitar um grupo de componentes
        /// </summary>
        /// <param name="sender">Passe todos componentes a serem desabilitados</param>
        /// <returns></returns>
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
    }
}
