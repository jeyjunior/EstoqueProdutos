namespace Estoque.Telas_Produto
{
    partial class FrmCadastrarComplementosProduto
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
            panel2 = new Panel();
            tlpTab = new TableLayoutPanel();
            btnCargo = new Button();
            btnCategoria = new Button();
            panel1 = new Panel();
            pCentral = new Panel();
            tblPrincipal.SuspendLayout();
            tlpTab.SuspendLayout();
            SuspendLayout();
            // 
            // tblPrincipal
            // 
            tblPrincipal.BackColor = Color.FromArgb(80, 90, 100);
            tblPrincipal.ColumnCount = 3;
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblPrincipal.Controls.Add(panel2, 2, 0);
            tblPrincipal.Controls.Add(tlpTab, 1, 0);
            tblPrincipal.Controls.Add(panel1, 0, 0);
            tblPrincipal.Controls.Add(pCentral, 1, 1);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 46, 56);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(529, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 40);
            panel2.TabIndex = 2;
            // 
            // tlpTab
            // 
            tlpTab.BackColor = Color.FromArgb(32, 46, 56);
            tlpTab.ColumnCount = 3;
            tlpTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTab.Controls.Add(btnCargo, 0, 0);
            tlpTab.Controls.Add(btnCategoria, 0, 0);
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
            // btnCargo
            // 
            btnCargo.Cursor = Cursors.Hand;
            btnCargo.Dock = DockStyle.Fill;
            btnCargo.FlatAppearance.BorderSize = 0;
            btnCargo.FlatStyle = FlatStyle.Flat;
            btnCargo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargo.ForeColor = Color.White;
            btnCargo.Location = new Point(171, 0);
            btnCargo.Margin = new Padding(0);
            btnCargo.Name = "btnCargo";
            btnCargo.Size = new Size(171, 40);
            btnCargo.TabIndex = 2;
            btnCargo.Text = "Cargo";
            btnCargo.UseVisualStyleBackColor = true;
            btnCargo.Click += btnCargo_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.Cursor = Cursors.Hand;
            btnCategoria.Dock = DockStyle.Fill;
            btnCategoria.FlatAppearance.BorderSize = 0;
            btnCategoria.FlatStyle = FlatStyle.Flat;
            btnCategoria.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategoria.ForeColor = Color.White;
            btnCategoria.Location = new Point(0, 0);
            btnCategoria.Margin = new Padding(0);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(171, 40);
            btnCategoria.TabIndex = 1;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCadastro_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 46, 56);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(15, 40);
            panel1.TabIndex = 1;
            // 
            // pCentral
            // 
            pCentral.BackColor = Color.Transparent;
            pCentral.Dock = DockStyle.Fill;
            pCentral.ForeColor = SystemColors.ControlText;
            pCentral.Location = new Point(15, 40);
            pCentral.Margin = new Padding(0);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(514, 466);
            pCentral.TabIndex = 3;
            // 
            // FrmCadastrarComplementosProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(544, 521);
            Controls.Add(tblPrincipal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimumSize = new Size(560, 560);
            Name = "FrmCadastrarComplementosProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar complementos dos produtos";
            FormClosed += FrmCadastrarSetores_Cargos_FormClosed;
            Load += FrmCadastrarSetores_Cargos_Load;
            tblPrincipal.ResumeLayout(false);
            tlpTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblPrincipal;
        private TableLayoutPanel tlpTab;
        private Button btnCategoria;
        private Button btnCargo;
        private Panel panel2;
        private Panel panel1;
        private Panel pCentral;
    }
}