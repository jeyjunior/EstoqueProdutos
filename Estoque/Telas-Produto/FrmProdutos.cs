using EP.Data.Interfaces;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Interfaces;
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

namespace EstoqueProdutos.Telas_Produto
{
    public partial class FrmProdutos : Telas_Base.FrmGestor
    {
        private readonly IRepositorio<Categoria> categoriaRepositorio;
        private readonly IProdutoRepositorio produtoRepositorio;

        private IEnumerable<Produto> listaDeProdutos;

        public FrmProdutos()
        {
            InitializeComponent();

            categoriaRepositorio = ConfiguradorDI.Container.GetInstance<CategoriaRepositorio>();
            produtoRepositorio = ConfiguradorDI.Container.GetInstance<IProdutoRepositorio>();
        }

        #region Metodos

        private void InicializarComponentes()
        {
            try
            {
                BindCboCategoria();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha sql\n\n" + ex.Message);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar essa operação\n\n" + ex.Message);
                this.Close();
            }
        }

        private void BindCboCategoria()
        {
            var result = categoriaRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Categoria
                {
                    PK_Categoria = 0,
                    Nome = "Nenhuma",
                    Descricao = "Nenhuma"
                });


            if (result != null)
            {
                cboCategoria.DataSource = result;
                cboCategoria.DisplayMember = "Nome";
                cboCategoria.ValueMember = "PK_Categoria";
                cboCategoria.SelectedIndex = 0;
            }
        }

        #endregion Metodos

        #region Eventos

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastrarProduto>();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var pesquisarProdutos = new PesquisaProdutoSimples()
            {
                Nome = txtNome.TextoFormatoLikeSQL(),
                FK_Categoria = cboCategoria.ObterValorInt()
            };

            listaDeProdutos = produtoRepositorio.ObterProduto(pesquisarProdutos);

            if (listaDeProdutos.Count() > 0)
            {
                dtgProdutos.DataSource = listaDeProdutos;
            }
        }
        #endregion Eventos

    }
}
