using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using EstoqueProdutos.Telas_Base;
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
    public partial class FrmProdutos : FormularioGestor
    {
        public FrmProdutos(IGestorDeTelas? gestorDeTelas = null): base (gestorDeTelas)
        {
            InitializeComponent();
        }

        #region Eventos

        private void FrmProdutos_Load(object sender, EventArgs e)
        {

        }

        #endregion Eventos

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void FrmProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }
    }
}
