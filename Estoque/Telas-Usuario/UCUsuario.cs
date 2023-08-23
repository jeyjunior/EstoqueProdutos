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

namespace Estoque.Telas
{
    public partial class UCUsuario : Estoque.Telas_Base.UCBase
    {

        private IEnumerable<Produto> produtos;

        public UCUsuario()
        {
            InitializeComponent();
            AtualizarPropriedades();
        }

        private void InicializarComponentes()
        {
            try
            {
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

        private void BindComboBoxFormato()
        {
            //var result = formatoRepositorio.ObterTabela().ToList();
            //result.Insert(0,
            //    new Formato
            //    {
            //        PK_Formato = 0,
            //        Nome = "Nenhum",
            //        Descricao = "Nenhum"
            //    });

            //if (result != null)
            //{
            //    cboFormato.DataSource = result;
            //    cboFormato.DisplayMember = "Nome";
            //    cboFormato.ValueMember = "PK_Formato";
            //    cboFormato.SelectedIndex = 0;
            //}
        }

        private void BindComboBoxEmbalagem()
        {
            //var result = embalagemRepositorio.ObterTabela().ToList();
            //result.Insert(0,
            //    new Embalagem
            //    {
            //        PK_Embalagem = 0,
            //        Nome = "Nenhuma",
            //        Descricao = "Nenhuma"
            //    });

            //if (result != null)
            //{
            //    cboCargo.DataSource = result;
            //    cboCargo.DisplayMember = "Nome";
            //    cboCargo.ValueMember = "PK_Embalagem";
            //    cboCargo.SelectedIndex = 0;
            //}
        }

        private void BindDataGridView()
        {
            if (produtos != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                dtgUsuarios.Rows.Clear();
                produtos.ToList().ForEach(item =>
                {
                    dtgUsuarios.Rows.Add(
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
            txtNomeUsuario.Text = "";
            cboCargo.SelectedValue = 0;
            cboSetor.SelectedValue = 0;
            dtgUsuarios.Rows.Clear();
        }

        private void UCProdutos_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //var pesquisa = new PesquisaProdutoSimples()
            //{
            //    Nome = txtNomeProduto.TextoFormatoLikeSQL(),
            //    Descricao = txtDescricaoProduto.TextoFormatoLikeSQL(),
            //    FK_Categoria = cboCategoria.ObterValorInt(),
            //    FK_Embalagem = cboEmbalagem.ObterValorInt(),
            //    FK_Formato = cboFormato.ObterValorInt(),
            //    FK_Marca = cboMarca.ObterValorInt()
            //};

            //produtos = produtoRepositorio.ObterProduto(pesquisa);
            BindDataGridView();
        }

        private void UCProdutos_ParentChanged(object sender, EventArgs e)
        {
            LimparComponentes();
        }
    }
}
