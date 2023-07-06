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
            components = new System.ComponentModel.Container();
            lblNome = new Label();
            txtNome = new TextBox();
            gpbDadosProduto = new GroupBox();
            lblFornecedor = new Label();
            cboFornecedor = new ComboBox();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            lblEmbalagem = new Label();
            cboEmbalagem = new ComboBox();
            lblUnidade = new Label();
            txtDescri = new TextBox();
            lblDescri = new Label();
            txtPreco = new TextBox();
            lblPreco = new Label();
            cboVolume = new ComboBox();
            pcbImagem = new PictureBox();
            txtVolume = new TextBox();
            lblVolume = new Label();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            btnLimpar = new Button();
            toolTipCadastrarProduto = new ToolTip(components);
            gpbDadosProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).BeginInit();
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
            // txtNome
            // 
            txtNome.Location = new Point(162, 58);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Brahama puro malte";
            txtNome.Size = new Size(370, 27);
            txtNome.TabIndex = 1;
            // 
            // gpbDadosProduto
            // 
            gpbDadosProduto.Controls.Add(lblFornecedor);
            gpbDadosProduto.Controls.Add(cboFornecedor);
            gpbDadosProduto.Controls.Add(lblCategoria);
            gpbDadosProduto.Controls.Add(cboCategoria);
            gpbDadosProduto.Controls.Add(lblEmbalagem);
            gpbDadosProduto.Controls.Add(cboEmbalagem);
            gpbDadosProduto.Controls.Add(lblUnidade);
            gpbDadosProduto.Controls.Add(txtDescri);
            gpbDadosProduto.Controls.Add(lblDescri);
            gpbDadosProduto.Controls.Add(txtPreco);
            gpbDadosProduto.Controls.Add(lblPreco);
            gpbDadosProduto.Controls.Add(cboVolume);
            gpbDadosProduto.Controls.Add(pcbImagem);
            gpbDadosProduto.Controls.Add(txtVolume);
            gpbDadosProduto.Controls.Add(lblVolume);
            gpbDadosProduto.Controls.Add(txtNome);
            gpbDadosProduto.Controls.Add(lblNome);
            gpbDadosProduto.Location = new Point(12, 12);
            gpbDadosProduto.Name = "gpbDadosProduto";
            gpbDadosProduto.Size = new Size(545, 288);
            gpbDadosProduto.TabIndex = 2;
            gpbDadosProduto.TabStop = false;
            gpbDadosProduto.Text = "Dados do produto";
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Location = new Point(363, 216);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(84, 20);
            lblFornecedor.TabIndex = 15;
            lblFornecedor.Text = "Fornecedor";
            // 
            // cboFornecedor
            // 
            cboFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Location = new Point(284, 239);
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(248, 28);
            cboFornecedor.TabIndex = 14;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(105, 216);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 13;
            lblCategoria.Text = "Categoria";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(19, 239);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(248, 28);
            cboCategoria.TabIndex = 12;
            // 
            // lblEmbalagem
            // 
            lblEmbalagem.AutoSize = true;
            lblEmbalagem.Location = new Point(245, 156);
            lblEmbalagem.Name = "lblEmbalagem";
            lblEmbalagem.Size = new Size(89, 20);
            lblEmbalagem.TabIndex = 11;
            lblEmbalagem.Text = "Embalagem";
            // 
            // cboEmbalagem
            // 
            cboEmbalagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmbalagem.FormattingEnabled = true;
            cboEmbalagem.Location = new Point(226, 179);
            cboEmbalagem.Name = "cboEmbalagem";
            cboEmbalagem.Size = new Size(128, 28);
            cboEmbalagem.TabIndex = 10;
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.Location = new Point(151, 157);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(65, 20);
            lblUnidade.TabIndex = 9;
            lblUnidade.Text = "Unidade";
            // 
            // txtDescri
            // 
            txtDescri.Location = new Point(162, 117);
            txtDescri.Name = "txtDescri";
            txtDescri.PlaceholderText = "Malte especial";
            txtDescri.Size = new Size(370, 27);
            txtDescri.TabIndex = 8;
            // 
            // lblDescri
            // 
            lblDescri.AutoSize = true;
            lblDescri.Location = new Point(162, 94);
            lblDescri.Name = "lblDescri";
            lblDescri.Size = new Size(74, 20);
            lblDescri.TabIndex = 7;
            lblDescri.Text = "Descrição";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(363, 180);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$ 3,50";
            txtPreco.Size = new Size(169, 27);
            txtPreco.TabIndex = 6;
            txtPreco.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(432, 157);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço";
            // 
            // cboVolume
            // 
            cboVolume.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVolume.FormattingEnabled = true;
            cboVolume.Location = new Point(150, 179);
            cboVolume.Name = "cboVolume";
            cboVolume.Size = new Size(67, 28);
            cboVolume.TabIndex = 1;
            // 
            // pcbImagem
            // 
            pcbImagem.BackColor = Color.White;
            pcbImagem.BorderStyle = BorderStyle.FixedSingle;
            pcbImagem.Location = new Point(19, 35);
            pcbImagem.Name = "pcbImagem";
            pcbImagem.Size = new Size(119, 109);
            pcbImagem.TabIndex = 4;
            pcbImagem.TabStop = false;
            pcbImagem.Click += pcbImagem_Click;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(16, 179);
            txtVolume.Name = "txtVolume";
            txtVolume.PlaceholderText = "350";
            txtVolume.Size = new Size(122, 27);
            txtVolume.TabIndex = 3;
            txtVolume.TextAlign = HorizontalAlignment.Right;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new Point(39, 156);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(59, 20);
            lblVolume.TabIndex = 2;
            lblVolume.Text = "Volume";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(265, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 44);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrar.BackColor = Color.Green;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.Control;
            btnCadastrar.Location = new Point(414, 318);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(143, 44);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpar.Location = new Point(12, 319);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(49, 44);
            btnLimpar.TabIndex = 8;
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 374);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(gpbDadosProduto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCadastroProduto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Produto";
            Load += FrmCadastroProduto_Load;
            gpbDadosProduto.ResumeLayout(false);
            gpbDadosProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private GroupBox gpbDadosProduto;
        private PictureBox pcbImagem;
        private TextBox txtVolume;
        private Label lblVolume;
        private ComboBox cboVolume;
        private Button btnCancelar;
        private Button btnCadastrar;
        private Button btnLimpar;
        private TextBox txtPreco;
        private Label lblPreco;
        private TextBox txtDescri;
        private Label lblDescri;
        private Label lblFornecedor;
        private ComboBox cboFornecedor;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private Label lblEmbalagem;
        private ComboBox cboEmbalagem;
        private Label lblUnidade;
        private ToolTip toolTipCadastrarProduto;
    }
}