using Estoque.Controladores;
using Estoque.Interfaces;
using Estoque.Telas_Produto;
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
        public List<Form> FormsInstanciados { get; } =new List<Form>();
        
        /// <summary>
        /// Passar algum tipo de objeto para os filhos instanciados
        /// Ex.: Passar usuario selecionado de um form pai para form filho
        /// </summary>
        public object ObjetoGenerico;
        public UCGerenciadorDeTelas()
        {
            InitializeComponent();
        }


        public void AbrirTela(Type tela, IUCGerenciadorDeTelas ucGestor, bool travarTela = false, FormClosedEventHandler eFecharFilho = null) 
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
                    Form telaNova = (Form)Activator.CreateInstance(tela, ucGestor);

                    FormsInstanciados.Add(telaNova);

                    telaNova.StartPosition = FormStartPosition.CenterScreen;
                    if(eFecharFilho != null)
                        telaNova.FormClosed += eFecharFilho;

                    if (travarTela)
                        telaNova.ShowDialog();
                    else
                        telaNova.Show();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message, "Falha ao abrir telas!");
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
        public object ObterObjetoGenerico()
        {
            return ObjetoGenerico;
        }

    }
}
