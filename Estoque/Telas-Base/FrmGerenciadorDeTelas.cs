using Estoque.Controladores;
using Estoque.Interfaces;
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
    /// <summary>
    /// Responsável por Abrir Telas e guardar suas referencias em uma coleção (enquanto ativas)
    /// </summary>
    public partial class FrmGerenciadorDeTelas : FrmBase
    {
        protected List<UserControl> telasInstanciadas = new List<UserControl>();
        //protected Control panelCentralGerenciador;

        public FrmGerenciadorDeTelas()
        {
            InitializeComponent();
        }

        protected virtual void AbrirTela<T>(Control control) where T : UserControl,  new()
        {
            try
            {
                Type tipoT = typeof(T);
                UserControl? telaEncontrada = telasInstanciadas.FirstOrDefault(f => f.GetType() == tipoT);

                if (telaEncontrada != null)
                {
                    if (!control.Controls.Contains(telaEncontrada))
                    {
                        control.Controls.Clear();
                        control.Controls.Add(telaEncontrada);
                        return;
                    }
                }
                else 
                {
                    var telaNova = new T();
                    telasInstanciadas.Add(telaNova);

                    control.Controls.Clear();
                    control.Controls.Add(telaNova);
                    telaNova.Show();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao abrir telas!");
            }
        }

        protected virtual void AbrirTela(Type userControlType, Control control, bool clearControl = false)
        {
            try
            {
                UserControl? telaEncontrada = telasInstanciadas.FirstOrDefault(f => f.GetType() == userControlType);
                telasInstanciadas.ForEach(f => f.Visible = false);
                
                if(clearControl)
                    control.Controls.Clear();


                if (telaEncontrada != null)
                {
                    control.Controls.Add(telaEncontrada);
                    telaEncontrada.Visible = true;
                }
                else
                {
                    UserControl newUserControl = (UserControl)Activator.CreateInstance(userControlType);
                    telasInstanciadas.Add(newUserControl);

                    control.Controls.Add(newUserControl);
                    newUserControl.Show();
                    newUserControl.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao abrir telas!");
            }
        }

        protected virtual void AbrirTela(Type userControlType, Control control, bool bringToFront = false, EventHandler eDisposed = null)
        {
            AbrirTela(userControlType, control, false);

            if(eDisposed != null)
            {
                UserControl? telaEncontrada = telasInstanciadas.FirstOrDefault(f => f.GetType() == userControlType);

                if (bringToFront)
                    telaEncontrada.BringToFront();

                telaEncontrada.Disposed += eDisposed;
            }
        }
    }
}
