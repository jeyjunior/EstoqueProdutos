using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using EstoqueProdutos.Telas_Base;
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

namespace EstoqueProdutos.Telas_Principal
{
    public partial class FrmPrincipal : FrmGestor
    {
        SimpleInjector.Container container;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProtudos_Click(object sender, EventArgs e)
        {
            var Produto = container.GetInstance<FrmCadastrarProduto>();
            Produto.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
