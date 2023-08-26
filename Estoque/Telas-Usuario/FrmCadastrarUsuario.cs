using Estoque.Interfaces;
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
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
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

        #endregion Eventos

        private void FrmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }
    }
}
