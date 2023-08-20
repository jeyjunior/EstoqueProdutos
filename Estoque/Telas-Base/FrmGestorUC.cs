using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Telas_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Base
{
    public partial class FrmGestorUC : Form
    {
        protected List<UserControl> telasInstanciadas = new List<UserControl>();
        protected Panel panelCentral;

        public FrmGestorUC()
        {
            InitializeComponent();
        }

        protected virtual void AbrirTela<T>(Panel panelCentral = null) where T : UserControl,  new()
        {
            try
            {
                if (panelCentral != null)
                {
                    this.panelCentral = panelCentral;
                }
                else
                {
                    throw new Exception();
                }


                Type tipoT = typeof(T);
                UserControl? telaEncontrada = telasInstanciadas.FirstOrDefault(f => f.GetType() == tipoT);

                if (telaEncontrada != null)
                {
                    if (!panelCentral.Controls.Contains(telaEncontrada))
                    {
                        panelCentral.Controls.Clear();
                        panelCentral.Controls.Add(telaEncontrada);
                        return;
                    }
                }
                else 
                {
                    var telaNova = new T();
                    telasInstanciadas.Add(telaNova);

                    panelCentral.Controls.Clear();
                    panelCentral.Controls.Add(telaNova);
                    telaNova.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao abrir telas!");
            }
        }

    }
}
