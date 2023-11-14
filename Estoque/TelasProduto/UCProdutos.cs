using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
using Estoque.Telas_Usuario;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Interfaces;
using System.Data.SqlClient;

namespace Estoque.Telas_Produto
{
    public partial class UCProdutos : Estoque.Telas_Base.UCGerenciadorDeTelas
    {
        #region Interfaces
        private readonly IProdutoRepositorio produtoRepositorio;
        private readonly IMarcaRepositorio marcaRepositorio;
        private readonly ICategoriaRepositorio categoriaRepositorio;
        private readonly IFormatoRepositorio formatoRepositorio;
        private readonly IEmbalagemRepositorio embalagemRepositorio;
        private readonly IRepositorio<Produto> repositorioGenerico;

        private readonly IConfigColunasProdutoRepositorio configColunasProdutoRepositorio;
        private readonly IUsuarioLogado usuarioLogado;
        #endregion Interfaces

        #region Propriedades
        private int PK_ProdutoSelecionado;
        private Produto produtoSelecionado;
        private int indiceLinhaSelecionada;
        #endregion 

        #region Colecoes
        private IEnumerable<Produto> produtos;
        #endregion Colecoes

        #region Construtor
        public UCProdutos()
        {
            InitializeComponent();
            AtualizarPropriedades();

            produtoRepositorio = DIRepositorios.Container.GetInstance<IProdutoRepositorio>();
            marcaRepositorio = DIRepositorios.Container.GetInstance<IMarcaRepositorio>();
            categoriaRepositorio = DIRepositorios.Container.GetInstance<ICategoriaRepositorio>();
            formatoRepositorio = DIRepositorios.Container.GetInstance<IFormatoRepositorio>();
            embalagemRepositorio = DIRepositorios.Container.GetInstance<IEmbalagemRepositorio>();
            repositorioGenerico = DIRepositorios.Container.GetInstance<IRepositorio<Produto>>();
            configColunasProdutoRepositorio = DIRepositorios.Container.GetInstance<IConfigColunasProdutoRepositorio>();

            usuarioLogado = DITelas.Container.GetInstance<IUsuarioLogado>();
        }
        #endregion Construtor

