
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Telas_Base;
using EstoqueProdutos.Telas_Produtos;
using System.Collections.Generic;

namespace EstoqueProdutos
{
    public partial class MainForm : FormularioGestor
    {
        private FrmProdutos FrmProdutos;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
           FrmProdutos = new FrmProdutos(this);

            AbrirTelaSubordinada(FrmProdutos);
        }
    }
}