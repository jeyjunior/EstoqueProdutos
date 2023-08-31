using Estoque.Enums;
using Estoque.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Componentes_Base
{
    public class Botoes: IBotoes
    {
        private List<Button> btns = new List<Button>();

        public Button BtnSalvar { get; set; }
        public Button BtnCancelar { get; set; }
        public Button BtnExcluir { get; set; }
        public Button BtnAlterar { get; set; }
        public Button BtnCadastrar { get; set; }
        public Button BtnLimpar { get; set; }
        public Button BtnPesquisar { get; set; }
        
        private TableLayoutPanel TableLayoutPanel { get; set; }

        public void Mapear(Botoes botoes, TableLayoutPanel tableLayoutPanel)
        {
            BtnSalvar = botoes.BtnSalvar;
            BtnCancelar = botoes.BtnCancelar;
            BtnExcluir = botoes.BtnExcluir;
            BtnAlterar = botoes.BtnAlterar;
            BtnCadastrar = botoes.BtnCadastrar;
            BtnLimpar   = botoes.BtnLimpar;
            BtnPesquisar = botoes.BtnPesquisar;

            btns.Add(BtnSalvar);
            btns.Add(BtnCancelar);
            btns.Add(BtnExcluir);
            btns.Add(BtnAlterar);
            btns.Add(BtnCadastrar);
            btns.Add(BtnLimpar);
            btns.Add(BtnPesquisar);

            TableLayoutPanel = tableLayoutPanel;
        }

        /// <summary>
        /// Padrão: 4 colunas, indice 0 reservado para btnPesquisar, indices 1 ao 3 disponivel
        /// </summary>
        /// <param name="modoBotoes"></param>
        public void Layout(ModoBotoes modoBotoes)
        {
            TableLayoutPanel.Controls.Clear();
            TableLayoutPanel.Controls.Add(BtnPesquisar, 0, 0);
            btns.ForEach(btn =>
            {
                if (btn != BtnPesquisar)
                    btn.Visible = false;
            });
            
            switch (modoBotoes)
            {
                case ModoBotoes.Inicial:
                    InserirBtnsNoTableLayoutPanel(BtnExcluir, BtnAlterar, BtnCadastrar);
                    break;
                case ModoBotoes.Edicao:
                    InserirBtnsNoTableLayoutPanel(BtnCancelar, BtnLimpar, BtnSalvar);
                    break;
                case ModoBotoes.Exclusao:
                    InserirBtnsNoTableLayoutPanel(BtnCancelar, BtnSalvar, null);
                    break;
            }
        }

        private void InserirBtnsNoTableLayoutPanel(Button? btnIndice1, Button? btnIndice2, Button? btnIndice3)
        {
            int qtdBotoesNulos = 0;

            if(btnIndice1 != null)
            {
                btnIndice1.Visible = true;
                TableLayoutPanel.Controls.Add(btnIndice1, 1, 0);
            }
            else
            {
                qtdBotoesNulos++;
            }

            if(btnIndice2 != null)
            {
                btnIndice2.Visible = true;
                TableLayoutPanel.Controls.Add(btnIndice2, 2, 0);
            }
            else
            {
                qtdBotoesNulos++;
            }

            if (btnIndice3 != null)
            {
                btnIndice3.Visible = true;
                TableLayoutPanel.Controls.Add(btnIndice3, 3, 0);
            }
            else
            {
                qtdBotoesNulos++;
            }


            if(qtdBotoesNulos > 0)
            {
                OrganizarBotoes();
            }
        }

        private void OrganizarBotoes()
        {
            int totalColunas = TableLayoutPanel.ColumnCount;

            for (int coluna = 1; coluna < totalColunas - 1; coluna++)
            {
                Button botaoAtual = (Button)TableLayoutPanel.GetControlFromPosition(coluna, 0);
                Button proximoBotao = (Button)TableLayoutPanel.GetControlFromPosition(coluna + 1, 0);

                if (botaoAtual == null && proximoBotao != null)
                {
                    TableLayoutPanel.SetCellPosition(proximoBotao, new TableLayoutPanelCellPosition(coluna, 0));
                }
            }
        }
    }
}
