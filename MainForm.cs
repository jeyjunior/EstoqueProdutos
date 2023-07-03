using System.Data;

namespace EstoqueProdutos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable result = SQLServer.Procedures.PesquisarProduto.ObterTodosProdutos();

            if (result.Rows.Count > 0)
                foreach (DataRow row in result.Rows)
                    dtgProdutos.Rows.Add(row[0], row[1], row[3], row[4], "R$ " + row[2], row[5]);

            AtualizarLabelContagem();
        }

        private void dtgProdutos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarLabelContagem();
        }

        private void AtualizarLabelContagem()
        {
            lblContagem.Text = "Total de produtos: " + dtgProdutos.Rows.Count;
        }
    }
}