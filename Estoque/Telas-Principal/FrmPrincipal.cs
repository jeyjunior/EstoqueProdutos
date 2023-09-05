using EP.Data.Interfaces;
using Estoque.Interfaces;
using Estoque.Telas_Base;
using Estoque.Telas_Principal;
using Estoque.Telas_Produto;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueProdutos.Telas_Principal
{
    public partial class FrmPrincipal : Estoque.Telas_Base.FrmGerenciadorDeTelas, IFrmPrincipal
    {
        #region Classes
        private readonly IUCTelaPrincipalBaixo uCPrincipalBot;
        private readonly IUCTelaPrincipalCima uCPrincipalTop;
        private readonly IUCTelaPrincipalDireita uCPrincipalRight;
        private readonly IImagemRepositorio imagemRepositorio;
        #endregion Classes

        #region Propriedades Publicas

        #endregion Propriedades Publicas

        public FrmPrincipal()
        {
            InitializeComponent();
            uCPrincipalBot = DITelas.Container.GetInstance<IUCTelaPrincipalBaixo>();
            uCPrincipalTop = DITelas.Container.GetInstance<IUCTelaPrincipalCima>();
            uCPrincipalRight = DITelas.Container.GetInstance<IUCTelaPrincipalDireita>();
            imagemRepositorio = DIRepositorios.Container.GetInstance<IImagemRepositorio>();

            uCPrincipalRight.ObterFrmPrincipal(this);
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
            pDireita.Controls.Add((Control)uCPrincipalRight);
        }

        private void CarregarImagemPadrao()
        {
            imagemRepositorio.SalvarImagemPadraoLocalTemporario();
        }

        #endregion Metodos

        #region Eventos

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            var telaSenha = new UCLogin();
            this.Controls.Add(telaSenha);   

            telaSenha.Show();
            telaSenha.BringToFront();
            telaSenha.Dock = DockStyle.Fill;

            InicializarConfiguracoes();
        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            //if (this.ClientSize.Width > 1600)
            //    pDireita.Size = new Size(300, pDireita.Size.Height);
            //else if (this.ClientSize.Width > 1000)
            //    pDireita.Size = new Size(200, pDireita.Size.Height);
            //else
            //    pDireita.Size = new Size(125, pDireita.Size.Height);
        }

        public void AbrirTelaPanelCentral<T>() where T : UserControl, new()
        {
            AbrirTela<T>(panelCentral: pCentral);
        }

        #endregion Eventos

    }
}
