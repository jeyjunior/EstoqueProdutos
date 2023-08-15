namespace EstoqueProdutos.Telas_Produto
{
    partial class FrmProdutos
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
            dtgProdutos = new DataGridView();
            btnCadastrar = new Button();
            button2 = new Button();
            button3 = new Button();
            btnPesquisar = new Button();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            txtNome = new TextBox();
            lblNome = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            SuspendLayout();
            // 
            // dtgProdutos
            // 
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProdutos.Location = new Point(10, 75);
            dtgProdutos.Margin = new Padding(3, 2, 3, 2);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.RowHeadersWidth = 51;
            dtgProdutos.RowTemplate.Height = 29;
            dtgProdutos.Size = new Size(1158, 436);
            dtgProdutos.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(10, 12);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(57, 49);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(73, 12);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(57, 49);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(135, 12);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(57, 49);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(1111, 12);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(57, 49);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(876, 18);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FlatStyle = FlatStyle.Flat;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(876, 36);
            cboCategoria.MaxDropDownItems = 100;
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(216, 23);
            cboCategoria.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(584, 36);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(286, 23);
            txtNome.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(584, 18);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(106, 15);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome do produto:";
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 541);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(cboCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(btnPesquisar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCadastrar);
            Controls.Add(dtgProdutos);
            Name = "FrmProdutos";
            Text = "Produtos";
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgProdutos;
        private Button btnCadastrar;
        private Button button2;
        private Button button3;
        private Button btnPesquisar;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private TextBox txtNome;
        private Label lblNome;
    }
}