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

namespace Estoque.Telas_Base.FrmEspecialistas
{
    /// <summary>
    /// Responsável por padronizar estilos e comportamentos das Tabs personalizadas
    /// </summary>
    public partial class FrmTabControl : Estoque.Telas_Base.FrmGerenciadorDeTelas
    {
        public FrmTabControl()
        {
            InitializeComponent();
        }

        protected virtual void AlterarCorDoBotaoSelecionado(TableLayoutPanel tab, Button botaoAtivo)
        {
            foreach (Button button in tab.Controls.OfType<Button>())
            {
                button.BackColor = Color.FromArgb(32, 46, 56);
            }

            botaoAtivo.BackColor = Color.FromArgb(80, 90, 100);
        }
    }
}
