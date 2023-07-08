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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        //private void DesabilitarBtnCadastrar(object sender)
        //{
        //    btnCadastrar.Enabled = false;

        //    Control obj = (Control)sender;
        //    obj.Enabled = false;
        //}

        #region BuscarImagem, GuardarImagem
        private void GuardarImagem()
        {
            if (pcbImagem.Image is null)
                return;

            using (MemoryStream ms = new MemoryStream())
            {
                Image img = pcbImagem.Image;
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imgByte = ms.ToArray();
            }

            Pr_GuardarImagem.Guardar(nomeImagem, formatoImagem, imgByte);
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

                    nomeImagem = Path.GetFileNameWithoutExtension(caminhoArquivo).FormatarNomeImagem();
                    formatoImagem = Path.GetExtension(caminhoArquivo).FormatarNomeDoFormatoImagem();
                    pcbImagem.Image = Image.FromFile(caminhoArquivo);
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
        }

        #endregion Carregar dados dos Componentes

        #endregion Metodos

        #region Eventos

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            GuardarImagem();
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

        #endregion Eventos

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarDadosDosComponentes();
        }


    }
}
