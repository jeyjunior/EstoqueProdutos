using Estoque.Enums;
using Estoque.Telas_Mensagens;

namespace Estoque.Controladores
{
    public static class Mensagem
    {
        public static RespostaCaixaDialogo Erro(string mensagem, string titulo = "Pergunta")
        {
            FrmMensagem frmMensagem = new FrmMensagem();
            frmMensagem.ExibirErro(mensagem, titulo);
            frmMensagem.ShowDialog();

            return frmMensagem.Resultado;
        }

        public static RespostaCaixaDialogo Pergunta(string mensagem, string titulo = "Pergunta")
        {
            FrmMensagem frmMensagem = new FrmMensagem();
            frmMensagem.ExibirPergunta(mensagem, titulo);
            frmMensagem.ShowDialog();

            return frmMensagem.Resultado;
        }
    }
}
