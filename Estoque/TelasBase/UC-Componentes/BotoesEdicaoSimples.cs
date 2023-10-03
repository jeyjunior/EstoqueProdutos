using Estoque.Enums;
using Estoque.Interfaces;
using EstoqueProdutos.Gerenciamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Base.UC_Componentes
{
    public partial class BotoesEdicaoSimples : Telas_Base.UCBase, IBotoesEdicaoSimples
    {
        private List<Button> btns = new List<Button>();
        public BotoesEdicaoSimples()
        {
            InitializeComponent();
            AtualizarPropriedades();
        }
        private void InicializarBotoes()
        {
            btns.Add(btnAlterar);
            btns.Add(btnCadastrar);
            btns.Add(btnCancelar);
            btns.Add(btnExcluir);
            btns.Add(btnLimpar);
            btns.Add(btnPesquisar);
            btns.Add(btnSalvar);
        }
        public void AtribuirEventoClick(EventHandler eventoDeClick, NomeBotoes nome)
        {
            if (eventoDeClick == null)
                throw new Exception();

            switch (nome)
            {
                case NomeBotoes.Alterar:
                    btnAlterar.Click += eventoDeClick;
                    break;
                case NomeBotoes.Cadastrar:
                    btnCadastrar.Click += eventoDeClick;
                    break;
                case NomeBotoes.Cancelar:
                    btnCancelar.Click += eventoDeClick;
                    break;
                case NomeBotoes.Excluir:
                    btnExcluir.Click += eventoDeClick;
                    break;
                case NomeBotoes.Limpar:
                    btnLimpar.Click += eventoDeClick;
                    break;
                case NomeBotoes.Pesquisar:
                    btnPesquisar.Click += eventoDeClick;
                    break;
                case NomeBotoes.Salvar:
                    btnSalvar.Click += eventoDeClick;
                    break;
            }
        }
        public void Layout(ModoBotoes modoBotoes)
        {
            tblBotoes.Controls.Clear();
            btns.ForEach(btn => btn.Visible = false);

            switch (modoBotoes)
            {
                case ModoBotoes.Inicial:
                    btnPesquisar.Visible = true;
                    btnLimpar.Visible = true;
                    btnAlterar.Visible = true;
                    btnCadastrar.Visible = true;
                    btnExcluir.Visible = true;

                    tblBotoes.Controls.Add(btnPesquisar, 0, 0);
                    tblBotoes.Controls.Add(btnLimpar, 1, 0);
                    tblBotoes.Controls.Add(btnAlterar, 2, 0);
                    tblBotoes.Controls.Add(btnCadastrar, 3, 0);
                    tblBotoes.Controls.Add(btnExcluir, 5, 0);
                    break;
                case ModoBotoes.Edicao:
                    btnSalvar.Visible = true;
                    btnLimpar.Visible = true;
                    btnCancelar.Visible = true;

                    tblBotoes.Controls.Add(btnLimpar, 0, 0);
                    tblBotoes.Controls.Add(btnCancelar, 1, 0);
                    tblBotoes.Controls.Add(btnSalvar, 2, 0);
                    break;
            }
        }
        private void BotoesEdicaoSimples_Load(object sender, EventArgs e)
        {
            InicializarBotoes();
        }

        public void ExecutarEventoBotao(NomeBotoes nome)
        {
            switch (nome)
            {
                case NomeBotoes.Alterar:
                    break;
                case NomeBotoes.Excluir:
                    break;
                case NomeBotoes.Cadastrar:
                    break;
                case NomeBotoes.Pesquisar:
                    btnPesquisar.PerformClick();
                    break;
                case NomeBotoes.Cancelar:
                    break;
                case NomeBotoes.Limpar:
                    break;
                case NomeBotoes.Salvar:
                    break;
                default:
                    break;
            }
        }
    }
}
