using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Componentes_Base;
using Estoque.Enums;
using Estoque.Interfaces;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Repositorios;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Usuario
{
    public partial class UCSetor : Telas_Base.UCBase
    {
        private readonly ISetorRepositorio setorRepositorio;
        private readonly IBotoes botoes;

        private Setor setorSelecionado;
        public UCSetor()
        {
            InitializeComponent();
            AtualizarPropriedades();
            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
            botoes = DITelas.Container.GetInstance<IBotoes>();
        }

        #region Metodos
        private void InicializarGrid()
        {
            try
            {
                dtgSetor.DataSource = setorRepositorio.ObterTabela().ToList();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha sql\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar essa operação\n\n" + ex.Message);
            }
        }

        private void InicializarBotoes()
        {
            botoes.Mapear(new Botoes()
            {
                BtnCadastrar = btnCadastrar,
                BtnAlterar = btnAlterar,
                BtnExcluir = btnExcluir,
                BtnCancelar = btnCancelar,
                BtnLimpar = btnLimpar,
                BtnPesquisar = btnPesquisar,
                BtnSalvar = btnSalvar
            },
            tblBotoes);
        }

        private void Limpar()
        {
            txtSetor.Text = "";
            btnPesquisar.PerformClick();
        }

        private void AtualizarTotalRegistrado()
        {
            int total = setorRepositorio.ObterTotalSetoresRegistrados();
            lblTotalRegistrado.Text = "Registrados: " + total;
        }

        private void AtualizarTotalPesquisado()
        {
            lblTotalPesquisado.Text = "Pesquisado: " + dtgSetor.Rows.Count;
        }

        #endregion Metodos

        #region Eventos

        private void UCSetor_Load(object sender, EventArgs e)
        {
            InicializarGrid();
            AtualizarTotalRegistrado();
            AtualizarTotalPesquisado();
            InicializarBotoes();
            botoes.Layout(ModoBotoes.Inicial);
        }

        private void UCSetor_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Limpar();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string setor = txtSetor.TextoFormatoLikeSQL();
                var tabela = setorRepositorio.ObterTabela(new Setor() { NomeSetor = setor });

                if (tabela != null)
                {
                    dtgSetor.DataSource = tabela.ToList();
                }

                AtualizarTotalPesquisado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na pesquisa.\nErro:" + ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            botoes.Layout(ModoBotoes.Edicao);
            return;

            if (txtSetor.Text == "")
            {
                txtSetor.Focus();
                return;
            }

            try
            {
                string mensagem = "Tem certeza que deseja incluir esse setor?\n";
                string novoSetor = "Setor: " + txtSetor.Text.Trim();

                var resultado = MessageBox.Show(mensagem + novoSetor,
                                            "Cadastro",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var resultadoInsert = setorRepositorio.InserirDadosNaTabela(new Setor() { NomeSetor = txtSetor.TextoFormatoLikeSQL().Replace("%", "").Trim() });

                    if (resultadoInsert)
                    {
                        MessageBox.Show("Setor registrado com sucesso!");
                        Limpar();
                        AtualizarTotalRegistrado();
                    }
                }
                else
                {
                    txtSetor.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar essa operação\n.Erro: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            botoes.Layout(ModoBotoes.Edicao);
            return;

            if (dtgSetor.Rows.Count <= 0)
            {
                MessageBox.Show("Para realizar essa operação, é necessário selecionar um setor");
                return;
            }

            setorSelecionado = new Setor()
            {
                PK_Setor = Convert.ToInt32(dtgSetor.SelectedRows[0].Cells["colPK_Setor"].Value),
                NomeSetor = dtgSetor.SelectedRows[0].Cells["colNomeSetor"].Value.ToString()
            };

            if (setorSelecionado != null)
            {
                txtSetor.Text = setorSelecionado.NomeSetor;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            botoes.Layout(ModoBotoes.Inicial);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            botoes.Layout(ModoBotoes.Exclusao);
        }
        #endregion Eventos

    }
}
