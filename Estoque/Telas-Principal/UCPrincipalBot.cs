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

namespace Estoque.Telas_Principal
{
    public partial class UCPrincipalBot : Estoque.Telas_Base.UCBase, IUCPrincipalBot
    {
        public UCPrincipalBot()
        {
            InitializeComponent();
            AtualizarPropriedades();
        }
    }
}
