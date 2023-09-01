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
        private readonly IBotoes botoes;
        #endregion Interfaces

        #region Objetos
        private Setor setorSelecionado;
        #endregion Objetos

        #region Propriedades
        private ModoCRUD modoCRUD = ModoCRUD.select;
        #endregion Propriedades

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

            modoCRUD = ModoCRUD.select;
            botoes.Layout(ModoBotoes.Inicial);
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
            InicializarBotoes();
            botoes.Layout(ModoBotoes.Inicial);
        }
        private void UCSetor_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Reiniciar();
            }
        }

        /* Botoes */
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (modoCRUD == ModoCRUD.select)
            {
                PesquisarSetores();
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            botoes.Layout(ModoBotoes.Edicao);
            modoCRUD = ModoCRUD.insert;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            botoes.Layout(ModoBotoes.Edicao);
            modoCRUD = ModoCRUD.update;

            SelecionarSetor();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //botoes.Layout(ModoBotoes.Exclusao);
            //modoCRUD = ModoCRUD.delete;

            SelecionarSetor();
            ExcluirSetorSelecionado();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reiniciar();
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
                case ModoCRUD.insert:
                    CadastrarNovoSetor();
                    break;
                case ModoCRUD.update:
                    AlterarSetorSelecionado();
                    break;
                case ModoCRUD.delete:
                    ExcluirSetorSelecionado();
                    break;
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSetor.Text = "";
            txtSetor.Focus();
        }
        #endregion Eventos
    }
}
