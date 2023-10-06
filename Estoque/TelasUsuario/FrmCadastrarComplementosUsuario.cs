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

namespace Estoque.Telas_Usuario
{
    public partial class FrmCadastrarComplementosUsuario : FrmTabControl
    {
        public FrmCadastrarComplementosUsuario(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            InitializeComponent();
            this.gerenciadorDeTelas = gerenciadorDeTelas;
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            AlterarCorDoBotaoSelecionado(tlpTab, (Button)sender);
            AbrirTela(typeof(UCCadastrarCargo), pCentral, true);
        }

        private void btnSetor_Click(object sender, EventArgs e)
        {
            AlterarCorDoBotaoSelecionado(tlpTab, (Button)sender);
            AbrirTela(typeof(UCCadastrarSetor), pCentral, true);
        }

        private void FrmCadastrarSetores_Cargos_Load(object sender, EventArgs e)
        {
            btnSetor.PerformClick();
        }

        private void FrmCadastrarSetores_Cargos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }
    }
}
