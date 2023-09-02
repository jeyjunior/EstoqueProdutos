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
    public partial class UCBase : UserControl
    {
        public UCBase()
        {
        }

        protected virtual void AtualizarPropriedades() 
        {
            this.Dock = DockStyle.Fill;
            this.MaximumSize = new System.Drawing.Size(0, 0);
        }
    }
}
