using EstoqueProdutos.Interfaces;
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
    public partial class FrmGerenciadorDeTelas : FrmBase
    {
        protected List<UserControl> telasInstanciadas = new List<UserControl>();
        protected Panel panelCentralGerenciador;

        public FrmGerenciadorDeTelas()
        {
            InitializeComponent();
        }

        protected virtual void AbrirTela<T>(Panel panelCentral = null) where T : UserControl,  new()
        {
            try
            {
                this.panelCentralGerenciador = panelCentral;

                if (this.panelCentralGerenciador == null)
                {
                    throw new Exception("O painel central não foi fornecido.");
                }

                Type tipoT = typeof(T);
                UserControl? telaEncontrada = telasInstanciadas.FirstOrDefault(f => f.GetType() == tipoT);

                if (telaEncontrada != null)
                {
                    if (!this.panelCentralGerenciador.Controls.Contains(telaEncontrada))
                    {
                        this.panelCentralGerenciador.Controls.Clear();
                        this.panelCentralGerenciador.Controls.Add(telaEncontrada);
                        return;
                    }
                }
                else 
                {
                    var telaNova = new T();
                    telasInstanciadas.Add(telaNova);

                    this.panelCentralGerenciador.Controls.Clear();
                    this.panelCentralGerenciador.Controls.Add(telaNova);
                    telaNova.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao abrir telas!");
            }
        }

        protected virtual void AbrirTela(Type userControlType, Panel panelCentral = null)
        {
            try
            {
                this.panelCentralGerenciador = panelCentral;

                if (this.panelCentralGerenciador == null)
                {
                    throw new Exception("O painel central não foi fornecido.");
                }

                UserControl? telaEncontrada = telasInstanciadas.FirstOrDefault(f => f.GetType() == userControlType);

                telasInstanciadas.ForEach(f => f.Visible = false);

                if (telaEncontrada != null)
                {
                    this.panelCentralGerenciador.Controls.Clear();
                    this.panelCentralGerenciador.Controls.Add(telaEncontrada);
                    telaEncontrada.Visible = true;
                }
                else
                {
                    UserControl newUserControl = (UserControl)Activator.CreateInstance(userControlType);
                    telasInstanciadas.Add(newUserControl);

                    this.panelCentralGerenciador.Controls.Clear();
                    this.panelCentralGerenciador.Controls.Add(newUserControl);
                    newUserControl.Show();
                    newUserControl.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao abrir telas!");
            }
        }

    }
}
