using Estoque.Controladores;
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
        public enum Resposta { Nenhuma, Afirmacao, Negacao }
        public enum TipoMensagem { Pergunta, Erro }
        public Resposta Resultado { get; private set; } = Resposta.Nenhuma;


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
                    this.BackColor = Color.FromArgb(255, 255, 132);
                    pTopL.BackColor = Color.FromArgb(255, 255, 132);
                    pTopM.BackColor = Color.FromArgb(255, 255, 132);
                    pTopR.BackColor = Color.FromArgb(255, 255, 132);
                    break;
                case TipoMensagem.Erro:
                    this.BackColor = Color.FromArgb(255, 88, 88);
                    pTopL.BackColor = Color.FromArgb(255, 88, 88);
                    pTopM.BackColor = Color.FromArgb(255, 88, 88);
                    pTopR.BackColor = Color.FromArgb(255, 88, 88);
                    break;
                default:
                    break;
            }
        }

        private void btnAfirmacao_Click(object sender, EventArgs e)
        {
            Resultado = Resposta.Afirmacao;
            this.Close();
        }

        private void btnNegacao_Click(object sender, EventArgs e)
        {
            Resultado = Resposta.Negacao;
            this.Close();
        }
    }
}
