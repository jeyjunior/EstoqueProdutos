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

namespace EstoqueProdutos.Telas_Produto
{
    public partial class FrmCadastrarProduto : Telas_Base.FrmBase
    {

        #region Classes
        IMarcaRepositorio marcaRepositorio = new MarcaRepositorio();
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
            BindCboMarca();
        }
        private void BindCboMarca() 
        {
            var result = marcaRepositorio.ObterTabela();
            cboMarca.DataSource = result;
            cboMarca.DisplayMember = "Nome";
            cboMarca.ValueMember = "PK_Marca";
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

        #endregion Eventos

    }
}
