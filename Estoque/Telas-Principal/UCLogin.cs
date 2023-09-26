using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
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
            salvarEmail = !salvarEmail;

            pcbCheckBoxEmail.Image = !salvarEmail ?
                Properties.Resources.chk_uncheck_32x32 : Properties.Resources.chk_checked_32x32;
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

            SalvarEmailEmCache();

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                var validarUsuarioAtivo = usuarioRepositorio.UsuarioLogin(new UsuarioLoginAcess
                {
                    Email = txtEmail.Text.Trim(),
                    Ativo = true
                })
                .FirstOrDefault();

                if (validarUsuarioAtivo != null && validarUsuarioAtivo.Ativo)
                {
                    var usuario = usuarioRepositorio.ObterUsuario(new Usuario
                    {
                        Email = validarUsuarioAtivo.Email
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
                    else
                    {
                        Alerta.Erro("Falha ao tentar obter usuário!");
                    }
                }
                else
                {
                    Alerta.Erro("Usuário sem permissão!");
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Erro");
            }
        }

        private void SalvarEmailEmCache()
        {
            try
            {
                string arquivoCache = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Estoque", "userEmail.txt");

                string emailSalvo = salvarEmail ? txtEmail.Text.Trim() : " ";

                using (StreamWriter writer = new StreamWriter(arquivoCache))
                {
                    writer.Write(emailSalvo);
                }
            }
            catch
            {
            }
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtSenha.Text = "";

            try
            {
                string arquivoCache = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Estoque", "userEmail.txt");

                if (File.Exists(arquivoCache))
                {
                    txtEmail.Text = File.ReadAllText(arquivoCache).Trim();
                }
            }
            catch
            {

            }

            if (txtEmail.Text.Length > 0)
            {
                pcbCheckBoxEmail_Click(pcbCheckBoxEmail, EventArgs.Empty);
                txtSenha.Focus();
            }
            else
                txtEmail.Focus();
        }
    }
}
