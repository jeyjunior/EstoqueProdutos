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

namespace Estoque.Telas_Produto
{
    public partial class FrmCadastrarComplementosProduto : FrmTabControl
    {
        public FrmCadastrarComplementosProduto(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            InitializeComponent();
            this.gerenciadorDeTelas = gerenciadorDeTelas;
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            AlterarCorDoBotaoSelecionado(tlpTab, (Button)sender);
            AbrirTela(typeof(UCCadastrarCategoria), pCentral, true);
        }
        private void btnEmbalagem_Click(object sender, EventArgs e)
        {
            AlterarCorDoBotaoSelecionado(tlpTab, (Button)sender);
            AbrirTela(typeof(UCCadastrarEmbalagem), pCentral, true);
        }

        private void FrmCadastrarSetores_Cargos_Load(object sender, EventArgs e)
        {
            btnCategoria.PerformClick();
        }
        private void FrmCadastrarSetores_Cargos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }


    }
}

