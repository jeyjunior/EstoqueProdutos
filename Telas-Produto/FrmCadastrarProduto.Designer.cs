namespace EstoqueProdutos.Telas_Produto
{
    partial class FrmCadastrarProduto
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
            gpProduto = new GroupBox();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            pcbImgProduto = new PictureBox();
            lblVolume = new Label();
            txtVolume = new TextBox();
            cboUnidade = new ComboBox();
            lblUnidade = new Label();
            dtpValidade = new DateTimePicker();
            lblValidade = new Label();
            gpDetalhesProduto = new GroupBox();
            chkFabricacao = new CheckBox();
            lblFabricacao = new Label();
            dtpFabricacao = new DateTimePicker();
            chkValidade = new CheckBox();
            lblAltura = new Label();
            txtAltura = new TextBox();
            lblLargura = new Label();
            txtLargura = new TextBox();
            lblComprimento = new Label();
            txtComprimento = new TextBox();
            gpDimensoes = new GroupBox();
            cboMarca = new ComboBox();
            lblMarca = new Label();
            cboCategoria = new ComboBox();
            lblCategoria = new Label();
            gpMarcaCategoria = new GroupBox();
            btnCadastrarCategoria = new Button();
            btnCadastrarMarca = new Button();
            gpFormatoTipoEmbalagem = new GroupBox();
            btnCadastrarEmbalagem = new Button();
            btnCadastrarFormato = new Button();
            lblEmbalagem = new Label();
            cboEmbalagem = new ComboBox();
            lblFormato = new Label();
            cboFormato = new ComboBox();
            btnSair = new Button();
            btnSalvar = new Button();
            btnLimpar = new Button();
            gpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImgProduto).BeginInit();
            gpDetalhesProduto.SuspendLayout();
            gpDimensoes.SuspendLayout();
            gpMarcaCategoria.SuspendLayout();
            gpFormatoTipoEmbalagem.SuspendLayout();
            SuspendLayout();
            // 
            // gpProduto
            // 
            gpProduto.Controls.Add(txtDescricao);
            gpProduto.Controls.Add(lblDescricao);
            gpProduto.Controls.Add(txtNomeProduto);
            gpProduto.Controls.Add(lblNomeProduto);
            gpProduto.Controls.Add(pcbImgProduto);
            gpProduto.Location = new Point(12, 12);
            gpProduto.Name = "gpProduto";
            gpProduto.Size = new Size(610, 171);
            gpProduto.TabIndex = 0;
            gpProduto.TabStop = false;
            gpProduto.Text = "Produto";
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescricao.Location = new Point(167, 126);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(426, 26);
            txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.ForeColor = Color.FromArgb(54, 54, 54);
            lblDescricao.Location = new Point(167, 99);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(329, 24);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição:";
            lblDescricao.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProduto.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeProduto.ForeColor = Color.FromArgb(64, 64, 64);
            txtNomeProduto.Location = new Point(167, 60);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(426, 26);
            txtNomeProduto.TabIndex = 1;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeProduto.ForeColor = Color.FromArgb(54, 54, 54);
            lblNomeProduto.Location = new Point(167, 33);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(281, 24);
            lblNomeProduto.TabIndex = 2;
            lblNomeProduto.Text = "Nome do Produto:";
            lblNomeProduto.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pcbImgProduto
            // 
            pcbImgProduto.BackColor = Color.FromArgb(224, 224, 224);
            pcbImgProduto.Location = new Point(21, 32);
            pcbImgProduto.Name = "pcbImgProduto";
            pcbImgProduto.Size = new Size(120, 120);
            pcbImgProduto.TabIndex = 1;
            pcbImgProduto.TabStop = false;
            pcbImgProduto.Click += pcbImgProduto_Click;
            // 
            // lblVolume
            // 
            lblVolume.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblVolume.ForeColor = Color.FromArgb(54, 54, 54);
            lblVolume.Location = new Point(21, 20);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(120, 24);
            lblVolume.TabIndex = 2;
            lblVolume.Text = "Volume:";
            lblVolume.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtVolume
            // 
            txtVolume.BorderStyle = BorderStyle.FixedSingle;
            txtVolume.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtVolume.ForeColor = Color.FromArgb(64, 64, 64);
            txtVolume.Location = new Point(21, 46);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(145, 26);
            txtVolume.TabIndex = 0;
            // 
            // cboUnidade
            // 
            cboUnidade.DropDownHeight = 150;
            cboUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnidade.FormattingEnabled = true;
            cboUnidade.IntegralHeight = false;
            cboUnidade.Location = new Point(177, 46);
            cboUnidade.Name = "cboUnidade";
            cboUnidade.Size = new Size(83, 28);
            cboUnidade.TabIndex = 1;
            // 
            // lblUnidade
            // 
            lblUnidade.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnidade.ForeColor = Color.FromArgb(54, 54, 54);
            lblUnidade.Location = new Point(177, 21);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(83, 24);
            lblUnidade.TabIndex = 6;
            lblUnidade.Text = "Un.:";
            lblUnidade.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dtpValidade
            // 
            dtpValidade.CustomFormat = "d";
            dtpValidade.Format = DateTimePickerFormat.Short;
            dtpValidade.Location = new Point(470, 47);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(123, 27);
            dtpValidade.TabIndex = 5;
            dtpValidade.Value = new DateTime(2023, 8, 4, 0, 0, 0, 0);
            // 
            // lblValidade
            // 
            lblValidade.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblValidade.ForeColor = Color.FromArgb(54, 54, 54);
            lblValidade.Location = new Point(449, 22);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(144, 24);
            lblValidade.TabIndex = 8;
            lblValidade.Text = "Data Validade:";
            lblValidade.TextAlign = ContentAlignment.BottomLeft;
            // 
            // gpDetalhesProduto
            // 
            gpDetalhesProduto.Controls.Add(chkFabricacao);
            gpDetalhesProduto.Controls.Add(lblFabricacao);
            gpDetalhesProduto.Controls.Add(dtpFabricacao);
            gpDetalhesProduto.Controls.Add(chkValidade);
            gpDetalhesProduto.Controls.Add(lblValidade);
            gpDetalhesProduto.Controls.Add(dtpValidade);
            gpDetalhesProduto.Controls.Add(lblUnidade);
            gpDetalhesProduto.Controls.Add(cboUnidade);
            gpDetalhesProduto.Controls.Add(txtVolume);
            gpDetalhesProduto.Controls.Add(lblVolume);
            gpDetalhesProduto.Location = new Point(12, 186);
            gpDetalhesProduto.Name = "gpDetalhesProduto";
            gpDetalhesProduto.Size = new Size(610, 92);
            gpDetalhesProduto.TabIndex = 1;
            gpDetalhesProduto.TabStop = false;
            gpDetalhesProduto.Text = "Detalhes do Produto";
            // 
            // chkFabricacao
            // 
            chkFabricacao.AutoSize = true;
            chkFabricacao.Checked = true;
            chkFabricacao.CheckState = CheckState.Checked;
            chkFabricacao.Location = new Point(288, 52);
            chkFabricacao.Name = "chkFabricacao";
            chkFabricacao.Size = new Size(18, 17);
            chkFabricacao.TabIndex = 2;
            chkFabricacao.UseVisualStyleBackColor = true;
            // 
            // lblFabricacao
            // 
            lblFabricacao.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFabricacao.ForeColor = Color.FromArgb(54, 54, 54);
            lblFabricacao.Location = new Point(288, 22);
            lblFabricacao.Name = "lblFabricacao";
            lblFabricacao.Size = new Size(144, 24);
            lblFabricacao.TabIndex = 13;
            lblFabricacao.Text = "Data Fabricação:";
            lblFabricacao.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dtpFabricacao
            // 
            dtpFabricacao.CustomFormat = "d";
            dtpFabricacao.Format = DateTimePickerFormat.Short;
            dtpFabricacao.Location = new Point(309, 47);
            dtpFabricacao.Name = "dtpFabricacao";
            dtpFabricacao.Size = new Size(123, 27);
            dtpFabricacao.TabIndex = 3;
            dtpFabricacao.Value = new DateTime(2023, 8, 4, 0, 0, 0, 0);
            // 
            // chkValidade
            // 
            chkValidade.AutoSize = true;
            chkValidade.Checked = true;
            chkValidade.CheckState = CheckState.Checked;
            chkValidade.Location = new Point(449, 52);
            chkValidade.Name = "chkValidade";
            chkValidade.Size = new Size(18, 17);
            chkValidade.TabIndex = 4;
            chkValidade.UseVisualStyleBackColor = true;
            // 
            // lblAltura
            // 
            lblAltura.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAltura.ForeColor = Color.FromArgb(54, 54, 54);
            lblAltura.Location = new Point(21, 19);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(179, 24);
            lblAltura.TabIndex = 11;
            lblAltura.Text = "Altura (cm)";
            lblAltura.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtAltura
            // 
            txtAltura.BorderStyle = BorderStyle.FixedSingle;
            txtAltura.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.ForeColor = Color.FromArgb(64, 64, 64);
            txtAltura.Location = new Point(21, 46);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(179, 26);
            txtAltura.TabIndex = 1;
            // 
            // lblLargura
            // 
            lblLargura.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblLargura.ForeColor = Color.FromArgb(54, 54, 54);
            lblLargura.Location = new Point(218, 19);
            lblLargura.Name = "lblLargura";
            lblLargura.Size = new Size(179, 24);
            lblLargura.TabIndex = 13;
            lblLargura.Text = "Largura (cm)";
            lblLargura.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtLargura
            // 
            txtLargura.BorderStyle = BorderStyle.FixedSingle;
            txtLargura.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLargura.ForeColor = Color.FromArgb(64, 64, 64);
            txtLargura.Location = new Point(218, 46);
            txtLargura.Name = "txtLargura";
            txtLargura.Size = new Size(179, 26);
            txtLargura.TabIndex = 2;
            // 
            // lblComprimento
            // 
            lblComprimento.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblComprimento.ForeColor = Color.FromArgb(54, 54, 54);
            lblComprimento.Location = new Point(414, 19);
            lblComprimento.Name = "lblComprimento";
            lblComprimento.Size = new Size(179, 24);
            lblComprimento.TabIndex = 15;
            lblComprimento.Text = "Comprimento (cm)";
            lblComprimento.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtComprimento
            // 
            txtComprimento.BorderStyle = BorderStyle.FixedSingle;
            txtComprimento.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtComprimento.ForeColor = Color.FromArgb(64, 64, 64);
            txtComprimento.Location = new Point(414, 46);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new Size(179, 26);
            txtComprimento.TabIndex = 3;
            // 
            // gpDimensoes
            // 
            gpDimensoes.Controls.Add(txtComprimento);
            gpDimensoes.Controls.Add(lblComprimento);
            gpDimensoes.Controls.Add(txtLargura);
            gpDimensoes.Controls.Add(lblLargura);
            gpDimensoes.Controls.Add(txtAltura);
            gpDimensoes.Controls.Add(lblAltura);
            gpDimensoes.Location = new Point(12, 279);
            gpDimensoes.Name = "gpDimensoes";
            gpDimensoes.Size = new Size(610, 88);
            gpDimensoes.TabIndex = 2;
            gpDimensoes.TabStop = false;
            gpDimensoes.Text = "Dimensões";
            // 
            // cboMarca
            // 
            cboMarca.DropDownHeight = 150;
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.IntegralHeight = false;
            cboMarca.Location = new Point(21, 44);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(239, 28);
            cboMarca.TabIndex = 1;
            // 
            // lblMarca
            // 
            lblMarca.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarca.ForeColor = Color.FromArgb(54, 54, 54);
            lblMarca.Location = new Point(21, 19);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(274, 24);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca";
            lblMarca.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownHeight = 150;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.IntegralHeight = false;
            cboCategoria.Location = new Point(313, 44);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(245, 28);
            cboCategoria.TabIndex = 2;
            // 
            // lblCategoria
            // 
            lblCategoria.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.ForeColor = Color.FromArgb(54, 54, 54);
            lblCategoria.Location = new Point(313, 19);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(280, 24);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoria";
            lblCategoria.TextAlign = ContentAlignment.BottomLeft;
            // 
            // gpMarcaCategoria
            // 
            gpMarcaCategoria.Controls.Add(btnCadastrarCategoria);
            gpMarcaCategoria.Controls.Add(btnCadastrarMarca);
            gpMarcaCategoria.Controls.Add(lblCategoria);
            gpMarcaCategoria.Controls.Add(cboCategoria);
            gpMarcaCategoria.Controls.Add(lblMarca);
            gpMarcaCategoria.Controls.Add(cboMarca);
            gpMarcaCategoria.Location = new Point(12, 368);
            gpMarcaCategoria.Name = "gpMarcaCategoria";
            gpMarcaCategoria.Size = new Size(610, 88);
            gpMarcaCategoria.TabIndex = 3;
            gpMarcaCategoria.TabStop = false;
            gpMarcaCategoria.Text = "Marca e Categoria";
            // 
            // btnCadastrarCategoria
            // 
            btnCadastrarCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCadastrarCategoria.BackColor = Color.FromArgb(0, 192, 192);
            btnCadastrarCategoria.FlatAppearance.BorderColor = Color.Silver;
            btnCadastrarCategoria.FlatAppearance.BorderSize = 0;
            btnCadastrarCategoria.FlatStyle = FlatStyle.Flat;
            btnCadastrarCategoria.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarCategoria.ForeColor = Color.White;
            btnCadastrarCategoria.Location = new Point(564, 43);
            btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            btnCadastrarCategoria.Size = new Size(29, 29);
            btnCadastrarCategoria.TabIndex = 11;
            btnCadastrarCategoria.Text = "+";
            btnCadastrarCategoria.UseVisualStyleBackColor = false;
            btnCadastrarCategoria.Click += btnCadastrarCategoria_Click;
            // 
            // btnCadastrarMarca
            // 
            btnCadastrarMarca.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCadastrarMarca.BackColor = Color.FromArgb(0, 192, 192);
            btnCadastrarMarca.FlatAppearance.BorderColor = Color.Silver;
            btnCadastrarMarca.FlatAppearance.BorderSize = 0;
            btnCadastrarMarca.FlatStyle = FlatStyle.Flat;
            btnCadastrarMarca.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarMarca.ForeColor = Color.White;
            btnCadastrarMarca.Location = new Point(266, 43);
            btnCadastrarMarca.Name = "btnCadastrarMarca";
            btnCadastrarMarca.Size = new Size(29, 29);
            btnCadastrarMarca.TabIndex = 8;
            btnCadastrarMarca.Text = "+";
            btnCadastrarMarca.UseVisualStyleBackColor = false;
            btnCadastrarMarca.Click += btnCadastrarMarca_Click;
            // 
            // gpFormatoTipoEmbalagem
            // 
            gpFormatoTipoEmbalagem.Controls.Add(btnCadastrarEmbalagem);
            gpFormatoTipoEmbalagem.Controls.Add(btnCadastrarFormato);
            gpFormatoTipoEmbalagem.Controls.Add(lblEmbalagem);
            gpFormatoTipoEmbalagem.Controls.Add(cboEmbalagem);
            gpFormatoTipoEmbalagem.Controls.Add(lblFormato);
            gpFormatoTipoEmbalagem.Controls.Add(cboFormato);
            gpFormatoTipoEmbalagem.Location = new Point(12, 458);
            gpFormatoTipoEmbalagem.Name = "gpFormatoTipoEmbalagem";
            gpFormatoTipoEmbalagem.Size = new Size(610, 89);
            gpFormatoTipoEmbalagem.TabIndex = 4;
            gpFormatoTipoEmbalagem.TabStop = false;
            gpFormatoTipoEmbalagem.Text = "Formato e Tipo de Embalagem";
            // 
            // btnCadastrarEmbalagem
            // 
            btnCadastrarEmbalagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCadastrarEmbalagem.BackColor = Color.FromArgb(0, 192, 192);
            btnCadastrarEmbalagem.FlatAppearance.BorderColor = Color.Silver;
            btnCadastrarEmbalagem.FlatAppearance.BorderSize = 0;
            btnCadastrarEmbalagem.FlatStyle = FlatStyle.Flat;
            btnCadastrarEmbalagem.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarEmbalagem.ForeColor = Color.White;
            btnCadastrarEmbalagem.Location = new Point(564, 43);
            btnCadastrarEmbalagem.Name = "btnCadastrarEmbalagem";
            btnCadastrarEmbalagem.Size = new Size(29, 29);
            btnCadastrarEmbalagem.TabIndex = 12;
            btnCadastrarEmbalagem.Text = "+";
            btnCadastrarEmbalagem.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarFormato
            // 
            btnCadastrarFormato.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCadastrarFormato.BackColor = Color.FromArgb(0, 192, 192);
            btnCadastrarFormato.FlatAppearance.BorderColor = Color.Silver;
            btnCadastrarFormato.FlatAppearance.BorderSize = 0;
            btnCadastrarFormato.FlatStyle = FlatStyle.Flat;
            btnCadastrarFormato.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarFormato.ForeColor = Color.White;
            btnCadastrarFormato.Location = new Point(266, 43);
            btnCadastrarFormato.Name = "btnCadastrarFormato";
            btnCadastrarFormato.Size = new Size(29, 29);
            btnCadastrarFormato.TabIndex = 11;
            btnCadastrarFormato.Text = "+";
            btnCadastrarFormato.UseVisualStyleBackColor = false;
            // 
            // lblEmbalagem
            // 
            lblEmbalagem.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmbalagem.ForeColor = Color.FromArgb(54, 54, 54);
            lblEmbalagem.Location = new Point(313, 19);
            lblEmbalagem.Name = "lblEmbalagem";
            lblEmbalagem.Size = new Size(280, 24);
            lblEmbalagem.TabIndex = 10;
            lblEmbalagem.Text = "Embalagem";
            lblEmbalagem.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboEmbalagem
            // 
            cboEmbalagem.DropDownHeight = 150;
            cboEmbalagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmbalagem.FormattingEnabled = true;
            cboEmbalagem.IntegralHeight = false;
            cboEmbalagem.Location = new Point(313, 44);
            cboEmbalagem.Name = "cboEmbalagem";
            cboEmbalagem.Size = new Size(245, 28);
            cboEmbalagem.TabIndex = 2;
            // 
            // lblFormato
            // 
            lblFormato.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormato.ForeColor = Color.FromArgb(54, 54, 54);
            lblFormato.Location = new Point(21, 19);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(274, 24);
            lblFormato.TabIndex = 8;
            lblFormato.Text = "Formato";
            lblFormato.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboFormato
            // 
            cboFormato.DropDownHeight = 150;
            cboFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormato.FormattingEnabled = true;
            cboFormato.IntegralHeight = false;
            cboFormato.Location = new Point(21, 44);
            cboFormato.Name = "cboFormato";
            cboFormato.Size = new Size(239, 28);
            cboFormato.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSair.BackColor = Color.Red;
            btnSair.FlatAppearance.BorderColor = Color.DarkRed;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(12, 561);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.Green;
            btnSalvar.FlatAppearance.BorderColor = Color.Green;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(528, 561);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpar.BackColor = Color.White;
            btnLimpar.FlatAppearance.BorderColor = Color.Silver;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(428, 561);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // FrmCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(633, 600);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnSair);
            Controls.Add(gpFormatoTipoEmbalagem);
            Controls.Add(gpMarcaCategoria);
            Controls.Add(gpDimensoes);
            Controls.Add(gpDetalhesProduto);
            Controls.Add(gpProduto);
            Name = "FrmCadastrarProduto";
            Text = "Cadastrar Produtos";
            Load += FrmCadastrarProduto_Load;
            gpProduto.ResumeLayout(false);
            gpProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImgProduto).EndInit();
            gpDetalhesProduto.ResumeLayout(false);
            gpDetalhesProduto.PerformLayout();
            gpDimensoes.ResumeLayout(false);
            gpDimensoes.PerformLayout();
            gpMarcaCategoria.ResumeLayout(false);
            gpFormatoTipoEmbalagem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpProduto;
        private TextBox txtNomeProduto;
        private Label lblNomeProduto;
        private PictureBox pcbImgProduto;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private Label lblVolume;
        private TextBox txtVolume;
        private ComboBox cboUnidade;
        private Label lblUnidade;
        private DateTimePicker dtpValidade;
        private Label lblValidade;
        private GroupBox gpDetalhesProduto;
        private Label lblAltura;
        private TextBox txtAltura;
        private Label lblLargura;
        private TextBox txtLargura;
        private Label lblComprimento;
        private TextBox txtComprimento;
        private GroupBox gpDimensoes;
        private ComboBox cboMarca;
        private Label lblMarca;
        private ComboBox cboCategoria;
        private Label lblCategoria;
        private GroupBox gpMarcaCategoria;
        private GroupBox gpFormatoTipoEmbalagem;
        private Label lblEmbalagem;
        private ComboBox cboEmbalagem;
        private Label lblFormato;
        private ComboBox cboFormato;
        private Button btnSair;
        private Button btnSalvar;
        private Button btnLimpar;
        private CheckBox chkValidade;
        private CheckBox chkFabricacao;
        private Label lblFabricacao;
        private DateTimePicker dtpFabricacao;
        private Button btnCadastrarCategoria;
        private Button btnCadastrarMarca;
        private Button btnCadastrarEmbalagem;
        private Button btnCadastrarFormato;
    }
}