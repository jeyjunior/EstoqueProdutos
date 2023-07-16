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
            cboUnidadeMedida = new ComboBox();
            pcbImagem = new PictureBox();
            txtVolume = new TextBox();
            lblVolume = new Label();
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
            txtNome.MaxLength = 30;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Brahama puro malte";
            txtNome.Size = new Size(370, 27);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // gpbDadosProduto
            // 
            gpbDadosProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            gpbDadosProduto.Controls.Add(cboUnidadeMedida);
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
            cboFornecedor.TabIndex = 7;
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
            cboCategoria.Location = new Point(16, 239);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(251, 28);
            cboCategoria.TabIndex = 6;
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
            cboEmbalagem.TabIndex = 4;
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
            txtDescri.MaxLength = 99;
            txtDescri.Name = "txtDescri";
            txtDescri.PlaceholderText = "Malte especial";
            txtDescri.Size = new Size(370, 27);
            txtDescri.TabIndex = 1;
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
            txtPreco.TabIndex = 5;
            txtPreco.TextAlign = HorizontalAlignment.Right;
            txtPreco.TextChanged += txtPreco_TextChanged;
            txtPreco.Enter += txtPreco_Enter;
            txtPreco.KeyPress += txtPreco_KeyPress;
            txtPreco.Leave += txtPreco_Leave;
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
            // cboUnidadeMedida
            // 
            cboUnidadeMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnidadeMedida.FormattingEnabled = true;
            cboUnidadeMedida.Location = new Point(150, 179);
            cboUnidadeMedida.Name = "cboUnidadeMedida";
            cboUnidadeMedida.Size = new Size(67, 28);
            cboUnidadeMedida.TabIndex = 3;
            // 
            // pcbImagem
            // 
            pcbImagem.BackColor = Color.White;
            pcbImagem.BorderStyle = BorderStyle.FixedSingle;
            pcbImagem.Location = new Point(19, 35);
            pcbImagem.Name = "pcbImagem";
            pcbImagem.Size = new Size(119, 109);
            pcbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagem.TabIndex = 4;
            pcbImagem.TabStop = false;
            pcbImagem.Click += pcbImagem_Click;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(16, 179);
            txtVolume.MaxLength = 100;
            txtVolume.Name = "txtVolume";
            txtVolume.PlaceholderText = "350";
            txtVolume.Size = new Size(122, 27);
            txtVolume.TabIndex = 2;
            txtVolume.TextAlign = HorizontalAlignment.Right;
            txtVolume.TextChanged += txtVolume_TextChanged;
            txtVolume.KeyPress += txtVolume_KeyPress;
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
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrar.BackColor = Color.Transparent;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.Black;
            btnCadastrar.Image = Properties.Resources.save_color;
            btnCadastrar.Location = new Point(512, 316);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(45, 45);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpar.BackColor = Color.Transparent;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.Image = Properties.Resources.erase_color;
            btnLimpar.Location = new Point(461, 316);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(45, 45);
            btnLimpar.TabIndex = 10;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FrmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 374);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastrar);
            Controls.Add(gpbDadosProduto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private ComboBox cboUnidadeMedida;
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