namespace Estoque.Telas_Modelos
{
    partial class FrmEstruturaBaseBtnsGenericos
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
            tblPrincipal = new TableLayoutPanel();
            tlpCentral = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            button2 = new Button();
            tblPrincipal.SuspendLayout();
            tlpCentral.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblPrincipal
            // 
            tblPrincipal.ColumnCount = 3;
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblPrincipal.Controls.Add(tlpCentral, 1, 1);
            tblPrincipal.Dock = DockStyle.Fill;
            tblPrincipal.Location = new Point(0, 0);
            tblPrincipal.Margin = new Padding(0);
            tblPrincipal.Name = "tblPrincipal";
            tblPrincipal.RowCount = 3;
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblPrincipal.Size = new Size(544, 521);
            tblPrincipal.TabIndex = 0;
            // 
            // tlpCentral
            // 
            tlpCentral.ColumnCount = 1;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCentral.Controls.Add(tableLayoutPanel1, 0, 2);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(15, 15);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 5;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral.Size = new Size(514, 491);
            tlpCentral.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnExcluir, 7, 0);
            tableLayoutPanel1.Controls.Add(btnCancelar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSalvar, 2, 0);
            tableLayoutPanel1.Controls.Add(btnCadastrar, 5, 0);
            tableLayoutPanel1.Controls.Add(btnAlterar, 4, 0);
            tableLayoutPanel1.Controls.Add(button2, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 228);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(514, 35);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.search_1;
            button1.Location = new Point(479, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.delete_outline_1;
            btnExcluir.Location = new Point(0, 0);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(35, 35);
            btnExcluir.TabIndex = 5;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_outline_1;
            btnCancelar.Location = new Point(444, 0);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(35, 35);
            btnCancelar.TabIndex = 16;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(409, 0);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(35, 35);
            btnSalvar.TabIndex = 15;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = Properties.Resources.new_outline_1;
            btnCadastrar.Location = new Point(304, 0);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(35, 35);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = Properties.Resources.edit_outline_1;
            btnAlterar.Location = new Point(339, 0);
            btnAlterar.Margin = new Padding(0);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(35, 35);
            btnAlterar.TabIndex = 4;
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.erase_outline_1;
            button2.Location = new Point(374, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmEstruturaBaseBtnsGenericos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(544, 521);
            Controls.Add(tblPrincipal);
            Name = "FrmEstruturaBaseBtnsGenericos";
            Text = "FrmEstruturaBase";
            tblPrincipal.ResumeLayout(false);
            tlpCentral.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblPrincipal;
        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnCadastrar;
        private Button btnAlterar;
        private Button button2;
    }
}