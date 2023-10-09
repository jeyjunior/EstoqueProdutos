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
    public partial class UCCadastrarCategoria : Telas_Base.UCBase
    {
        #region Interfaces 
        private readonly ICategoriaRepositorio categoriaRepositorio;
        #endregion Interfaces

        #region Propriedades
        private Cargo cargoSelecionado;
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

            if (resultado.Count == 0)
            {
                var empty = categoriaCollection.Select(c => new
                {
                    PK_Categoria = 0,
                    Nome = "",
                    Descricao = ""
                });

                dtgCategoria.DataSource = empty;
            }
            else
            {
                dtgCategoria.DataSource = resultado;
            }
        }
        /* Updates */
        private void SelecionarCargo()
        {
            if (dtgCategoria.Rows.Count <= 0)
            {
                Alerta.Aviso("Para realizar essa operação, é necessário selecionar um cargo");
                return;
            }

            DataGridViewRow linha = dtgCategoria.SelectedRows[0];

            cargoSelecionado = new Cargo()
            {
                PK_Cargo = Convert.ToInt32(linha.Cells["colPK_Cargo"].Value),
                NomeCargo = linha.Cells["colNomeCargo"].Value.ToString(),
                FK_Setor = Convert.ToInt32(linha.Cells["colFK_Setor"].Value)
            };

            if (cargoSelecionado != null)
            {
                txtCategoria.Text = cargoSelecionado.NomeCargo;
                //cboSetor.SelectedValue = cargoSelecionado.FK_Setor;
            }
        }
        private void Reiniciar()
        {
            txtCategoria.Text = "";
            txtCategoria.Enabled = true;
            txtDescricao.Text = "";

            modoCRUD = ModoCRUD.Select;
            LayoutBotoes();
            PesquisarCargos();

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
        private void CadastrarNovaCategoria()
        {
            try
            {
                string mensagem = "Tem certeza que deseja criar esta categoria?\n";
                string novoCargo = "Categoria: " + txtCategoria.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + novoCargo, "Cadastro");

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
        private void AlterarCargoSelecionado()
        {
            try
            {
                //string mensagem = "Tem certeza que deseja alterar esse cargo?\n";
                //string antigoCargo = "\nAntigo: " + cargoSelecionado.NomeCargo;
                //string novoCargo = "\nNovo: " + txtCategoria.Text.Trim();

                //var resultado = Mensagem.Pergunta(mensagem + antigoCargo + novoCargo, "Alterar");

                //if (resultado == RespostaCaixaDialogo.Sim)
                //{
                //    var resultadoInsert = cargoRepositorio
                //        .AtualizarCargo(new Cargo()
                //        {
                //            PK_Cargo = cargoSelecionado.PK_Cargo,
                //            NomeCargo = txtCategoria.TextoFormatoLikeSQL().Replace("%", "").Trim(),
                //            FK_Setor = (int)cboSetor.SelectedValue
                //        });

                //    if (resultadoInsert)
                //    {
                //        Alerta.Confirmacao("Cargo atualizado com sucesso!");
                //        Reiniciar();
                //        AtualizarTotalRegistrado();
                //    }
                //}
                //else
                //{
                //    txtCategoria.Focus();
                //}
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao executar essa operação");
            }
        }
        private void ExcluirCargoSelecionado()
        {
            try
            {
                //string mensagem = "Tem certeza que excluir esse cargo?\n";
                //string excluirCargo = "\nDeletar: " + txtCategoria.Text.Trim();

                //var resultado = Mensagem.Pergunta(mensagem + excluirCargo, "Deletar");

                //if (resultado == RespostaCaixaDialogo.Sim)
                //{
                //    var resultadoInsert = cargoRepositorio.ExcluirCargo(new Cargo()
                //    { PK_Cargo = cargoSelecionado.PK_Cargo });

                //    if (resultadoInsert)
                //    {
                //        Alerta.Confirmacao("Cargo excluído com sucesso!");
                //        Reiniciar();
                //        AtualizarTotalRegistrado();
                //    }
                //}
                //else
                //{
                //    txtCategoria.Focus();
                //}
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }
        private void PesquisarCargos()
        {
            try
            {
                CarregarPesquisa();
                AtualizarTotalPesquisado();
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

            btnLimpar.Enabled = true;

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
            else
            {
                var categoria = new Categoria();
                var coluna = nameof(categoria.Nome).ToString();
                var resultado = categoriaRepositorio.ValidarValorExistente(coluna, txtCategoria.Text.ToString());

                if (resultado)
                {
                    Alerta.Aviso("Esta categoria já existe!");
                    txtCategoria.Focus();
                    return;
                }
            }

            //if (txtDescricao.Text == "")
            //{
            //    var resultado = Mensagem.Pergunta("Deseja salvar categoria sem descrição?");

            //    if (resultado != RespostaCaixaDialogo.Sim)
            //    {
            //        txtDescricao.Focus();
            //        return;
            //    }
            //}

            switch (modoCRUD)
            {
                case ModoCRUD.Insert:
                    CadastrarNovaCategoria();
                    break;
                case ModoCRUD.Update:
                    AlterarCargoSelecionado();
                    break;
                case ModoCRUD.Delete:
                    ExcluirCargoSelecionado();
                    break;
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SelecionarCargo();
            ExcluirCargoSelecionado();
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
            PesquisarCargos();
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
            SelecionarCargo();
        }
        private void UCCadastrarSetor_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
            AtualizarTotalRegistrado();
            AtualizarTotalPesquisado();
            LayoutBotoes();
        }
        #endregion Eventos
    }
}
