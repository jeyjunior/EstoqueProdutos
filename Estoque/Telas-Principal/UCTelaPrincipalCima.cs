
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
    public partial class UCTelaPrincipalCima : Estoque.Telas_Base.UCBase, IUCTelaPrincipalCima
    {
        public UCTelaPrincipalCima()
        {
            InitializeComponent();
            AtualizarPropriedades();
        }
    }
}
