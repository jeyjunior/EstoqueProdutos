using Estoque.Interfaces;
using Estoque.Telas_Base;
using Estoque.Telas_Produto;
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
        private Button btnSelecionado;

        public UCTelaPrincipalDireita()
        {
            InitializeComponent();
            AtualizarPropriedades();
        }

        public void ObterFrmPrincipal(IFrmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmPrincipal.AbrirTelaPanelCentral<UCProduto>();
            ModificarCorBotaoParaPadrao((Button)sender);
        }


        private void UCTelaPrincipalDireita_Load(object sender, EventArgs e)
        {
            AtualizarTamanhoDosComponentes();
        }

        private void tblDireita_Resize(object sender, EventArgs e)
        {
            AtualizarTamanhoDosComponentes();

        }
        private void AtualizarTamanhoDosComponentes()
        {
            if (tblDireita.ClientSize.Width > 290 && tblDireita.ClientSize.Height > 720  /* && btnProduto.Font.Size < 14 */)
            {
                ModificarPropriedadesBotao(btnProduto, 14, Properties.Resources.produto_32x);
            }
            else if (tblDireita.ClientSize.Width > 190 && tblDireita.ClientSize.Height > 650 /* && btnProduto.Font.Size < 12 */)
            {
                ModificarPropriedadesBotao(btnProduto, 12, Properties.Resources.produto_24x);
            }
            else if (tblDireita.ClientSize.Width <= 190 && tblDireita.ClientSize.Height <= 650 /* && btnProduto.Font.Size > 10 */)
            {
                ModificarPropriedadesBotao(btnProduto, 8, Properties.Resources.produto_18x);
            }
        }

        private void ModificarPropriedadesBotao(Button btn, int TamanhoDaFonte, Image image)
        {
            btn.Font = new Font("Verdana", TamanhoDaFonte, FontStyle.Bold);
            btn.Image = image;
        }

        private void ModificarCorBotaoParaPadrao(Button btn)
        {
            if (btnSelecionado != null)
                btnSelecionado.BackColor = Color.FromArgb(32, 46, 56);

            btnSelecionado = btn;
            btnSelecionado.BackColor = Color.FromArgb(16, 23, 28);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmPrincipal.AbrirTelaPanelCentral<UCUsuario>();
            ModificarCorBotaoParaPadrao((Button)sender);
        }

    }
}