        #region Metodos - Inicialização
        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxCategoria();
                BindComboBoxMarca();
                BindComboBoxFormato();
                BindComboBoxEmbalagem();
                AtualizarTotalRegistrado();
                btnPesquisar.PerformClick();
            }
            catch (SqlException ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha conexão");
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao executar essa operação");
            }
        }
        private void BindComboBoxMarca()
        {
            var result = marcaRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Marca
                {
                    PK_Marca = 0,
                    Nome = "Nenhuma",
                    Descricao = "Nenhuma"
                });

            if (result != null)
            {
                cboMarca.DataSource = result;
                cboMarca.DisplayMember = "Nome";
                cboMarca.ValueMember = "PK_Marca";
                cboMarca.SelectedIndex = 0;
            }
        }
        private void BindComboBoxCategoria()
        {
            var result = categoriaRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Categoria
                {
                    PK_Categoria = 0,
                    Nome = "Nenhuma",
                    Descricao = "Nenhuma"
                });


            if (result != null)
            {
                cboCategoria.DataSource = result;
                cboCategoria.DisplayMember = "Nome";
                cboCategoria.ValueMember = "PK_Categoria";
                cboCategoria.SelectedIndex = 0;
            }
        }
        private void BindComboBoxFormato()
        {
            var result = formatoRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Formato
                {
                    PK_Formato = 0,
                    Nome = "Nenhum",
                    Descricao = "Nenhum"
                });

            if (result != null)
            {
                cboFormato.DataSource = result;
                cboFormato.DisplayMember = "Nome";
                cboFormato.ValueMember = "PK_Formato";
                cboFormato.SelectedIndex = 0;
            }
        }
        private void BindComboBoxEmbalagem()
        {
            var result = embalagemRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Embalagem
                {
                    PK_Embalagem = 0,
                    Nome = "Nenhuma",
                    Descricao = "Nenhuma"
                });

            if (result != null)
            {
                cboEmbalagem.DataSource = result;
                cboEmbalagem.DisplayMember = "Nome";
                cboEmbalagem.ValueMember = "PK_Embalagem";
                cboEmbalagem.SelectedIndex = 0;
            }
        }
        #endregion Metodos - Inicialização

        #region Metodos - Updates
        private void BindDataGridView()
        {
            if (produtos != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                var resultado = produtos.Select(c => new
                {
                    PK_Produto = c.PK_Produto,
                    Nome = c.Nome,
                    Volume = (c.Volume != null) ? $"{c.Volume} {c.UnidadeMedida.Sigla}" : "",
                    Descricao = c.Descricao,
                    Altura = c.Altura,
                    Largura = c.Largura,
                    Comprimento = c.Comprimento,
                    Formato = c.Formato.Nome,
                    Categoria = c.Categoria.Nome,
                    Marca = c.Marca.Nome,
                    Embalagem = c.Embalagem.Nome
                })
                    .ToList();

                if (resultado.Count == 0)
                {
                    dtgProdutos.DataSource = produtos.Select(c => new
                    {
                        PK_Produto = 0,
                        Nome = "",
                        Volume = "",
                        Descricao = "",
                        Altura = "",
                        Largura = "",
                        Comprimento = "",
                        Formato = "",
                        Categoria = "",
                        Marca = "",
                        Embalagem = ""
                    })
                    .ToList();
                }
                else
                {
                    dtgProdutos.DataSource = resultado;
                }
            }
            AtualizarTotalRegistrado();
            AtualizarTotalPesquisado();
        }
        private void LimparComponentes()
        {
            txtNomeProduto.Text = "";
            txtDescricaoProduto.Text = "";

            cboCategoria.SelectedValue = 0;
            cboEmbalagem.SelectedValue = 0;
            cboMarca.SelectedValue = 0;
            cboFormato.SelectedValue = 0;

            txtNomeProduto.Focus();
        }
        private void AtualizarTotalRegistrado()
        {
            int total = repositorioGenerico.ObterContagemTotal("Produto");
            lblTotalRegistrado.Text = "Registrados: " + total;
        }
        private void AtualizarTotalPesquisado()
        {
            lblTotalPesquisado.Text = "Pesquisado: " + dtgProdutos.Rows.Count;
        }
        private void ObterProdutoDaLinhaSelecionar()
        {
            try
            {
                PK_ProdutoSelecionado = -1;
                if (dtgProdutos.Rows.Count <= 0)
                {
                    Alerta.Aviso("Selecione um produto");
                    return;
                }

                DataGridViewRow linhaSelecionada = dtgProdutos.SelectedRows[0];
                indiceLinhaSelecionada = linhaSelecionada.Index;

                PK_ProdutoSelecionado = Convert.ToInt32(linhaSelecionada.Cells["colPK_Produto"].Value);
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }
        #endregion Metodos - Updates

        #region Eventos - UserControl
        private void UCProdutos_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }
        private void UCProdutos_ParentChanged(object sender, EventArgs e)
        {
            LimparComponentes();
        }
        private void UCProdutos_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                btnPesquisar.PerformClick();
                //AtualizarConfiguracaoDoGrid();
            }
        }
        #endregion Eventos - UserControl

        #region Eventos - Btn
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var pesquisa = new PesquisaProdutoSimples()
            {
                Nome = txtNomeProduto.TextoFormatoLikeSQLComPorcentagem(),
                Descricao = txtDescricaoProduto.TextoFormatoLikeSQLComPorcentagem(),
                FK_Categoria = cboCategoria.ObterValorInt(),
                FK_Embalagem = cboEmbalagem.ObterValorInt(),
                FK_Formato = cboFormato.ObterValorInt(),
                FK_Marca = cboMarca.ObterValorInt()
            };

            produtos = produtoRepositorio.ObterProduto(pesquisa);
            BindDataGridView();
        }
        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            AbrirTela(typeof(FrmConfigurarColunas), this, true, UCProdutos_VisibleChanged);
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }
        private void btnOutrosCadastro_Click(object sender, EventArgs e)
        {
            AbrirTela(typeof(FrmCadastrarComplementosProduto), this, true, FilhoFechado);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ObterProdutoDaLinhaSelecionar();

            if (PK_ProdutoSelecionado > 0)
            {
                ObjetoGenerico = produtoRepositorio.ObterProduto(new PesquisaProdutoSimples 
                { 
                    PK_Produto = PK_ProdutoSelecionado,
                    Nome = "",
                    Descricao = ""
                }).FirstOrDefault();

                if(ObjetoGenerico != null)
                {
                    StatusGenerico = true;
                    AbrirTela(typeof(FrmCadastrarAlterarProduto), this, true, FilhoFechado);
                }
                else
                {
                    Mensagem.Erro("Falha ao carregar produto selecionado!");
                }
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AbrirTela(typeof(FrmCadastrarAlterarProduto), this, true, FilhoFechado);
        }
        #endregion Eventos - Btn

        #region Eventos - Filhos 
        private void FilhoFechado(object? sender, FormClosedEventArgs e)
        {
            InicializarComponentes();
            AtualizarTotalRegistrado();
        }
        #endregion Eventos - Filhos
    }
}