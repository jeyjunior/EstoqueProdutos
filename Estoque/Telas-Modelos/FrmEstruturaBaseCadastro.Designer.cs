namespace Estoque.Telas_Modelos
{
    partial class FrmEstruturaBaseCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpPrincipal = new TableLayoutPanel();
            tblCentral = new TableLayoutPanel();
            tblBotoes = new TableLayoutPanel();
            btnSalvar = new Button();
            btnLimpar = new Button();
            tlpPrincipal.SuspendLayout();
            tblCentral.SuspendLayout();
            tblBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(80, 90, 100);
            tlpPrincipal.ColumnCount = 3;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpPrincipal.Controls.Add(tblCentral, 1, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Margin = new Padding(0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpPrincipal.Size = new Size(544, 521);
            tlpPrincipal.TabIndex = 0;
            // 
            // tblCentral
            // 
            tblCentral.BackColor = Color.FromArgb(80, 90, 100);
            tblCentral.ColumnCount = 1;
            tblCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCentral.Controls.Add(tblBotoes, 0, 2);
            tblCentral.Dock = DockStyle.Fill;
            tblCentral.Location = new Point(15, 15);
            tblCentral.Margin = new Padding(0);
            tblCentral.Name = "tblCentral";
            tblCentral.RowCount = 3;
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblCentral.Size = new Size(514, 491);
            tblCentral.TabIndex = 0;
            // 
            // tblBotoes
            // 
            tblBotoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblBotoes.ColumnCount = 4;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBotoes.Controls.Add(btnSalvar, 0, 0);
            tblBotoes.Controls.Add(btnLimpar, 2, 0);
            tblBotoes.Location = new Point(0, 456);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(514, 35);
            tblBotoes.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Fill;
            btnSalvar.ForeColor = Color.FromArgb(66, 142, 79);
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(424, 0);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(10, 0, 0, 0);
            btnSalvar.Size = new Size(90, 35);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Dock = DockStyle.Fill;
            btnLimpar.ForeColor = Color.FromArgb(66, 159, 159);
            btnLimpar.Image = Properties.Resources.erase_outline_1;
            btnLimpar.Location = new Point(329, 0);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Padding = new Padding(5, 0, 0, 0);
            btnLimpar.Size = new Size(90, 35);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // FrmEstruturaBaseCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(544, 521);
            Controls.Add(tlpPrincipal);
            Name = "FrmEstruturaBaseCadastro";
            Text = "FrmEstruturaBase";
            tlpPrincipal.ResumeLayout(false);
            tblCentral.ResumeLayout(false);
            tblBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tblCentral;
        private TableLayoutPanel tblBotoes;
        private Button btnSalvar;
        private Button btnLimpar;
    }
}