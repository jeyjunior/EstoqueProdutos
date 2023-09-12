namespace Estoque.Telas_Base.UC_Componentes
{
    partial class BotoesEdicaoSimples
    {

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tblBotoes = new TableLayoutPanel();
            btnPesquisar = new Button();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnCadastrar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            toolTip1 = new ToolTip(components);
            tblBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // tblBotoes
            // 
            tblBotoes.ColumnCount = 6;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.Controls.Add(btnPesquisar, 0, 0);
            tblBotoes.Controls.Add(btnLimpar, 1, 0);
            tblBotoes.Controls.Add(btnExcluir, 5, 0);
            tblBotoes.Controls.Add(btnAlterar, 2, 0);
            tblBotoes.Controls.Add(btnCadastrar, 3, 0);
            tblBotoes.Location = new Point(0, 0);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(431, 37);
            tblBotoes.TabIndex = 12;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.search_1;
            btnPesquisar.Location = new Point(396, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(35, 35);
            btnPesquisar.TabIndex = 1;
            toolTip1.SetToolTip(btnPesquisar, "Pesquisar");
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.erase_outline_1;
            btnLimpar.Location = new Point(361, 0);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(35, 35);
            btnLimpar.TabIndex = 14;
            toolTip1.SetToolTip(btnLimpar, "Limpar ");
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.delete_outline_1;
            btnExcluir.Location = new Point(0, 0);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(35, 35);
            btnExcluir.TabIndex = 5;
            toolTip1.SetToolTip(btnExcluir, "Excluir ");
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = Properties.Resources.edit_outline_1;
            btnAlterar.Location = new Point(326, 0);
            btnAlterar.Margin = new Padding(0);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(35, 35);
            btnAlterar.TabIndex = 4;
            toolTip1.SetToolTip(btnAlterar, "Alterar");
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = Properties.Resources.new_outline_1;
            btnCadastrar.Location = new Point(291, 0);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(35, 35);
            btnCadastrar.TabIndex = 3;
            toolTip1.SetToolTip(btnCadastrar, "Novo ");
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(159, -1);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(35, 35);
            btnSalvar.TabIndex = 9;
            toolTip1.SetToolTip(btnSalvar, "Salvar");
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_outline_1;
            btnCancelar.Location = new Point(194, 0);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(35, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnCancelar, "Cancelar");
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BotoesEdicaoSimples
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(tblBotoes);
            Name = "BotoesEdicaoSimples";
            Size = new Size(431, 37);
            Load += BotoesEdicaoSimples_Load;
            tblBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tblBotoes;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnCadastrar;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnCancelar;
        private ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
    }
}
