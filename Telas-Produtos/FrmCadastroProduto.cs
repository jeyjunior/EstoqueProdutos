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
        private bool Cadastrar()
        {
            try
            {
                ((Imagem)pcbImagem.Tag).PK_ID = ManipularImagem.GuardarImagem(pcbImagem);

                txtNome.Text = txtNome.Text.SanitizarTexto(30).PrimeiraLetraMaiuscula();
                txtDescri.Text = txtDescri.Text.SanitizarTexto(90);

                string? preco = txtPreco.RemoverMascarDinheiro();
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
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro: \n\n" + Pr_GuardarProduto.ErroMensagem);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \n\n" + ex.Message);
                return false;
            }

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
        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            cboUnidadeMedida.ObterData(Pr_ObterUnidadeMedida.Obter(), btnCadastrar);
            cboFornecedor.ObterData(Pr_ObterFornecedor.Obter(), btnCadastrar);
            cboCategoria.ObterData(pr_ObterCategoria.Obter(), btnCadastrar);
            cboEmbalagem.ObterData(Pr_ObterEmbalagem.Obter(), btnCadastrar);

            pcbImagem.ObterImagemStandard();

            HabilitarComponente.DesabilitarBtnCadastrar(btnCadastrar);
        }

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
            ((TextBox)sender).AplicarMascaraDinheiro();
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).RemoverMascarDinheiro();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control componente in gpbDadosProduto.Controls)
            {
                if (componente is TextBox)
                    ((TextBox)componente).Clear();

                if (componente is ComboBox)
                    ((ComboBox)componente).SelectedIndex = 0;
            }

            pcbImagem.ObterImagemStandard();
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            ((TextBox)sender).AplicarMascaraVolume(e);
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

        private void txtVolume_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.LimitarCasasDecimais(2);
        }
        #endregion Eventos

    }
}
