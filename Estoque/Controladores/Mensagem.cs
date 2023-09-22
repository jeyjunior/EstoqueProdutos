using Estoque.Telas_Mensagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Controladores
{
    public class Mensagem
    {
        private Control parentControl;

        public Mensagem(Control parentControl)
        {
            this.parentControl = parentControl;
        }

        public bool Erro(string mensagem, string titulo = "Erro")
        {
            UCMensagem mensagemControl = new UCMensagem(this);
            parentControl.Controls.Add(mensagemControl);
            mensagemControl.ExibirPergunta(mensagem, titulo);

            if (mensagemControl.Disposing)
                parentControl.Controls.Remove(mensagemControl);
            return mensagemControl.Resultado == UCMensagem.Resposta.Afirmacao;
        }
        public bool Pergunta(string mensagem, string titulo = "Pergunta")
        {
            UCMensagem mensagemControl = new UCMensagem(this);
            parentControl.Controls.Add(mensagemControl);
            mensagemControl.ExibirPergunta(mensagem, titulo);

            if (mensagemControl.Disposing)
                parentControl.Controls.Remove(mensagemControl);
            return mensagemControl.Resultado == UCMensagem.Resposta.Afirmacao;
        }
    }
}
