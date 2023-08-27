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

        private BindingSource bindingSourceCargos = new BindingSource();
        private BindingSource bindingSourceSetor = new BindingSource();

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
                bindingSourceSetor.DataSource = result;
                cboSetor.DataSource = bindingSourceSetor;
                cboSetor.DisplayMember = "NomeSetor";
                cboSetor.ValueMember = "PK_Setor";
                cboSetor.SelectedIndex = 0;
            }
        }

        private void BindComboBoxCargo()
        {
            var result = cargoRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                bindingSourceCargos.DataSource = result;
                cboCargo.DataSource = bindingSourceCargos
                    .Cast<Cargo>().Where(c => c.FK_Setor == 1).ToList();
                cboCargo.DisplayMember = "NomeCargo";
                cboCargo.ValueMember = "PK_Cargo";
                cboCargo.SelectedIndex = 0;
            }
        }

        private void OrganizarCargoPorSetorSelecionado()
        {
            int PK_Setor = ObterSetorSelecionado();

            if (PK_Setor > 0)
            {
                cboCargo.DataSource = bindingSourceCargos
                    .Cast<Cargo>().Where(c => c.FK_Setor == PK_Setor).ToList();
            }
        }
        #region Eventos

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponetes();
        }

        private void LimparComponetes()
        {
            txtNomeCompleto.Text = "";
            txtNomeAbreviado.Text = "";

            cboSetor.SelectedIndex = 0;
            cboCargo.SelectedIndex = 0;

            txtEmail.Text = "";
            txtConfirmarEmail.Text = "";

            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
        }

        private void FrmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }

        private void cboSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrganizarCargoPorSetorSelecionado();
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

        #endregion Eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ObterSetorSelecionado() <= 0)
            {
                MessageBox.Show("Campo setor é obrigatorio");
                cboSetor.Focus();
                return;
            }

            if (ObterCargoSelecionado() <= 0)
            {
                MessageBox.Show("Campo cargo é obrigatorio");
                cboCargo.Focus();
                return;
            }

            try
            {
                var usuario = new Usuario()
                {
                    NomeCompleto = txtNomeCompleto.Text.Trim(),
                    NomeAbreviado = txtNomeAbreviado.Text.Trim(),
                    FK_Setor = ObterSetorSelecionado(),
                    FK_Cargo = ObterCargoSelecionado(),
                    Ativo = true,
                    DataCadastro = DateTime.Today,
                    FK_Imagem = 1,
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

        private int ObterSetorSelecionado()
        {
            if (cboSetor != null
                && cboSetor.Items.Count > 0
                && cboSetor.SelectedItem is Setor setorSelecionado)
            {
                return cboSetor.SelectedIndex > 0 ? setorSelecionado.PK_Setor : 0;
            }

            return 0;
        }

        private int ObterCargoSelecionado()
        {
            if (cboCargo != null
                && cboCargo.Items.Count > 0
                && cboCargo.SelectedItem is Cargo cargoSelecionado)
            {
                return cboCargo.SelectedIndex > 0 ? cargoSelecionado.PK_Cargo : 0;
            }

            return 0;
        }

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

        private void ValidarEmail()
        {
            if (txtEmail.Text == "")
            {
                pcbValidacaoEmail.Visible = false;
                return;
            }

            if (txtEmail.Text.ValidarEmail())
            {
                pcbValidacaoEmail.Visible = true;
                if (pcbValidacaoEmail.Image != Properties.Resources.circulo_verde)
                    pcbValidacaoEmail.Image = Properties.Resources.circulo_verde;
            }
            else
            {
                pcbValidacaoEmail.Visible = true;
                pcbValidacaoEmail.Image = Properties.Resources.alert;
            }
        }

        private void ValidarConfirmacaoDeEmail()
        {
            if (txtConfirmarEmail.Text == "" && txtEmail.Text == "")
            {
                pcbValidacaoConfirmarEmail.Visible = false;
                return;
            }

            if (txtConfirmarEmail.Text == "" && txtEmail.Text != "")
            {
                pcbValidacaoConfirmarEmail.Visible = true;
                if (pcbValidacaoConfirmarEmail.Image != Properties.Resources.alert)
                    pcbValidacaoConfirmarEmail.Image = Properties.Resources.alert;
                return;
            }

            if (!txtConfirmarEmail.Text.ValidarEmail())
            {
                pcbValidacaoConfirmarEmail.Visible = true;
                if (pcbValidacaoConfirmarEmail.Image != Properties.Resources.alert)
                    pcbValidacaoConfirmarEmail.Image = Properties.Resources.alert;
                return;
            }

            if (txtConfirmarEmail.Text.Equals(txtEmail.Text))
            {
                pcbValidacaoConfirmarEmail.Visible = true;
                if (pcbValidacaoConfirmarEmail.Image != Properties.Resources.circulo_verde)
                    pcbValidacaoConfirmarEmail.Image = Properties.Resources.circulo_verde;
            }
            else
            {
                pcbValidacaoConfirmarEmail.Visible = true;
                if (pcbValidacaoConfirmarEmail.Image != Properties.Resources.alert)
                    pcbValidacaoConfirmarEmail.Image = Properties.Resources.alert;
            }
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
    }
}
