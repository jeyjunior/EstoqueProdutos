using Estoque.Interfaces;
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
    public partial class UCGerenciadorDeTelas : UCBase, IUCGerenciadorDeTelas
    {
        public UCGerenciadorDeTelas()
        {
            InitializeComponent();
        }

        public List<Form> FormsInstanciados { get; } =new List<Form>();

        public void AbrirTela(Type tela, IUCGerenciadorDeTelas ucGestor) 
        {
            try
            {
                var telaEncontrada = FormsInstanciados.FirstOrDefault(f => f.GetType() == tela);

                if (telaEncontrada != null)
                {
                    telaEncontrada.Focus();
                }
                else
                {
                    Form novaTela = (Form)Activator.CreateInstance(tela, ucGestor);
                    FormsInstanciados.Add(novaTela);
                    novaTela.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma falha ao tentar abrir tela.\nErro: " + ex.Message);
            }
        }

        public void FecharTela(Type tipoTela)
        {
            var telaEncontrada = FormsInstanciados.FirstOrDefault(f => f.GetType() == tipoTela);

            if (telaEncontrada != null)
            {
                FormsInstanciados.Remove(telaEncontrada);
                telaEncontrada.Close();
            }
        }
    }
}

//public void AbrirTela<T>(IUCGerenciadorDeTelas ucGestor) where T : Form, new()
        //{
        //    var tela = typeof(T);
        //    var telaEncontrada = FormsInstanciados.FirstOrDefault(f => f.GetType() == tela);

        //    if (telaEncontrada != null)
        //    {
        //        telaEncontrada.Focus();
        //    }
        //    else 
        //    {
        //        var telaNova = new T();

        //        if(telaNova is IFecharFormularioBase fecharFormulario) 
        //        {
        //            fecharFormulario.ObterGerenciadorTelas(this);
        //        }

        //        FormsInstanciados.Add(telaNova);
        //        telaNova.Show();
        //    }
        //}