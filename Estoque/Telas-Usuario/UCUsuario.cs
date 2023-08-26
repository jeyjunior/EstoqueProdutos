using EP.Data.Entidades;
using EP.Data.Interfaces;
using EP.Data.Repositorios;
using Estoque.Telas_Base;
using Estoque.Telas_Usuario;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using EstoqueProdutos.Telas_Principal;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas
{
    public partial class UCUsuario : Estoque.Telas_Base.UCGerenciadorDeTelas
    {
        private readonly IRepositorio<Setor> setorRepositorio;
        private readonly IRepositorio<Cargo> cargoRepositorio;

        private IEnumerable<Produto> produtos;

        public UCUsuario()
        {
            InitializeComponent();

            setorRepositorio = DIRepositorios.Container.GetInstance<SetorRepositorio>();
            cargoRepositorio = DIRepositorios.Container.GetInstance<CargoRepositorio>();
            AtualizarPropriedades();
        }

        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxSetor();
                BindComboBoxCargo();
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

        private void BindComboBoxSetor()
        {
            var result = setorRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Setor
                {
                    PK_Setor = 0,
                    NomeSetor = "Nenhum",
                    Descricao = "Nenhum"
                });

            if (result != null)
            {
                cboSetor.DataSource = result;
                cboSetor.DisplayMember = "NomeSetor";
                cboSetor.ValueMember = "PK_Setor";
                cboSetor.SelectedIndex = 0;
            }
        }

        private void BindComboBoxCargo()
        {
            var result = cargoRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Cargo
                {
                    PK_Cargo = 0,
                    NomeCargo = "Nenhuma",
                    Descricao = "Nenhuma"
                });

            if (result != null)
            {
                cboCargo.DataSource = result;
                cboCargo.DisplayMember = "NomeCargo";
                cboCargo.ValueMember = "PK_Cargo";
                cboCargo.SelectedIndex = 0;
            }
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

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            AbrirTela<FrmCadastrarUsuario>(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AbrirTela<UCBase>(this);
        }
    }
}
