using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using EstoqueProdutos.Telas_Base;
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
        IRepositorio<Formato> formatoRepositorio = new FormatoRepositorio();
        IRepositorio<Embalagem> embalagemRepositorio = new EmbalagemRepositorio();
        IRepositorio<UnidadeMedida> unidadeMedidaRepositorio = new UnidadeMedidaRepositorio();
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
                BindCboFormato();
                BindCboEmbalagem(); 
                BindCboUnidadeDeMedida();
                InicializarDatas();
                InicializarTextBoxs();
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
                cboMarca.SelectedIndex = 0;
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
                cboCategoria.SelectedIndex = 0;
            }
        }

        private void BindCboFormato()
        {
            var result = formatoRepositorio.ObterTabela();

            if (result != null)
            {
                cboFormato.DataSource = result.OrderBy(c => c.Nome).ToList();
                cboFormato.DisplayMember = "Nome";
                cboFormato.ValueMember = "PK_Formato";
                cboFormato.SelectedIndex = 0;
            }
        }

        private void BindCboEmbalagem()
        {
            var result = embalagemRepositorio.ObterTabela();

            if (result != null)
            {
                cboEmbalagem.DataSource = result.OrderBy(c => c.Nome).ToList();
                cboEmbalagem.DisplayMember = "Nome";
                cboEmbalagem.ValueMember = "PK_Embalagem";
                cboEmbalagem.SelectedIndex = 0;
            }
        }

        private void BindCboUnidadeDeMedida()
        {
            List<UnidadeMedida> result = unidadeMedidaRepositorio.ObterTabela().ToList();
            result.Insert(0, new UnidadeMedida { PK_UnidadeMedida = 0, Sigla = "n", Extenso = "Nenhum" });

            if (result != null)
            {
                cboUnidade.DataSource = result;
                cboUnidade.DisplayMember = "Sigla";
                cboUnidade.ValueMember = "PK_UnidadeMedida";
                cboUnidade.Enabled = false;
                cboUnidade.SelectedIndex = 0;
            }
        }

        private void InicializarTextBoxs() 
        {
            txtNomeProduto.Text = "";
            txtDescricao.Text = "";
            txtVolume.Text = "";
            txtAltura.Text = "";
            txtLargura.Text = "";
            txtComprimento.Text = "";
        }

        private void InicializarDatas()
        {
            chkValidade.Checked = false;
            chkFabricacao.Checked = false;
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
            AbrirFilho<FrmCadastroSimples>(AtualizarCboMarca_Click);

            if (ObterFilho<FrmCadastroSimples>() is FrmCadastroSimples cadastroSimples)
            {
                cadastroSimples.ObterRepositorio<MarcaRepositorio>();
                cadastroSimples.ObterEntidade<Marca>();
            }
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastroSimples>(AtualizarCboCategoria_Click);

            if (ObterFilho<FrmCadastroSimples>() is FrmCadastroSimples cadastroSimples)
            {
                cadastroSimples.ObterRepositorio<CategoriaRepositorio>();
                cadastroSimples.ObterEntidade<Categoria>();
            }
        }

        private void btnCadastrarFormato_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastroSimples>(AtualizarCboFormato_Click);

            if (ObterFilho<FrmCadastroSimples>() is FrmCadastroSimples cadastroSimples)
            {
                cadastroSimples.ObterRepositorio<FormatoRepositorio>();
                cadastroSimples.ObterEntidade<Formato>();
            }
        }

        private void btnCadastrarEmbalagem_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastroSimples>(AtualizarCboEmbalagem_Click);

            if (ObterFilho<FrmCadastroSimples>() is FrmCadastroSimples cadastroSimples)
            {
                cadastroSimples.ObterRepositorio<EmbalagemRepositorio>();
                cadastroSimples.ObterEntidade<Embalagem>();
            }
        }

        private void AtualizarCboMarca_Click(object sender, EventArgs e)
        {
            BindCboMarca();
        }

        private void AtualizarCboCategoria_Click(object sender, EventArgs e)
        {
            BindCboCategoria();
        }

        private void AtualizarCboFormato_Click(object sender, EventArgs e)
        {
            BindCboFormato();
        }

        private void AtualizarCboEmbalagem_Click(object sender, EventArgs e)
        {
            BindCboEmbalagem();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            InicializarComponentes();
        }

        private void TextBoxDecimais_KeyPress(object sender, KeyPressEventArgs e)
        {
            EstoqueProdutos.Formatacao.Eventos.TextBoxNumerosDecimais_KeyPress((TextBox)sender, e);
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            cboUnidade.Enabled = ((TextBox)sender).Text.Length > 0;
        }

        private void chkFabricacao_CheckedChanged(object sender, EventArgs e)
        {
            dtpFabricacao.Enabled = chkFabricacao.Checked;
            dtpFabricacao.Value = DateTime.Today;
        }

        private void chkValidade_CheckedChanged(object sender, EventArgs e)
        {
            dtpValidade.Enabled = chkValidade.Checked;
            dtpValidade.Value = DateTime.Today;
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = ((TextBox)sender).Text.Length > 0;
        }
        #endregion Eventos
    }
}
