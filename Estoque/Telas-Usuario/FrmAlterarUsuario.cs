using Azure.Core;
using EP.Data.Entidades;
using EP.Data.Interfaces;
using EP.Data.Repositorios;
using Estoque.Controladores;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Gerenciamento;
using JJ.Helpers.Formatacao;
using JJ.Helpers.Interfaces;
using Microsoft.Data.SqlClient;
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
    public partial class FrmAlterarUsuario : Estoque.Telas_Base.FrmBase
    {
        private readonly IImagemRepositorio imagemRepositorio;
        private readonly ISetorRepositorio setorRepositorio;
        private readonly ICargoRepositorio cargoRepositorio;
        private readonly IUsuarioRepositorio usuarioRepositorio;
        private readonly IValidacao validacao;

        private BindingSource bsCargo = new BindingSource();

        private bool emailValidado = false;
        private bool confirmacaoEmailValidado = false;
        private bool senhaValidada = false;
        public Usuario UsuarioSelecionado { get; set; }

        public FrmAlterarUsuario(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            InitializeComponent();

            this.gerenciadorDeTelas = gerenciadorDeTelas;

            imagemRepositorio = DIRepositorios.Container.GetInstance<IImagemRepositorio>();
            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
            cargoRepositorio = DIRepositorios.Container.GetInstance<ICargoRepositorio>();
            usuarioRepositorio = DIRepositorios.Container.GetInstance<IUsuarioRepositorio>();
            validacao = DITelas.Container.GetInstance<IValidacao>();

            pcbImagemUsuario.Image = imagemRepositorio.ObterImagemPadrao();
        }

        #region Metodos 
        /* Inicializacao */

        private void ObterUsuarioSelecionado()
        {
            try
            {
                UsuarioSelecionado = gerenciadorDeTelas.ObterObjetoGenerico() as Usuario;
                if (UsuarioSelecionado != null)
                {
                    txtNomeCompleto.Text = UsuarioSelecionado.NomeCompleto;
                    txtNomeAbreviado.Text = UsuarioSelecionado.NomeAbreviado;
                    cboSetor.SelectedValue = UsuarioSelecionado.FK_Setor;
                    cboCargo.SelectedValue = UsuarioSelecionado.FK_Cargo;
                    txtEmail.Text = UsuarioSelecionado.Email;
                    txtConfirmarEmail.Text = UsuarioSelecionado.Email;

                    pcbImagemUsuario.Image = ObterImagemDoUsuario(UsuarioSelecionado.FK_Imagem);
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao encontrar usuário");
                this.Close();
            }
        }

        private Image ObterImagemDoUsuario(int FK_Imagem)
        {
            //verificar se imagem ja existe em cache

            var img = imagemRepositorio.ObterApenasImagem(FK_Imagem);

            if (img != null)
                return img;

            return imagemRepositorio.ObterImagemPadrao();
        }

        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxSetor();
                BindComboBoxCargo();
            }
            catch (SqlException ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha conexão");
                this.Close();
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao executar essa operação");
                this.Close();
            }
        }
        private void BindComboBoxSetor()
        {
            var result = setorRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                cboSetor.DataSource = result;
                cboSetor.DisplayMember = "NomeSetor";
                cboSetor.ValueMember = "PK_Setor";
                cboSetor.SelectedValue = 3;
            }
        }
        private void BindComboBoxCargo()
        {
            var result = cargoRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                bsCargo.DataSource = result;
                cboCargo.DataSource = FiltrarCargos();
                cboCargo.DisplayMember = "NomeCargo";
                cboCargo.ValueMember = "PK_Cargo";
            }
        }

        /* Updates */
        private void LimparComponetes()
        {
            pcbImagemUsuario.Image = imagemRepositorio.ObterImagemPadrao();

            txtNomeCompleto.Text = "";
            txtNomeAbreviado.Text = "";

            cboSetor.SelectedValue = 1;

            txtEmail.Text = "";
            txtConfirmarEmail.Text = "";

            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
        }
        private IEnumerable<Cargo> FiltrarCargos()
        {
            if (cboSetor != null && cboSetor.SelectedItem is Setor setor)
            {
                return bsCargo.OfType<Cargo>().Where(c => c.Setor.PK_Setor == setor.PK_Setor).ToList();
            }

            return null;
        }

        /* Validacoes */
        private void ValidarEmail()
        {
            emailValidado = false;

            if (txtEmail.Text == "")
            {
                pcbValidacaoEmail.Visible = false;
                return;
            }

            if (validacao.ValidarEmail(txtEmail.Text))
            {
                pcbValidacaoEmail.Visible = true;
                pcbValidacaoEmail.Image = Properties.Resources.circulo_verde;

                emailValidado = true;
            }
            else
            {
                pcbValidacaoEmail.Visible = true;
                pcbValidacaoEmail.Image = Properties.Resources.erro;
            }
        }
        private void ValidarConfirmacaoDeEmail()
        {
            confirmacaoEmailValidado = false;

            if (txtConfirmarEmail.Text == "" && txtEmail.Text == "")
            {
                if (txtEmail.Text == "")
                {
                    pcbValidacaoConfirmarEmail.Visible = false;
                    return;
                }
                else
                {
                    pcbValidacaoConfirmarEmail.Visible = true;
                    pcbValidacaoConfirmarEmail.Image = Properties.Resources.erro;
                    return;
                }
            }

            if (!validacao.ValidarEmail(txtConfirmarEmail.Text))
            {
                pcbValidacaoConfirmarEmail.Visible = true;
                pcbValidacaoConfirmarEmail.Image = Properties.Resources.erro;
            }
            else
            {
                if (txtConfirmarEmail.Text.Equals(txtEmail.Text))
                {
                    pcbValidacaoConfirmarEmail.Visible = true;
                    pcbValidacaoConfirmarEmail.Image = Properties.Resources.circulo_verde;

                    confirmacaoEmailValidado = true;
                }
                else
                {
                    pcbValidacaoConfirmarEmail.Visible = true;
                    pcbValidacaoConfirmarEmail.Image = Properties.Resources.erro;
                }
            }
        }
        private void ValidarConfirmacaoSenha()
        {
            senhaValidada = false;
            if (txtConfirmarSenha.Text == "" && txtSenha.Text == "")
            {
                pcbValidacaoConfirmacaoSenha.Visible = false;
                pcbValidacaoConfirmacaoSenha.Image = Properties.Resources.circulo_verde;
                return;
            }
            else
            {
                pcbValidacaoConfirmacaoSenha.Visible = true;
                pcbValidacaoConfirmacaoSenha.Image = Properties.Resources.erro;
            }

            if (txtConfirmarSenha.Text.Equals(txtSenha.Text))
            {
                pcbValidacaoConfirmacaoSenha.Visible = true;
                pcbValidacaoConfirmacaoSenha.Image = Properties.Resources.circulo_verde;
                senhaValidada = true;
            }
            else
            {
                pcbValidacaoConfirmacaoSenha.Visible = true;
                pcbValidacaoConfirmacaoSenha.Image = Properties.Resources.erro;
            }
        }


        private bool ValidarSenhaNovaRegistrada()
        {
            if ((txtConfirmarSenha.Text == "" && txtSenha.Text == "") ||
                txtConfirmarSenha.Text.Equals(txtSenha.Text.Trim())
                )
            {
                return true;
            }

            return false;
        }
        private bool ValidarCamposPreenchidos()
        {
            if (txtNomeCompleto.Text == "")
            {
                Alerta.Erro("Campo nome completo é obrigatorio");
                txtNomeCompleto.Focus();
                return false;
            }

            if (txtNomeAbreviado.Text == "")
            {
                Alerta.Erro("Campo usuário é obrigatorio");
                txtNomeAbreviado.Focus();
                return false;
            }

            if ((int)cboSetor.SelectedValue <= 0)
            {
                Alerta.Erro("Campo setor é obrigatorio");
                cboSetor.Focus();
                return false;
            }

            if ((int)cboCargo.SelectedValue <= 0)
            {
                Alerta.Erro("Campo cargo é obrigatorio");
                cboCargo.Focus();
                return false;
            }

            if (!emailValidado || !confirmacaoEmailValidado)
            {
                Alerta.Erro("Email inválido!");
                txtEmail.Focus();
                return false;
            }

            if (!ValidarSenhaNovaRegistrada())
            {
                Alerta.Erro("Senha inválida!");
                txtSenha.Focus();
                return false;
            }

            return true;
        }
        #endregion Metodos

        #region Eventos
        /* Form */
        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
            ObterUsuarioSelecionado();
        }
        private void FrmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }

        /* Botoes */
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponetes();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var img = pcbImagemUsuario.Image;
            int PK_Imagem = imagemRepositorio.SalvarImagemNaBase(img);

            try
            {
                if (!ValidarCamposPreenchidos())
                    return;

                if (UsuarioSelecionado.NomeCompleto != txtNomeCompleto.Text.Trim())
                    UsuarioSelecionado.NomeCompleto = txtNomeCompleto.Text.Trim();

                if (UsuarioSelecionado.NomeAbreviado != txtNomeAbreviado.Text.Trim())
                    UsuarioSelecionado.NomeAbreviado = txtNomeAbreviado.Text.Trim();

                if (UsuarioSelecionado.FK_Setor != (int)cboSetor.SelectedValue)
                    UsuarioSelecionado.FK_Setor = (int)cboSetor.SelectedValue;

                if (UsuarioSelecionado.FK_Cargo != (int)cboCargo.SelectedValue)
                    UsuarioSelecionado.FK_Cargo = (int)cboCargo.SelectedValue;

                if (UsuarioSelecionado.Email != txtEmail.Text.Trim())
                    UsuarioSelecionado.Email = txtEmail.Text.Trim();

                if (txtSenha.Text != "")
                    UsuarioSelecionado.Senha = txtSenha.Text.Trim();

                if (PK_Imagem > 1)
                    UsuarioSelecionado.FK_Imagem = PK_Imagem;

                var resultado = usuarioRepositorio.AtualizarDadosNaTabela(UsuarioSelecionado);

                if (resultado)
                {
                    Alerta.Confirmacao("Usuário atualizado com sucesso!");

                    LimparComponetes();
                    ObterUsuarioSelecionado();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Erro ao atualizar dados");
            }
        }

        /* ComboBox */
        private void cboSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSetor != null)
            {
                cboCargo.DataSource = FiltrarCargos();
            }
        }

        /* PictureBox */
        private void pcbImagemUsuario_Click(object sender, EventArgs e)
        {
            var img = imagemRepositorio.ProcurarImagemLocal();

            if (img != null)
            {
                pcbImagemUsuario.Image = img;
            }
        }
        private void pcbSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.PasswordChar = '\0';
        }
        private void pcbSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }
        private void pcbConfirmarSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmarSenha.PasswordChar = '\0';
        }
        private void pcbConfirmarSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmarSenha.PasswordChar = '*';
        }

        /* TextBox */
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidarEmail();
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            ValidarEmail();
            if (txtConfirmarEmail.Text.Length > 0)
            {
                ValidarConfirmacaoDeEmail();
            }
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            ValidarEmail();
        }
        private void txtConfirmarEmail_Leave(object sender, EventArgs e)
        {
            ValidarConfirmacaoDeEmail();
        }
        private void txtConfirmarEmail_TextChanged(object sender, EventArgs e)
        {
            ValidarConfirmacaoDeEmail();
        }
        private void txtConfirmarEmail_Enter(object sender, EventArgs e)
        {
            ValidarConfirmacaoDeEmail();
        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {

            ValidarConfirmacaoSenha();
        }
        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            ValidarConfirmacaoSenha();
        }
        private void txtConfirmarSenha_Enter(object sender, EventArgs e)
        {
            ValidarConfirmacaoSenha();
        }
        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            ValidarConfirmacaoSenha();
        }
        #endregion Eventos
    }
}
