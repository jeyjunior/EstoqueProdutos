
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Telas_Base;
using EstoqueProdutos.Telas_Produtos;
using System.Collections.Generic;

namespace EstoqueProdutos
{
    public partial class MainForm : FormularioGestor
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirTelaSubordinada(() => new FrmProdutos(this), "FrmProdutos");
        }
    }
}