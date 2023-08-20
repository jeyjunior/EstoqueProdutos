using EP.Data.Interfaces;
using Estoque.Interfaces;
using Estoque.Telas_Base;
using Estoque.Telas_Principal;
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
    public partial class FrmPrincipal : Estoque.Telas_Base.FrmGestorUC, IFrmPrincipal
    {
        #region Classes
        private readonly IUCPrincipalBot uCPrincipalBot;
        private readonly IUCPrincipalTop uCPrincipalTop;
        private readonly IUCPrincipalRight uCPrincipalRight;
        private readonly IImagemRepositorio imagemRepositorio;
        #endregion Classes

        #region Propriedades Publicas
        public Panel panelCentral { get; set; }
        #endregion Propriedades Publicas

        public FrmPrincipal()
        {
            InitializeComponent();
            uCPrincipalBot = DITelas.Container.GetInstance<UCPrincipalBot>();
            uCPrincipalTop = DITelas.Container.GetInstance<UCPrincipalTop>();
            uCPrincipalRight = DITelas.Container.GetInstance<UCPrincipalRight>();
            uCPrincipalRight.ObterFrmPrincipal(this);

            imagemRepositorio = DIRepositorios.Container.GetInstance<ImagemRepositorio>();
        }

        #region Metodos

        private void InicializarConfiguracoes()
        {
            CarregarImagemPadrao();
            InicilizarModulosDaInterface();
        }

        private void InicilizarModulosDaInterface()
        {
            pBot.Controls.Add((Control)uCPrincipalBot);
            pTop.Controls.Add((Control)uCPrincipalTop);
            pRight.Controls.Add((Control)uCPrincipalRight);
        }

        private void CarregarImagemPadrao()
        {
            imagemRepositorio.SalvarImagemPadraoLocalTemporario();
        }

        #endregion Metodos

        #region Eventos

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            InicializarConfiguracoes();
        }

        public void AbrirTelaPanelCentral<T>() where T : UserControl, new()
        {
            AbrirTela<T>(panelCentral: pCentral);
        }

        #endregion Eventos

    }
}
