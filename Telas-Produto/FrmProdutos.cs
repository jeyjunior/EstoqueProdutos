using EstoqueProdutos.Gerenciamento;
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
    public partial class FrmProdutos : Telas_Base.FrmGestor
    {

        public FrmProdutos()
        {
            InitializeComponent();
        }

        #region Metodos


        #endregion Metodos

        #region Eventos

        protected override void AbrirFilho<T>(EventHandler? e = null)
        {
            base.AbrirFilho<T>();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var produtoForm = FrmCadastrarProduto.CriarFormComDependencias();
            produtoForm.Show();
        }

        #endregion Eventos
    }
}
