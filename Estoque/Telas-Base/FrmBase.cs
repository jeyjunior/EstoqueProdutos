using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Telas_Produto;
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
    /// <summary>
    /// Fornece os recursos basico para todos os formularios do projeto
    /// </summary>
    public partial class FrmBase : Form, IFrmBase
    {
        protected IFrmGestor FrmGestor { get; set; }

        public FrmBase()
        {
            InitializeComponent();
        }

        public void ObterFrmGestor(IFrmGestor frmGestor)
        {
            FrmGestor = frmGestor;
        }

        public void FecharTela()
        {
            try
            {
                Type tipoClasseHerdeira = this.GetType();
                MethodInfo? metodoFecharFilho = FrmGestor.GetType().GetMethod("FecharFilho");
                metodoFecharFilho?.Invoke(FrmGestor, new object[] { tipoClasseHerdeira });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar fechar tela\nErro: " + ex.Message);
            }
        }
    }
}
