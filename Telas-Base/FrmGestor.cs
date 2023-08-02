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

        public void AbrirFilho<T>() where T : FrmBase, IFrmBase, new()
        {
            Type tipoT = typeof(T);
            FrmBase? filhoEncontrado = filhosInstanciados.FirstOrDefault(f => f.GetType() == tipoT);
            
            if (filhoEncontrado == null)
            {
                var novoFilho = new T();
                filhosInstanciados.Add(novoFilho);

                novoFilho.ObterFrmGestor(this);
                novoFilho.Show();
            }
            else
            {
                filhoEncontrado.Focus();
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



        //public void FecharFilho<T>() where T : FrmBase, IFrmBase
        //{
        //    Type tipoT = typeof(T);
        //    FrmBase? filhoEncontrado = filhosInstanciados.FirstOrDefault(f => f.GetType() == tipoT);

        //    if (filhoEncontrado != null)
        //    {
        //        filhosInstanciados.Remove(filhoEncontrado);
        //        filhoEncontrado.Close();
        //    }
        //}
    }
}
