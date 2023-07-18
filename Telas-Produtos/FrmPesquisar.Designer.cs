namespace EstoqueProdutos.Telas_Produtos
{
    partial class FrmPesquisar
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
            label2 = new Label();
            cboOperadorVolume = new ComboBox();
            label1 = new Label();
            cboOperadorPreco = new ComboBox();
            lblFornecedor = new Label();
            cboFornecedor = new ComboBox();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            lblEmbalagem = new Label();
            cboEmbalagem = new ComboBox();
            lblUnidade = new Label();
            txtPreco = new TextBox();
            lblPreco = new Label();
            cboUnidadeMedida = new ComboBox();
            txtVolume = new TextBox();
            lblVolume = new Label();
            btnLimpar = new Button();
            toolTipCadastrarProduto = new ToolTip(components);
            btnPesquisar = new Button();
            gpbDadosProduto.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Location = new Point(16, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(342, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(16, 54);
            txtNome.MaxLength = 30;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Brahama puro malte";
            txtNome.Size = new Size(341, 27);
            txtNome.TabIndex = 0;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // gpbDadosProduto
            // 
            gpbDadosProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpbDadosProduto.Controls.Add(label2);
            gpbDadosProduto.Controls.Add(cboOperadorVolume);
            gpbDadosProduto.Controls.Add(label1);
            gpbDadosProduto.Controls.Add(cboOperadorPreco);
            gpbDadosProduto.Controls.Add(lblFornecedor);
            gpbDadosProduto.Controls.Add(cboFornecedor);
            gpbDadosProduto.Controls.Add(lblCategoria);
            gpbDadosProduto.Controls.Add(cboCategoria);
            gpbDadosProduto.Controls.Add(lblEmbalagem);
            gpbDadosProduto.Controls.Add(cboEmbalagem);
            gpbDadosProduto.Controls.Add(lblUnidade);
            gpbDadosProduto.Controls.Add(txtPreco);
            gpbDadosProduto.Controls.Add(lblPreco);
            gpbDadosProduto.Controls.Add(cboUnidadeMedida);
            gpbDadosProduto.Controls.Add(txtVolume);
            gpbDadosProduto.Controls.Add(lblVolume);
            gpbDadosProduto.Controls.Add(txtNome);
            gpbDadosProduto.Controls.Add(lblNome);
            gpbDadosProduto.Location = new Point(12, 12);
            gpbDadosProduto.Name = "gpbDadosProduto";
            gpbDadosProduto.Size = new Size(378, 395);
            gpbDadosProduto.TabIndex = 2;
            gpbDadosProduto.TabStop = false;
            gpbDadosProduto.Text = "Dados do produto";
            // 
            // label2
            // 
            label2.Location = new Point(17, 145);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 19;
            label2.Text = "Operador";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboOperadorVolume
            // 
            cboOperadorVolume.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOperadorVolume.FormattingEnabled = true;
            cboOperadorVolume.Location = new Point(14, 168);
            cboOperadorVolume.Name = "cboOperadorVolume";
            cboOperadorVolume.Size = new Size(156, 28);
            cboOperadorVolume.TabIndex = 18;
            // 
            // label1
            // 
            label1.Location = new Point(21, 88);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 17;
            label1.Text = "Operador";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboOperadorPreco
            // 
            cboOperadorPreco.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOperadorPreco.FormattingEnabled = true;
            cboOperadorPreco.Location = new Point(14, 111);
            cboOperadorPreco.Name = "cboOperadorPreco";
            cboOperadorPreco.Size = new Size(156, 28);
            cboOperadorPreco.TabIndex = 16;
            cboOperadorPreco.SelectedIndexChanged += cboOperadorPreco_SelectedIndexChanged;
            // 
            // lblFornecedor
            // 
            lblFornecedor.Location = new Point(14, 318);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(344, 20);
            lblFornecedor.TabIndex = 15;
            lblFornecedor.Text = "Fornecedor";
            lblFornecedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboFornecedor
            // 
            cboFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Location = new Point(14, 341);
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(343, 28);
            cboFornecedor.TabIndex = 7;
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(14, 260);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(344, 20);
            lblCategoria.TabIndex = 13;
            lblCategoria.Text = "Categoria";
            lblCategoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(14, 283);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(344, 28);
            cboCategoria.TabIndex = 6;
            // 
            // lblEmbalagem
            // 
            lblEmbalagem.Location = new Point(14, 203);
            lblEmbalagem.Name = "lblEmbalagem";
            lblEmbalagem.Size = new Size(344, 20);
            lblEmbalagem.TabIndex = 11;
            lblEmbalagem.Text = "Embalagem";
            lblEmbalagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboEmbalagem
            // 
            cboEmbalagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmbalagem.FormattingEnabled = true;
            cboEmbalagem.Location = new Point(14, 225);
            cboEmbalagem.Name = "cboEmbalagem";
            cboEmbalagem.Size = new Size(344, 28);
            cboEmbalagem.TabIndex = 4;
            // 
            // lblUnidade
            // 
            lblUnidade.Location = new Point(286, 145);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(71, 20);
            lblUnidade.TabIndex = 9;
            lblUnidade.Text = "Un.";
            lblUnidade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPreco
            // 
            txtPreco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPreco.Location = new Point(176, 111);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$ 3,50";
            txtPreco.Size = new Size(182, 27);
            txtPreco.TabIndex = 5;
            txtPreco.TextAlign = HorizontalAlignment.Right;
            txtPreco.Enter += txtPreco_Enter;
            txtPreco.KeyPress += MascaraCasasDecimais_KeyPress;
            txtPreco.Leave += txtPreco_Leave;
            // 
            // lblPreco
            // 
            lblPreco.Location = new Point(176, 88);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(181, 20);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço";
            lblPreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboUnidadeMedida
            // 
            cboUnidadeMedida.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboUnidadeMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnidadeMedida.FormattingEnabled = true;
            cboUnidadeMedida.Location = new Point(286, 168);
            cboUnidadeMedida.Name = "cboUnidadeMedida";
            cboUnidadeMedida.Size = new Size(72, 28);
            cboUnidadeMedida.TabIndex = 3;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(176, 168);
            txtVolume.MaxLength = 100;
            txtVolume.Name = "txtVolume";
            txtVolume.PlaceholderText = "350";
            txtVolume.Size = new Size(104, 27);
            txtVolume.TabIndex = 2;
            txtVolume.TextAlign = HorizontalAlignment.Right;
            txtVolume.KeyPress += MascaraCasasDecimais_KeyPress;
            txtVolume.Leave += txtVolume_Leave;
            // 
            // lblVolume
            // 
            lblVolume.Location = new Point(176, 145);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(104, 20);
            lblVolume.TabIndex = 2;
            lblVolume.Text = "Volume";
            lblVolume.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpar.BackColor = Color.Transparent;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.Location = new Point(12, 414);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(45, 45);
            btnLimpar.TabIndex = 10;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.Image = Properties.Resources.search;
            btnPesquisar.Location = new Point(211, 414);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(179, 45);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // FrmPesquisar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 471);
            Controls.Add(btnPesquisar);
            Controls.Add(btnLimpar);
            Controls.Add(gpbDadosProduto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmPesquisar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar";
            Load += FrmCadastroProduto_Load;
            gpbDadosProduto.ResumeLayout(false);
            gpbDadosProduto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private GroupBox gpbDadosProduto;
        private TextBox txtVolume;
        private Label lblVolume;
        private ComboBox cboUnidadeMedida;
        private Button btnLimpar;
        private TextBox txtPreco;
        private Label lblPreco;
        private Label lblFornecedor;
        private ComboBox cboFornecedor;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private Label lblEmbalagem;
        private ComboBox cboEmbalagem;
        private Label lblUnidade;
        private ToolTip toolTipCadastrarProduto;
        private Label label1;
        private ComboBox cboOperadorPreco;
        private Label label2;
        private ComboBox cboOperadorVolume;
        private Button btnPesquisar;
    }
}