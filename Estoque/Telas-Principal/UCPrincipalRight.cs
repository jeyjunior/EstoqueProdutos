using Estoque.Interfaces;
using Estoque.Telas;
using Estoque.Telas_Base;
using Estoque.Telas_Produto;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Telas_Principal;
using EstoqueProdutos.Telas_Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Principal
{
    public partial class UCPrincipalRight : Estoque.Telas_Base.UCBase, IUCPrincipalRight
    {
        public UCPrincipalRight()
        {
            InitializeComponent();
            AtualizarPropriedades();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FrmPrincipal.frmPrincipal.AbrirTelaPanelCentral<UCProduto>();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            FrmPrincipal.frmPrincipal.AbrirTelaPanelCentral<UCBase>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal.frmPrincipal.AbrirTelaPanelCentral<UCUsuario>();
        }
    }
}
