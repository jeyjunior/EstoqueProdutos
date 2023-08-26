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
    public partial class FrmBase : Form, IFecharFormularioBase
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        public IUCGerenciadorDeTelas GerenciadorDeTelas { get; set; }

        public void ObterGerenciadorTelas(IUCGerenciadorDeTelas GerenciadorDeTelas)
        {
            this.GerenciadorDeTelas = GerenciadorDeTelas;
        }
        public void Fechar()
        {
            GerenciadorDeTelas.FecharTela(this.GetType());
        }
    }
}
