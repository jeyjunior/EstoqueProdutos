using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
using Estoque.Enums;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
using Estoque.Telas_Base.UC_Componentes;
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
    public partial class UCCadastrarCargo : Telas_Base.UCBase
    {
        #region Interfaces 
        private readonly ICargoRepositorio cargoRepositorio;
        private readonly ISetorRepositorio setorRepositorio;
        #endregion Interfaces

        #region Propriedades
        private Cargo cargoSelecionado;
        private ModoCRUD modoCRUD = ModoCRUD.Select;
        #endregion Propriedades
        public UCCadastrarCargo()
        {
            InitializeComponent();
            AtualizarPropriedades();

            cargoRepositorio = DIRepositorios.Container.GetInstance<ICargoRepositorio>();
            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
        }

        #region Metodos
        /* Start */
        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxSetor();
                BindDataGridView(null);
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

        /* Updates */
        private void SelecionarCargo()
        {
            if (dtgCargo.Rows.Count <= 0)
            {
                Alerta.Aviso("Para realizar essa operação, é necessário selecionar um cargo");
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
            LayoutBotoes();
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
                Alerta.Aviso("Preencha o campo cargo corretamente.");
                return;
            }

            if ((int)cboSetor.SelectedValue == 0)
            {
                cboSetor.Focus();
                Alerta.Aviso("Selecione um setor.");
                return;
            }

            try
            {
                string mensagem = "Tem certeza que deseja incluir este cargo?\n";
                string novoCargo = "Cargo: " + txtCargo.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + novoCargo, "Cadastro");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = cargoRepositorio.InserirDadosNaTabela(new Cargo() { NomeCargo = txtCargo.TextoFormatoLikeSQL(), FK_Setor = ((Setor)cboSetor.SelectedItem).PK_Setor });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Cargo registrado com sucesso!");
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
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao executar essa operação");
            }
        }
        private void AlterarCargoSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que deseja alterar esse cargo?\n";
                string antigoCargo = "\nAntigo: " + cargoSelecionado.NomeCargo;
                string novoCargo = "\nNovo: " + txtCargo.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + antigoCargo + novoCargo, "Alterar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = cargoRepositorio
                        .AtualizarTodosOsDados(new Cargo()
                        {
                            PK_Cargo = cargoSelecionado.PK_Cargo,
                            NomeCargo = txtCargo.TextoFormatoLikeSQL().Replace("%", "").Trim(),
                            FK_Setor = (int)cboSetor.SelectedValue
                        });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Cargo atualizado com sucesso!");
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
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao executar essa operação");
            }
        }
        private void ExcluirCargoSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que excluir esse cargo?\n";
                string excluirCargo = "\nDeletar: " + txtCargo.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + excluirCargo, "Deletar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = cargoRepositorio.ExcluirCargo(new Cargo()
                    { PK_Cargo = cargoSelecionado.PK_Cargo });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Cargo excluído com sucesso!");
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
                Mensagem.Erro("Erro: " + ex.Message);
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
        }
        #endregion Metodos

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text == "" && (int)cboSetor.SelectedValue <= 0)
            {
                Alerta.Aviso("Digite um valor válido!");
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
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SelecionarCargo();
            ExcluirCargoSelecionado();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCargo.Text = "";
            txtCargo.Focus();

            cboSetor.SelectedValue = 0;
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
