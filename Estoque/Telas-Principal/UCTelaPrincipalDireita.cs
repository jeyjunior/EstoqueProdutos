using Estoque.Interfaces;
using Estoque.Telas_Base;
using Estoque.Telas_Produto;
using Estoque.Telas_Usuario;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Telas_Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Principal
{
    public partial class UCTelaPrincipalDireita : Estoque.Telas_Base.UCBase, IUCTelaPrincipalDireita
    {
        private IFrmPrincipal frmPrincipal;
        private readonly IUCTelaPrincipalCima uCPrincipalCima;
        private Button btnSelecionado;

        public UCTelaPrincipalDireita()
        {
            InitializeComponent();
            AtualizarPropriedades();

            uCPrincipalCima = DITelas.Container.GetInstance<IUCTelaPrincipalCima>();
        }

        #region Metodos
        public void ObterFrmPrincipal(IFrmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
        }

        private void ModificarCorBotaoParaPadrao(Button btn)
        {
            if (btnSelecionado != null)
                btnSelecionado.BackColor = Color.FromArgb(32, 46, 56);

            btnSelecionado = btn;
            btnSelecionado.BackColor = Color.FromArgb(16, 23, 28);
        }

        #endregion Metodos

        #region Eventos
        /* btns */
        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmPrincipal.AbrirTelaPanelCentral<UCProduto>();
            ModificarCorBotaoParaPadrao((Button)sender);

            uCPrincipalCima.AtualizarInfoTelaAberta(Properties.Resources.icone_Produto_24x, "Produto");
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmPrincipal.AbrirTelaPanelCentral<UCUsuarios>();
            ModificarCorBotaoParaPadrao((Button)sender);

            uCPrincipalCima.AtualizarInfoTelaAberta(Properties.Resources.icone_Usuario_24x, "Usuário");
        }
        private void UCTelaPrincipalDireita_Load(object sender, EventArgs e)
        {
            btnProduto.PerformClick();
        }

        #endregion Eventos

    }
}
