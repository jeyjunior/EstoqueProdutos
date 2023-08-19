using EP.Data.Interfaces;
using Estoque.Telas_Base;
using Estoque.Telas_Produto;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Gerenciamento;
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
    public partial class FrmPrincipal : Estoque.Telas_Base.FrmGestorUC
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            ObterPanelCentral(pCentral);
        }

        #region Metodos

        private void InicializarConfiguracoes()
        {
            CarregarImagemPadrao();
        }

        private void CarregarImagemPadrao()
        {
            IImagemRepositorio imagemRepositorio = ConfiguradorDI.Container.GetInstance<ImagemRepositorio>();
            imagemRepositorio.SalvarImagemPadraoLocalTemporario();
        }

        #endregion Metodos

        #region Eventos

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            InicializarConfiguracoes();
        }

        #endregion Eventos

        private void btnProduto_Click(object sender, EventArgs e)
        {
            AbrirTela<UCProdutos>();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            AbrirTela<UCBase>();
        }
    }
}
