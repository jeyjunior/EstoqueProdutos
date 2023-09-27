using EP.Data.Entidades;
using Estoque.Telas_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Produto
{
    public partial class FrmConfigurarColunas : FrmBase
    {
        private ColunasGridProdutos colunasGridProdutos;
        public FrmConfigurarColunas()
        {
            InitializeComponent();

            colunasGridProdutos = new ColunasGridProdutos();
        }

        private void pcb_Click(object sender, EventArgs e)
        {
            string componentName = ((Control)sender).Name;
            var properties = typeof(ColunasGridProdutos).GetProperties();

            foreach (var property in properties)
            {
                if (property.Name == componentName)
                {
                    var currentValue = (bool)property.GetValue(colunasGridProdutos);
                    property.SetValue(colunasGridProdutos, !currentValue);
                }
            }
        }
    }
}
