
using Estoque.Interfaces;
using EstoqueProdutos.Entidades;
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

namespace Estoque.Telas_Principal
{
    public partial class UCTelaPrincipalCima : Estoque.Telas_Base.UCBase, IUCTelaPrincipalCima
    {
        private readonly IUsuarioLogado usuarioLogado;

        public UCTelaPrincipalCima()
        {
            InitializeComponent();
            AtualizarPropriedades();

            usuarioLogado = DITelas.Container.GetInstance<IUsuarioLogado>();
        }

        public void AtualizarInfoTelaAberta(Image logo, string nomeTela)
        {
            pcbLogo.Image = logo;
            lblTela.Text = nomeTela;
        }

        public void AtualizarInfoUsuarioLogado()
        {
            var usuario = usuarioLogado.ObterUsuarioLogado();

            if (usuario != null)
            {
                string nomeUsuario = usuario.NomeAbreviado;
                string cargoUsuario = usuario.Cargo.NomeCargo;

                lblUsuario.Text = $"{nomeUsuario} | {cargoUsuario}";
            }
        }
    }
}
