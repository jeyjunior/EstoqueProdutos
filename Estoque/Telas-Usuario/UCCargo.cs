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
    public partial class UCCargo : Telas_Base.UCBase
    {
        #region Interfaces 
        private readonly ICargoRepositorio cargoRepositorio;
        private readonly ISetorRepositorio setorRepositorio;
        private readonly IBotoesEdicaoSimples botoesEdicaoSimples;
        #endregion Interfaces

        #region Objetos
        private Cargo cargoSelecionado;
        #endregion Objetos

        #region Propriedades
        private ModoCRUD modoCRUD = ModoCRUD.Select;
        #endregion Propriedades

        public UCCargo()
        {
            InitializeComponent();
            AtualizarPropriedades();
            cargoRepositorio = DIRepositorios.Container.GetInstance<ICargoRepositorio>();
            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
            botoesEdicaoSimples = new Telas_Base.UC_Componentes.BotoesEdicaoSimples();
        }

        #region Metodos
        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxSetor();
                BindDataGridView(null);
                InicializarEventoDoSBotoes();
                pBotoes.Controls.Add((Control)botoesEdicaoSimples);
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
        private void BindDataGridView(Cargo cargo)
        {
            var resultado = cargoRepositorio.ObterTabela(cargo).Select(s => new
            {
                PK_Cargo = s.PK_Cargo,
                NomeCargo = s.NomeCargo,
                FK_Setor = s.Setor.PK_Setor,
                NomeSetor = s.Setor.NomeSetor
            })
            .ToList();

            dtgCargo.DataSource = resultado;
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
        private void SelecionarCargo()
        {
            if (dtgCargo.Rows.Count <= 0)
            {
                MessageBox.Show("Para realizar essa operação, é necessário selecionar um cargo");
                return;
            }

            DataGridViewRow linha = dtgCargo.SelectedRows[0];

            cargoSelecionado = new Cargo()
            {
                PK_Cargo = Convert.ToInt32(linha.Cells["colPK_Cargo"].Value),
                NomeCargo = linha.Cells["colNomeCargo"].Value.ToString(),
                FK_Setor = Convert.ToInt32(linha.Cells["colFK_Setor"].Value)
            };

            if (cargoSelecionado != null)
            {
                txtCargo.Text = cargoSelecionado.NomeCargo;
                cboSetor.SelectedValue = cargoSelecionado.FK_Setor;
            }
        }
        private void Reiniciar()
        {
            txtCargo.Text = "";
            txtCargo.Enabled = true;
            cboSetor.SelectedValue = 0;

            modoCRUD = ModoCRUD.Select;
            botoesEdicaoSimples.Layout(ModoBotoes.Inicial);
            PesquisarCargos();
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
                MessageBox.Show("Preencha o campo cargo corretamente.");
                return;
            }

            if ((int)cboSetor.SelectedValue == 0)
            {
                cboSetor.Focus();
                MessageBox.Show("Selecione um setor.");
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
                            FK_Setor = (int)cboSetor.SelectedValue
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
            catch
            {
                string mensagem = "Falha ao executar essa operação\n" +
                    "Se existir Usuários cadastrado no cargo\n" +
                    "o mesmo não poderá ser excluído.";

                MessageBox.Show(mensagem);
            }
        }
        private void PesquisarCargos()
        {
            try
            {
                string cargo = txtCargo.TextoFormatoLikeSQL();
                int setor = (int)cboSetor.SelectedIndex;
                BindDataGridView(new Cargo
                {
                    NomeCargo = cargo,
                    FK_Setor = setor
                });

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
            botoesEdicaoSimples.Layout(ModoBotoes.Inicial);
        }
        private void UCCargo_VisibleChanged(object sender, EventArgs e)
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

            SelecionarCargo();
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
            //botoes.Layout(ModoBotoes.Exclusao);
            //modoCRUD = ModoCRUD.delete;

            SelecionarCargo();
            ExcluirCargoSelecionado();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCargo.Text = "";
            txtCargo.Focus();
            cboSetor.SelectedValue = 0;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (modoCRUD == ModoCRUD.Select)
            {
                PesquisarCargos();
            }
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
                case ModoCRUD.Insert:
                    CadastrarNovoCargo();
                    break;
                case ModoCRUD.Update:
                    AlterarCargoSelecionado();
                    break;
                case ModoCRUD.Delete:
                    ExcluirCargoSelecionado();
                    break;
            }
        }
        #endregion Eventos
    }
}
