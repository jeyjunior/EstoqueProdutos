using Estoque.Telas_Mensagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.GerenciamentoTelas
{
    public static class Alerta
    {
        /// <summary>
        /// Vermelho. Alerta sobre algum erro simples
        /// </summary>
        /// <param name="mensagem"></param>
        public static void Erro(string mensagem)
        {
            UCAlertas uCAlertas = new UCAlertas(mensagem, Enums.Alertas.Erro);
            ExibirAlerta(uCAlertas);
        }

        /// <summary>
        /// Verde. Confirmar uma ação
        /// </summary>
        /// <param name="mensagem"></param>
        public static void Confirmacao(string mensagem)
        {
            UCAlertas uCAlertas = new UCAlertas(mensagem, Enums.Alertas.Confirmacao);
            ExibirAlerta(uCAlertas);
        }

        /// <summary>
        /// Amarelo. Alertar sobre alguma ação
        /// </summary>
        /// <param name="mensagem"></param>
        public static void Aviso(string mensagem)
        {
            UCAlertas uCAlertas = new UCAlertas(mensagem, Enums.Alertas.Aviso);
            ExibirAlerta(uCAlertas);
        }

        /// <summary>
        /// Azul. 
        /// </summary>
        /// <param name="mensagem"></param>
        public static void Informacao(string mensagem)
        {
            UCAlertas uCAlertas = new UCAlertas(mensagem, Enums.Alertas.Informacao);
            ExibirAlerta(uCAlertas);
        }

        private static void ExibirAlerta(UCAlertas ucAlertas)
        {
            Form formularioAtivo = Form.ActiveForm;

            if(formularioAtivo != null) 
            {
                formularioAtivo.Controls.Add(ucAlertas);
                ucAlertas.Location = new Point((formularioAtivo.Width - ucAlertas.Width) / 2,20);

                ucAlertas.BringToFront();
                ucAlertas.Show();
            }
        }
    }
}
