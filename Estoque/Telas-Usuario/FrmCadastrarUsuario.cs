using Azure.Core;
using EP.Data.Entidades;
using EP.Data.Interfaces;
using EP.Data.Repositorios;
using Estoque.Interfaces;
using EstoqueProdutos.Gerenciamento;
using JJ.Helpers.Formatacao;
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
    public partial class FrmCadastrarUsuario : Estoque.Telas_Base.FrmBase
    {
        private readonly IImagemRepositorio imagemRepositorio;
        private readonly ISetorRepositorio setorRepositorio;
        private readonly ICargoRepositorio cargoRepositorio;
        private readonly IUsuarioRepositorio usuarioRepositorio;

        private BindingSource bsCargo = new BindingSource();

        private bool emailValidado = false;
        private bool confirmacaoEmailValidado = false;
        private bool senhaValidada = false;
        public FrmCadastrarUsuario(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            InitializeComponent();

            this.gerenciadorDeTelas = gerenciadorDeTelas;

            imagemRepositorio = DIRepositorios.Container.GetInstance<IImagemRepositorio>();
            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
            cargoRepositorio = DIRepositorios.Container.GetInstance<ICargoRepositorio>();
            usuarioRepositorio = DIRepositorios.Container.GetInstance<IUsuarioRepositorio>();
            pcbImagemUsuario.Image = imagemRepositorio.ObterImagemPadrao();
        }

        #region Metodos 
        /* Inicializacao */
        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxSetor();
                BindComboBoxCargo();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha sql\n\n" + ex.Message);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar essa operação\n\n" + ex.Message);
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

            if (txtEmail.Text.ValidarEmail())
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

            if (!txtConfirmarEmail.Text.ValidarEmail())
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
        private bool ValidarCamposPreenchidos()
        {
            if (txtNomeCompleto.Text == "")
            {
                MessageBox.Show("Campo nome completo é obrigatorio");
                txtNomeCompleto.Focus();
                return false;
            }

            if (txtNomeAbreviado.Text == "")
            {
                MessageBox.Show("Campo usuário é obrigatorio");
                txtNomeAbreviado.Focus();
                return false;
            }

            if ((int)cboSetor.SelectedValue <= 0)
            {
                MessageBox.Show("Campo setor é obrigatorio");
                cboSetor.Focus();
                return false;
            }

            if ((int)cboCargo.SelectedValue <= 0)
            {
                MessageBox.Show("Campo cargo é obrigatorio");
                cboCargo.Focus();
                return false;
            }

            if (!emailValidado || !confirmacaoEmailValidado)
            {
                MessageBox.Show("Email inválido!");
                txtEmail.Focus();
                return false;
            }

            if (!senhaValidada)
            {
                MessageBox.Show("Senha inválida!");
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

                var usuario = new Usuario()
                {
                    NomeCompleto = txtNomeCompleto.Text.Trim(),
                    NomeAbreviado = txtNomeAbreviado.Text.Trim(),
                    FK_Setor = (int)cboSetor.SelectedValue,
                    FK_Cargo = (int)cboCargo.SelectedValue,
                    Ativo = true,
                    DataCadastro = DateTime.Today,
                    FK_Imagem = PK_Imagem,
                    Email = txtEmail.Text,
                    Senha = txtSenha.Text
                };

                var resultado = usuarioRepositorio.InserirDadosNaTabela(usuario);

                if (resultado)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    LimparComponetes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário.\nErro: " + ex.Message);
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

        private void tlpUsuario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
