using Azure.Core;
using EP.Data.Entidades;
using EP.Data.Interfaces;
using EP.Data.Repositorios;
using Estoque.Interfaces;
using EstoqueProdutos.Gerenciamento;
using JJ.Helpers.Formatacao;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Usuario
{
    public partial class FrmCadastrarSetorCargo : Estoque.Telas_Base.FrmGerenciadorDeTelas
    {
        public FrmCadastrarSetorCargo(IUCGerenciadorDeTelas gerenciadorDeTelas)
        {
            InitializeComponent();

            this.gerenciadorDeTelas = gerenciadorDeTelas;
        }


        #region Eventos


        private void FrmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            btnSetor.PerformClick();
        }

        #endregion Eventos


        private void btnSetor_Click(object sender, EventArgs e)
        {
            AlterarCorDoBotaoSelecionado((Button)sender);
            AbrirTela(typeof(UCSetor), pnCentral);
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            AlterarCorDoBotaoSelecionado((Button)sender);
            AbrirTela(typeof(UCCargo), pnCentral);
        }

        private void AlterarCorDoBotaoSelecionado(Button botaoAtivo)
        {
            foreach (Button button in tab.Controls.OfType<Button>())
            {
                button.BackColor = Color.FromArgb(32, 46, 56);
            }

            botaoAtivo.BackColor = Color.FromArgb(80, 90, 100);
        }
    }
}
