using EstoqueProdutos.Interfaces.Telas;
using EstoqueProdutos.Telas_Base;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueProdutos.Telas_Base
{
    public partial class FrmGestor : Telas_Base.FrmBase, IFrmGestor
    {
        protected List<FrmBase> filhosInstanciados = new List<FrmBase>();

        protected int limiteMaxFilhosInstanciados = 2;

        public FrmGestor()
        {
            InitializeComponent();
        }


        protected virtual void AbrirFilho<T>(EventHandler? e = null) where T : FrmBase, IFrmBase, new()
        {
            try
            {
                Type tipoT = typeof(T);
                FrmBase? filhoEncontrado = filhosInstanciados.FirstOrDefault(f => f.GetType() == tipoT);

                if (filhoEncontrado == null)
                {
                    var novoFilho = new T();
                    filhosInstanciados.Add(novoFilho);

                    novoFilho.ObterFrmGestor(this);
                    novoFilho.FormClosed += FrmBase_FormClosed;

                    if (e != null)
                        novoFilho.FormClosed += new FormClosedEventHandler(e);

                    novoFilho.Show();
                }
                else
                {
                    filhoEncontrado.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao abrir telas!");
            }
        }

        public void FecharFilho(Type tipoClasseHerdeira)
        {
            FrmBase? filhoEncontrado = filhosInstanciados.FirstOrDefault(f => f.GetType() == tipoClasseHerdeira);

            if (filhoEncontrado != null)
            {
                filhosInstanciados.Remove(filhoEncontrado);
                filhoEncontrado.Close();
            }
        }

        private void FrmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is FrmBase frmBase)
            {
                frmBase.FecharTela();
            }
        }
    }
}
