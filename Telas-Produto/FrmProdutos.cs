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


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastrarProduto>();
        }

        #endregion Eventos
    }
}
