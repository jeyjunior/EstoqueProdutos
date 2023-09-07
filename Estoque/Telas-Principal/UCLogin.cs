using EP.Data.Interfaces;
using Estoque.GerenciamentoTelas;
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
    public partial class UCLogin : UserControl
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;
        public UCLogin()
        {
            InitializeComponent();

            usuarioRepositorio = DIRepositorios.Container.GetInstance<IUsuarioRepositorio>();
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
            if (txtEmail.Text.Length == 0 || txtSenha.Text.Length == 0)
            {
                Alerta.Erro("Email ou senha inválido!");
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                var resultado = usuarioRepositorio.ObterUsuario(new EP.Data.Entidades.Usuario
                {
                    Email = txtEmail.Text.Trim(),
                });

                if (resultado != null)
                {
                    if (txtSenha.Text.Equals(resultado.Select(s => s.Senha).FirstOrDefault()))
                    {
                        Alerta.Confirmacao("Bem vindo!");
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
    }
}
