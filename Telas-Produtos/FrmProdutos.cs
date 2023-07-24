using EstoqueProdutos.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueProdutos.Telas_Produtos
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ProdutoColecao produtoColecao = new ProdutoColecao();
            produtoColecao.ObterProdutoMultiMapPorId(100);
        }
    }
}
