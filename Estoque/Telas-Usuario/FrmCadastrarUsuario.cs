using EP.Data.Interfaces;
using Estoque.Interfaces;
using EstoqueProdutos.Gerenciamento;
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

namespace Estoque.Telas_Usuario
{
    public partial class FrmCadastrarUsuario : Estoque.Telas_Base.FrmBase
    {
        private readonly IImagemRepositorio imagemRepositorio;

        public FrmCadastrarUsuario(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            InitializeComponent();

            this.gerenciadorDeTelas = gerenciadorDeTelas;

            imagemRepositorio = DIRepositorios.Container.GetInstance<IImagemRepositorio>();

            pcbImagemUsuario.Image = imagemRepositorio.ObterImagemPadrao();
        }

        #region Eventos

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCompleto.Text = "";
            txtNomeAbreviado.Text = "";

            cboSetor.SelectedValue = 0;
            cboSetor.SelectedValue = 0;

            txtEmail.Text = "";
            txtConfirmarEmail.Text = "";

            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
        }

        private void FrmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }

        #endregion Eventos
    }
}
