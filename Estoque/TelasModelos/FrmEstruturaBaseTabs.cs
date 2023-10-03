using Estoque.Interfaces;
using Estoque.Telas_Base;
using Estoque.Telas_Base.FrmEspecialistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Modelos
{
    public partial class FrmCadastrarSetores_Cargos : FrmTabControl
    {
        public FrmCadastrarSetores_Cargos(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            InitializeComponent();
            this.gerenciadorDeTelas = gerenciadorDeTelas;
        }

        private void btnTab1_Click(object sender, EventArgs e)
        {
            AlterarCorDoBotaoSelecionado(tlpTab, (Button)sender);
        }
    }
}
