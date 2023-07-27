using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Telas_Produtos;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Telas_Base
{
    public class FormularioBase : Form
    {
        private IGestorDeTelas? gestorDeTelas;

        public FormularioBase(IGestorDeTelas? gestorDeTelas = null)
        {
            this.gestorDeTelas = gestorDeTelas;
        }

        protected virtual void Fechar()
        {
            if (gestorDeTelas != null)
            {
                gestorDeTelas.FecharTelaSubordinada(this);
                return;
            }
        }
    }
}
