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
using System.Text;

namespace EstoqueProdutos.Telas_Produtos
{
    public partial class FrmPesquisar : Form
    {
        public FrmPesquisar()
        {
            InitializeComponent();
        }

        #region Metodos



        #endregion Metodos

        #region Eventos

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            cboUnidadeMedida.AtribuirData(Pr_ObterUnidadeMedida.Obter());
            cboFornecedor.AtribuirData(Pr_ObterFornecedor.Obter());
            cboCategoria.AtribuirData(Pr_PesquisarCategoria.Obter());
            cboEmbalagem.AtribuirData(Pr_PesquisarEmbalagem.Obter());

            cboOperadorPreco.AtribuirDataOperador(Pr_PesquisarOperador.ObterOperadorSimples());
            cboOperadorVolume.AtribuirDataOperador(Pr_PesquisarOperador.ObterOperadorSimples());
        }

        private void MascaraCasasDecimais_KeyPress(object sender, KeyPressEventArgs e)
        {
            ((TextBox)sender).AplicarMascaraNumerosComCasasDecimais(e);
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).AplicarMascaraDinheiro();
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).RemoverMascarDinheiro();
        }

        private void txtVolume_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.LimitarCasasDecimais(2);
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
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string valorPesquisa = txtNome.Text.Trim();
            string customFilter = "'%" + valorPesquisa + "%'";

            if (!String.IsNullOrWhiteSpace(txtPreco.Text))
            {
                string preco = txtPreco.RemoverMascarDinheiro();
                preco = preco.TrocarVirgulaPorPonto();
                customFilter += "    AND PRECO_UNITARIO " + ObterTipoOperador(cboOperadorPreco) + " " + preco;
            }

            DataTable dt = Pr_PesquisarProduto.Obter(customFilter);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private string ObterTipoOperador(ComboBox cbo)
        {
            DataRowView row = (DataRowView)cbo.SelectedItem;
            return row["Sigla"].ToString();
        }

        #endregion Eventos

        private void cboOperadorPreco_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = ObterTipoOperador((ComboBox)sender);

            if (item == "n")
            {
                txtPreco.Clear();
                txtPreco.Enabled = false;
                return;
            }

            txtPreco.Enabled = true;
        }
    }
}
//if (!String.IsNullOrWhiteSpace(txtPreco.Text))
//{
//    string cmdPreco = "    AND PRECO_UNITARIO ";
//    string preco_unitario = txtPreco.RemoverMascarDinheiro();
//    var operadorSelecionado = ObterTipoOperador(cboOperadorPreco);


//    if (String.IsNullOrWhiteSpace(operadorSelecionado))
//    {
//        customFilter.AppendLine(cmdPreco + " > " + preco_unitario );
//    }
//    else
//    {
//        customFilter.AppendLine(cmdPreco + operadorSelecionado + preco_unitario);
//    }
//}