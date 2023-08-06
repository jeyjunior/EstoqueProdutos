using EstoqueProdutos.Entidades;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using Polly.Timeout;
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

namespace EstoqueProdutos
{
    public partial class FrmCadastroSimples<T> : Telas_Base.FrmBase
    {
        private IRepositorio<T> repositorio;

        public FrmCadastroSimples(IRepositorio<T> repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void LimparCampos()
        {
            txtNomeMarca.Clear();
            txtDescricao.Clear();

            txtNomeMarca.Focus();
            HabilitarComponentes();
        }

        private void HabilitarComponentes()
        {
            if (txtNomeMarca.TextLength > 0)
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
            T entidade = GetEntidade();

            var resultado = repositorio.InserirDadosNaTabela(entidade);

            if (resultado)
            {
                LimparCampos();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar!");
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

        private T GetEntidade()
        {
            return PreencherEntidade();
        }

        private T PreencherEntidade()
        {
            T entidade = Activator.CreateInstance<T>();

            PropertyInfo propNome = typeof(T).GetProperty("Nome");
            PropertyInfo propDescricao = typeof(T).GetProperty("Descricao");

            if (propNome != null && propDescricao != null)
            {
                propNome.SetValue(entidade, txtNomeMarca.Text);
                propDescricao.SetValue(entidade, txtDescricao.Text);
            }

            return entidade;
        }
    }
}
