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
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        #region Metodos

        #region BuscarImagem, GuardarImagem
        protected int? GuardarImagem(PictureBox pictureBox)
        {
            return 0;

        }

        private void BuscarImagemRepositorioLocal()
        {
            Imagem imagem = new Imagem();

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Imagens PNG e JPEG|*.png;*.jpeg;*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = openFileDialog.FileName;


                    imagem.Nome = Path.GetFileNameWithoutExtension(caminhoArquivo).PrimeiraLetraMaiuscula();
                    imagem.Formato = Path.GetExtension(caminhoArquivo).FormatarNomeDoFormatoImagem();
                    
                    pcbImagem.Image = Image.FromFile(caminhoArquivo);
                    pcbImagem.Tag = null;
                    pcbImagem.Tag = imagem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar imagens!\nErro: " + ex.Message);
            }
        }

        #endregion Imagem

        #region Carregar dados dos Componentes

        protected void CarregarDadosDosComponentes()
        {
            //Tabela.ObterData(Pr_ObterFornecedor.Obter(), cboBase, btnBase);
            

            ManipularImagem.ObterImagemStandard(pcbImagem);

            HabilitarComponente.DesabilitarBtnCadastrar(btnBase);
        }

        #endregion Carregar dados dos Componentes


        #endregion Metodos

        #region Eventos

        protected void pcbImagem_Click(object sender, EventArgs e)
        {
            BuscarImagemRepositorioLocal();
        }

        protected void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarDadosDosComponentes();
        }

        protected void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TextBox = ((TextBox)sender);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (TextBox.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
        }

        protected void txtPreco_Leave(object sender, EventArgs e)
        {
            //TextBox TextPreco = ((TextBox)sender);

            //if (!String.IsNullOrEmpty(TextPreco.Text))
            //{
            //    TextPreco.Text = TextPreco.Text.RemoverMascarDinheiro();
            //    decimal preco = Convert.ToDecimal(TextPreco.Text);
            //    TextPreco.Text = Math.Round(preco, 2).ToString();
            //    TextPreco.Text = TextPreco.Text.AplicarMascaraDinheiro();
            //}
        }

        protected void txtPreco_Enter(object sender, EventArgs e)
        {
            //((TextBox)sender).Text = ((TextBox)sender).Text.RemoverMascarDinheiro();
        }

        protected void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TextBox = ((TextBox)sender);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (TextBox.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;

        }


        #endregion Eventos


    }
}
