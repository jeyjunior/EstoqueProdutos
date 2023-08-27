namespace Estoque.Telas_Principal
{
    partial class UCTelaPrincipalDireita
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
            button12 = new Button();
            btnUsuario = new Button();
            btnProduto = new Button();
            tblDireita.SuspendLayout();
            SuspendLayout();
            // 
            // tblDireita
            // 
            tblDireita.BackColor = Color.FromArgb(32, 46, 56);
            tblDireita.ColumnCount = 1;
            tblDireita.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDireita.Controls.Add(button12, 0, 13);
            tblDireita.Controls.Add(btnUsuario, 0, 2);
            tblDireita.Controls.Add(btnProduto, 0, 1);
            tblDireita.Dock = DockStyle.Fill;
            tblDireita.Location = new Point(0, 0);
            tblDireita.Margin = new Padding(0);
            tblDireita.Name = "tblDireita";
            tblDireita.RowCount = 14;
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.134874F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13487434F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13487434F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13487434F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13487434F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13487434F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13487434F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13487434F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13518238F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13518238F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13518238F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13518238F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 6.13518238F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 20.2450867F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblDireita.Size = new Size(125, 495);
            tblDireita.TabIndex = 5;
            tblDireita.Resize += tblDireita_Resize;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(0, 64, 64);
            button12.Dock = DockStyle.Fill;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(3, 393);
            button12.Name = "button12";
            button12.Size = new Size(119, 99);
            button12.TabIndex = 28;
            button12.UseVisualStyleBackColor = false;
            button12.Visible = false;
            // 
            // btnUsuario
            // 
            btnUsuario.Cursor = Cursors.Hand;
            btnUsuario.Dock = DockStyle.Fill;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.Location = new Point(0, 60);
            btnUsuario.Margin = new Padding(0);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(125, 30);
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "Usuário";
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnProduto
            // 
            btnProduto.Cursor = Cursors.Hand;
            btnProduto.Dock = DockStyle.Fill;
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduto.ForeColor = Color.White;
            btnProduto.Image = Properties.Resources.produto_18x;
            btnProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduto.Location = new Point(0, 30);
            btnProduto.Margin = new Padding(0);
            btnProduto.Name = "btnProduto";
            btnProduto.Padding = new Padding(15, 0, 0, 0);
            btnProduto.RightToLeft = RightToLeft.No;
            btnProduto.Size = new Size(125, 30);
            btnProduto.TabIndex = 1;
            btnProduto.Text = " Produto";
            btnProduto.TextAlign = ContentAlignment.MiddleRight;
            btnProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // UCTelaPrincipalDireita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 75, 85);
            Controls.Add(tblDireita);
            Name = "UCTelaPrincipalDireita";
            Size = new Size(125, 495);
            Load += UCTelaPrincipalDireita_Load;
            tblDireita.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblDireita;
        private Button btnProduto;
        private Button btnUsuario;
        private Button button12;
    }
}
