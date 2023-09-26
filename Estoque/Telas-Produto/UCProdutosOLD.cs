﻿using EP.Data.Interfaces;
using Estoque.Controladores;
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
    public partial class UCProdutosOLD : Estoque.Telas_Base.UCBase
    {
        private readonly IProdutoRepositorio produtoRepositorio;
        private readonly IMarcaRepositorio marcaRepositorio;
        private readonly ICategoriaRepositorio categoriaRepositorio;
        private readonly IFormatoRepositorio formatoRepositorio;
        private readonly IEmbalagemRepositorio embalagemRepositorio;

        private IEnumerable<Produto> produtos;

        public UCProdutosOLD()
        {
            InitializeComponent();
            AtualizarPropriedades();

            produtoRepositorio = DIRepositorios.Container.GetInstance<IProdutoRepositorio>();
            marcaRepositorio = DIRepositorios.Container.GetInstance<IMarcaRepositorio>();
            categoriaRepositorio = DIRepositorios.Container.GetInstance<ICategoriaRepositorio>();
            formatoRepositorio = DIRepositorios.Container.GetInstance<IFormatoRepositorio>();
            embalagemRepositorio = DIRepositorios.Container.GetInstance<IEmbalagemRepositorio>();
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
                Mensagem.Erro("Erro: " + ex.Message, "Falha conexão");
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao executar essa operação");
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

            if (dtgProdutos.Rows.Count > 0)
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

        private void tlpComponentesRow1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
