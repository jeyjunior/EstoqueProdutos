using Estoque.Enums;
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
    public partial class UCAlertas : UserControl
    {
        private int duracao = 4000; /* milliseconds */

        public UCAlertas(string mensagem, Alertas tipoAlerta, int duracao = 4000)
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;
            this.duracao = duracao;

            ConfigurarTipoAlerta(tipoAlerta);
        }

        private void ConfigurarTipoAlerta(Alertas tipoAlerta)
        {
            switch (tipoAlerta)
            {
                case Alertas.Erro:
                    this.BackColor = Color.FromArgb(255, 88, 88);
                    break;
                case Alertas.Aviso:
                    this.BackColor = Color.FromArgb(255, 255, 132);
                    break;
                case Alertas.Confirmacao:
                    this.BackColor = Color.FromArgb(87, 222, 110);
                    break;
                case Alertas.Informacao:
                    this.BackColor = Color.FromArgb(81, 140, 173);
                    break;
                default:
                    throw new Exception();
            }
        }

        private void UCFeedback_Load(object sender, EventArgs e)
        {
            FecharMensagem();
        }

        private async void FecharMensagem()
        {
            await Task.Delay(duracao);
            this.Dispose();
        }
    }
}
