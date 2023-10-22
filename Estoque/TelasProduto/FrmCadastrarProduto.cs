﻿using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
using Estoque.Telas_Base;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Repositorios;
using JJ.Helpers.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Estoque.Telas_Produto
{
    public partial class FrmCadastrarProduto : FrmBase
    {
        private readonly IUsuarioLogado usuarioLogado;
        private readonly IValidacao validacao;

        private readonly IImagemRepositorio imagemRepositorio;
        private readonly ICategoriaRepositorio categoriaRepositorio;
        private readonly IMarcaRepositorio marcaRepositorio;
        private readonly IEmbalagemRepositorio embalagemRepositorio;
        private readonly IFormatoRepositorio formatoRepositorio;
        private readonly IUnidadeMedidaRepositorio unidadeMedidaRepositorio;
        private readonly IProdutoRepositorio produtoRepositorio;

        private bool produtoValidado = false;
        public FrmCadastrarProduto(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            InitializeComponent();

            this.gerenciadorDeTelas = gerenciadorDeTelas;

            usuarioLogado = DITelas.Container.GetInstance<IUsuarioLogado>();
            validacao = DITelas.Container.GetInstance<IValidacao>();

            imagemRepositorio = DIRepositorios.Container.GetInstance<IImagemRepositorio>();
            categoriaRepositorio = DIRepositorios.Container.GetInstance<ICategoriaRepositorio>();
            marcaRepositorio = DIRepositorios.Container.GetInstance<IMarcaRepositorio>();
            embalagemRepositorio = DIRepositorios.Container.GetInstance<IEmbalagemRepositorio>();
            formatoRepositorio = DIRepositorios.Container.GetInstance<IFormatoRepositorio>();
            unidadeMedidaRepositorio = DIRepositorios.Container.GetInstance<IUnidadeMedidaRepositorio>();
            produtoRepositorio = DIRepositorios.Container.GetInstance<IProdutoRepositorio>();

            pcbImagem.Image = imagemRepositorio.ObterImagemPadrao();
        }

        #region Metodos 
        /* Inicializacao */
        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxCategoria();
                BindComboBoxMarca();
                BindComboBoxEmbalagem();
                BindComboBoxFormato();
                BindComboBoxUnidadeMedida();
                InicializarEventos();
                dtpFabricacao.Value = DateTime.Today;
                FormatarComponentesDateTime();
            }
            catch (SqlException ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha conexão.");
                this.Close();
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha carregar componentes");
                this.Close();
            }
        }
        private void BindComboBoxCategoria()
        {
            var result = categoriaRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                cboCategoria.DataSource = result;
                cboCategoria.DisplayMember = "Nome";
                cboCategoria.ValueMember = "PK_Categoria";
            }
        }
        private void BindComboBoxMarca()
        {
            var result = marcaRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                cboMarca.DataSource = result;
                cboMarca.DisplayMember = "Nome";
                cboMarca.ValueMember = "PK_Marca";
            }
        }
        private void BindComboBoxEmbalagem()
        {
            var result = embalagemRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                cboEmbalagem.DataSource = result;
                cboEmbalagem.DisplayMember = "Nome";
                cboEmbalagem.ValueMember = "PK_Embalagem";
            }
        }
        private void BindComboBoxFormato()
        {
            var result = formatoRepositorio.ObterTabela().ToList();

            if (result != null)
            {
                cboFormato.DataSource = result;
                cboFormato.DisplayMember = "Nome";
                cboFormato.ValueMember = "PK_Formato";
            }
        }
        private void BindComboBoxUnidadeMedida()
        {
            var result = unidadeMedidaRepositorio.ObterTabela()
                .Select(s => new
                {
                    PK_UnidadeMedida = s.PK_UnidadeMedida,
                    Nome = $"{s.Extenso} ({s.Sigla})"
                })
                .ToList();

            if (result != null)
            {
                cboUnidadeMedida.DataSource = result;
                cboUnidadeMedida.DisplayMember = "Nome";
                cboUnidadeMedida.ValueMember = "PK_UnidadeMedida";
            }
        }

        private void InicializarEventos()
        {
            txtProduto.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            //txtProduto.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;

            txtDescricao.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            //txtDescricao.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;

            txtAltura.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            txtAltura.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;
            txtAltura.Leave += Eventos.TextBoxAtribuirZero_Leave;
            txtAltura.KeyPress += Eventos.TextBoxNumerosDecimais_KeyPress;

            txtLargura.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            txtLargura.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;
            txtLargura.Leave += Eventos.TextBoxAtribuirZero_Leave;
            txtLargura.KeyPress += Eventos.TextBoxNumerosDecimais_KeyPress;

            txtComprimento.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            txtComprimento.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;
            txtComprimento.Leave += Eventos.TextBoxAtribuirZero_Leave;
            txtComprimento.KeyPress += Eventos.TextBoxNumerosDecimais_KeyPress;

            txtVolume.Enter += Eventos.TextBoxSelecionarTudo_Enter;
            txtVolume.MouseClick += Eventos.TextBoxSelecionarTudo_MouseClick;
            txtVolume.Leave += Eventos.TextBoxAtribuirZero_Leave;
            txtVolume.KeyPress += Eventos.TextBoxNumerosDecimais_KeyPress;
        }

        private void FormatarComponentesDateTime()
        {
            dtpValidade.MinDate = dtpFabricacao.Value;
        }

        /* Updates */
        private void LimparComponetes()
        {
            pcbImagem.Image = imagemRepositorio.ObterImagemPadrao();

            txtProduto.Text = "";
            dtpFabricacao.Value = DateTime.Today;
            dtpValidade.Value = DateTime.Today;
            txtDescricao.Text = "";

            cboCategoria.SelectedValue = 1;
            cboMarca.SelectedValue = 1;
            cboFormato.SelectedValue = 1;
            cboEmbalagem.SelectedValue = 1;
            cboUnidadeMedida.SelectedValue = 1;

            txtAltura.Text = "0";
            txtLargura.Text = "0";
            txtComprimento.Text = "0";
            txtVolume.Text = "0";

            txtProduto.Focus();
        }

        private bool ValidarComponentes()
        {
            if (!produtoValidado)
            {
                Alerta.Erro("Campo produto é obrigatório!");
                txtProduto.Focus();
                return false;
            }

            return true;
        }
        #endregion Metodos

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var img = pcbImagem.Image;
            int PK_Imagem = imagemRepositorio.SalvarImagemNaBase(img);

            try
            {
                if (!ValidarComponentes())
                    return;

                var nome = txtProduto.Text;
                var descricao = txtDescricao.Text;
                var dataFabricacao = dtpFabricacao.Value;
                var dataValidade = dtpValidade.Value;
                var pk_Categoria = (int)cboCategoria.SelectedValue;
                var pk_Embalagem = (int)cboEmbalagem.SelectedValue;
                var pk_Formato = (int)cboFormato.SelectedValue;
                var pk_Marca = (int)cboMarca.SelectedValue;
                var pk_UnidadeMedida = (int)cboUnidadeMedida.SelectedValue;
                var altura = Convert.ToDecimal(txtAltura.Text);
                var largura = Convert.ToDecimal(txtLargura.Text);
                var comprimento = Convert.ToDecimal(txtComprimento.Text);

                var produto = new Produto()
                {
                    Nome = nome,
                    Descricao = descricao,
                    DataFabricacao = dataFabricacao,
                    DataValidade = dataValidade,
                    FK_Categoria = pk_Categoria,
                    FK_Embalagem = pk_Embalagem,
                    FK_Formato = pk_Formato,
                    FK_Marca = pk_Marca,
                    FK_UnidadeMedida = pk_UnidadeMedida,
                    FK_Imagem = PK_Imagem,
                    Altura = altura,
                    Largura = largura,
                    Comprimento = comprimento,
                    FK_Usuario = usuarioLogado.ObterUsuarioLogado().PK_Usuario
                };

                var resultado = produtoRepositorio.InserirDadosNaTabela(produto);

                if (resultado)
                {
                    Alerta.Confirmacao("Produto cadastrado com sucesso!");
                    LimparComponetes();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Erro ao cadastrar produto.");
            }
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponetes();
        }

        private void pcbImagemUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                var img = imagemRepositorio.ProcurarImagemLocal();

                if (img != null)
                {
                    pcbImagem.Image = img;
                }
            }
            catch (Exception ex)
            {

                Mensagem.Erro("Erro: " + ex.Message);
            }
        }

        #endregion Eventos

        private void FrmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
            LimparComponetes();
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            produtoValidado = validacao.ValidarTextDoTextBox(ref txtProduto, ref pValidarProduto, 2);
        }

        private void txtAltura_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtAltura_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dtpFabricacao_ValueChanged(object sender, EventArgs e)
        {
            FormatarComponentesDateTime();
        }
    }
}
