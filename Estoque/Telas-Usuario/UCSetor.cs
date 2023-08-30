using EP.Data.Entidades;
using EP.Data.Interfaces;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Repositorios;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Usuario
{
    public partial class UCSetor : Telas_Base.UCBase
    {
        private readonly ISetorRepositorio setorRepositorio;

        public UCSetor()
        {
            InitializeComponent();
            AtualizarPropriedades();
            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
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

        #endregion Eventos

    }
}
