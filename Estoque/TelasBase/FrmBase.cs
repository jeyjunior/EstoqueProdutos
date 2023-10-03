using Estoque.Interfaces;
using Estoque.Telas_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Base
{
    public partial class FrmBase : Form, IFrmBase
    {
        protected IUCGerenciadorDeTelas gerenciadorDeTelas;

        public FrmBase()
        {
        }

        public FrmBase(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            this.gerenciadorDeTelas = gerenciadorDeTelas;
        }

        public void Fechar()
        {
            if(gerenciadorDeTelas != null)
            {
                gerenciadorDeTelas.FecharTela(this.GetType());
            }
            else
            {
                this.Close();
            }
        }
    }
}
