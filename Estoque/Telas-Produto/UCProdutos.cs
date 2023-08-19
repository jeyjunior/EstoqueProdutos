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
    public partial class UCProdutos : Estoque.Telas_Base.UCBase
    {
        public UCProdutos()
        {
            InitializeComponent();

            // Create a DataGridViewTextBoxColumn with the name "Teste" and add it to the DataGridView's columns
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Teste";
            dtgProdutos.Columns.Add(column);

            // Add rows to the DataGridView
            for (int i = 0; i < 5; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                dtgProdutos.Rows.Add(row);
            }

            // Set the "Teste" cell value for each row
            foreach (DataGridViewRow row in dtgProdutos.Rows)
            {
                row.Cells["Teste"].Value = "Teste";
            }
        }
    }
}
