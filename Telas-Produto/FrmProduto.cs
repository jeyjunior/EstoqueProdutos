using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueProdutos.Telas_Produto
{
    public partial class FrmProduto : Telas_Base.FrmGestor
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastrarProduto>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmEditarProduto>();
        }
    }
}
