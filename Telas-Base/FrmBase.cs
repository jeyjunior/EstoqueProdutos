using EstoqueProdutos.Interfaces.Telas;
using EstoqueProdutos.Telas_Produto;
using System;
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
    public partial class FrmBase : Form, IFrmBase
    {
        protected IFrmGestor FrmGestor { get; set; }

        public FrmBase()
        {
            InitializeComponent();
        }

        public void ObterFrmGestor(IFrmGestor frmGestor)
        {
            FrmGestor = frmGestor;
        }

        protected virtual void Fechar()
        {
            Type tipoClasseHerdeira = this.GetType();
            MethodInfo metodoFecharFilho = FrmGestor.GetType().GetMethod("FecharFilho");
            metodoFecharFilho.Invoke(FrmGestor, new object[] { tipoClasseHerdeira });
        }


    }
}
