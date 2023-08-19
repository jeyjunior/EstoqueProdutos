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
            tlpTop = new TableLayoutPanel();
            lblUsuario = new Label();
            lblTela = new Label();
            pCentral = new Panel();
            tblDireita = new TableLayoutPanel();
            btnTeste = new Button();
            tlpTop.SuspendLayout();
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
            btnProduto.Location = new Point(0, 30);
            btnProduto.Margin = new Padding(0);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(125, 30);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "Produto";
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // tlpTop
            // 
            tlpTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpTop.BackColor = Color.FromArgb(16, 23, 28);
            tlpTop.ColumnCount = 2;
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTop.Controls.Add(lblUsuario, 1, 0);
            tlpTop.Controls.Add(lblTela, 0, 0);
            tlpTop.Location = new Point(0, 0);
            tlpTop.Margin = new Padding(0);
            tlpTop.Name = "tlpTop";
            tlpTop.Padding = new Padding(10, 0, 10, 0);
            tlpTop.RowCount = 1;
            tlpTop.RowStyles.Add(new RowStyle());
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTop.Size = new Size(784, 35);
            tlpTop.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(395, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(376, 35);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "José Junior";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTela
            // 
            lblTela.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTela.ForeColor = Color.White;
            lblTela.Location = new Point(13, 0);
            lblTela.Name = "lblTela";
            lblTela.Size = new Size(376, 35);
            lblTela.TabIndex = 4;
            lblTela.Text = "Tela aberta";
            lblTela.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pCentral
            // 
            pCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCentral.BackColor = Color.FromArgb(255, 192, 192);
            pCentral.Location = new Point(129, 37);
            pCentral.Margin = new Padding(0);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(650, 520);
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
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(784, 561);
            Controls.Add(pCentral);
            Controls.Add(tlpTop);
            Controls.Add(tblDireita);
            Name = "FrmPrincipal";
            Text = "Principal";
            Load += FrmPrincipal_Load;
            tlpTop.ResumeLayout(false);
            tblDireita.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnProduto;
        private TableLayoutPanel tlpTop;
        private Panel pCentral;
        private Label lblUsuario;
        private Label lblTela;
        private TableLayoutPanel tblDireita;
        private Button btnTeste;
    }
}