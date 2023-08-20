﻿using Estoque.Interfaces;
using Estoque.Telas_Base;
using Estoque.Telas_Produto;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Telas_Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Principal
{
    public partial class UCPrincipalRight : Estoque.Telas_Base.UCBase, IUCPrincipalRight
    {
        private IFrmPrincipal frmPrincipal;

        public UCPrincipalRight()
        {
            InitializeComponent();
            AtualizarPropriedades();
        }

        public void ObterFrmPrincipal(IFrmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmPrincipal.AbrirTelaPanelCentral<UCProdutos>();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            frmPrincipal.AbrirTelaPanelCentral<UCBase>();
        }
    }
}