using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
using Estoque.Telas_Base;
using EstoqueProdutos.Gerenciamento;
using JJ.Helpers.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Estoque.Telas_Produto
{
    public partial class FrmCadastrarUsuario : FrmBase
    {
        private readonly IImagemRepositorio imagemRepositorio;
        private readonly ISetorRepositorio setorRepositorio;
        private readonly ICargoRepositorio cargoRepositorio;
        private readonly IUsuarioRepositorio usuarioRepositorio;
        private readonly IValidacao validacao;


        private BindingSource bsCargo = new BindingSource();

        private bool nomeValidado = false;
        private bool usuarioValidado = false;
        private bool emailValidado = false;
        private bool confirmacaoEmailValidado = false;
        private bool senhaValidada = false;
        private bool confirmacaoSenhaValidada = false;

        public FrmCadastrarUsuario(IUCGerenciadorDeTelas gerenciadorDeTelas)
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
        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxSetor();
                BindComboBoxCargo();
            }
            catch (SqlException ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha conexão.");
                this.Close();
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha carregar componentes");
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

        private bool ValidarComponentes()
        {
            if (!nomeValidado)
            {
                Alerta.Erro("Campo nome é obrigatório!");
                txtNomeCompleto.Focus();
                return false;
            }

            if (!usuarioValidado)
            {
                Alerta.Erro("Campo usuário é obrigatório!");
                txtUsuario.Focus();
                return false;
            }

            if (!emailValidado)
            {
                Alerta.Erro("Campo email é obrigatório!");
                txtEmail.Focus();
                return false;
            }

            if (!confirmacaoEmailValidado)
            {
                Alerta.Erro("Campo confirmar email é obrigatório!");
                txtConfirmarEmail.Focus();
                return false;
            }

            if (!senhaValidada)
            {
                Alerta.Erro("Campo senha é obrigatório!");
                txtSenha.Focus();
                return false;
            }

            if (!confirmacaoSenhaValidada)
            {
                Alerta.Erro("Campo confirmar senha é obrigatório!");
                txtConfirmarSenha.Focus();
                return false;
            }

            return true;
        }
        #endregion Metodos

        #region Eventos
        private void FrmEstruturaBaseCadastro_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }
        private void FrmEstruturaBaseCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var img = pcbImagemUsuario.Image;
            int PK_Imagem = imagemRepositorio.SalvarImagemNaBase(img);

            try
            {
                if (!ValidarComponentes())
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
                    Alerta.Confirmacao("Usuário cadastrado com sucesso!");
                    LimparComponetes();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Erro ao cadastrar usuário.");
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

        private void pcbExibirSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '\0')
            {
                txtSenha.PasswordChar = '*';
                pcbExibirSenha.Image = Properties.Resources.eyeBG_1;
            }
            else
            {
                txtSenha.PasswordChar = '\0';
                pcbExibirSenha.Image = Properties.Resources.eyeBG_2;
            }
        }
        private void pcbExibirConfirmarSenha_Click(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.PasswordChar == '\0')
            {
                txtConfirmarSenha.PasswordChar = '*';
                pcbExibirConfirmarSenha.Image = Properties.Resources.eyeBG_1;
            }
            else
            {
                txtConfirmarSenha.PasswordChar = '\0';
                pcbExibirConfirmarSenha.Image = Properties.Resources.eyeBG_2;
            }
        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            nomeValidado = validacao.ValidarTextDoTextBox(ref txtNomeCompleto, ref pValidarNomeCompleto, 5);
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            usuarioValidado = validacao.ValidarTextDoTextBox(ref txtUsuario, ref pValidarUsuario, 3);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            emailValidado = validacao.ValidarEmail(ref txtEmail, ref pValidarEmail);

            if (txtConfirmarEmail.Text.Length > 0)
            {
                txtConfirmarEmail_TextChanged(txtConfirmarEmail, e);
            }
        }
        private void txtConfirmarEmail_TextChanged(object sender, EventArgs e)
        {
            confirmacaoEmailValidado = false;

            if (txtConfirmarEmail.Text.Equals(txtEmail.Text) && validacao.ValidarEmail(txtConfirmarEmail.Text))
            {
                validacao.ObterCorValidacao(ref pValidarConfirmarEmail, eValidacao.itemValidado);
                confirmacaoEmailValidado = true;
            }
            else if (txtConfirmarEmail.Text.Length > 0)
            {
                validacao.ObterCorValidacao(ref pValidarConfirmarEmail, eValidacao.itemNaoValidado);
            }
            else
            {
                validacao.ObterCorValidacao(ref pValidarConfirmarEmail, eValidacao.itemPadrao);
            }
        }
        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            int max = txtConfirmarSenha.Text.Length > 8 ? txtConfirmarSenha.Text.Length : 8;
            lblConfirmarSenha.Text = $"Confirmar Senha [{txtConfirmarSenha.Text.Length} / {max}]:";
            confirmacaoSenhaValidada = false;

            if (txtConfirmarSenha.Text.Equals(txtSenha.Text) && txtConfirmarSenha.Text.Length >= 8)
            {
                validacao.ObterCorValidacao(ref pValidarConfirmarSenha, eValidacao.itemValidado);
                confirmacaoSenhaValidada = true;
            }
            else if (txtConfirmarSenha.Text.Length > 0)
            {
                validacao.ObterCorValidacao(ref pValidarConfirmarSenha, eValidacao.itemNaoValidado);
            }
            else
            {
                validacao.ObterCorValidacao(ref pValidarConfirmarSenha, eValidacao.itemPadrao);
            }
        }
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            int max = txtSenha.Text.Length > 8 ? txtSenha.Text.Length : 8;
            lblSenha.Text = $"Senha [{txtSenha.Text.Length} / {max}]:";

            senhaValidada = validacao.ValidarTextDoTextBox(ref txtSenha, ref pValidarSenha, 8);

            if (txtConfirmarSenha.Text.Length > 0)
            {
                txtConfirmarSenha_TextChanged(txtConfirmarSenha, e);
            }
        }
        #endregion Eventos
    }
}
