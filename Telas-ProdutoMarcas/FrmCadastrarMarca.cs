using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueProdutos.Telas_ProdutoMarcas
{
    public partial class FrmCadastrarMarca : Telas_Base.FrmBase
    {
        #region Classes
        IRepositorio<Marca> marcaRepositorio = new MarcaRepositorio();
        #endregion Classes

        #region Propriedades

        #endregion Propriedades

        public FrmCadastrarMarca()
        {
            InitializeComponent();
        }

        #region Metodos
        private void LimparCampos()
        {
            txtNomeMarca.Clear();
            txtDescricao.Clear();

            txtNomeMarca.Focus();
            HabilitarComponentes();
        }

        private void HabilitarComponentes()
        {
            if (txtNomeMarca.TextLength > 0)
            {
                btnSalvar.Enabled = true;
                btnSalvar.BackColor = Color.Green;
                btnSalvar.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                btnSalvar.Enabled = false;
                btnSalvar.BackColor = Color.LightGray;
                btnSalvar.FlatAppearance.BorderColor = Color.LightGray;
            }
        }

        #endregion Metodos

        #region Eventos
        private void FrmCadastrarMarca_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novaMarca = new Marca()
            {
                Nome = txtNomeMarca.Text.LimparTexto(),
                Descricao = txtDescricao.Text.LimparTexto()
            };

            var resultado = marcaRepositorio.InserirDadosNaTabela(novaMarca);

            if (resultado)
            {
                LimparCampos();
                MessageBox.Show("Marca cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar Marca!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtNomeMarca_TextChanged(object sender, EventArgs e)
        {
            HabilitarComponentes();
        }

        #endregion Eventos


    }
}
