
using EstoqueProdutos.Telas_Produtos;
using System.Collections.Generic;

namespace EstoqueProdutos
{
    public partial class MainForm : Form
    {
        Dictionary<string, Form> formsAberto = new Dictionary<string, Form>();
        int maxFormsAberto = 3;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Metodos
        private void AbrirFormulario(string formNome, Func<Form> formCriador)
        {
            if (formsAberto.Count >= maxFormsAberto)
                return;

            if (formsAberto.ContainsKey(formNome))
            {
                formsAberto[formNome].Focus();
                return;
            }

            Form form = formCriador();
            formsAberto.Add(formNome, form);
            form.FormClosed += RemoverFormDosAbertos_FormClosed;
            form.Show();
        }

        #endregion Metodos

        #region Eventos
        private void RemoverFormDosAbertos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formsAberto.Remove(((Form)sender).Name);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormulario("FrmProdutos", () => new FrmProdutos());
        }

        #endregion Eventos
    }
}