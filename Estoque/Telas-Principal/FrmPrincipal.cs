using EP.Data.Interfaces;
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
    public partial class FrmPrincipal : FrmGestor
    {
        public FrmPrincipal()
        {
            InitializeComponent();
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

        private void btnProtudos_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastrarProduto>();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            InicializarConfiguracoes();
        }

        #endregion Eventos
    }
}
