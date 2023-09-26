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


namespace Estoque.Telas_Usuario
{
    public partial class FrmAlterarUsuario : FrmBase
    {
        private readonly IImagemRepositorio imagemRepositorio;
        private readonly ISetorRepositorio setorRepositorio;
        private readonly ICargoRepositorio cargoRepositorio;
        private readonly IUsuarioRepositorio usuarioRepositorio;
        private readonly IValidacao validacao;

        private BindingSource bsCargo = new BindingSource();
        public Usuario UsuarioSelecionado { get; set; }

        private bool nomeValidado = false;
        private bool usuarioValidado = false;
        private bool emailValidado = false;
        private bool confirmacaoEmailValidado = false;
        private bool senhaValidada = false;
        private bool confirmacaoSenhaValidada = false;

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

        #region Metodos - Inicializacao
        private void ObterUsuarioSelecionado()
        {
            try
            {
                UsuarioSelecionado = gerenciadorDeTelas.ObterObjetoGenerico() as Usuario;
                if (UsuarioSelecionado != null)
                {
                    txtNomeCompleto.Text = UsuarioSelecionado.NomeCompleto;
                    txtUsuario.Text = UsuarioSelecionado.NomeAbreviado;
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
            return img != null ? img : imagemRepositorio.ObterImagemPadrao();
        }
        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxSetor();
                BindComboBoxCargo();
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
        #endregion Metodos - Inicializacao


        #region Metodos - Update
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

            if(txtSenha.Text.Length > 0 || txtConfirmarSenha.Text.Length > 0 )
            {
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
            }

            return true;
        }
        #endregion Metodos - Update



        #region Eventos - Form
        private void FrmEstruturaBaseCadastro_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
            ObterUsuarioSelecionado();
        }
        private void FrmEstruturaBaseCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }
        #endregion Eventos - Form

        #region Eventos - Botoes
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var img = pcbImagemUsuario.Image;
            int PK_Imagem = imagemRepositorio.SalvarImagemNaBase(img);

            try
            {
                if (!ValidarComponentes())
                    return;

                if (UsuarioSelecionado.NomeCompleto != txtNomeCompleto.Text.Trim())
                    UsuarioSelecionado.NomeCompleto = txtNomeCompleto.Text.Trim();

                if (UsuarioSelecionado.NomeAbreviado != txtUsuario.Text.Trim())
                    UsuarioSelecionado.NomeAbreviado = txtUsuario.Text.Trim();

                if (UsuarioSelecionado.FK_Setor != (int)cboSetor.SelectedValue)
                    UsuarioSelecionado.FK_Setor = (int)cboSetor.SelectedValue;

                if (UsuarioSelecionado.FK_Cargo != (int)cboCargo.SelectedValue)
                    UsuarioSelecionado.FK_Cargo = (int)cboCargo.SelectedValue;

                if (UsuarioSelecionado.Email != txtEmail.Text.Trim())
                    UsuarioSelecionado.Email = txtEmail.Text.Trim();

                if (txtSenha.Text != "")
                    UsuarioSelecionado.Senha = txtSenha.Text.Trim();

                if (PK_Imagem > 1)
                {
                    UsuarioSelecionado.FK_Imagem = PK_Imagem;
                }

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
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponetes();
        }
        #endregion Eventos - Botoes

        #region Eventos - Componentes
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
        #endregion Eventos - Componentes
    }
}
