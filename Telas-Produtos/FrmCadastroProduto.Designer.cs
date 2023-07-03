namespace EstoqueProdutos.Telas_Produtos
{
    partial class FrmCadastroProduto
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
            lblNome = new Label();
            textBox1 = new TextBox();
            gpbDadosProduto = new GroupBox();
            textBox2 = new TextBox();
            lblMedida = new Label();
            pcbImagem = new PictureBox();
            groupBox2 = new GroupBox();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            cboFornecedor = new ComboBox();
            lblFornecedor = new Label();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            btnLimpar = new Button();
            textBox3 = new TextBox();
            lblPreco = new Label();
            gpbDadosProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(162, 35);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 58);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Brahama puro malte";
            textBox1.Size = new Size(370, 27);
            textBox1.TabIndex = 1;
            // 
            // gpbDadosProduto
            // 
            gpbDadosProduto.Controls.Add(textBox3);
            gpbDadosProduto.Controls.Add(lblPreco);
            gpbDadosProduto.Controls.Add(pcbImagem);
            gpbDadosProduto.Controls.Add(textBox2);
            gpbDadosProduto.Controls.Add(lblMedida);
            gpbDadosProduto.Controls.Add(textBox1);
            gpbDadosProduto.Controls.Add(lblNome);
            gpbDadosProduto.Location = new Point(12, 12);
            gpbDadosProduto.Name = "gpbDadosProduto";
            gpbDadosProduto.Size = new Size(558, 165);
            gpbDadosProduto.TabIndex = 2;
            gpbDadosProduto.TabStop = false;
            gpbDadosProduto.Text = "Dados Base";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 117);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Lata 350 ml";
            textBox2.Size = new Size(189, 27);
            textBox2.TabIndex = 3;
            // 
            // lblMedida
            // 
            lblMedida.AutoSize = true;
            lblMedida.Location = new Point(162, 94);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(66, 20);
            lblMedida.TabIndex = 2;
            lblMedida.Text = "Medidas";
            // 
            // pcbImagem
            // 
            pcbImagem.Location = new Point(19, 35);
            pcbImagem.Name = "pcbImagem";
            pcbImagem.Size = new Size(119, 109);
            pcbImagem.TabIndex = 4;
            pcbImagem.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboFornecedor);
            groupBox2.Controls.Add(lblFornecedor);
            groupBox2.Controls.Add(cboCategoria);
            groupBox2.Controls.Add(lblCategoria);
            groupBox2.Location = new Point(12, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(558, 115);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Complemento";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(19, 38);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria";
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(19, 61);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(227, 28);
            cboCategoria.TabIndex = 1;
            // 
            // cboFornecedor
            // 
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Location = new Point(280, 61);
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(252, 28);
            cboFornecedor.TabIndex = 3;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Location = new Point(280, 38);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(84, 20);
            lblFornecedor.TabIndex = 2;
            lblFornecedor.Text = "Fornecedor";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(427, 304);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 44);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Green;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.Control;
            btnCadastrar.Location = new Point(278, 304);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(143, 44);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 304);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(49, 44);
            btnLimpar.TabIndex = 8;
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(363, 117);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "R$ 3,50";
            textBox3.Size = new Size(169, 27);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(482, 94);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço";
            // 
            // FrmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 361);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox2);
            Controls.Add(gpbDadosProduto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCadastroProduto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Produto";
            gpbDadosProduto.ResumeLayout(false);
            gpbDadosProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private TextBox textBox1;
        private GroupBox gpbDadosProduto;
        private PictureBox pcbImagem;
        private TextBox textBox2;
        private Label lblMedida;
        private GroupBox groupBox2;
        private ComboBox cboFornecedor;
        private Label lblFornecedor;
        private ComboBox cboCategoria;
        private Label lblCategoria;
        private Button btnCancelar;
        private Button btnCadastrar;
        private Button btnLimpar;
        private TextBox textBox3;
        private Label lblPreco;
    }
}