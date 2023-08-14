using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
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
using EP.Data;
using Microsoft.Data.SqlClient;
using EP.Data.Interfaces;

namespace EstoqueProdutos.Telas_Produto
{
    public partial class FrmCadastrarProduto : Telas_Base.FrmGestor
    {

        private readonly IRepositorio<Marca> marcaRepositorio;
        private readonly IRepositorio<Categoria> categoriaRepositorio;
        private readonly IRepositorio<Formato> formatoRepositorio;
        private readonly IRepositorio<Embalagem> embalagemRepositorio;
        private readonly IRepositorio<UnidadeMedida> unidadeMedidaRepositorio;
        private readonly IRepositorio<Produto> produtoRepositorio;
        private readonly IImagemRepositorio imagemRepositorio;

        public FrmCadastrarProduto()
        {
            InitializeComponent();
            marcaRepositorio = ConfiguradorDI.Container.GetInstance<MarcaRepositorio>();
            categoriaRepositorio = ConfiguradorDI.Container.GetInstance<CategoriaRepositorio>();
            formatoRepositorio = ConfiguradorDI.Container.GetInstance<FormatoRepositorio>();
            embalagemRepositorio = ConfiguradorDI.Container.GetInstance<EmbalagemRepositorio>();
            unidadeMedidaRepositorio = ConfiguradorDI.Container.GetInstance<UnidadeMedidaRepositorio>();
            produtoRepositorio = ConfiguradorDI.Container.GetInstance<ProdutoRepositorio>();
            imagemRepositorio = ConfiguradorDI.Container.GetInstance<ImagemRepositorio>();
        }

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
                InicializarImagem();
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

        private void BindCboUnidadeDeMedida()
        {
            var result = unidadeMedidaRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new UnidadeMedida
                {
                    PK_UnidadeMedida = 0,
                    Sigla = "n",
                    Extenso = "Nenhum"
                });

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

            dtpFabricacao.MaxDate = DateTime.Today;
            dtpValidade.MinDate = dtpFabricacao.Value;
        }

        private void InicializarImagem()
        {
            btnProcurarImg.BackgroundImage = imagemRepositorio.ObterImagemPadrao();
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

        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastroSimples>(AtualizarCboMarca_Click, true);

            if (ObterFilho<FrmCadastroSimples>() is FrmCadastroSimples cadastroSimples)
            {
                cadastroSimples.ObterRepositorio<MarcaRepositorio>();
                cadastroSimples.ObterEntidade<Marca>();
            }
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastroSimples>(AtualizarCboCategoria_Click, true);

            if (ObterFilho<FrmCadastroSimples>() is FrmCadastroSimples cadastroSimples)
            {
                cadastroSimples.ObterRepositorio<CategoriaRepositorio>();
                cadastroSimples.ObterEntidade<Categoria>();
            }
        }

        private void btnCadastrarFormato_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastroSimples>(AtualizarCboFormato_Click, true);

            if (ObterFilho<FrmCadastroSimples>() is FrmCadastroSimples cadastroSimples)
            {
                cadastroSimples.ObterRepositorio<FormatoRepositorio>();
                cadastroSimples.ObterEntidade<Formato>();
            }
        }

        private void btnCadastrarEmbalagem_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmCadastroSimples>(AtualizarCboEmbalagem_Click, true);

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

        private void btnSalvar_EnabledChanged(object sender, EventArgs e)
        {
            Formatacao
            .Eventos
            .AlterarCorButton_EnabledChanged((Button)sender, Color.Green, Color.LightGray, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int PK_Imagem = imagemRepositorio.SalvarImagem(btnProcurarImg.BackgroundImage);

                var produto = new Produto()
                {
                    Nome = txtNomeProduto.LimparTexto(),
                    Descricao = txtDescricao.LimparTexto(),
                    Volume = txtVolume.ParaDecimal(),

                    DataFabricacao = dtpFabricacao.ParaDataPequena(),
                    DataValidade = dtpValidade.ParaDataPequena(),

                    Altura = txtAltura.ParaDecimal(),
                    Largura = txtLargura.ParaDecimal(),
                    Comprimento = txtComprimento.ParaDecimal(),

                    FK_Categoria = cboCategoria.ObterValorInt(),
                    FK_Embalagem = cboEmbalagem.ObterValorInt(),
                    FK_Formato = cboFormato.ObterValorInt(),
                    FK_Marca = cboMarca.ObterValorInt(),
                    FK_UnidadeMedida = cboUnidade.ObterValorInt(),

                    FK_Imagem = PK_Imagem
                };

                var resultado = produtoRepositorio.InserirDadosNaTabela(produto);

                if (resultado)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    btnLimpar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar produto!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar executar essa operação!");
            }
        }

        private void dtpFabricacao_ValueChanged(object sender, EventArgs e)
        {
            dtpValidade.MinDate = dtpFabricacao.Value;
        }

        private void btnProcurarImg_Click(object sender, EventArgs e)
        {
            var img = imagemRepositorio.ProcurarImagemLocal();

            if (img != null)
            {
                btnProcurarImg.BackgroundImage = img;
            }
        }

        private void btnLimparImg_Click(object sender, EventArgs e)
        {
            btnProcurarImg.BackgroundImage = imagemRepositorio.ObterImagemPadrao();
        }

        #endregion Eventos

    }
}
