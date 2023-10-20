namespace Estoque.Telas_Produto
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
            tlpPrincipal = new TableLayoutPanel();
            tblCentral = new TableLayoutPanel();
            tlpComboBoxs2 = new TableLayoutPanel();
            cboFormato = new ComboBox();
            lblMarca = new Label();
            cboMarca = new ComboBox();
            lblFormato = new Label();
            tblBotoes = new TableLayoutPanel();
            btnSalvar = new Button();
            btnLimpar = new Button();
            tlpInformacoesBase = new TableLayoutPanel();
            pcbImagem = new PictureBox();
            tblInformacoesBaseDados = new TableLayoutPanel();
            tlpNomeProduto = new TableLayoutPanel();
            lblNomeProduto = new Label();
            lblValidade = new Label();
            lblFabricacao = new Label();
            tlpInformacoesBaseNomeCompleto = new TableLayoutPanel();
            dtpValidade = new DateTimePicker();
            txtNomeCompleto = new TextBox();
            pValidarNomeCompleto = new Panel();
            pDivisoria1 = new Panel();
            pDivisoria2 = new Panel();
            dtpFabricacao = new DateTimePicker();
            tlpInformacoesBaseUsuario = new TableLayoutPanel();
            txtDescricao = new TextBox();
            lblDescrição = new Label();
            tlpEmail = new TableLayoutPanel();
            tlpDigitarEmail = new TableLayoutPanel();
            txtAltura = new TextBox();
            lblEmail = new Label();
            lblConfirmarEmail = new Label();
            tlpLargura = new TableLayoutPanel();
            txtLargura = new TextBox();
            lblComprimento = new Label();
            tlpComprimento = new TableLayoutPanel();
            txtComprimento = new TextBox();
            tlpComboBoxs1 = new TableLayoutPanel();
            cboEmbalagem = new ComboBox();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            lblEmbalagem = new Label();
            tlpSenha = new TableLayoutPanel();
            lblVolume = new Label();
            tlpVolume = new TableLayoutPanel();
            txtVolume = new TextBox();
            cboUnidadeMedida = new ComboBox();
            lblUnidadeMedida = new Label();
            tlpPrincipal.SuspendLayout();
            tblCentral.SuspendLayout();
            tlpComboBoxs2.SuspendLayout();
            tblBotoes.SuspendLayout();
            tlpInformacoesBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).BeginInit();
            tblInformacoesBaseDados.SuspendLayout();
            tlpNomeProduto.SuspendLayout();
            tlpInformacoesBaseNomeCompleto.SuspendLayout();
            tlpInformacoesBaseUsuario.SuspendLayout();
            tlpEmail.SuspendLayout();
            tlpDigitarEmail.SuspendLayout();
            tlpLargura.SuspendLayout();
            tlpComprimento.SuspendLayout();
            tlpComboBoxs1.SuspendLayout();
            tlpSenha.SuspendLayout();
            tlpVolume.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(80, 90, 100);
            tlpPrincipal.ColumnCount = 3;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpPrincipal.Controls.Add(tblCentral, 1, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Margin = new Padding(0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpPrincipal.Size = new Size(784, 667);
            tlpPrincipal.TabIndex = 0;
            // 
            // tblCentral
            // 
            tblCentral.BackColor = Color.FromArgb(80, 90, 100);
            tblCentral.ColumnCount = 1;
            tblCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCentral.Controls.Add(tlpComboBoxs2, 0, 3);
            tblCentral.Controls.Add(tblBotoes, 0, 8);
            tblCentral.Controls.Add(tlpInformacoesBase, 0, 0);
            tblCentral.Controls.Add(tlpEmail, 0, 5);
            tblCentral.Controls.Add(tlpComboBoxs1, 0, 2);
            tblCentral.Controls.Add(tlpSenha, 0, 6);
            tblCentral.Dock = DockStyle.Fill;
            tblCentral.Location = new Point(15, 15);
            tblCentral.Margin = new Padding(0);
            tblCentral.Name = "tblCentral";
            tblCentral.RowCount = 9;
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCentral.Size = new Size(754, 637);
            tblCentral.TabIndex = 0;
            // 
            // tlpComboBoxs2
            // 
            tlpComboBoxs2.BackColor = Color.FromArgb(60, 75, 85);
            tlpComboBoxs2.ColumnCount = 5;
            tlpComboBoxs2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComboBoxs2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpComboBoxs2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpComboBoxs2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpComboBoxs2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComboBoxs2.Controls.Add(cboFormato, 3, 1);
            tlpComboBoxs2.Controls.Add(lblMarca, 1, 0);
            tlpComboBoxs2.Controls.Add(cboMarca, 1, 1);
            tlpComboBoxs2.Controls.Add(lblFormato, 3, 0);
            tlpComboBoxs2.Location = new Point(0, 285);
            tlpComboBoxs2.Margin = new Padding(0);
            tlpComboBoxs2.Name = "tlpComboBoxs2";
            tlpComboBoxs2.RowCount = 3;
            tlpComboBoxs2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpComboBoxs2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpComboBoxs2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpComboBoxs2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComboBoxs2.Size = new Size(754, 75);
            tlpComboBoxs2.TabIndex = 5;
            // 
            // cboFormato
            // 
            cboFormato.Dock = DockStyle.Fill;
            cboFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormato.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboFormato.FormattingEnabled = true;
            cboFormato.Location = new Point(387, 34);
            cboFormato.Margin = new Padding(0);
            cboFormato.Name = "cboFormato";
            cboFormato.Size = new Size(352, 26);
            cboFormato.TabIndex = 7;
            // 
            // lblMarca
            // 
            lblMarca.Dock = DockStyle.Fill;
            lblMarca.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.ForeColor = SystemColors.ControlLightLight;
            lblMarca.Location = new Point(15, 0);
            lblMarca.Margin = new Padding(0);
            lblMarca.Name = "lblMarca";
            lblMarca.Padding = new Padding(0, 0, 0, 5);
            lblMarca.Size = new Size(352, 34);
            lblMarca.TabIndex = 5;
            lblMarca.Text = "Marca:";
            lblMarca.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboMarca
            // 
            cboMarca.Dock = DockStyle.Fill;
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(15, 34);
            cboMarca.Margin = new Padding(0);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(352, 26);
            cboMarca.TabIndex = 6;
            // 
            // lblFormato
            // 
            lblFormato.Dock = DockStyle.Fill;
            lblFormato.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormato.ForeColor = SystemColors.ControlLightLight;
            lblFormato.Location = new Point(387, 0);
            lblFormato.Margin = new Padding(0);
            lblFormato.Name = "lblFormato";
            lblFormato.Padding = new Padding(0, 0, 0, 5);
            lblFormato.Size = new Size(352, 34);
            lblFormato.TabIndex = 8;
            lblFormato.Text = "Formato:";
            lblFormato.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tblBotoes
            // 
            tblBotoes.ColumnCount = 4;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBotoes.Controls.Add(btnSalvar, 0, 0);
            tblBotoes.Controls.Add(btnLimpar, 2, 0);
            tblBotoes.Dock = DockStyle.Fill;
            tblBotoes.Location = new Point(0, 600);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(754, 37);
            tblBotoes.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Fill;
            btnSalvar.ForeColor = Color.FromArgb(66, 142, 79);
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(664, 0);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(10, 0, 0, 0);
            btnSalvar.Size = new Size(90, 37);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Dock = DockStyle.Fill;
            btnLimpar.ForeColor = Color.FromArgb(66, 159, 159);
            btnLimpar.Image = Properties.Resources.erase_outline_1;
            btnLimpar.Location = new Point(569, 0);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Padding = new Padding(5, 0, 0, 0);
            btnLimpar.Size = new Size(90, 37);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // tlpInformacoesBase
            // 
            tlpInformacoesBase.BackColor = Color.FromArgb(60, 75, 85);
            tlpInformacoesBase.ColumnCount = 5;
            tlpInformacoesBase.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpInformacoesBase.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tlpInformacoesBase.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpInformacoesBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInformacoesBase.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpInformacoesBase.Controls.Add(pcbImagem, 1, 1);
            tlpInformacoesBase.Controls.Add(tblInformacoesBaseDados, 3, 1);
            tlpInformacoesBase.Dock = DockStyle.Fill;
            tlpInformacoesBase.Location = new Point(0, 0);
            tlpInformacoesBase.Margin = new Padding(0);
            tlpInformacoesBase.Name = "tlpInformacoesBase";
            tlpInformacoesBase.RowCount = 3;
            tlpInformacoesBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpInformacoesBase.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInformacoesBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpInformacoesBase.Size = new Size(754, 165);
            tlpInformacoesBase.TabIndex = 0;
            // 
            // pcbImagem
            // 
            pcbImagem.BackColor = Color.WhiteSmoke;
            pcbImagem.BorderStyle = BorderStyle.FixedSingle;
            pcbImagem.Cursor = Cursors.Hand;
            pcbImagem.Dock = DockStyle.Fill;
            pcbImagem.Location = new Point(15, 15);
            pcbImagem.Margin = new Padding(0);
            pcbImagem.Name = "pcbImagem";
            pcbImagem.Size = new Size(135, 135);
            pcbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagem.TabIndex = 1;
            pcbImagem.TabStop = false;
            pcbImagem.Click += pcbImagemUsuario_Click;
            // 
            // tblInformacoesBaseDados
            // 
            tblInformacoesBaseDados.BackColor = Color.FromArgb(60, 75, 85);
            tblInformacoesBaseDados.ColumnCount = 1;
            tblInformacoesBaseDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblInformacoesBaseDados.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblInformacoesBaseDados.Controls.Add(tlpNomeProduto, 0, 0);
            tblInformacoesBaseDados.Controls.Add(tlpInformacoesBaseNomeCompleto, 0, 1);
            tblInformacoesBaseDados.Controls.Add(tlpInformacoesBaseUsuario, 0, 4);
            tblInformacoesBaseDados.Controls.Add(lblDescrição, 0, 3);
            tblInformacoesBaseDados.Dock = DockStyle.Fill;
            tblInformacoesBaseDados.Location = new Point(165, 15);
            tblInformacoesBaseDados.Margin = new Padding(0);
            tblInformacoesBaseDados.Name = "tblInformacoesBaseDados";
            tblInformacoesBaseDados.RowCount = 5;
            tblInformacoesBaseDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblInformacoesBaseDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tblInformacoesBaseDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblInformacoesBaseDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblInformacoesBaseDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tblInformacoesBaseDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblInformacoesBaseDados.Size = new Size(574, 135);
            tblInformacoesBaseDados.TabIndex = 2;
            // 
            // tlpNomeProduto
            // 
            tlpNomeProduto.AutoScroll = true;
            tlpNomeProduto.BackColor = Color.FromArgb(60, 75, 85);
            tlpNomeProduto.ColumnCount = 5;
            tlpNomeProduto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpNomeProduto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpNomeProduto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpNomeProduto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpNomeProduto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpNomeProduto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpNomeProduto.Controls.Add(lblNomeProduto, 0, 0);
            tlpNomeProduto.Controls.Add(lblValidade, 4, 0);
            tlpNomeProduto.Controls.Add(lblFabricacao, 2, 0);
            tlpNomeProduto.Dock = DockStyle.Fill;
            tlpNomeProduto.Location = new Point(0, 0);
            tlpNomeProduto.Margin = new Padding(0);
            tlpNomeProduto.Name = "tlpNomeProduto";
            tlpNomeProduto.RowCount = 1;
            tlpNomeProduto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpNomeProduto.Size = new Size(574, 34);
            tlpNomeProduto.TabIndex = 5;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.Dock = DockStyle.Fill;
            lblNomeProduto.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeProduto.ForeColor = SystemColors.ControlLightLight;
            lblNomeProduto.Location = new Point(0, 0);
            lblNomeProduto.Margin = new Padding(0);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Padding = new Padding(0, 0, 0, 5);
            lblNomeProduto.Size = new Size(294, 34);
            lblNomeProduto.TabIndex = 5;
            lblNomeProduto.Text = "Produto:";
            lblNomeProduto.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblValidade
            // 
            lblValidade.Dock = DockStyle.Fill;
            lblValidade.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidade.ForeColor = SystemColors.ControlLightLight;
            lblValidade.Location = new Point(454, 0);
            lblValidade.Margin = new Padding(0);
            lblValidade.Name = "lblValidade";
            lblValidade.Padding = new Padding(0, 0, 0, 5);
            lblValidade.Size = new Size(120, 34);
            lblValidade.TabIndex = 7;
            lblValidade.Text = "Validade:";
            lblValidade.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblFabricacao
            // 
            lblFabricacao.Dock = DockStyle.Fill;
            lblFabricacao.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFabricacao.ForeColor = SystemColors.ControlLightLight;
            lblFabricacao.Location = new Point(314, 0);
            lblFabricacao.Margin = new Padding(0);
            lblFabricacao.Name = "lblFabricacao";
            lblFabricacao.Padding = new Padding(0, 0, 0, 5);
            lblFabricacao.Size = new Size(120, 34);
            lblFabricacao.TabIndex = 6;
            lblFabricacao.Text = "Fabricação:";
            lblFabricacao.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tlpInformacoesBaseNomeCompleto
            // 
            tlpInformacoesBaseNomeCompleto.AutoScroll = true;
            tlpInformacoesBaseNomeCompleto.BackColor = Color.White;
            tlpInformacoesBaseNomeCompleto.ColumnCount = 6;
            tlpInformacoesBaseNomeCompleto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInformacoesBaseNomeCompleto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpInformacoesBaseNomeCompleto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpInformacoesBaseNomeCompleto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpInformacoesBaseNomeCompleto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpInformacoesBaseNomeCompleto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpInformacoesBaseNomeCompleto.Controls.Add(dtpValidade, 5, 0);
            tlpInformacoesBaseNomeCompleto.Controls.Add(txtNomeCompleto, 0, 0);
            tlpInformacoesBaseNomeCompleto.Controls.Add(pValidarNomeCompleto, 1, 0);
            tlpInformacoesBaseNomeCompleto.Controls.Add(pDivisoria1, 2, 0);
            tlpInformacoesBaseNomeCompleto.Controls.Add(pDivisoria2, 4, 0);
            tlpInformacoesBaseNomeCompleto.Controls.Add(dtpFabricacao, 3, 0);
            tlpInformacoesBaseNomeCompleto.Dock = DockStyle.Fill;
            tlpInformacoesBaseNomeCompleto.Location = new Point(0, 34);
            tlpInformacoesBaseNomeCompleto.Margin = new Padding(0);
            tlpInformacoesBaseNomeCompleto.Name = "tlpInformacoesBaseNomeCompleto";
            tlpInformacoesBaseNomeCompleto.RowCount = 1;
            tlpInformacoesBaseNomeCompleto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInformacoesBaseNomeCompleto.Size = new Size(574, 26);
            tlpInformacoesBaseNomeCompleto.TabIndex = 0;
            // 
            // dtpValidade
            // 
            dtpValidade.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpValidade.CalendarMonthBackground = Color.White;
            dtpValidade.Dock = DockStyle.Fill;
            dtpValidade.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpValidade.Format = DateTimePickerFormat.Short;
            dtpValidade.Location = new Point(454, 0);
            dtpValidade.Margin = new Padding(0);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(120, 25);
            dtpValidade.TabIndex = 2;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.BorderStyle = BorderStyle.None;
            txtNomeCompleto.Dock = DockStyle.Fill;
            txtNomeCompleto.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCompleto.Location = new Point(10, 4);
            txtNomeCompleto.Margin = new Padding(10, 4, 0, 0);
            txtNomeCompleto.MaxLength = 120;
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.PlaceholderText = "Digite o nome do produto";
            txtNomeCompleto.Size = new Size(274, 18);
            txtNomeCompleto.TabIndex = 0;
            // 
            // pValidarNomeCompleto
            // 
            pValidarNomeCompleto.BackColor = Color.FromArgb(16, 23, 28);
            pValidarNomeCompleto.Location = new Point(284, 0);
            pValidarNomeCompleto.Margin = new Padding(0);
            pValidarNomeCompleto.Name = "pValidarNomeCompleto";
            pValidarNomeCompleto.Size = new Size(10, 26);
            pValidarNomeCompleto.TabIndex = 29;
            // 
            // pDivisoria1
            // 
            pDivisoria1.BackColor = Color.FromArgb(60, 75, 85);
            pDivisoria1.Dock = DockStyle.Fill;
            pDivisoria1.Location = new Point(294, 0);
            pDivisoria1.Margin = new Padding(0);
            pDivisoria1.Name = "pDivisoria1";
            pDivisoria1.Size = new Size(20, 26);
            pDivisoria1.TabIndex = 30;
            // 
            // pDivisoria2
            // 
            pDivisoria2.BackColor = Color.FromArgb(60, 75, 85);
            pDivisoria2.Dock = DockStyle.Fill;
            pDivisoria2.Location = new Point(434, 0);
            pDivisoria2.Margin = new Padding(0);
            pDivisoria2.Name = "pDivisoria2";
            pDivisoria2.Size = new Size(20, 26);
            pDivisoria2.TabIndex = 31;
            // 
            // dtpFabricacao
            // 
            dtpFabricacao.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFabricacao.CalendarMonthBackground = Color.White;
            dtpFabricacao.Dock = DockStyle.Fill;
            dtpFabricacao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFabricacao.Format = DateTimePickerFormat.Short;
            dtpFabricacao.Location = new Point(314, 0);
            dtpFabricacao.Margin = new Padding(0);
            dtpFabricacao.Name = "dtpFabricacao";
            dtpFabricacao.Size = new Size(120, 25);
            dtpFabricacao.TabIndex = 1;
            // 
            // tlpInformacoesBaseUsuario
            // 
            tlpInformacoesBaseUsuario.AutoScroll = true;
            tlpInformacoesBaseUsuario.BackColor = Color.White;
            tlpInformacoesBaseUsuario.ColumnCount = 2;
            tlpInformacoesBaseUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInformacoesBaseUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpInformacoesBaseUsuario.Controls.Add(txtDescricao, 0, 0);
            tlpInformacoesBaseUsuario.Dock = DockStyle.Fill;
            tlpInformacoesBaseUsuario.Location = new Point(0, 109);
            tlpInformacoesBaseUsuario.Margin = new Padding(0);
            tlpInformacoesBaseUsuario.Name = "tlpInformacoesBaseUsuario";
            tlpInformacoesBaseUsuario.RowCount = 1;
            tlpInformacoesBaseUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInformacoesBaseUsuario.Size = new Size(574, 26);
            tlpInformacoesBaseUsuario.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Dock = DockStyle.Fill;
            txtDescricao.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.Location = new Point(10, 4);
            txtDescricao.Margin = new Padding(10, 4, 0, 0);
            txtDescricao.MaxLength = 120;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Digite uma descrição para o produto";
            txtDescricao.Size = new Size(554, 18);
            txtDescricao.TabIndex = 3;
            // 
            // lblDescrição
            // 
            lblDescrição.Dock = DockStyle.Fill;
            lblDescrição.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescrição.ForeColor = SystemColors.ControlLightLight;
            lblDescrição.Location = new Point(0, 75);
            lblDescrição.Margin = new Padding(0);
            lblDescrição.Name = "lblDescrição";
            lblDescrição.Padding = new Padding(0, 0, 0, 5);
            lblDescrição.Size = new Size(574, 34);
            lblDescrição.TabIndex = 4;
            lblDescrição.Text = "Descrição:";
            lblDescrição.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tlpEmail
            // 
            tlpEmail.BackColor = Color.FromArgb(60, 75, 85);
            tlpEmail.ColumnCount = 7;
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpEmail.Controls.Add(tlpDigitarEmail, 1, 1);
            tlpEmail.Controls.Add(lblEmail, 1, 0);
            tlpEmail.Controls.Add(lblConfirmarEmail, 3, 0);
            tlpEmail.Controls.Add(tlpLargura, 3, 1);
            tlpEmail.Controls.Add(lblComprimento, 5, 0);
            tlpEmail.Controls.Add(tlpComprimento, 5, 1);
            tlpEmail.Dock = DockStyle.Fill;
            tlpEmail.Location = new Point(0, 405);
            tlpEmail.Margin = new Padding(0);
            tlpEmail.Name = "tlpEmail";
            tlpEmail.RowCount = 3;
            tlpEmail.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpEmail.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpEmail.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpEmail.Size = new Size(754, 75);
            tlpEmail.TabIndex = 2;
            // 
            // tlpDigitarEmail
            // 
            tlpDigitarEmail.AutoScroll = true;
            tlpDigitarEmail.BackColor = Color.White;
            tlpDigitarEmail.ColumnCount = 2;
            tlpDigitarEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDigitarEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpDigitarEmail.Controls.Add(txtAltura, 0, 0);
            tlpDigitarEmail.Dock = DockStyle.Fill;
            tlpDigitarEmail.Location = new Point(15, 34);
            tlpDigitarEmail.Margin = new Padding(0);
            tlpDigitarEmail.Name = "tlpDigitarEmail";
            tlpDigitarEmail.RowCount = 1;
            tlpDigitarEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDigitarEmail.Size = new Size(228, 26);
            tlpDigitarEmail.TabIndex = 15;
            // 
            // txtAltura
            // 
            txtAltura.BorderStyle = BorderStyle.None;
            txtAltura.Dock = DockStyle.Fill;
            txtAltura.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.Location = new Point(10, 4);
            txtAltura.Margin = new Padding(10, 4, 0, 0);
            txtAltura.MaxLength = 2000;
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "00.00";
            txtAltura.Size = new Size(208, 18);
            txtAltura.TabIndex = 8;
            txtAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(15, 0);
            lblEmail.Margin = new Padding(0);
            lblEmail.Name = "lblEmail";
            lblEmail.Padding = new Padding(0, 0, 0, 5);
            lblEmail.Size = new Size(228, 34);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Altura (cm):";
            lblEmail.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblConfirmarEmail
            // 
            lblConfirmarEmail.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmarEmail.ForeColor = SystemColors.ControlLightLight;
            lblConfirmarEmail.Location = new Point(263, 0);
            lblConfirmarEmail.Margin = new Padding(0);
            lblConfirmarEmail.Name = "lblConfirmarEmail";
            lblConfirmarEmail.Padding = new Padding(0, 0, 0, 5);
            lblConfirmarEmail.Size = new Size(228, 34);
            lblConfirmarEmail.TabIndex = 18;
            lblConfirmarEmail.Text = "Largura (cm):";
            lblConfirmarEmail.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tlpLargura
            // 
            tlpLargura.AutoScroll = true;
            tlpLargura.BackColor = Color.White;
            tlpLargura.ColumnCount = 2;
            tlpLargura.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLargura.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpLargura.Controls.Add(txtLargura, 0, 0);
            tlpLargura.Dock = DockStyle.Fill;
            tlpLargura.Location = new Point(263, 34);
            tlpLargura.Margin = new Padding(0);
            tlpLargura.Name = "tlpLargura";
            tlpLargura.RowCount = 1;
            tlpLargura.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLargura.Size = new Size(228, 26);
            tlpLargura.TabIndex = 19;
            // 
            // txtLargura
            // 
            txtLargura.BorderStyle = BorderStyle.None;
            txtLargura.Dock = DockStyle.Fill;
            txtLargura.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtLargura.Location = new Point(10, 4);
            txtLargura.Margin = new Padding(10, 4, 0, 0);
            txtLargura.MaxLength = 2000;
            txtLargura.Name = "txtLargura";
            txtLargura.PlaceholderText = "00.00";
            txtLargura.Size = new Size(208, 18);
            txtLargura.TabIndex = 9;
            txtLargura.TextAlign = HorizontalAlignment.Right;
            // 
            // lblComprimento
            // 
            lblComprimento.Dock = DockStyle.Fill;
            lblComprimento.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblComprimento.ForeColor = SystemColors.ControlLightLight;
            lblComprimento.Location = new Point(511, 0);
            lblComprimento.Margin = new Padding(0);
            lblComprimento.Name = "lblComprimento";
            lblComprimento.Padding = new Padding(0, 0, 0, 5);
            lblComprimento.Size = new Size(228, 34);
            lblComprimento.TabIndex = 20;
            lblComprimento.Text = "Comprimento (cm):";
            lblComprimento.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tlpComprimento
            // 
            tlpComprimento.AutoScroll = true;
            tlpComprimento.BackColor = Color.White;
            tlpComprimento.ColumnCount = 2;
            tlpComprimento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpComprimento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpComprimento.Controls.Add(txtComprimento, 0, 0);
            tlpComprimento.Dock = DockStyle.Fill;
            tlpComprimento.Location = new Point(511, 34);
            tlpComprimento.Margin = new Padding(0);
            tlpComprimento.Name = "tlpComprimento";
            tlpComprimento.RowCount = 1;
            tlpComprimento.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComprimento.Size = new Size(228, 26);
            tlpComprimento.TabIndex = 21;
            // 
            // txtComprimento
            // 
            txtComprimento.BorderStyle = BorderStyle.None;
            txtComprimento.Dock = DockStyle.Fill;
            txtComprimento.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtComprimento.Location = new Point(10, 4);
            txtComprimento.Margin = new Padding(10, 4, 0, 0);
            txtComprimento.MaxLength = 2000;
            txtComprimento.Name = "txtComprimento";
            txtComprimento.PlaceholderText = "00.00";
            txtComprimento.Size = new Size(208, 18);
            txtComprimento.TabIndex = 10;
            txtComprimento.TextAlign = HorizontalAlignment.Right;
            // 
            // tlpComboBoxs1
            // 
            tlpComboBoxs1.BackColor = Color.FromArgb(60, 75, 85);
            tlpComboBoxs1.ColumnCount = 5;
            tlpComboBoxs1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComboBoxs1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpComboBoxs1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpComboBoxs1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpComboBoxs1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComboBoxs1.Controls.Add(cboEmbalagem, 3, 1);
            tlpComboBoxs1.Controls.Add(lblCategoria, 1, 0);
            tlpComboBoxs1.Controls.Add(cboCategoria, 1, 1);
            tlpComboBoxs1.Controls.Add(lblEmbalagem, 3, 0);
            tlpComboBoxs1.Location = new Point(0, 210);
            tlpComboBoxs1.Margin = new Padding(0);
            tlpComboBoxs1.Name = "tlpComboBoxs1";
            tlpComboBoxs1.RowCount = 3;
            tlpComboBoxs1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpComboBoxs1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpComboBoxs1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpComboBoxs1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComboBoxs1.Size = new Size(754, 75);
            tlpComboBoxs1.TabIndex = 1;
            // 
            // cboEmbalagem
            // 
            cboEmbalagem.Dock = DockStyle.Fill;
            cboEmbalagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmbalagem.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboEmbalagem.FormattingEnabled = true;
            cboEmbalagem.Location = new Point(387, 34);
            cboEmbalagem.Margin = new Padding(0);
            cboEmbalagem.Name = "cboEmbalagem";
            cboEmbalagem.Size = new Size(352, 26);
            cboEmbalagem.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.Dock = DockStyle.Fill;
            lblCategoria.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.ForeColor = SystemColors.ControlLightLight;
            lblCategoria.Location = new Point(15, 0);
            lblCategoria.Margin = new Padding(0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Padding = new Padding(0, 0, 0, 5);
            lblCategoria.Size = new Size(352, 34);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            lblCategoria.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboCategoria
            // 
            cboCategoria.Dock = DockStyle.Fill;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(15, 34);
            cboCategoria.Margin = new Padding(0);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(352, 26);
            cboCategoria.TabIndex = 4;
            // 
            // lblEmbalagem
            // 
            lblEmbalagem.Dock = DockStyle.Fill;
            lblEmbalagem.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmbalagem.ForeColor = SystemColors.ControlLightLight;
            lblEmbalagem.Location = new Point(387, 0);
            lblEmbalagem.Margin = new Padding(0);
            lblEmbalagem.Name = "lblEmbalagem";
            lblEmbalagem.Padding = new Padding(0, 0, 0, 5);
            lblEmbalagem.Size = new Size(352, 34);
            lblEmbalagem.TabIndex = 8;
            lblEmbalagem.Text = "Embalagem:";
            lblEmbalagem.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tlpSenha
            // 
            tlpSenha.BackColor = Color.FromArgb(60, 75, 85);
            tlpSenha.ColumnCount = 5;
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5882359F));
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5882359F));
            tlpSenha.Controls.Add(lblVolume, 1, 0);
            tlpSenha.Controls.Add(tlpVolume, 1, 1);
            tlpSenha.Controls.Add(cboUnidadeMedida, 3, 1);
            tlpSenha.Controls.Add(lblUnidadeMedida, 3, 0);
            tlpSenha.Location = new Point(0, 480);
            tlpSenha.Margin = new Padding(0);
            tlpSenha.Name = "tlpSenha";
            tlpSenha.RowCount = 3;
            tlpSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpSenha.Size = new Size(754, 75);
            tlpSenha.TabIndex = 3;
            // 
            // lblVolume
            // 
            lblVolume.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVolume.ForeColor = SystemColors.ControlLightLight;
            lblVolume.Location = new Point(151, 0);
            lblVolume.Margin = new Padding(0);
            lblVolume.Name = "lblVolume";
            lblVolume.Padding = new Padding(0, 0, 0, 5);
            lblVolume.Size = new Size(215, 34);
            lblVolume.TabIndex = 5;
            lblVolume.Text = "Volume:";
            lblVolume.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tlpVolume
            // 
            tlpVolume.AutoScroll = true;
            tlpVolume.BackColor = Color.White;
            tlpVolume.ColumnCount = 2;
            tlpVolume.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpVolume.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpVolume.Controls.Add(txtVolume, 0, 0);
            tlpVolume.Dock = DockStyle.Fill;
            tlpVolume.Location = new Point(151, 34);
            tlpVolume.Margin = new Padding(0);
            tlpVolume.Name = "tlpVolume";
            tlpVolume.RowCount = 1;
            tlpVolume.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpVolume.Size = new Size(215, 26);
            tlpVolume.TabIndex = 16;
            // 
            // txtVolume
            // 
            txtVolume.BorderStyle = BorderStyle.None;
            txtVolume.Dock = DockStyle.Fill;
            txtVolume.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtVolume.Location = new Point(10, 4);
            txtVolume.Margin = new Padding(10, 4, 0, 0);
            txtVolume.MaxLength = 2000;
            txtVolume.Name = "txtVolume";
            txtVolume.PlaceholderText = "00.00";
            txtVolume.Size = new Size(195, 18);
            txtVolume.TabIndex = 11;
            txtVolume.TextAlign = HorizontalAlignment.Right;
            // 
            // cboUnidadeMedida
            // 
            cboUnidadeMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnidadeMedida.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboUnidadeMedida.FormattingEnabled = true;
            cboUnidadeMedida.Location = new Point(386, 34);
            cboUnidadeMedida.Margin = new Padding(0);
            cboUnidadeMedida.Name = "cboUnidadeMedida";
            cboUnidadeMedida.Size = new Size(215, 26);
            cboUnidadeMedida.TabIndex = 12;
            // 
            // lblUnidadeMedida
            // 
            lblUnidadeMedida.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnidadeMedida.ForeColor = SystemColors.ControlLightLight;
            lblUnidadeMedida.Location = new Point(386, 0);
            lblUnidadeMedida.Margin = new Padding(0);
            lblUnidadeMedida.Name = "lblUnidadeMedida";
            lblUnidadeMedida.Padding = new Padding(0, 0, 0, 5);
            lblUnidadeMedida.Size = new Size(215, 34);
            lblUnidadeMedida.TabIndex = 18;
            lblUnidadeMedida.Text = "Unidade de medida:";
            lblUnidadeMedida.TextAlign = ContentAlignment.BottomCenter;
            // 
            // FrmCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(784, 667);
            Controls.Add(tlpPrincipal);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "FrmCadastrarProduto";
            Text = "Cadastrar Produto";
            FormClosed += FrmCadastrarUsuario_FormClosed;
            Load += FrmCadastrarUsuario_Load;
            tlpPrincipal.ResumeLayout(false);
            tblCentral.ResumeLayout(false);
            tlpComboBoxs2.ResumeLayout(false);
            tblBotoes.ResumeLayout(false);
            tlpInformacoesBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbImagem).EndInit();
            tblInformacoesBaseDados.ResumeLayout(false);
            tlpNomeProduto.ResumeLayout(false);
            tlpInformacoesBaseNomeCompleto.ResumeLayout(false);
            tlpInformacoesBaseNomeCompleto.PerformLayout();
            tlpInformacoesBaseUsuario.ResumeLayout(false);
            tlpInformacoesBaseUsuario.PerformLayout();
            tlpEmail.ResumeLayout(false);
            tlpDigitarEmail.ResumeLayout(false);
            tlpDigitarEmail.PerformLayout();
            tlpLargura.ResumeLayout(false);
            tlpLargura.PerformLayout();
            tlpComprimento.ResumeLayout(false);
            tlpComprimento.PerformLayout();
            tlpComboBoxs1.ResumeLayout(false);
            tlpSenha.ResumeLayout(false);
            tlpVolume.ResumeLayout(false);
            tlpVolume.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tblCentral;
        private TableLayoutPanel tblBotoes;
        private Button btnSalvar;
        private Button btnLimpar;
        private TableLayoutPanel tlpInformacoesBase;
        private TableLayoutPanel tlpComboBoxs1;
        private PictureBox pcbImagem;
        private TableLayoutPanel tblInformacoesBaseDados;
        private Label lblDescrição;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private ComboBox cboEmbalagem;
        private Label lblEmbalagem;
        private TableLayoutPanel tlpEmail;
        private TableLayoutPanel tlpDigitarEmail;
        private TextBox txtAltura;
        private Label lblEmail;
        private Label lblConfirmarEmail;
        private TableLayoutPanel tlpLargura;
        private TextBox txtLargura;
        private TableLayoutPanel tlpInformacoesBaseNomeCompleto;
        private Panel pValidarNomeCompleto;
        private TableLayoutPanel tlpInformacoesBaseUsuario;
        private TextBox txtDescricao;
        private TableLayoutPanel tlpComboBoxs2;
        private ComboBox cboFormato;
        private Label lblMarca;
        private ComboBox cboMarca;
        private Label lblFormato;
        private TextBox txtNomeCompleto;
        private Panel pDivisoria1;
        private Panel pDivisoria2;
        private DateTimePicker dtpValidade;
        private DateTimePicker dtpFabricacao;
        private TableLayoutPanel tlpNomeProduto;
        private Label lblNomeProduto;
        private Label lblValidade;
        private Label lblFabricacao;
        private Label lblComprimento;
        private TableLayoutPanel tlpComprimento;
        private TextBox txtComprimento;
        private TableLayoutPanel tlpSenha;
        private Label lblVolume;
        private TableLayoutPanel tlpVolume;
        private TextBox txtVolume;
        private ComboBox cboUnidadeMedida;
        private Label lblUnidadeMedida;
    }
}