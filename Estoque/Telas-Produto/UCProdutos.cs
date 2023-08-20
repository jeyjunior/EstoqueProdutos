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
    public partial class UCProdutos : Estoque.Telas_Base.UCBase
    {
        private readonly IProdutoRepositorio produtoRepositorio;
        private readonly IRepositorio<Marca> marcaRepositorio;
        private readonly IRepositorio<Categoria> categoriaRepositorio;
        private readonly IRepositorio<Formato> formatoRepositorio;
        private readonly IRepositorio<Embalagem> embalagemRepositorio;

        private IEnumerable<Produto> produtos;

        public UCProdutos()
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
                BindCboCategoria();
                BindCboMarca();
                BindCboFormato();
                BindCboEmbalagem();

                InicializarDatas();
                DefinirEstadoDasDatas();
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

        private void BindCboMarca()
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

        private void BindCboFormato()
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

        private void BindCboEmbalagem()
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

        private void InicializarDatas()
        {
            dtpFabricacao.MaxDate = DateTime.Today;
            dtpFabricacao.Value = DateTime.Today;

            dtpValidade.MinDate = dtpFabricacao.Value;
            dtpValidade.Value = dtpFabricacao.Value;
        }

        private void DefinirEstadoDasDatas()
        {
            dtpFabricacao.Enabled = chkDatas.Checked;
            dtpValidade.Enabled = chkDatas.Checked;
        }

        private void BindDataGrid()
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
                        item.DataFabricacao,
                        item.DataValidade,
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



        private void UCProdutos_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }

        private void dtpFabricacao_ValueChanged(object sender, EventArgs e)
        {
            dtpValidade.MinDate = dtpFabricacao.Value;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime? dataFabricacao = chkDatas.Checked ? dtpFabricacao.Value : null;
            DateTime? dataValidade = chkDatas.Checked ? dtpValidade.Value : null;

            var pesquisa = new PesquisaProdutoSimples()
            {
                Nome = txtNomeProduto.TextoFormatoLikeSQL(),
                DataFabricacao = dataFabricacao,
                DataValidade = dataValidade,
                FK_Categoria = cboCategoria.ObterValorInt(),
                FK_Embalagem = cboEmbalagem.ObterValorInt(),
                FK_Formato = cboFormato.ObterValorInt(),
                FK_Marca = cboMarca.ObterValorInt()
            };

            produtos = produtoRepositorio.ObterProduto(pesquisa);
            BindDataGrid();
        }

        private void chkDatas_CheckedChanged(object sender, EventArgs e)
        {
            DefinirEstadoDasDatas();
        }
    }
}
