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
    public partial class UCCadastrarEmbalagem : Telas_Base.UCBase
    {
        #region Interfaces 
        private readonly IEmbalagemRepositorio embalagemRepositorio;
        #endregion Interfaces

        #region Propriedades
        private Embalagem embalagemSelecionada;
        private ModoCRUD modoCRUD = ModoCRUD.Select;
        private IEnumerable<Embalagem> embalagemCollection;
        #endregion Propriedades

        public UCCadastrarEmbalagem()
        {
            InitializeComponent();
            AtualizarPropriedades();

            embalagemRepositorio = DIRepositorios.Container.GetInstance<IEmbalagemRepositorio>();
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
            embalagemCollection = embalagemRepositorio.ConsultarDadosNaTabela(new Embalagem
            {
                Nome = txtEmbalagem.TextoFormatoLikeSQL().AtribuirPorcentagemAoTextoSQL(),
                Descricao = txtDescricao.TextoFormatoLikeSQL().AtribuirPorcentagemAoTextoSQL()
            });

            BindDataGridView();
        }

        private void BindDataGridView()
        {
            var resultado = embalagemCollection.Select(s => new
            {
                PK_Embalagem = s.PK_Embalagem,
                Nome = s.Nome,
                Descricao = s.Descricao
            })
            .ToList();

            dtgEmbalagem.DataSource = resultado;
        }
        /* Updates */
        private void SelecionarItem()
        {
            if (dtgEmbalagem.Rows.Count <= 0)
            {
                Alerta.Aviso("Para realizar essa operação, é necessário selecionar uma embalagem");
                return;
            }

            DataGridViewRow linha = dtgEmbalagem.SelectedRows[0];

            embalagemSelecionada = new Embalagem()
            {
                PK_Embalagem = Convert.ToInt32(linha.Cells["colPK_Embalagem"].Value),
                Nome = linha.Cells["colNome"].Value.ToString(),
                Descricao = linha.Cells["colDescricao"].Value.ToString()
            };

            if (embalagemSelecionada != null)
            {
                txtEmbalagem.Text = embalagemSelecionada.Nome;
                txtDescricao.Text = embalagemSelecionada.Descricao;
            }
        }
        private void Reiniciar()
        {
            txtEmbalagem.Text = "";
            txtEmbalagem.Enabled = true;
            txtDescricao.Text = "";

            modoCRUD = ModoCRUD.Select;
            LayoutBotoes();
            PesquisarItem();

            txtEmbalagem.Focus();
        }
        private void AtualizarTotalRegistrado()
        {
            int total = embalagemRepositorio.ObterContagemTotal();
            lblTotalRegistrado.Text = "Registrados: " + total;
        }
        private void AtualizarTotalPesquisado()
        {
            lblTotalPesquisado.Text = "Pesquisado: " + dtgEmbalagem.Rows.Count;
        }
        private void CadastrarNovoItem()
        {
            try
            {
                string mensagem = "Tem certeza que deseja criar esta embalagem?\n" +
                                  "Embalagem: " + txtEmbalagem.Text.Trim() + "\n";

                mensagem += (txtDescricao.Text != "") ? "Descrição: " + txtDescricao.Text.Trim() : "";

                var resultado = Mensagem.Pergunta(mensagem, "Cadastro");

                if (resultado != RespostaCaixaDialogo.Sim)
                {
                    txtEmbalagem.Focus();
                    return;
                }

                var resultadoInsert = embalagemRepositorio.InserirDadosNaTabela(new Embalagem() { Nome = txtEmbalagem.TextoFormatoLikeSQL(), Descricao = txtDescricao.TextoFormatoLikeSQL() });

                if (resultadoInsert)
                {
                    Alerta.Confirmacao("Embalagem registrada com sucesso!");
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
                string mensagem = "Tem certeza que deseja alterar esta embalagem?\n\n";

                var resultado = Mensagem.Pergunta(mensagem, "Alterar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = embalagemRepositorio
                        .AtualizarTodosOsDados(new Embalagem()
                        {
                            PK_Embalagem = embalagemSelecionada.PK_Embalagem,
                            Nome = txtEmbalagem.TextoFormatoLikeSQL(),
                            Descricao = txtDescricao.TextoFormatoLikeSQL()
                        });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Embalagem atualizada com sucesso!");
                        Reiniciar();
                        AtualizarTotalRegistrado();
                    }
                }
                else
                {
                    txtEmbalagem.Focus();
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
                string mensagem = "Tem certeza que deseja excluir esta embalagem?\n";
                string excluirEmbalagem = "\nDeletar: " + txtEmbalagem.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + excluirEmbalagem, "Deletar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = embalagemRepositorio.ExcluirDadosDaTabela(embalagemSelecionada.PK_Embalagem);

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Embalagem excluída com sucesso!");
                        Reiniciar();
                        AtualizarTotalRegistrado();
                    }
                }
                else
                {
                    txtEmbalagem.Focus();
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

                txtEmbalagem.Focus();
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

            txtEmbalagem.Focus();
        }
        #endregion Metodos

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtEmbalagem.Text == "")
            {
                Alerta.Aviso("É necessário inserir uma embalagem!");
                txtEmbalagem.Focus();
                return;
            }

            switch (modoCRUD)
            {
                case ModoCRUD.Insert:
                    var embalagem = new Embalagem();
                    var coluna = nameof(embalagem.Nome).ToString();
                    var resultado = embalagemRepositorio.ValidarValorExistente(coluna, txtEmbalagem.Text.ToString());

                    if (resultado)
                    {
                        Alerta.Aviso("Esta embalagem já existe!");
                        txtEmbalagem.Focus();
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
            txtEmbalagem.Text = "";
            txtEmbalagem.Focus();
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
