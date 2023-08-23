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

namespace Estoque.Telas_Produto
{
    public partial class UCProduto : Estoque.Telas_Base.UCBase
    {
        private readonly IProdutoRepositorio produtoRepositorio;
        private readonly IRepositorio<Marca> marcaRepositorio;
        private readonly IRepositorio<Categoria> categoriaRepositorio;
        private readonly IRepositorio<Formato> formatoRepositorio;
        private readonly IRepositorio<Embalagem> embalagemRepositorio;

        private IEnumerable<Produto> produtos;

        public UCProduto()
        {
            InitializeComponent();
            AtualizarPropriedades();

            produtoRepositorio = DIRepositorios.Container.GetInstance<IProdutoRepositorio>();
            marcaRepositorio = DIRepositorios.Container.GetInstance<MarcaRepositorio>();
            categoriaRepositorio = DIRepositorios.Container.GetInstance<CategoriaRepositorio>();
            formatoRepositorio = DIRepositorios.Container.GetInstance<FormatoRepositorio>();
            embalagemRepositorio = DIRepositorios.Container.GetInstance<EmbalagemRepositorio>();
        }

        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxCategoria();
                BindComboBoxMarca();
                BindComboBoxFormato();
                BindComboBoxEmbalagem();
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

        private void BindComboBoxMarca()
        {
            var result = marcaRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Marca
                {
                    PK_Marca = 0,
                    Nome = "Nenhuma",
                    Descricao = "Nenhuma"
                });

            if (result != null)
            {
                cboMarca.DataSource = result;
                cboMarca.DisplayMember = "Nome";
                cboMarca.ValueMember = "PK_Marca";
                cboMarca.SelectedIndex = 0;
            }
        }

        private void BindComboBoxCategoria()
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

        private void BindComboBoxFormato()
        {
            var result = formatoRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Formato
                {
                    PK_Formato = 0,
                    Nome = "Nenhum",
                    Descricao = "Nenhum"
                });

            if (result != null)
            {
                cboFormato.DataSource = result;
                cboFormato.DisplayMember = "Nome";
                cboFormato.ValueMember = "PK_Formato";
                cboFormato.SelectedIndex = 0;
            }
        }

        private void BindComboBoxEmbalagem()
        {
            var result = embalagemRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Embalagem
                {
                    PK_Embalagem = 0,
                    Nome = "Nenhuma",
                    Descricao = "Nenhuma"
                });

            if (result != null)
            {
                cboEmbalagem.DataSource = result;
                cboEmbalagem.DisplayMember = "Nome";
                cboEmbalagem.ValueMember = "PK_Embalagem";
                cboEmbalagem.SelectedIndex = 0;
            }
        }

        private void BindDataGridView()
        {
            if (produtos != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                dtgProdutos.Rows.Clear();
                produtos.ToList().ForEach(item =>
                {
                    dtgProdutos.Rows.Add(
                        item.PK_Produto,
                        item.Nome,
                        item.Volume,
                        item.Descricao,
                        item.Altura,
                        item.Largura,
                        item.Comprimento,
                        Formatacao.ObterNome(item.Formato),
                        item.FK_Imagem,
                        Formatacao.ObterNome(item.Categoria),
                        Formatacao.ObterNome(item.Marca),
                        Formatacao.ObterNome(item.Embalagem),
                        item.FK_UnidadeMedida
                        );
                });
            }
        }

        private void LimparComponentes()
        {
            txtNomeProduto.Text = "";
            txtDescricaoProduto.Text = "";

            cboCategoria.SelectedValue = 0;
            cboEmbalagem.SelectedValue = 0;
            cboMarca.SelectedValue = 0;
            cboFormato.SelectedValue = 0;

            dtgProdutos.Rows.Clear();

        }

        private void UCProdutos_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var pesquisa = new PesquisaProdutoSimples()
            {
                Nome = txtNomeProduto.TextoFormatoLikeSQL(),
                Descricao = txtDescricaoProduto.TextoFormatoLikeSQL(),
                FK_Categoria = cboCategoria.ObterValorInt(),
                FK_Embalagem = cboEmbalagem.ObterValorInt(),
                FK_Formato = cboFormato.ObterValorInt(),
                FK_Marca = cboMarca.ObterValorInt()
            };

            produtos = produtoRepositorio.ObterProduto(pesquisa);
            BindDataGridView();
        }

        private void UCProdutos_ParentChanged(object sender, EventArgs e)
        {
            LimparComponentes();
        }
    }
}
