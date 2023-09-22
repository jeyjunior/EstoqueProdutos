using Estoque.Controladores;
using Estoque.Telas_Base;
using System;
using System.Windows.Forms;

namespace Estoque.Telas_Mensagens
{
    public partial class UCMensagem : UCBase
    {
        private Mensagem Mensagem { get; set; }

        public UCMensagem(Mensagem mensagem)
        {
            InitializeComponent();
            btnAfirmacao.Click += btnAfirmacao_Click;
            btnNegacao.Click += btnNegacao_Click;

            this.Mensagem = mensagem;
        }

        public enum Resposta { Nenhuma, Afirmacao, Negacao }
        public Resposta Resultado { get; private set; } = Resposta.Nenhuma;

        public void ExibirErro(string mensagem, string titulo = "Erro")
        {
            lblTitulo.Text = titulo;
            lblMensagem.Text = mensagem;

            btnNegacao.Visible = false;
            btnAfirmacao.Visible = true;
            btnAfirmacao.Text = "OK";
            Resultado = Resposta.Nenhuma;

            this.Show();
            this.BringToFront();
        }

        public void ExibirPergunta(string mensagem, string titulo = "Pergunta")
        {
            lblTitulo.Text = titulo;
            lblMensagem.Text = mensagem;

            btnNegacao.Visible = true;
            btnAfirmacao.Visible = true;

            btnNegacao.Text = "Não";
            btnAfirmacao.Text = "Sim";

            Resultado = Resposta.Nenhuma;

            this.Show();
            this.BringToFront();
        }

        private void btnAfirmacao_Click(object sender, EventArgs e)
        {
            Resultado = Resposta.Afirmacao;
            this.Dispose();
        }

        private void btnNegacao_Click(object sender, EventArgs e)
        {
            Resultado = Resposta.Negacao;
            this.Dispose();
        }
    }
}
