namespace Estoque.Telas_Principal
{
    partial class UCPrincipalRight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblDireita = new TableLayoutPanel();
            button1 = new Button();
            btnTeste = new Button();
            btnProduto = new Button();
            tblDireita.SuspendLayout();
            SuspendLayout();
            // 
            // tblDireita
            // 
            tblDireita.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tblDireita.BackColor = Color.FromArgb(60, 75, 85);
            tblDireita.ColumnCount = 1;
            tblDireita.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDireita.Controls.Add(button1, 0, 2);
            tblDireita.Controls.Add(btnTeste, 0, 2);
            tblDireita.Controls.Add(btnProduto, 0, 1);
            tblDireita.Location = new Point(0, 0);
            tblDireita.Margin = new Padding(0);
            tblDireita.Name = "tblDireita";
            tblDireita.RowCount = 16;
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblDireita.Size = new Size(125, 453);
            tblDireita.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.produtoIcon1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 60);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 0, 0);
            button1.Size = new Size(125, 30);
            button1.TabIndex = 3;
            button1.Text = "Usuário";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnTeste
            // 
            btnTeste.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTeste.Cursor = Cursors.Hand;
            btnTeste.FlatAppearance.BorderSize = 0;
            btnTeste.FlatStyle = FlatStyle.Flat;
            btnTeste.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeste.ForeColor = Color.White;
            btnTeste.Location = new Point(0, 90);
            btnTeste.Margin = new Padding(0);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(125, 30);
            btnTeste.TabIndex = 2;
            btnTeste.Text = "Teste";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // btnProduto
            // 
            btnProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnProduto.Cursor = Cursors.Hand;
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduto.ForeColor = Color.White;
            btnProduto.Image = Properties.Resources.produtoIcon1;
            btnProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduto.Location = new Point(0, 30);
            btnProduto.Margin = new Padding(0);
            btnProduto.Name = "btnProduto";
            btnProduto.Padding = new Padding(5, 0, 0, 0);
            btnProduto.Size = new Size(125, 30);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "Produto";
            btnProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // UCPrincipalRight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 75, 85);
            Controls.Add(tblDireita);
            Name = "UCPrincipalRight";
            Size = new Size(125, 495);
            tblDireita.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblDireita;
        private Button btnTeste;
        private Button btnProduto;
        private Button button1;
    }
}
