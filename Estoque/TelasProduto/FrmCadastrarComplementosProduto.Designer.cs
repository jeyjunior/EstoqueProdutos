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
            btnMarca = new Button();
            btnEmbalagem = new Button();
            btnCategoria = new Button();
            panel1 = new Panel();
            pCentral = new Panel();
            btnFormato = new Button();
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
            tlpTab.ColumnCount = 4;
            tlpTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tlpTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tlpTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tlpTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9981289F));
            tlpTab.Controls.Add(btnMarca, 0, 0);
            tlpTab.Controls.Add(btnEmbalagem, 0, 0);
            tlpTab.Controls.Add(btnCategoria, 0, 0);
            tlpTab.Controls.Add(btnFormato, 3, 0);
            tlpTab.Dock = DockStyle.Fill;
            tlpTab.Location = new Point(15, 0);
            tlpTab.Margin = new Padding(0);
            tlpTab.Name = "tlpTab";
            tlpTab.RowCount = 1;
            tlpTab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTab.Size = new Size(514, 40);
            tlpTab.TabIndex = 0;
            // 
            // btnMarca
            // 
            btnMarca.Cursor = Cursors.Hand;
            btnMarca.Dock = DockStyle.Fill;
            btnMarca.FlatAppearance.BorderSize = 0;
            btnMarca.FlatStyle = FlatStyle.Flat;
            btnMarca.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarca.ForeColor = Color.White;
            btnMarca.Location = new Point(256, 0);
            btnMarca.Margin = new Padding(0);
            btnMarca.Name = "btnMarca";
            btnMarca.Size = new Size(128, 40);
            btnMarca.TabIndex = 3;
            btnMarca.Text = "Marca";
            btnMarca.UseVisualStyleBackColor = true;
            btnMarca.Click += btnMarca_Click;
            // 
            // btnEmbalagem
            // 
            btnEmbalagem.Cursor = Cursors.Hand;
            btnEmbalagem.Dock = DockStyle.Fill;
            btnEmbalagem.FlatAppearance.BorderSize = 0;
            btnEmbalagem.FlatStyle = FlatStyle.Flat;
            btnEmbalagem.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmbalagem.ForeColor = Color.White;
            btnEmbalagem.Location = new Point(128, 0);
            btnEmbalagem.Margin = new Padding(0);
            btnEmbalagem.Name = "btnEmbalagem";
            btnEmbalagem.Size = new Size(128, 40);
            btnEmbalagem.TabIndex = 2;
            btnEmbalagem.Text = "Embalagem";
            btnEmbalagem.UseVisualStyleBackColor = true;
            btnEmbalagem.Click += btnEmbalagem_Click;
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
            btnCategoria.Size = new Size(128, 40);
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
            // btnFormato
            // 
            btnFormato.Cursor = Cursors.Hand;
            btnFormato.Dock = DockStyle.Fill;
            btnFormato.FlatAppearance.BorderSize = 0;
            btnFormato.FlatStyle = FlatStyle.Flat;
            btnFormato.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormato.ForeColor = Color.White;
            btnFormato.Location = new Point(384, 0);
            btnFormato.Margin = new Padding(0);
            btnFormato.Name = "btnFormato";
            btnFormato.Size = new Size(130, 40);
            btnFormato.TabIndex = 4;
            btnFormato.Text = "Formato";
            btnFormato.UseVisualStyleBackColor = true;
            btnFormato.Click += btnFormato_Click;
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
        private Button btnEmbalagem;
        private Panel panel2;
        private Panel panel1;
        private Panel pCentral;
        private Button btnMarca;
        private Button btnFormato;
    }
}