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
        IRepositorio<Categoria> categoriaRepositorio = new CategoriaRepositorio();
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
                BindCboCategoria();
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

            if (result != null)
            {
                cboMarca.DataSource = result.OrderBy(c => c.Nome).ToList();
                cboMarca.DisplayMember = "Nome";
                cboMarca.ValueMember = "PK_Marca";
            }
        }
        private void BindCboCategoria()
        {
            var result = categoriaRepositorio.ObterTabela();

            if (result != null)
            {
                cboCategoria.DataSource = result.OrderBy(c => c.Nome).ToList();
                cboCategoria.DisplayMember = "Nome";
                cboCategoria.ValueMember = "PK_Categoria";
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
            var repositorioCategoria = new MarcaRepositorio();
            AbrirFilhoCadastroSimples(repositorioCategoria, AtualizarCboMarca_Click);
        }
        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            var repositorioCategoria = new CategoriaRepositorio();
            AbrirFilhoCadastroSimples(repositorioCategoria, AtualizarCboCategoria_Click);
        }

        private void AtualizarCboMarca_Click(object sender, EventArgs e)
        {
            BindCboMarca();
        }

        private void AtualizarCboCategoria_Click(object sender, EventArgs e)
        {
            BindCboCategoria();
        }

        #endregion Eventos

    }
}
