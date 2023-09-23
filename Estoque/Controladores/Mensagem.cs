using Estoque.Telas_Mensagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static Estoque.Telas_Mensagens.FrmMensagem;

namespace Estoque.Controladores
{
    public static class Mensagem
    {
        public static bool Erro(string mensagem, string titulo = "Pergunta")
        {
            FrmMensagem frmMensagem = new FrmMensagem();
            frmMensagem.ExibirErro(mensagem, titulo);
            frmMensagem.ShowDialog();

            Resposta resultado = frmMensagem.Resultado;

            return resultado == Resposta.Afirmacao;
        }

        public static bool Pergunta(string mensagem, string titulo = "Pergunta")
        {
            FrmMensagem frmMensagem = new FrmMensagem();
            frmMensagem.ExibirPergunta(mensagem, titulo);
            frmMensagem.ShowDialog();

            Resposta resultado = frmMensagem.Resultado;

            return resultado == Resposta.Afirmacao;
        }
    }
}
