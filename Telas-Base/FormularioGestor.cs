using EstoqueProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Telas_Base
{
    public class FormularioGestor : FormularioBase, IGestorDeTelas
    {
        protected List<string> TelasAbertas = new List<string>();

        protected int LimiteMaxTelasAbertas { get; set; } = 2;
        
        public FormularioGestor(IGestorDeTelas? gestorDeTelas = null) :  base (gestorDeTelas)
        {

        }
        
        public virtual bool AbrirTelaSubordinada(FormularioBase formularioBase)
        {
            if (TelasAbertas.Count >= LimiteMaxTelasAbertas)
                return false;

            if (!TelasAbertas.Contains(formularioBase.Name))
            {
                TelasAbertas.Add(formularioBase.Name);
                formularioBase.Show();
                return true;
            }

            formularioBase.Focus();
            return false;
        }

        public virtual bool FecharTelaSubordinada(FormularioBase formularioBase)
        {
            if (TelasAbertas.Contains(formularioBase.Name))
            {
                TelasAbertas.Remove(formularioBase.Name);
                formularioBase.Dispose();
                return true;
            }

            return false;
        }
    }
}
