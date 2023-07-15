using EstoqueProdutos.Ajudantes.Bind;
using EstoqueProdutos.Ajudantes.Componentes;
using EstoqueProdutos.Ajudantes.Formatacao;
using EstoqueProdutos.SQLServer.Conexao;
using EstoqueProdutos.SQLServer.Procedures;
using SqlData.Core.CommonSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;



namespace EstoqueProdutos.Telas_Produtos
{
    public partial class FrmPesquisar : Form
    {
        private string nomeImagem = String.Empty;
        private string formatoImagem = String.Empty;
        private byte[]? imgByte;

        public FrmPesquisar()
        {
            InitializeComponent();
        }

        #region Metodos

        #region BuscarImagem, GuardarImagem
        private int? GuardarImagem()
        {
            if (pcbImagem.Image is null)
                return 100;

            int? PK_ID = (int?)pcbImagem.Tag;

            if (PK_ID is not null)
                return 100;

            int novoID = 100;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Image img = pcbImagem.Image;
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imgByte = ms.ToArray();
                }

                novoID = Pr_GuardarImagem.Guardar(PK_ID, nomeImagem, formatoImagem, imgByte);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao registrar imagem no banco!\nErro: " + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no savalmente da imagem!");
            }

            return novoID;
        }

        private void BuscarImagemRepositorioLocal()
        {
            nomeImagem = String.Empty;
            formatoImagem = String.Empty;

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Imagens PNG e JPEG|*.png;*.jpeg;*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = openFileDialog.FileName;

                    nomeImagem = Path.GetFileNameWithoutExtension(caminhoArquivo).PrimeiraLetraMaiuscula();
                    formatoImagem = Path.GetExtension(caminhoArquivo).FormatarNomeDoFormatoImagem();
                    pcbImagem.Image = Image.FromFile(caminhoArquivo);
                    pcbImagem.Tag = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar imagens!\nErro: " + ex.Message);
            }
        }

        #endregion Imagem

        #region Carregar dados dos Componentes

        private void CarregarDadosDosComponentes()
        {
            Tabela.ObterDataSource(Pr_ObterUnidadeMedida.Obter(), cboUnidadeMedida, btnCadastrar);
            Tabela.ObterDataSource(Pr_ObterFornecedor.Obter(), cboFornecedor, btnCadastrar);
            Tabela.ObterDataSource(pr_ObterCategoria.Obter(), cboCategoria, btnCadastrar);
            Tabela.ObterDataSource(Pr_ObterEmbalagem.Obter(), cboEmbalagem, btnCadastrar);

            Imagem.ObterImagemStandard(pcbImagem);

            Componente.DesabilitarBtnCadastrar(btnCadastrar);
        }

        #endregion Carregar dados dos Componentes

        private bool Cadastrar()
        {
            int? PK_ID_img = GuardarImagem();

            txtNome.Text = txtNome.Text.SanitizarTexto(30).PrimeiraLetraMaiuscula();
            txtDescri.Text = txtDescri.Text.SanitizarTexto(90);

            string? preco = txtPreco.Text.RemoverMascarDinheiro();
            decimal precoUnitario = !String.IsNullOrEmpty(preco) ? Convert.ToDecimal(preco) : 0.00m;

            decimal volume = !String.IsNullOrEmpty(txtVolume.Text) ? Convert.ToDecimal(txtVolume.Text) : 0.00m;

            int PK_ID_Fornecedor = Convert.ToInt32(cboFornecedor.SelectedValue.ToString());
            int PK_ID_Categoria = Convert.ToInt32(cboCategoria.SelectedValue.ToString());
            int PK_ID_Embalagem = Convert.ToInt32(cboEmbalagem.SelectedValue.ToString());
            int PK_ID_Unidade = Convert.ToInt32(cboUnidadeMedida.SelectedValue.ToString());

            Produto produto = new();

            produto.Nome = txtNome.Text;
            produto.Preco = precoUnitario;
            produto.FK_tblCategoria_ID = PK_ID_Categoria;
            produto.FK_tblFornecedor_ID = PK_ID_Fornecedor;
            produto.FK_tblTipoEmbalagem_ID = PK_ID_Embalagem;
            produto.Volume = volume;
            produto.FK_tblUnidadeMedida_ID = PK_ID_Unidade;
            produto.FK_Imagem_ID = PK_ID_img is null ? 100 : PK_ID_img;
            produto.Descricao = String.IsNullOrWhiteSpace(txtDescri.Text) ? null : txtDescri.Text;

            Pr_GuardarProduto.Guardar(produto);

            if (String.IsNullOrWhiteSpace(Pr_GuardarProduto.ErroMensagem))
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                return true;
            }

            MessageBox.Show("Erro: \n\n" + Pr_GuardarProduto.ErroMensagem);
            return false;
        }

        private void HabilitarBtnCadastrar()
        {
            btnCadastrar.DesabilitarBtnCadastrar();

            if (String.IsNullOrEmpty(txtNome.Text))
                return;

            if (String.IsNullOrEmpty(txtPreco.Text))
                return;

            if (String.IsNullOrEmpty(txtVolume.Text))
                return;

            btnCadastrar.HabilitarBtnCadastrar();
        }

        #endregion Metodos

        #region Eventos

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool result = Cadastrar();

            if (result)
            {
                this.Close();
                btnLimpar.PerformClick();
            }
        }

        private void pcbImagem_Click(object sender, EventArgs e)
        {
            BuscarImagemRepositorioLocal();
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarDadosDosComponentes();
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TextBox = ((TextBox)sender);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (TextBox.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;

        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPreco.Text))
            {
                txtPreco.Text = txtPreco.Text.RemoverMascarDinheiro();
                decimal preco = Convert.ToDecimal(txtPreco.Text);
                txtPreco.Text = Math.Round(preco, 2).ToString();
                txtPreco.Text = txtPreco.Text.AplicarMascaraDinheiro();
            }
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.RemoverMascarDinheiro();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescri.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtVolume.Clear();

            cboCategoria.SelectedIndex = 0;
            cboFornecedor.SelectedIndex = 0;
            cboEmbalagem.SelectedIndex = 0;
            cboUnidadeMedida.SelectedIndex = 0;

            //pcbImagem.Dispose();
            pcbImagem.Image = null;
            Imagem.ObterImagemStandard(pcbImagem);
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TextBox = ((TextBox)sender);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (TextBox.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnCadastrar();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnCadastrar();
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnCadastrar();
        }

        #endregion Eventos


    }
}
