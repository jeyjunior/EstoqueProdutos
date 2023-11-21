using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
using Estoque.Telas_Base;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Repositorios;
using JJ.Helpers.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace Estoque.Telas_Produto
{
    public partial class FrmCadastrarAlterarProduto : FrmBase
    {
        private readonly IUsuarioLogado usuarioLogado;
        private readonly IValidacao validacao;

        private readonly IImagemRepositorio imagemRepositorio;
        private readonly ICategoriaRepositorio categoriaRepositorio;
        private readonly IMarcaRepositorio marcaRepositorio;
        private readonly IEmbalagemRepositorio embalagemRepositorio;
        private readonly IFormatoRepositorio formatoRepositorio;
        private readonly IUnidadeMedidaRepositorio unidadeMedidaRepositorio;
        private readonly IProdutoRepositorio produtoRepositorio;

        private bool produtoValidado = false;
        private Produto ProdutoSelecionado { get; set; }
        private bool AlterarProduto { get; set; }

        public FrmCadastrarAlterarProduto(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            InitializeComponent();

            this.gerenciadorDeTelas = gerenciadorDeTelas;

            usuarioLogado = DITelas.Container.GetInstance<IUsuarioLogado>();
            validacao = DITelas.Container.GetInstance<IValidacao>();

            imagemRepositorio = DIRepositorios.Container.GetInstance<IImagemRepositorio>();
            categoriaRepositorio = DIRepositorios.Container.GetInstance<ICategoriaRepositorio>();
            marcaRepositorio = DIRepositorios.Container.GetInstance<IMarcaRepositorio>();
            embalagemRepositorio = DIRepositorios.Container.GetInstance<IEmbalagemRepositorio>();
            formatoRepositorio = DIRepositorios.Container.GetInstance<IFormatoRepositorio>();
            unidadeMedidaRepositorio = DIRepositorios.Container.GetInstance<IUnidadeMedidaRepositorio>();
            produtoRepositorio = DIRepositorios.Container.GetInstance<IProdutoRepositorio>();

            pcbImagem.Image = imagemRepositorio.ObterImagemPadrao();
        }

        #region Metodos 
        /* Inicializacao */
        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxCategoria();
                BindComboBoxMarca();
                BindComboBoxEmbalagem();
                BindComboBoxFormato();
                BindComboBoxUnidadeMedida();
                InicializarEventos();
                dtpFabricacao.Value = DateTime.Today;
                FormatarComponentesDateTime();
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
        private void BindComboBoxCategoria()
        {
            var result = categoriaRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                cboCategoria.DataSource = result;
                cboCategoria.DisplayMember = "Nome";
                cboCategoria.ValueMember = "PK_Categoria";
            }
        }
        private void BindComboBoxMarca()
        {
            var result = marcaRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                cboMarca.DataSource = result;
                cboMarca.DisplayMember = "Nome";
                cboMarca.ValueMember = "PK_Marca";
            }
        }
        private void BindComboBoxEmbalagem()
        {
            var result = embalagemRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                cboEmbalagem.DataSource = result;
                cboEmbalagem.DisplayMember = "Nome";
                cboEmbalagem.ValueMember = "PK_Embalagem";
            }
        }
        private void BindComboBoxFormato()
        {
            var result = formatoRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                cboFormato.DataSource = result;
                cboFormato.DisplayMember = "Nome";
                cboFormato.ValueMember = "PK_Formato";
            }
        }
        private void BindComboBoxUnidadeMedida()
        {
            var result = unidadeMedidaRepositorio.ObterTabela()
                .Select(s => new
                {
                    PK_UnidadeMedida = s.PK_UnidadeMedida,
                    Nome = $"{s.Extenso} ({s.Sigla})"
                })
                .ToList();

            if (result != null)
            {
                cboUnidadeMedida.DataSource = result;
                cboUnidadeMedida.DisplayMember = "Nome";
                cboUnidadeMedida.ValueMember = "PK_UnidadeMedida";
            }
        }

        private void InicializarEventos()
        {
            txtProduto.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            //txtProduto.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;

            txtDescricao.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            //txtDescricao.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;

            txtAltura.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            txtAltura.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;
            txtAltura.Leave += Eventos.TextBoxAtribuirZero_Leave;
            txtAltura.KeyPress += Eventos.TextBoxNumerosDecimais_KeyPress;

            txtLargura.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            txtLargura.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;
            txtLargura.Leave += Eventos.TextBoxAtribuirZero_Leave;
            txtLargura.KeyPress += Eventos.TextBoxNumerosDecimais_KeyPress;

            txtComprimento.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            txtComprimento.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;
            txtComprimento.Leave += Eventos.TextBoxAtribuirZero_Leave;
            txtComprimento.KeyPress += Eventos.TextBoxNumerosDecimais_KeyPress;

            txtVolume.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            txtVolume.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;
            txtVolume.Leave += Eventos.TextBoxAtribuirZero_Leave;
            txtVolume.KeyPress += Eventos.TextBoxNumerosDecimais_KeyPress;
        }


        /* Updates */
        private void FormatarComponentesDateTime()
        {
            dtpValidade.MinDate = dtpFabricacao.Value;
        }

        private void LimparComponetes()
        {
            pcbImagem.Image = imagemRepositorio.ObterImagemPadrao();

            txtProduto.Text = "";
            dtpFabricacao.Value = DateTime.Today;
            dtpValidade.Value = DateTime.Today;
            txtDescricao.Text = "";

            cboCategoria.SelectedValue = 1;
            cboMarca.SelectedValue = 1;
            cboFormato.SelectedValue = 1;
            cboEmbalagem.SelectedValue = 1;
            cboUnidadeMedida.SelectedValue = 1;

            txtAltura.Text = "0";
            txtLargura.Text = "0";
            txtComprimento.Text = "0";
            txtVolume.Text = "0";

            txtProduto.Focus();

            if (AlterarProduto)
                AtribuirInformacoesDoProduto();
        }

        private bool ValidarComponentes()
        {
            if (!produtoValidado)
            {
                Alerta.Erro("Campo produto é obrigatório!");
                txtProduto.Focus();
                return false;
            }

            return true;
        }
        #endregion Metodos

        #region Eventos
        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            InicializarComponentes();

            ProdutoSelecionado = gerenciadorDeTelas.ObterObjetoGenerico() as Produto;
            AlterarProduto = gerenciadorDeTelas.ObterStatusGenerico();

            LimparComponetes();
        }

        private void AtribuirInformacoesDoProduto()
        {
            try
            {
                var img = imagemRepositorio.ObterApenasImagem(ProdutoSelecionado.FK_Imagem);

                pcbImagem.Image = img != null ? img : imagemRepositorio.ObterImagemPadrao();
                txtProduto.Text = ProdutoSelecionado.Nome;
                txtDescricao.Text = ProdutoSelecionado.Descricao;

                dtpFabricacao.Value = ProdutoSelecionado.DataFabricacao != null ? Convert.ToDateTime(ProdutoSelecionado.DataFabricacao) : DateTime.Today;
                dtpValidade.Value = ProdutoSelecionado.DataValidade != null ? Convert.ToDateTime(ProdutoSelecionado.DataValidade) : DateTime.Today.AddDays(5);

                cboCategoria.SelectedValue = ProdutoSelecionado.FK_Categoria;
                cboEmbalagem.SelectedValue = ProdutoSelecionado.FK_Embalagem;
                cboFormato.SelectedValue = ProdutoSelecionado.FK_Formato;
                cboMarca.SelectedValue = ProdutoSelecionado.FK_Marca;
                cboUnidadeMedida.SelectedValue = ProdutoSelecionado.FK_UnidadeMedida;

                txtVolume.Text = ProdutoSelecionado.Volume != null ? ProdutoSelecionado.Volume.ToString() : "0";
                txtAltura.Text = ProdutoSelecionado.Altura != null ? ProdutoSelecionado.Altura.ToString() : "0";
                txtLargura.Text = ProdutoSelecionado.Largura != null ? ProdutoSelecionado.Largura.ToString() : "0";
                txtComprimento.Text = ProdutoSelecionado.Comprimento != null ? ProdutoSelecionado.Comprimento.ToString() : "0";
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Falha ao carregar informações do produto!\nErro: " + ex.Message);
                this.Close();
            }
        }

        private void FrmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var img = pcbImagem.Image;
            int PK_Imagem = imagemRepositorio.SalvarImagemNaBase(img);

            try
            {
                if (!ValidarComponentes())
                    return;

                var nome = txtProduto.Text;
                var descricao = txtDescricao.Text;
                var dataFabricacao = dtpFabricacao.Value;
                var dataValidade = dtpValidade.Value;
                var pk_Categoria = (int)cboCategoria.SelectedValue;
                var pk_Embalagem = (int)cboEmbalagem.SelectedValue;
                var pk_Formato = (int)cboFormato.SelectedValue;
                var pk_Marca = (int)cboMarca.SelectedValue;
                var pk_UnidadeMedida = (int)cboUnidadeMedida.SelectedValue;
                var altura = Convert.ToDecimal(txtAltura.Text);
                var largura = Convert.ToDecimal(txtLargura.Text);
                var comprimento = Convert.ToDecimal(txtComprimento.Text);

                var produto = new Produto()
                {
                    Nome = nome,
                    Descricao = descricao,
                    DataFabricacao = dataFabricacao,
                    DataValidade = dataValidade,
                    FK_Categoria = pk_Categoria,
                    FK_Embalagem = pk_Embalagem,
                    FK_Formato = pk_Formato,
                    FK_Marca = pk_Marca,
                    FK_UnidadeMedida = pk_UnidadeMedida,
                    FK_Imagem = PK_Imagem,
                    Altura = altura,
                    Largura = largura,
                    Comprimento = comprimento
                };

                bool resultado = false;

                if (!AlterarProduto)
                {
                    resultado = produtoRepositorio.InserirDados(produto);

                    if (resultado)
                    {
                        Alerta.Confirmacao("Produto cadastrado com sucesso!");
                        LimparComponetes();
                    }
                    else
                    {
                        Mensagem.Erro("Não foi possívl cadastrar o produto. \nCertifique-se de que todos os dados estejam corretos e que o produto não exista no sistema.");
                    }
                }
                else
                {
                    produto.PK_Produto = ProdutoSelecionado.PK_Produto;
                    resultado = produtoRepositorio.AtualizarDadosComValores(produto);

                    if (resultado)
                    {
                        Alerta.Confirmacao("Produto alterado com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        Mensagem.Erro("Não foi possívl alterar o produto. \nCertifique-se de que todos os dados estejam corretos.");
                    }
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Erro ao cadastrar produto.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponetes();
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            produtoValidado = validacao.ValidarTextDoTextBox(ref txtProduto, ref pValidarProduto, 2);
        }

        private void dtpFabricacao_ValueChanged(object sender, EventArgs e)
        {
            FormatarComponentesDateTime();
        }
        #endregion Eventos
    }
}
