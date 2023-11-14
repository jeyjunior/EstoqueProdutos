using EP.Data.Interfaces;
using Estoque.Controladores;
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
        #region Interfaces
        private readonly IUCTelaPrincipalBaixo uCPrincipalBaixo;
        private readonly IUCTelaPrincipalCima uCPrincipalCima;
        private readonly IUCTelaPrincipalDireita uCPrincipalDireita;
        private readonly IImagemRepositorio imagemRepositorio;
        #endregion Interfaces

        #region Propriedades Publicas

        #endregion Propriedades Publicas

        public FrmPrincipal()
        {
            InitializeComponent();
            uCPrincipalBaixo = DITelas.Container.GetInstance<IUCTelaPrincipalBaixo>();
            uCPrincipalCima = DITelas.Container.GetInstance<IUCTelaPrincipalCima>();
            uCPrincipalDireita = DITelas.Container.GetInstance<IUCTelaPrincipalDireita>();
            imagemRepositorio = DIRepositorios.Container.GetInstance<IImagemRepositorio>();

            uCPrincipalDireita.ObterFrmPrincipal(this);
        }

        #region Metodos

        private void InicializarConfiguracoes()
        {
            try
            {
                CarregarImagemPadrao();
                InicilizarModulosDaInterface();
            }
            catch (Exception ex)
            {
                var resposta = Mensagem.Erro("Falha ao iniciar programa.\nErro: " + ex.Message);

                if(resposta == Estoque.Enums.RespostaCaixaDialogo.Sim)
                {
                    this.Close();
                }
            }
        }

        private void InicilizarModulosDaInterface()
        {
            AbrirTela(typeof(UCLogin), this, true, TelaLogin_Disposed);

            pBot.Controls.Add((Control)uCPrincipalBaixo);
            pTop.Controls.Add((Control)uCPrincipalCima);
            pDireita.Controls.Add((Control)uCPrincipalDireita);
        }

        private void CarregarImagemPadrao()
        {
            imagemRepositorio.SalvarImagemPadraoLocalTemporario();
        }
        public void AbrirTelaPanelCentral<T>() where T : UserControl, new()
        {
            AbrirTela<T>(control: pCentral);
        }

        #endregion Metodos

        #region Eventos

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //var telaSenha = new UCLogin();
            //this.Controls.Add(telaSenha);   

            //telaSenha.Show();
            //telaSenha.BringToFront();
            //telaSenha.Dock = DockStyle.Fill;

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

        private void TelaLogin_Disposed(object sender, EventArgs e)
        {
            uCPrincipalCima.AtualizarInfoUsuarioLogado();
        }

        #endregion Eventos

    }
}
