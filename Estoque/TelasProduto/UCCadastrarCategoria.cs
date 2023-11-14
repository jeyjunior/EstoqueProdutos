using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
using Estoque.Enums;
using Estoque.GerenciamentoTelas;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Repositorios;
using System.Data.SqlClient;
using System.Reflection;

namespace Estoque.Telas_Produto
{
    public partial class UCCadastrarCategoria : Telas_Base.UCBase
    {
        #region Interfaces 
        private readonly ICategoriaRepositorio categoriaRepositorio;
        #endregion Interfaces

        #region Propriedades
        private Categoria categoriaSelecionada;
        private ModoCRUD modoCRUD = ModoCRUD.Select;
        private IEnumerable<Categoria> categoriaCollection;
        #endregion Propriedades

        public UCCadastrarCategoria()
        {
            InitializeComponent();
            AtualizarPropriedades();

            categoriaRepositorio = DIRepositorios.Container.GetInstance<ICategoriaRepositorio>();
        }
        #region Metodos
        /* Start */
        private void InicializarComponentes()
        {
            try
            {
                CarregarPesquisa();
                LayoutBotoes();
            }
            catch (SqlException ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha conexão");
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao carregar componentes");
            }
        }

        private void CarregarPesquisa()
        {
            categoriaCollection = categoriaRepositorio.ObterTabela(new Categoria
            {
                Nome = txtCategoria.TextoFormatoLikeSQL().AtribuirPorcentagemAoTextoSQL(),
                Descricao = txtDescricao.TextoFormatoLikeSQL().AtribuirPorcentagemAoTextoSQL()
            });

            BindDataGridView();
        }

        private void BindDataGridView()
        {
            var resultado = categoriaCollection.Select(s => new
            {
                PK_Categoria = s.PK_Categoria,
                Nome = s.Nome,
                Descricao = s.Descricao
            })
            .ToList();

            dtgCategoria.DataSource = resultado;
        }
        /* Updates */
        private void SelecionarItem()
        {
            if (dtgCategoria.Rows.Count <= 0)
            {
                Alerta.Aviso("Para realizar essa operação, é necessário selecionar uma categoria");
                return;
            }

            DataGridViewRow linha = dtgCategoria.SelectedRows[0];

            categoriaSelecionada = new Categoria()
            {
                PK_Categoria = Convert.ToInt32(linha.Cells["colPK_Categoria"].Value),
                Nome = linha.Cells["colNome"].Value.ToString(),
                Descricao = linha.Cells["colDescricao"].Value.ToString()
            };

            if (categoriaSelecionada != null)
            {
                txtCategoria.Text = categoriaSelecionada.Nome;
                txtDescricao.Text = categoriaSelecionada.Descricao;
            }
        }
        private void Reiniciar()
        {
            txtCategoria.Text = "";
            txtCategoria.Enabled = true;
            txtDescricao.Text = "";

            modoCRUD = ModoCRUD.Select;
            LayoutBotoes();
            PesquisarItem();

            txtCategoria.Focus();
        }
        private void AtualizarTotalRegistrado()
        {
            int total = categoriaRepositorio.ObterContagemTotal();
            lblTotalRegistrado.Text = "Registrados: " + total;
        }
        private void AtualizarTotalPesquisado()
        {
            lblTotalPesquisado.Text = "Pesquisado: " + dtgCategoria.Rows.Count;
        }
        private void CadastrarNovoItem()
        {
            try
            {
                string mensagem = "Tem certeza que deseja criar esta categoria?\n" +
                                  "Categoria: " + txtCategoria.Text.Trim() + "\n";

                mensagem += (txtDescricao.Text != "") ? "Descrição: " + txtDescricao.Text.Trim() : "";

                var resultado = Mensagem.Pergunta(mensagem, "Cadastro");

                if (resultado != RespostaCaixaDialogo.Sim)
                {
                    txtCategoria.Focus();
                    return;
                }

                var resultadoInsert = categoriaRepositorio.InserirDadosNaTabela(new Categoria() { Nome = txtCategoria.TextoFormatoLikeSQL(), Descricao = txtDescricao.TextoFormatoLikeSQL() });

                if (resultadoInsert)
                {
                    Alerta.Confirmacao("Categoria registrada com sucesso!");
                    Reiniciar();
                    AtualizarTotalRegistrado();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao executar essa operação");
            }
        }
        private void AlterarItemSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que deseja alterar esta categoria?\n\n";

                var resultado = Mensagem.Pergunta(mensagem, "Alterar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = categoriaRepositorio
                        .AtualizarTodosOsDados(new Categoria()
                        {
                            PK_Categoria = categoriaSelecionada.PK_Categoria,
                            Nome = txtCategoria.TextoFormatoLikeSQL(),
                            Descricao = txtDescricao.TextoFormatoLikeSQL()
                        });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Categoria atualizada com sucesso!");
                        Reiniciar();
                        AtualizarTotalRegistrado();
                    }
                }
                else
                {
                    txtCategoria.Focus();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao executar essa operação");
            }
        }
        private void ExcluirItemSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que deseja excluir esta categoria?\n";
                string excluirCategoria = "\nDeletar: " + txtCategoria.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + excluirCategoria, "Deletar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = categoriaRepositorio.ExcluirDadosDaTabela(categoriaSelecionada.PK_Categoria);

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Categoria excluída com sucesso!");
                        Reiniciar();
                        AtualizarTotalRegistrado();
                    }
                }
                else
                {
                    txtCategoria.Focus();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }
        private void PesquisarItem()
        {
            try
            {
                CarregarPesquisa();
                AtualizarTotalPesquisado();

                txtCategoria.Focus();
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }
        private void LayoutBotoes()
        {
            foreach (Button btn in tlpBotoes.Controls)
            {
                btn.Enabled = false;
            }

            btnLimpar.Enabled = (modoCRUD != ModoCRUD.Update);

            if (modoCRUD == ModoCRUD.Insert || modoCRUD == ModoCRUD.Update)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else if (modoCRUD == ModoCRUD.Select)
            {
                btnPesquisar.Enabled = true;
                btnCadastrar.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }

            txtCategoria.Focus();
        }
        #endregion Metodos

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                Alerta.Aviso("É necessário inserir uma categoria!");
                txtCategoria.Focus();
                return;
            }

            switch (modoCRUD)
            {
                case ModoCRUD.Insert:
                    var categoria = new Categoria();
                    var coluna = nameof(categoria.Nome).ToString();
                    var resultado = categoriaRepositorio.ValidarValorExistente(coluna, txtCategoria.Text.ToString());

                    if (resultado)
                    {
                        Alerta.Aviso("Esta categoria já existe!");
                        txtCategoria.Focus();
                        return;
                    }
                    CadastrarNovoItem();
                    break;
                case ModoCRUD.Update:
                    AlterarItemSelecionado();
                    break;
                case ModoCRUD.Delete:
                    ExcluirItemSelecionado();
                    break;
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SelecionarItem();
            ExcluirItemSelecionado();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCategoria.Text = "";
            txtCategoria.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            modoCRUD = ModoCRUD.Select;
            PesquisarItem();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modoCRUD = ModoCRUD.Insert;
            LayoutBotoes();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            modoCRUD = ModoCRUD.Update;
            LayoutBotoes();
            SelecionarItem();
        }

        private void UCCadastrar_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
            AtualizarTotalRegistrado();
            AtualizarTotalPesquisado();
            LayoutBotoes();
        }
        #endregion Eventos
    }
}
