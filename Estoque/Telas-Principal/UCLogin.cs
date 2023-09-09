using EP.Data.Interfaces;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
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
    public partial class UCLogin : Estoque.Telas_Base.UCBase
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;
        private readonly IUsuarioLogado usuarioLogado;
        public UCLogin()
        {
            InitializeComponent();
            AtualizarPropriedades();
            usuarioRepositorio = DIRepositorios.Container.GetInstance<IUsuarioRepositorio>();
            usuarioLogado = DITelas.Container.GetInstance<IUsuarioLogado>();
        }

        private bool salvarEmail;

        private void UCLogin_SizeChanged(object sender, EventArgs e)
        {
            int locX = Convert.ToInt32((this.Size.Width - pCentral.Width) / 2);
            int locY = Convert.ToInt32((this.Size.Height - pCentral.Height) / 2);
            pCentral.Location = new Point(locX, locY);
        }

        private void pcbCheckBoxEmail_Click(object sender, EventArgs e)
        {
            if (salvarEmail)
            {
                pcbCheckBoxEmail.Image = Properties.Resources.chk_uncheck_32x32;
            }
            else
            {
                pcbCheckBoxEmail.Image = Properties.Resources.chk_checked_32x32;
            }

            salvarEmail = !salvarEmail;
        }

        private void pcbCheckBoxSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == 0)
            {
                txtSenha.PasswordChar = '*';
                pcbCheckBoxSenha.Image = Properties.Resources.eyeBG_1;
            }
            else
            {
                pcbCheckBoxSenha.Image = Properties.Resources.eyeBG_2;
                txtSenha.PasswordChar = '\0';
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length == 0)
            {
                Alerta.Erro("Campo email é obrigatório!");
                txtEmail.Focus();
                return;
            }

            if (txtSenha.Text.Length == 0)
            {
                Alerta.Erro("Campo senha é obrigatório!");
                txtSenha.Focus();
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                var usuario = usuarioRepositorio.ObterUsuario(new EP.Data.Entidades.Usuario
                {
                    Email = txtEmail.Text.Trim(),
                })
                .FirstOrDefault();

                if (usuario != null)
                {
                    if (txtSenha.Text.Equals(usuario.Senha))
                    {
                        Alerta.Confirmacao("Bem vindo!");
                        usuarioLogado.AtribuirUsuario(usuario);
                        this.Dispose();
                    }
                    else
                    {
                        Alerta.Erro("Senha inválida!");
                    }
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "josejunior@teste.com";
            txtSenha.Text = "adm123";
        }
    }
}
