using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
using Estoque.Enums;
using Estoque.GerenciamentoTelas;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Repositorios;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace Estoque.Telas_Produto
{
    public partial class UCCadastrarMarca : Telas_Base.UCBase
    {
        #region Interfaces 
        private readonly IMarcaRepositorio marcaRepositorio;
        #endregion Interfaces

        #region Propriedades
        private Marca marcaSelecionada;
        private ModoCRUD modoCRUD = ModoCRUD.Select;
        private IEnumerable<Marca> marcaCollection;
        #endregion Propriedades

        public UCCadastrarMarca()
        {
            InitializeComponent();
            AtualizarPropriedades();

            marcaRepositorio = DIRepositorios.Container.GetInstance<IMarcaRepositorio>();
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
            marcaCollection = marcaRepositorio.ConsultarDadosNaTabela(new Marca
            {
                Nome = txtNome.TextoFormatoLikeSQL().AtribuirPorcentagemAoTextoSQL(),
                Descricao = txtDescricao.TextoFormatoLikeSQL().AtribuirPorcentagemAoTextoSQL()
            });

            BindDataGridView();
        }

        private void BindDataGridView()
        {
            var resultado = marcaCollection.Select(s => new
            {
                PK_Marca = s.PK_Marca,
                Nome = s.Nome,
                Descricao = s.Descricao
            })
            .ToList();

            dtgMarca.DataSource = resultado;
        }
        /* Updates */
        private void SelecionarItem()
        {
            if (dtgMarca.Rows.Count <= 0)
            {
                Alerta.Aviso("Para realizar essa operação, é necessário selecionar uma marca");
                return;
            }

            DataGridViewRow linha = dtgMarca.SelectedRows[0];

            marcaSelecionada = new Marca()
            {
                PK_Marca = Convert.ToInt32(linha.Cells["colPK_Marca"].Value),
                Nome = linha.Cells["colNome"].Value.ToString(),
                Descricao = linha.Cells["colDescricao"].Value.ToString()
            };

            if (marcaSelecionada != null)
            {
                txtNome.Text = marcaSelecionada.Nome;
                txtDescricao.Text = marcaSelecionada.Descricao;
            }
        }
        private void Reiniciar()
        {
            txtNome.Text = "";
            txtNome.Enabled = true;
            txtDescricao.Text = "";

            modoCRUD = ModoCRUD.Select;
            LayoutBotoes();
            PesquisarItem();

            txtNome.Focus();
        }
        private void AtualizarTotalRegistrado()
        {
            int total = marcaRepositorio.ObterContagemTotal();
            lblTotalRegistrado.Text = "Registrados: " + total;
        }
        private void AtualizarTotalPesquisado()
        {
            lblTotalPesquisado.Text = "Pesquisado: " + dtgMarca.Rows.Count;
        }
        private void CadastrarNovoItem()
        {
            try
            {
                string mensagem = "Tem certeza que deseja criar esta marca?\n" +
                                  "Marca: " + txtNome.Text.Trim() + "\n";

                mensagem += (txtDescricao.Text != "") ? "Descrição: " + txtDescricao.Text.Trim() : "";

                var resultado = Mensagem.Pergunta(mensagem, "Cadastro");

                if (resultado != RespostaCaixaDialogo.Sim)
                {
                    txtNome.Focus();
                    return;
                }

                var resultadoInsert = marcaRepositorio.InserirDadosNaTabela(new Marca() { Nome = txtNome.TextoFormatoLikeSQL(), Descricao = txtDescricao.TextoFormatoLikeSQL() });

                if (resultadoInsert)
                {
                    Alerta.Confirmacao("Marca registrada com sucesso!");
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
                string mensagem = "Tem certeza que deseja alterar esta marca?\n\n";

                var resultado = Mensagem.Pergunta(mensagem, "Alterar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = marcaRepositorio
                        .AtualizarTodosOsDados(new Marca()
                        {
                            PK_Marca = marcaSelecionada.PK_Marca,
                            Nome = txtNome.TextoFormatoLikeSQL(),
                            Descricao = txtDescricao.TextoFormatoLikeSQL()
                        });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Marca atualizada com sucesso!");
                        Reiniciar();
                        AtualizarTotalRegistrado();
                    }
                }
                else
                {
                    txtNome.Focus();
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
                string mensagem = "Tem certeza que deseja excluir esta marca?\n";
                string excluir = "\nDeletar: " + txtNome.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + excluir, "Deletar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = marcaRepositorio.ExcluirDadosDaTabela(marcaSelecionada.PK_Marca);

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Marca excluída com sucesso!");
                        Reiniciar();
                        AtualizarTotalRegistrado();
                    }
                }
                else
                {
                    txtNome.Focus();
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

                txtNome.Focus();
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

            txtNome.Focus();
        }
        #endregion Metodos

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                Alerta.Aviso("É necessário inserir uma marca!");
                txtNome.Focus();
                return;
            }

            switch (modoCRUD)
            {
                case ModoCRUD.Insert:
                    var marca = new Marca();
                    var coluna = nameof(marca.Nome).ToString();
                    var resultado = marcaRepositorio.ValidarValorExistente(coluna, txtNome.Text.ToString());

                    if (resultado)
                    {
                        Alerta.Aviso("Esta marca já existe!");
                        txtNome.Focus();
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
            txtNome.Text = "";
            txtNome.Focus();
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
