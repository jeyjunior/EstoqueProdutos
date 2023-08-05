using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueProdutos.Telas_Produto
{
    public partial class FrmCadastrarProduto : Telas_Base.FrmGestor
    {

        #region Classes
        IRepositorio<Marca> marcaRepositorio = new MarcaRepositorio();
        #endregion Classes

        #region Propriedades

        #endregion Propriedades

        #region Construtor
        public FrmCadastrarProduto()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Metodos

        private void InicializarComponentes()
        {
            try
            {
                BindCboMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar essa operação\n\n" + ex.Message);
                this.Close();
            }
        }
        private void BindCboMarca()
        {
            var result = marcaRepositorio.ObterTabela();

            if(result != null)
            {
                cboMarca.DataSource = result.OrderBy(c => c.Nome).ToList();
                cboMarca.DisplayMember = "Nome";
                cboMarca.ValueMember = "PK_Marca";
            }
        }

        #endregion Metodos

        #region Eventos
        private void FrmCadastrarProduto_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbImgProduto_Click(object sender, EventArgs e)
        {

        }
        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            AbrirFilho<Telas_ProdutoMarcas.FrmCadastrarMarca>(AtualizarCboMarca_Click);
        }

        private void AtualizarCboMarca_Click(object sender, EventArgs e)
        {
            BindCboMarca();
        }

        #endregion Eventos

    }
}
