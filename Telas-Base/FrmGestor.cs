using EstoqueProdutos.Interfaces.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueProdutos.Telas_Base
{
    public partial class FrmGestor : Telas_Base.FrmBase, IFrmGestor
    {
        protected List<FrmBase> filhosInstanciados = new List<FrmBase>();
        protected virtual void AbrirFilho<T>() where T : FrmBase, IFrmBase, new()
        {
            Type tipoT = typeof(T);
            FrmBase? filhoEncontrado = filhosInstanciados.FirstOrDefault(f => f.GetType() == tipoT);
            if(filhoEncontrado == null)
            {
                var novoFilho = new T();
                filhosInstanciados.Add(novoFilho);
                novoFilho.Show();
            }
            else
            {
                filhoEncontrado.Focus();
            }
        }


        protected int limiteMaxFilhosInstanciados = 2;

        public FrmGestor()
        {
            InitializeComponent();
        }

        protected virtual void FecharFilho(FrmBase frmBase, string frmNome)
        {
            
        }


    }
}
