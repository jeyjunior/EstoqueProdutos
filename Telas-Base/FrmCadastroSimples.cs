using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using Polly.Timeout;
using Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueProdutos.Telas_Base
{
    public partial class FrmCadastroSimples : Telas_Base.FrmBase
    {
        object repositorio;
        object entidade;

        public FrmCadastroSimples()
        {
            InitializeComponent();
        }

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
            if (txtNome.TextLength > 0)
            {
                btnSalvar.Enabled = true;
                btnSalvar.BackColor = Color.Green;
                btnSalvar.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                btnSalvar.Enabled = false;
                btnSalvar.BackColor = Color.LightGray;
                btnSalvar.FlatAppearance.BorderColor = Color.LightGray;
            }
        }

        private void FrmCadastroSimples_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.LimparTexto();
            string descricao = txtDescricao.Text.LimparTexto();

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

        private void txtNomeMarca_TextChanged(object sender, EventArgs e)
        {
            HabilitarComponentes();
        }
    }
}
