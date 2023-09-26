using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
using Estoque.Enums;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Interfaces;
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
    public partial class UCCadastrarSetor : Telas_Base.UCBase
    {
        #region Interfaces 
        private readonly ISetorRepositorio setorRepositorio;
        private readonly IRepositorio<Setor> repositorioGenerico;
        #endregion Interfaces

        #region Propriedades
        private Setor setorSelecionado;
        private ModoCRUD modoCRUD = ModoCRUD.Select;
        #endregion Propriedades
        public UCCadastrarSetor()
        {
            InitializeComponent();
            AtualizarPropriedades();

            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
            repositorioGenerico = DIRepositorios.Container.GetInstance<IRepositorio<Setor>>();
        }


        #region Metodos
        /* Start */
        private void InicializarGrid()
        {
            try
            {
                dtgSetor.DataSource = setorRepositorio.ObterTabela().ToList();
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }
        private void SelecionarSetor()
        {
            if (dtgSetor.Rows.Count <= 0)
            {
                Alerta.Aviso("Selecione um setor válido");
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

        /* Updates */
        private void Reiniciar()
        {
            txtSetor.Text = "";
            txtSetor.Enabled = true;

            modoCRUD = ModoCRUD.Select;
            LayoutBotoes();
            PesquisarSetores();
        }
        private void AtualizarTotalRegistrado()
        {
            int total = repositorioGenerico.ObterContagemTotal("Setor");
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

                var resultado = Mensagem.Pergunta(mensagem + novoSetor, "Cadastro");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = setorRepositorio.InserirDadosNaTabela(new Setor() { NomeSetor = txtSetor.TextoFormatoLikeSQL().Replace("%", "").Trim() });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Setor registrado com sucesso!");
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
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }
        private void AlterarSetorSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que deseja alterar esse setor?\n";
                string antigoSetor = "\nAntigo: " + setorSelecionado.NomeSetor;
                string novoSetor = "\nNovo: " + txtSetor.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + antigoSetor + novoSetor, "Alterar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = setorRepositorio.AtualizarSetor(new Setor() { PK_Setor = setorSelecionado.PK_Setor, NomeSetor = txtSetor.TextoFormatoLikeSQL().Replace("%", "").Trim() });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Setor atualizado com sucesso!");
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
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }
        private void ExcluirSetorSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que excluir esse setor e os cargos relacionados?\n";
                string excluirSetor = "\nDeletar: " + txtSetor.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + excluirSetor, "Deletar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = setorRepositorio.ExcluirSetor(new Setor() { PK_Setor = setorSelecionado.PK_Setor });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Setor excluído com sucesso!");
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
                Mensagem.Erro("Erro: " + ex.Message);
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
            if (txtSetor.Text == "")
            {
                Alerta.Aviso("Digite um valor válido!");
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            modoCRUD = ModoCRUD.Select;
            PesquisarSetores();
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
            SelecionarSetor();
        }
        private void UCCadastrarSetor_Load(object sender, EventArgs e)
        {
            InicializarGrid();
            AtualizarTotalRegistrado();
            AtualizarTotalPesquisado();
            LayoutBotoes();
        }
        #endregion Eventos

    }
}
