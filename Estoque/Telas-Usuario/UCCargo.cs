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
    public partial class UCCargo : Telas_Base.UCBase
    {
        #region Interfaces 
        private readonly ICargoRepositorio cargoRepositorio;
        private readonly ISetorRepositorio setorRepositorio;
        private readonly IBotoes botoes;
        #endregion Interfaces

        #region Objetos
        private Cargo cargoSelecionado;
        #endregion Objetos

        #region Propriedades
        private ModoCRUD modoCRUD = ModoCRUD.select;
        #endregion Propriedades

        public UCCargo()
        {
            InitializeComponent();
            AtualizarPropriedades();
            cargoRepositorio = DIRepositorios.Container.GetInstance<ICargoRepositorio>();
            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
            botoes = DITelas.Container.GetInstance<IBotoes>();
        }

        #region Metodos
        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxSetor();
                dtgCargo.DataSource = cargoRepositorio.ObterTabela().ToList();
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
        private void BindComboBoxSetor()
        {
            var result = setorRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Setor
                {
                    PK_Setor = 0,
                    NomeSetor = "Nenhum"
                });

            if (result != null)
            {
                cboSetor.DataSource = result;
                cboSetor.DisplayMember = "NomeSetor";
                cboSetor.ValueMember = "PK_Setor";
                cboSetor.SelectedIndex = 0;
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
        private void SelecionarCargo()
        {
            if (dtgCargo.Rows.Count <= 0)
            {
                MessageBox.Show("Para realizar essa operação, é necessário selecionar um cargo");
                return;
            }

            cargoSelecionado = new Cargo()
            {
                PK_Cargo = Convert.ToInt32(dtgCargo.SelectedRows[0].Cells["colPK_Cargo"].Value),
                NomeCargo = dtgCargo.SelectedRows[0].Cells["colNomeCargo"].Value.ToString(),
                FK_Setor = Convert.ToInt32(dtgCargo.SelectedRows[0].Cells["colFK_Setor"].Value)
            };

            if (cargoSelecionado != null)
            {
                txtCargo.Text = cargoSelecionado.NomeCargo;
            }
        }

        private void Reiniciar()
        {
            txtCargo.Text = "";
            txtCargo.Enabled = true;

            modoCRUD = ModoCRUD.select;
            botoes.Layout(ModoBotoes.Inicial);
            btnPesquisar.PerformClick();
        }
        private void AtualizarTotalRegistrado()
        {
            int total = cargoRepositorio.ObterTotalCargosRegistrados();
            lblTotalRegistrado.Text = "Registrados: " + total;
        }
        private void AtualizarTotalPesquisado()
        {
            lblTotalPesquisado.Text = "Pesquisado: " + dtgCargo.Rows.Count;
        }
        private void CadastrarNovoCargo()
        {
            if (txtCargo.Text == "")
            {
                txtCargo.Focus();
                return;
            }

            try
            {
                string mensagem = "Tem certeza que deseja incluir esse cargo?\n";
                string novoCargo = "Cargo: " + txtCargo.Text.Trim();

                var resultado = MessageBox.Show(mensagem + novoCargo,
                                            "Cadastro",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var resultadoInsert = cargoRepositorio.InserirDadosNaTabela(new Cargo() { NomeCargo = txtCargo.TextoFormatoLikeSQL().Replace("%", "").Trim(), FK_Setor = ((Setor)cboSetor.SelectedItem).PK_Setor });

                    if (resultadoInsert)
                    {
                        MessageBox.Show("Cargo registrado com sucesso!");
                        Reiniciar();
                        AtualizarTotalRegistrado();
                    }
                }
                else
                {
                    txtCargo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar essa operação\n.Erro: " + ex.Message);
            }
        }
        private void AlterarCargoSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que deseja alterar esse cargo?\n";
                string antigoCargo = "\nAntigo: " + cargoSelecionado.NomeCargo;
                string novoCargo = "\nNovo: " + txtCargo.Text.Trim();

                var resultado = MessageBox.Show(mensagem + antigoCargo + novoCargo,
                                            "Alterar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var resultadoInsert = cargoRepositorio
                        .AtualizarCargo(new Cargo()
                        {
                            PK_Cargo = cargoSelecionado.PK_Cargo,
                            NomeCargo = txtCargo.TextoFormatoLikeSQL().Replace("%", "").Trim(),
                            FK_Setor = ((Setor)cboSetor.SelectedItem).PK_Setor
                        });

                    if (resultadoInsert)
                    {
                        MessageBox.Show("Cargo atualizado com sucesso!");
                        Reiniciar();
                        AtualizarTotalRegistrado();
                    }
                }
                else
                {
                    txtCargo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar essa operação\n.Erro: " + ex.Message);
            }
        }
        private void ExcluirCargoSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que excluir esse cargo?\n";
                string excluirCargo = "\nDeletar: " + txtCargo.Text.Trim();

                var resultado = MessageBox.Show(mensagem + excluirCargo,
                                            "Deletar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var resultadoInsert = cargoRepositorio.ExcluirCargo(new Cargo()
                    { PK_Cargo = cargoSelecionado.PK_Cargo });

                    if (resultadoInsert)
                    {
                        MessageBox.Show("Cargo excluído com sucesso!");
                        Reiniciar();
                        AtualizarTotalRegistrado();
                    }
                }
                else
                {
                    txtCargo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar essa operação\n.Erro: " + ex.Message);
            }
        }
        private void PesquisarCargos()
        {
            try
            {
                string cargo = txtCargo.TextoFormatoLikeSQL();
                int fK_Setor = ((Setor)cboSetor.SelectedItem).PK_Setor;

                var tabela = cargoRepositorio.ObterTabela(new Cargo() { NomeCargo = cargo, FK_Setor = fK_Setor });

                if (tabela != null)
                {
                    dtgCargo.DataSource = tabela.ToList();
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
        private void UCCargo_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
            AtualizarTotalRegistrado();
            AtualizarTotalPesquisado();
            InicializarBotoes();
            botoes.Layout(ModoBotoes.Inicial);
        }
        private void UCCargo_VisibleChanged(object sender, EventArgs e)
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
                PesquisarCargos();
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

            SelecionarCargo();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //botoes.Layout(ModoBotoes.Exclusao);
            //modoCRUD = ModoCRUD.delete;

            SelecionarCargo();
            ExcluirCargoSelecionado();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text == "")
            {
                MessageBox.Show("Digite um valor válido!");
                return;
            }

            switch (modoCRUD)
            {
                case ModoCRUD.insert:
                    CadastrarNovoCargo();
                    break;
                case ModoCRUD.update:
                    AlterarCargoSelecionado();
                    break;
                case ModoCRUD.delete:
                    ExcluirCargoSelecionado();
                    break;
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCargo.Text = "";
            txtCargo.Focus();
        }
        #endregion Eventos


    }
}
