namespace Estoque.Telas_Modelos
{
    partial class FrmCadastrarSetores_Cargos
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
            tlpTab = new TableLayoutPanel();
            btnTab1 = new Button();
            pTabLeft = new Panel();
            pTabRight = new Panel();
            tblPrincipal.SuspendLayout();
            tlpTab.SuspendLayout();
            SuspendLayout();
            // 
            // tblPrincipal
            // 
            tblPrincipal.ColumnCount = 3;
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblPrincipal.Controls.Add(tlpTab, 1, 0);
            tblPrincipal.Controls.Add(tlpCentral, 1, 1);
            tblPrincipal.Controls.Add(pTabLeft, 0, 0);
            tblPrincipal.Controls.Add(pTabRight, 2, 0);
            tblPrincipal.Dock = DockStyle.Fill;
            tblPrincipal.Location = new Point(0, 0);
            tblPrincipal.Margin = new Padding(0);
            tblPrincipal.Name = "tblPrincipal";
            tblPrincipal.RowCount = 3;
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblPrincipal.Size = new Size(544, 521);
            tblPrincipal.TabIndex = 0;
            // 
            // tlpCentral
            // 
            tlpCentral.ColumnCount = 1;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(15, 40);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 1;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.Size = new Size(514, 466);
            tlpCentral.TabIndex = 0;
            // 
            // tlpTab
            // 
            tlpTab.BackColor = Color.FromArgb(32, 46, 56);
            tlpTab.ColumnCount = 3;
            tlpTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTab.Controls.Add(btnTab1, 0, 0);
            tlpTab.Dock = DockStyle.Fill;
            tlpTab.Location = new Point(15, 0);
            tlpTab.Margin = new Padding(0);
            tlpTab.Name = "tlpTab";
            tlpTab.RowCount = 1;
            tlpTab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTab.Size = new Size(514, 40);
            tlpTab.TabIndex = 0;
            // 
            // btnTab1
            // 
            btnTab1.Cursor = Cursors.Hand;
            btnTab1.Dock = DockStyle.Fill;
            btnTab1.FlatAppearance.BorderSize = 0;
            btnTab1.FlatStyle = FlatStyle.Flat;
            btnTab1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTab1.ForeColor = Color.White;
            btnTab1.Location = new Point(0, 0);
            btnTab1.Margin = new Padding(0);
            btnTab1.Name = "btnTab1";
            btnTab1.Size = new Size(171, 40);
            btnTab1.TabIndex = 1;
            btnTab1.Text = "Tab 1";
            btnTab1.UseVisualStyleBackColor = true;
            btnTab1.Click += btnTab1_Click;
            // 
            // pTabLeft
            // 
            pTabLeft.BackColor = Color.FromArgb(32, 46, 56);
            pTabLeft.Dock = DockStyle.Fill;
            pTabLeft.Location = new Point(0, 0);
            pTabLeft.Margin = new Padding(0);
            pTabLeft.Name = "pTabLeft";
            pTabLeft.Size = new Size(15, 40);
            pTabLeft.TabIndex = 1;
            // 
            // pTabRight
            // 
            pTabRight.BackColor = Color.FromArgb(32, 46, 56);
            pTabRight.Dock = DockStyle.Fill;
            pTabRight.Location = new Point(529, 0);
            pTabRight.Margin = new Padding(0);
            pTabRight.Name = "pTabRight";
            pTabRight.Size = new Size(15, 40);
            pTabRight.TabIndex = 2;
            // 
            // FrmCadastrarSetores_Cargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(544, 521);
            Controls.Add(tblPrincipal);
            Name = "FrmCadastrarSetores_Cargos";
            Text = "FrmEstruturaBaseTabs";
            tblPrincipal.ResumeLayout(false);
            tlpTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblPrincipal;
        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tlpTab;
        private Button btnTab1;
        private Panel pTabLeft;
        private Panel pTabRight;
    }
}