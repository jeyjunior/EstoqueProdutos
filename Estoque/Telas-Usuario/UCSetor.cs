using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Enums;
using Estoque.Interfaces;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Repositorios;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        #region Interfaces 
        private readonly ISetorRepositorio setorRepositorio;
        private readonly IBotoesEdicaoSimples botoesEdicaoSimples;
        #endregion Interfaces

        #region Objetos
        private Setor setorSelecionado;
        #endregion Objetos

        #region Propriedades
        private ModoCRUD modoCRUD = ModoCRUD.Select;
        #endregion Propriedades

        public UCSetor()
        {
            InitializeComponent();
            AtualizarPropriedades();
            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
            botoesEdicaoSimples = new Telas_Base.UC_Componentes.BotoesEdicaoSimples();
        }

        #region Metodos
        private void InicializarEventoDoSBotoes()
        {
            botoesEdicaoSimples.AtribuirEventoClick(btnAlterar_Click, NomeBotoes.Alterar);
            botoesEdicaoSimples.AtribuirEventoClick(btnCadastrar_Click, NomeBotoes.Cadastrar);
            botoesEdicaoSimples.AtribuirEventoClick(btnCancelar_Click, NomeBotoes.Cancelar);
            botoesEdicaoSimples.AtribuirEventoClick(btnExcluir_Click, NomeBotoes.Excluir);
            botoesEdicaoSimples.AtribuirEventoClick(btnLimpar_Click, NomeBotoes.Limpar);
            botoesEdicaoSimples.AtribuirEventoClick(btnPesquisar_Click, NomeBotoes.Pesquisar);
            botoesEdicaoSimples.AtribuirEventoClick(btnSalvar_Click, NomeBotoes.Salvar);
        }
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
        private void SelecionarSetor()
        {
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
        private void Reiniciar()
        {
            txtSetor.Text = "";
            txtSetor.Enabled = true;

            modoCRUD = ModoCRUD.Select;
            botoesEdicaoSimples.Layout(ModoBotoes.Inicial);

            PesquisarSetores();
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
        private void CadastrarNovoSetor()
        {
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
                        Reiniciar();
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
        private void AlterarSetorSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que deseja alterar esse setor?\n";
                string antigoSetor = "\nAntigo: " + setorSelecionado.NomeSetor;
                string novoSetor = "\nNovo: " + txtSetor.Text.Trim();

                var resultado = MessageBox.Show(mensagem + antigoSetor + novoSetor,
                                            "Alterar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var resultadoInsert = setorRepositorio.AtualizarSetor(new Setor() { PK_Setor = setorSelecionado.PK_Setor, NomeSetor = txtSetor.TextoFormatoLikeSQL().Replace("%", "").Trim() });

                    if (resultadoInsert)
                    {
                        MessageBox.Show("Setor atualizado com sucesso!");
                        Reiniciar();
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
        private void ExcluirSetorSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que excluir esse setor e os cargos relacionados?\n";
                string excluirSetor = "\nDeletar: " + txtSetor.Text.Trim();

                var resultado = MessageBox.Show(mensagem + excluirSetor,
                                            "Deletar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var resultadoInsert = setorRepositorio.ExcluirSetor(new Setor() { PK_Setor = setorSelecionado.PK_Setor });

                    if (resultadoInsert)
                    {
                        MessageBox.Show("Setor excluído com sucesso!");
                        Reiniciar();
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
        private void PesquisarSetores()
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
        #endregion Metodos

        #region Eventos
        private void UCSetor_Load(object sender, EventArgs e)
        {
            InicializarGrid();
            AtualizarTotalRegistrado();
            AtualizarTotalPesquisado();
            botoesEdicaoSimples.Layout(ModoBotoes.Inicial);

            pBotoes.Controls.Add((Control)botoesEdicaoSimples);
            InicializarEventoDoSBotoes();
        }
        private void UCSetor_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Reiniciar();
            }
        }

        /* Botoes */
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            botoesEdicaoSimples.Layout(ModoBotoes.Edicao);
            modoCRUD = ModoCRUD.Update;

            SelecionarSetor();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            botoesEdicaoSimples.Layout(ModoBotoes.Edicao);
            modoCRUD = ModoCRUD.Insert;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SelecionarSetor();
            ExcluirSetorSelecionado();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSetor.Text = "";
            txtSetor.Focus();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (modoCRUD == ModoCRUD.Select)
            {
                PesquisarSetores();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSetor.Text == "")
            {
                MessageBox.Show("Digite um valor válido!");
                return;
            }

            switch (modoCRUD)
            {
                case ModoCRUD.Insert:
                    CadastrarNovoSetor();
                    break;
                case ModoCRUD.Update:
                    AlterarSetorSelecionado();
                    break;
                case ModoCRUD.Delete:
                    ExcluirSetorSelecionado();
                    break;
            }
        }
        #endregion Eventos
    }
}
