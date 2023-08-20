namespace EstoqueProdutos.Telas_Principal
{
    partial class FrmPrincipal
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
            btnProduto = new Button();
            pCentral = new Panel();
            tblDireita = new TableLayoutPanel();
            btnTeste = new Button();
            pTop = new Panel();
            pBot = new Panel();
            tblDireita.SuspendLayout();
            SuspendLayout();
            // 
            // btnProduto
            // 
            btnProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnProduto.Cursor = Cursors.Hand;
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduto.ForeColor = Color.White;
            btnProduto.Image = Estoque.Properties.Resources.produtoIcon1;
            btnProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduto.Location = new Point(0, 30);
            btnProduto.Margin = new Padding(0);
            btnProduto.Name = "btnProduto";
            btnProduto.Padding = new Padding(5, 0, 0, 0);
            btnProduto.Size = new Size(125, 30);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "Produto";
            btnProduto.TextAlign = ContentAlignment.MiddleLeft;
            btnProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // pCentral
            // 
            pCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCentral.BackColor = Color.Transparent;
            pCentral.Location = new Point(129, 38);
            pCentral.Margin = new Padding(0);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(650, 480);
            pCentral.TabIndex = 3;
            // 
            // tblDireita
            // 
            tblDireita.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tblDireita.BackColor = Color.FromArgb(60, 75, 85);
            tblDireita.ColumnCount = 1;
            tblDireita.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDireita.Controls.Add(btnTeste, 0, 2);
            tblDireita.Controls.Add(btnProduto, 0, 1);
            tblDireita.Location = new Point(0, 34);
            tblDireita.Margin = new Padding(0);
            tblDireita.Name = "tblDireita";
            tblDireita.RowCount = 6;
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.Size = new Size(125, 528);
            tblDireita.TabIndex = 4;
            // 
            // btnTeste
            // 
            btnTeste.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTeste.Cursor = Cursors.Hand;
            btnTeste.FlatAppearance.BorderSize = 0;
            btnTeste.FlatStyle = FlatStyle.Flat;
            btnTeste.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeste.ForeColor = Color.White;
            btnTeste.Location = new Point(0, 60);
            btnTeste.Margin = new Padding(0);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(125, 30);
            btnTeste.TabIndex = 2;
            btnTeste.Text = "Teste";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // pTop
            // 
            pTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pTop.BackColor = Color.FromArgb(255, 128, 128);
            pTop.Location = new Point(0, 0);
            pTop.Name = "pTop";
            pTop.Size = new Size(784, 35);
            pTop.TabIndex = 6;
            // 
            // pBot
            // 
            pBot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBot.BackColor = Color.FromArgb(255, 128, 128);
            pBot.Location = new Point(0, 526);
            pBot.Name = "pBot";
            pBot.Size = new Size(784, 35);
            pBot.TabIndex = 7;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(784, 561);
            Controls.Add(pBot);
            Controls.Add(pTop);
            Controls.Add(pCentral);
            Controls.Add(tblDireita);
            MinimumSize = new Size(800, 600);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            tblDireita.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnProduto;
        private Panel pCentral;
        private TableLayoutPanel tblDireita;
        private Button btnTeste;
        private Panel pTop;
        private Panel pBot;
    }
}