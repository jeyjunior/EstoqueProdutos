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
    public partial class UCTelaPrincipalBaixo : Estoque.Telas_Base.UCBase, IUCTelaPrincipalBaixo
    {
        public UCTelaPrincipalBaixo()
        {
            InitializeComponent();
            AtualizarPropriedades();
        }
    }
}
