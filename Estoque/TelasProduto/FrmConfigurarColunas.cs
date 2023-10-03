using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
using Estoque.Telas_Base;
using EstoqueProdutos;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Repositorios;
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

namespace Estoque.Telas_Produto
{
    public partial class FrmConfigurarColunas : FrmBase
    {
        private readonly IConfigColunasProdutoRepositorio configColunasProdutoRepositorio;
        private readonly IUsuarioLogado usuarioLogado;

        private ConfigColunasProduto? colunasGridProdutos;

        public FrmConfigurarColunas(IUCGerenciadorDeTelas gerenciadorDeTelas) : base(gerenciadorDeTelas)
        {
            InitializeComponent();

            configColunasProdutoRepositorio = DIRepositorios.Container.GetInstance<IConfigColunasProdutoRepositorio>();
            usuarioLogado = DITelas.Container.GetInstance<IUsuarioLogado>();
        }

        private void InicializarObjConfiguracao()
        {
            var usario = usuarioLogado.ObterUsuarioLogado();
            colunasGridProdutos = configColunasProdutoRepositorio.ObterTabela().FirstOrDefault(c => c.FK_Usuario.Equals(usario.PK_Usuario));
        }

        private void InicializarPictureBoxs()
        {
            foreach (Control control in tlpColunas.Controls)
            {
                if (control is PictureBox pcb)
                {
                    string nomeComponente = pcb.Name.Replace("pcb", "");
                    var propriedades = colunasGridProdutos.GetType().GetProperties();

                    propriedades.ToList().ForEach(p =>
                    {
                        if (p.Name == nomeComponente)
                        {
                            var valor = (bool)p.GetValue(colunasGridProdutos);
                            pcb.Image = valor ? Properties.Resources.chk_checked_32x32 : Properties.Resources.chk_uncheck_32x32;
                        }
                    });
                }
            }
        }

        private void pcb_Click(object sender, EventArgs e)
        {
            var pcb = ((Control)sender) as PictureBox;

            if (pcb != null)
            {
                string componentName = ((Control)sender).Name.Replace("pcb", "");
                var properties = typeof(ConfigColunasProduto).GetProperties();

                foreach (var property in properties)
                {
                    if (property.Name == componentName)
                    {
                        var currentValue = (bool)property.GetValue(colunasGridProdutos);
                        property.SetValue(colunasGridProdutos, !currentValue);

                        if ((bool)property.GetValue(colunasGridProdutos))
                        {
                            pcb.Image = Properties.Resources.chk_checked_32x32;
                        }
                        else
                        {
                            pcb.Image = Properties.Resources.chk_uncheck_32x32;
                        }

                        break;
                    }
                }
            }
        }

        private void FrmConfigurarColunas_Load(object sender, EventArgs e)
        {
            try
            {
                InicializarObjConfiguracao();
                InicializarPictureBoxs();
            }
            catch (Exception)
            {
                Alerta.Erro("Falha ao carregar configurações!");
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = configColunasProdutoRepositorio.AtualizarConfiguracao(colunasGridProdutos);

                if (resultado)
                {
                    Alerta.Confirmacao("Configuração salva!");
                    btnFechar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
    }
}
