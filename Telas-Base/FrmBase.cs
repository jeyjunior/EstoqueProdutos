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
    public partial class FrmBase : Form, IFrmBase
    {
        protected IFrmGestor FrmGestor { get; set; }

        public FrmBase()
        {
            InitializeComponent();
        }

        public FrmBase(IFrmGestor frmGestor) : this()
        {
            FrmGestor = frmGestor;
        }



    }
}
