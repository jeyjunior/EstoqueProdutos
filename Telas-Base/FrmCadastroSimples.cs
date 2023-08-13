using System.Reflection;
using EP.Data;
using EstoqueProdutos.Formatacao;

namespace EstoqueProdutos.Telas_Base
{
    /// <summary>
    /// Formulario que sera utilizado por qualquer tabela para inserir dados simples
    /// </summary>
    public partial class FrmCadastroSimples : Telas_Base.FrmBase
    {
        private object repositorio;
        private object entidade;

        public FrmCadastroSimples()
        {
            InitializeComponent();
        }

        #region Metodos



        public void ObterRepositorio<T>() where T : class
        {
            repositorio = Activator.CreateInstance<T>();
        }

        public void ObterEntidade<T>() where T : class
        {
            entidade = Activator.CreateInstance<T>();

            if (entidade != null)
            {
                this.Text = $"Cadastrar {entidade.GetType().Name}";

                string nome = entidade.GetType().Name;

                if (nome[nome.Length - 1] == 'o' || nome[nome.Length - 1] == 'O')
                {
                    lblNome.Text = $"Nome do {nome}";
                    lblDescricao.Text = $"Descrição do {nome}";
                }
                else
                {
                    lblNome.Text = $"Nome da {nome}";
                    lblDescricao.Text = $"Descrição da {nome}";
                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();

            txtNome.Focus();
            HabilitarComponentes();
        }

        private void HabilitarComponentes()
        {
            btnSalvar.Enabled = txtNome.TextLength > 0;
        }

        #endregion Metodos

        #region Eventos

        private void FrmCadastroSimples_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string? nome = txtNome.LimparTexto();
            string? descricao = txtDescricao.LimparTexto();

            PropertyInfo[] prop = entidade.GetType().GetProperties();

            prop.ToList().ForEach(p =>
            {
                if (p.Name == "Nome")
                {
                    if (entidade.GetType().GetProperty("Nome") is PropertyInfo pNome &&
                    pNome.PropertyType == typeof(string))
                    {
                        pNome.SetValue(entidade, nome);
                    }
                }
                else if (p.Name == "Descricao")
                {
                    if (entidade.GetType().GetProperty("Descricao") is PropertyInfo pDesc &&
                            pDesc.PropertyType == typeof(string))
                    {
                        pDesc.SetValue(entidade, descricao);
                    }
                }
            });

            if (repositorio.GetType().GetMethod("InserirDadosNaTabela") is MethodInfo metodo)
            {
                object? resultado = metodo.Invoke(repositorio, new object[] { entidade });

                if (resultado != null && (bool)resultado)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Falha no cadastro!");
                    txtNome.Focus();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_EnabledChanged(object sender, EventArgs e)
        {
            Formatacao
            .Eventos
            .AlterarCorButton_EnabledChanged((Button)sender, Color.Green, Color.LightGray, e);
        }
        
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            HabilitarComponentes();
        }
        
        #endregion Eventos
    }
}
