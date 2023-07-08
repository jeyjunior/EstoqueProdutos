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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EstoqueProdutos.Telas_Produtos
{
    public partial class FrmCadastroProduto : Form
    {
        private string nomeImagem = String.Empty;
        private string formatoImagem = String.Empty;
        private byte[]? imgByte;

        public FrmCadastroProduto()
        {
            InitializeComponent();

        }

        #region Metodos

        #region BuscarImagem, GuardarImagem
        private void GuardarImagem()
        {
            if (pcbImagem.Image is null)
                return;

            int? PK_ID = (int?)pcbImagem.Tag;

            if (PK_ID is not null)
                return;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Image img = pcbImagem.Image;
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imgByte = ms.ToArray();
                }

                Pr_GuardarImagem.Guardar(PK_ID, nomeImagem, formatoImagem, imgByte);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no savalmente da imagem!");
            }
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
            txtNome.Text = txtNome.Text.SanitizarTexto(30).PrimeiraLetraMaiuscula();
            txtDescri.Text = txtDescri.Text.SanitizarTexto(90);

            return true;
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
            //GuardarImagem();
            Cadastrar();
        }

        private void pcbImagem_Click(object sender, EventArgs e)
        {
            BuscarImagemRepositorioLocal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar a operação?", "Cancelar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
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
            string text = ((TextBox)sender).Text;

            if (!String.IsNullOrEmpty(text))
                ((TextBox)sender).Text = text.AplicarMascaraDinheiro();
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.RemoverMascarDinheiro();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescri.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtPreco.Text = String.Empty;
            txtVolume.Text = String.Empty;

            cboCategoria.SelectedIndex = 0;
            cboFornecedor.SelectedIndex = 0;
            cboEmbalagem.SelectedIndex = 0;
            cboUnidadeMedida.SelectedIndex = 0;

            pcbImagem.Image = null;
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
