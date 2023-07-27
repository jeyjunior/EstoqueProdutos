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
        protected List<FormularioBase> TelasAbertas = new List<FormularioBase>();

        protected int LimiteMaxTelasAbertas { get; set; } = 2;
        
        public FormularioGestor(IGestorDeTelas? gestorDeTelas = null) :  base (gestorDeTelas)
        {

        }
        
        public virtual void AbrirTelaSubordinada(Func<FormularioBase> criarFormulario, string nomeFormulario)
        {
            var formularioBase = criarFormulario();
            var formularioExistente = TelasAbertas.Find(c => c.Name == nomeFormulario);
            if (formularioExistente != null)
            {
                formularioExistente.BringToFront();
                formularioExistente.Focus();
            }
            else
            {
                TelasAbertas.Add(formularioBase);
                formularioBase.Show();
            }
        }

        public virtual bool FecharTelaSubordinada(FormularioBase formularioBase)
        {
            if (TelasAbertas.Contains(formularioBase))
            {
                TelasAbertas.Remove(formularioBase);
                formularioBase.Dispose();
                return true;
            }

            return false;
        }
    }
}
