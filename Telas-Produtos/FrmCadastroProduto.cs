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
            BindingCboCategoria();
        }

        private void BindingCboCategoria()
        {
            try
            {
                DataTable dt = pr_ObterCategoria.Obter();

                if (dt.Rows.Count <= 0)
                    throw new Exception();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar categoria!\nErro: " + ex.Message);
                cboCategoria.Enabled = false;
                return;
            }
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
            DialogResult result =  MessageBox.Show("Tem certeza que deseja cancelar a operação?", "Cancelar", MessageBoxButtons.YesNo);
            
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
