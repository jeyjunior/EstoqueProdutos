using Estoque.Controladores;
using Estoque.Enums;
using Estoque.Telas_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Mensagens
{
    public partial class FrmMensagem : FrmBase
    {

        public RespostaCaixaDialogo Resultado { get; private set; } = RespostaCaixaDialogo.Nenhuma;

        public FrmMensagem()
        {
            InitializeComponent();

            btnAfirmacao.Click += btnAfirmacao_Click;
            btnNegacao.Click += btnNegacao_Click;
        }

        public void ExibirPergunta(string mensagem, string titulo = "Pergunta")
        {
            lblTitulo.Text = titulo;
            lblMensagem.Text = mensagem;

            btnNegacao.Visible = true;
            btnAfirmacao.Visible = true;

            btnNegacao.Text = "Não";
            btnAfirmacao.Text = "Sim";

            PadraoCor(TipoMensagem.Pergunta);
        }

        public void ExibirErro(string mensagem, string titulo = "Pergunta")
        {
            lblTitulo.Text = titulo;
            lblMensagem.Text = mensagem;

            btnNegacao.Visible = false;
            btnAfirmacao.Visible = true;

            btnAfirmacao.Text = "OK";

            PadraoCor(TipoMensagem.Erro);
        }

        private void PadraoCor(TipoMensagem tipoMensagem)
        {
            switch (tipoMensagem)
            {
                case TipoMensagem.Pergunta:
                    this.BackColor = Color.FromArgb(16, 23, 28);
                    pTopL.BackColor = Color.FromArgb(16, 23, 28);
                    pTopM.BackColor = Color.FromArgb(16, 23, 28);
                    pTopR.BackColor = Color.FromArgb(16, 23, 28);
                    lblTitulo.ForeColor = Color.White;
                    break;
                case TipoMensagem.Erro:
                    this.BackColor = Color.FromArgb(255, 88, 88);
                    pTopL.BackColor = Color.FromArgb(255, 88, 88);
                    pTopM.BackColor = Color.FromArgb(255, 88, 88);
                    pTopR.BackColor = Color.FromArgb(255, 88, 88);
                    lblTitulo.ForeColor = Color.Black;

                    break;
                default:
                    break;
            }
        }

        private void btnAfirmacao_Click(object sender, EventArgs e)
        {
            Resultado = RespostaCaixaDialogo.Sim;
            this.Close();
        }

        private void btnNegacao_Click(object sender, EventArgs e)
        {
            Resultado = RespostaCaixaDialogo.Não;
            this.Close();
        }
    }
}
