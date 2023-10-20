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
    public partial class FrmCadastrarProduto : FrmBase
    {
        private readonly IImagemRepositorio imagemRepositorio;
        //private readonly ISetorRepositorio setorRepositorio;
        //private readonly ICargoRepositorio cargoRepositorio;
        private readonly IUsuarioRepositorio usuarioRepositorio;
        //private readonly IValidacao validacao;


        //private BindingSource bsCargo = new BindingSource();

        //private bool nomeValidado = false;
        //private bool usuarioValidado = false;
        //private bool emailValidado = false;
        //private bool confirmacaoEmailValidado = false;
        //private bool senhaValidada = false;
        //private bool confirmacaoSenhaValidada = false;

        public FrmCadastrarProduto(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            InitializeComponent();

            this.gerenciadorDeTelas = gerenciadorDeTelas;

            imagemRepositorio = DIRepositorios.Container.GetInstance<IImagemRepositorio>();
            usuarioRepositorio = DIRepositorios.Container.GetInstance<IUsuarioRepositorio>();
            //setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
            //cargoRepositorio = DIRepositorios.Container.GetInstance<ICargoRepositorio>();
            //validacao = DITelas.Container.GetInstance<IValidacao>();

            pcbImagem.Image = imagemRepositorio.ObterImagemPadrao();
        }

        #region Metodos 
        /* Inicializacao */
        private void InicializarComponentes()
        {
            try
            {
                //BindComboBoxSetor();
                //BindComboBoxCargo();
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
        //private void BindComboBoxSetor()
        //{
        //    var result = setorRepositorio.ObterTabela().ToList();

        //    if (result != null)
        //    {
        //        cboCategoria.DataSource = result;
        //        cboCategoria.DisplayMember = "NomeSetor";
        //        cboCategoria.ValueMember = "PK_Setor";
        //        cboCategoria.SelectedValue = 3;
        //    }
        //}
        //private void BindComboBoxCargo()
        //{
        //    var result = cargoRepositorio.ObterTabela().ToList();

        //    if (result != null)
        //    {
        //        bsCargo.DataSource = result;
        //        cboEmbalagem.DataSource = FiltrarCargos();
        //        cboEmbalagem.DisplayMember = "NomeCargo";
        //        cboEmbalagem.ValueMember = "PK_Cargo";
        //    }
        //}
        /* Updates */
        private void LimparComponetes()
        {
            //pcbImagem.Image = imagemRepositorio.ObterImagemPadrao();

            txtNomeCompleto.Text = "";
            txtDescricao.Text = "";

            cboCategoria.SelectedValue = 1;

            txtAltura.Text = "";
            txtLargura.Text = "";

            txtNomeCompleto.Focus();
        }
        //private IEnumerable<Cargo> FiltrarCargos()
        //{
        //    if (cboCategoria != null && cboCategoria.SelectedItem is Setor setor)
        //    {
        //        return bsCargo.OfType<Cargo>().Where(c => c.Setor.PK_Setor == setor.PK_Setor).ToList();
        //    }

        //    return null;
        //}

        //private bool ValidarComponentes()
        //{
        //    if (!nomeValidado)
        //    {
        //        Alerta.Erro("Campo nome é obrigatório!");
        //        txtNomeCompleto.Focus();
        //        return false;
        //    }

        //    if (!usuarioValidado)
        //    {
        //        Alerta.Erro("Campo usuário é obrigatório!");
        //        txtDescricao.Focus();
        //        return false;
        //    }

        //    if (!emailValidado)
        //    {
        //        Alerta.Erro("Campo email é obrigatório!");
        //        txtAltura.Focus();
        //        return false;
        //    }

        //    if (!confirmacaoEmailValidado)
        //    {
        //        Alerta.Erro("Campo confirmar email é obrigatório!");
        //        txtLargura.Focus();
        //        return false;
        //    }

        //    if (!senhaValidada)
        //    {
        //        Alerta.Erro("Campo senha é obrigatório!");
        //        txtSenha.Focus();
        //        return false;
        //    }

        //    if (!confirmacaoSenhaValidada)
        //    {
        //        Alerta.Erro("Campo confirmar senha é obrigatório!");
        //        txtConfirmarSenha.Focus();
        //        return false;
        //    }

        //    return true;
        //}
        #endregion Metodos

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //var img = pcbImagem.Image;
            //int PK_Imagem = imagemRepositorio.SalvarImagemNaBase(img);

            //try
            //{
            //    if (!ValidarComponentes())
            //        return;

            //    var usuario = new Usuario()
            //    {
            //        NomeCompleto = txtNomeCompleto.Text.Trim(),
            //        NomeAbreviado = txtDescricao.Text.Trim(),
            //        FK_Setor = (int)cboCategoria.SelectedValue,
            //        FK_Cargo = (int)cboEmbalagem.SelectedValue,
            //        Ativo = true,
            //        DataCadastro = DateTime.Today,
            //        FK_Imagem = PK_Imagem,
            //        Email = txtAltura.Text,
            //        Senha = txtSenha.Text
            //    };

            //    var resultado = usuarioRepositorio.InserirDadosNaTabela(usuario);

            //    if (resultado)
            //    {
            //        Alerta.Confirmacao("Usuário cadastrado com sucesso!");
            //        LimparComponetes();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Mensagem.Erro("Erro: " + ex.Message, "Erro ao cadastrar usuário.");
            //}
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponetes();
        }

        private void pcbImagemUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                var img = imagemRepositorio.ProcurarImagemLocal();

                if (img != null)
                {
                    pcbImagem.Image = img;
                }
            }
            catch (Exception ex)
            {

                Mensagem.Erro("Erro: " + ex.Message);
            }
        }


        #endregion Eventos

        private void FrmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }
    }
}
