using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Interfaces;
using Estoque.Telas_Base;
using EstoqueProdutos.Gerenciamento;
using JJ.Helpers.Formatacao;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Usuario
{
    public partial class FrmEstruturaBaseCadastro : Estoque.Telas_Base.FrmBase
    {
        private readonly IImagemRepositorio imagemRepositorio;
        private readonly ISetorRepositorio setorRepositorio;
        private readonly ICargoRepositorio cargoRepositorio;
        private readonly IUsuarioRepositorio usuarioRepositorio;

        private BindingSource bsCargo = new BindingSource();

        private bool emailValidado = false;
        private bool confirmacaoEmailValidado = false;
        private bool senhaValidada = false;

        public FrmEstruturaBaseCadastro(IUCGerenciadorDeTelas gerenciadorDeTelas)
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
            txtUsuario.Text = "";

            cboSetor.SelectedValue = 1;

            txtEmail.Text = "";
            txtConfirmarEmail.Text = "";

            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";

            txtNomeCompleto.Focus();
        }
        private IEnumerable<Cargo> FiltrarCargos()
        {
            if (cboSetor != null && cboSetor.SelectedItem is Setor setor)
            {
                return bsCargo.OfType<Cargo>().Where(c => c.Setor.PK_Setor == setor.PK_Setor).ToList();
            }

            return null;
        }

        #endregion Metodos

        private void FrmEstruturaBaseCadastro_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var img = pcbImagemUsuario.Image;
            int PK_Imagem = imagemRepositorio.SalvarImagemNaBase(img);

            try
            {
                if (!emailValidado || !confirmacaoEmailValidado || !senhaValidada)
                    return;

                if (txtNomeCompleto.Text.Length <= 5 || txtUsuario.Text.Length <= 3)
                    return;

                var usuario = new Usuario()
                {
                    NomeCompleto = txtNomeCompleto.Text.Trim(),
                    NomeAbreviado = txtUsuario.Text.Trim(),
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
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponetes();
        }
        private void pcbImagemUsuario_Click(object sender, EventArgs e)
        {
            var img = imagemRepositorio.ProcurarImagemLocal();

            if (img != null)
            {
                pcbImagemUsuario.Image = img;
            }
        }
        private void FrmEstruturaBaseCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }
        private void cboSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSetor != null)
            {
                cboCargo.DataSource = FiltrarCargos();
            }
        }
        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pcbExibirSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.PasswordChar = '\0';
            pcbExibirSenha.Image = Properties.Resources.eyeBG_2;
        }
        private void pcbExibirSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.PasswordChar = '*';
            pcbExibirSenha.Image = Properties.Resources.eyeBG_1;
        }
        private void pcbExibirConfirmarSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.PasswordChar = '\0';
            pcbExibirConfirmarSenha.Image = Properties.Resources.eyeBG_2;
        }
        private void pcbExibirConfirmarSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.PasswordChar = '*';
            pcbExibirConfirmarSenha.Image = Properties.Resources.eyeBG_1;
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            emailValidado = false;

            if (txtEmail.Text.Length > 0)
            {
                if (txtEmail.Text.ValidarEmail())
                {
                    pValidarEmail.BackColor = Color.Green;
                    emailValidado = true;
                }
                else
                {
                    pValidarEmail.BackColor = Color.Red;
                }
            }
            else
            {
                pValidarEmail.BackColor = Color.White;
            }
        }
        private void txtConfirmarEmail_TextChanged(object sender, EventArgs e)
        {
            confirmacaoEmailValidado = false;

            if (txtConfirmarEmail.Text.Length > 0)
            {
                if (txtConfirmarEmail.Text.ValidarEmail() && txtConfirmarEmail.Text.Equals(txtEmail.Text))
                {
                    pValidarConfirmarEmail.BackColor = Color.Green;
                    confirmacaoEmailValidado = true;
                }
                else
                {
                    pValidarConfirmarEmail.BackColor = Color.Red;
                }
            }
            else
            {
                pValidarConfirmarEmail.BackColor = Color.White;
            }
        }
        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            senhaValidada = false;

            if (txtSenha.Text.Length >= 5 && txtConfirmarSenha.Text.Length >= 5)
            {
                senhaValidada = txtConfirmarSenha.Text.Equals(txtSenha.Text);
            }

            Validacao.ValidarTextDoTextBox(ref txtConfirmarSenha, ref pValidarConfirmarSenha, 5);
        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            Validacao.ValidarTextDoTextBox(ref txtNomeCompleto, ref pValidarNomeCompleto, 5);
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            Validacao.ValidarTextDoTextBox(ref txtSenha, ref pValidarSenha, 5);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Validacao.ValidarTextDoTextBox(ref txtUsuario, ref pValidarUsuario, 3);
        }
    }
}
