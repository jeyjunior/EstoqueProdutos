using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Principal
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void UCLogin_SizeChanged(object sender, EventArgs e)
        {
            pCentral.Size = ObterTamanhoPanelCentral();

            int locX = Convert.ToInt32((this.Size.Width - pCentral.Width) / 2);
            int locY = Convert.ToInt32((this.Size.Height - pCentral.Height) / 2);
            pCentral.Location = new Point(locX, locY);
        }

        private Size ObterTamanhoPanelCentral()
        {
            int sizeX = 0;
            int sizeY = 0;

            if (this.Size.Width >= 1680)
            {
                sizeX = 460;
                sizeY = 660;
            }
            else
            {
                sizeX = 320;
                sizeY = 460;
            }

            return new Size(sizeX, sizeY);
        }
    }
}
