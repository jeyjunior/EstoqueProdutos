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
    public partial class FrmCadastroProduto : Form
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        #region Metodos

        #region Carregar dados dos Componentes

        private void CarregarDadosDosComponentes()
        {
            Tabela.ObterData(Pr_ObterUnidadeMedida.Obter(), cboUnidadeMedida, btnCadastrar);
            Tabela.ObterData(Pr_ObterFornecedor.Obter(), cboFornecedor, btnCadastrar);
            Tabela.ObterData(pr_ObterCategoria.Obter(), cboCategoria, btnCadastrar);
            Tabela.ObterData(Pr_ObterEmbalagem.Obter(), cboEmbalagem, btnCadastrar);

            pcbImagem.ObterImagemStandard();

            HabilitarComponente.DesabilitarBtnCadastrar(btnCadastrar);
        }

        #endregion Carregar dados dos Componentes

        private bool Cadastrar()
        {
            ((Imagem)pcbImagem.Tag).PK_ID = ManipularImagem.GuardarImagem(pcbImagem);

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
            produto.FK_Imagem_ID = ((Imagem)pcbImagem.Tag).PK_ID;
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
            pcbImagem.BuscarImagemRepositorioLocal();
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

            pcbImagem.ObterImagemStandard();
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
