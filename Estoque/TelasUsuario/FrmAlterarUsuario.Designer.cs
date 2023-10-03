namespace Estoque.Telas_Usuario
{
    partial class FrmAlterarUsuario
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
            tblBotoes = new TableLayoutPanel();
            btnSalvar = new Button();
            btnLimpar = new Button();
            tlpInformacoesBase = new TableLayoutPanel();
            pcbImagemUsuario = new PictureBox();
            tblInformacoesBaseDados = new TableLayoutPanel();
            tlpInformacoesBaseNomeCompleto = new TableLayoutPanel();
            txtNomeCompleto = new TextBox();
            pValidarNomeCompleto = new Panel();
            tlpInformacoesBaseUsuario = new TableLayoutPanel();
            txtUsuario = new TextBox();
            pValidarUsuario = new Panel();
            lblNomeCompleto = new Label();
            lblUsuario = new Label();
            tlpSetor = new TableLayoutPanel();
            cboCargo = new ComboBox();
            lblSetor = new Label();
            cboSetor = new ComboBox();
            lblCargo = new Label();
            tlpEmail = new TableLayoutPanel();
            tlpDigitarEmail = new TableLayoutPanel();
            txtEmail = new TextBox();
            pValidarEmail = new Panel();
            lblEmail = new Label();
            lblConfirmarEmail = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtConfirmarEmail = new TextBox();
            pValidarConfirmarEmail = new Panel();
            tlpSenha = new TableLayoutPanel();
            lblSenha = new Label();
            lblConfirmarSenha = new Label();
            tlpConfirmarSenha = new TableLayoutPanel();
            txtConfirmarSenha = new TextBox();
            pcbExibirConfirmarSenha = new PictureBox();
            pValidarConfirmarSenha = new Panel();
            tlpDigitarSenha = new TableLayoutPanel();
            txtSenha = new TextBox();
            pcbExibirSenha = new PictureBox();
            pValidarSenha = new Panel();
            tlpPrincipal.SuspendLayout();
            tblCentral.SuspendLayout();
            tblBotoes.SuspendLayout();
            tlpInformacoesBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagemUsuario).BeginInit();
            tblInformacoesBaseDados.SuspendLayout();
            tlpInformacoesBaseNomeCompleto.SuspendLayout();
            tlpInformacoesBaseUsuario.SuspendLayout();
            tlpSetor.SuspendLayout();
            tlpEmail.SuspendLayout();
            tlpDigitarEmail.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlpSenha.SuspendLayout();
            tlpConfirmarSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbExibirConfirmarSenha).BeginInit();
            tlpDigitarSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbExibirSenha).BeginInit();
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
            tlpPrincipal.Size = new Size(784, 561);
            tlpPrincipal.TabIndex = 0;
            // 
            // tblCentral
            // 
            tblCentral.BackColor = Color.FromArgb(80, 90, 100);
            tblCentral.ColumnCount = 1;
            tblCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCentral.Controls.Add(tblBotoes, 0, 8);
            tblCentral.Controls.Add(tlpInformacoesBase, 0, 0);
            tblCentral.Controls.Add(tlpSetor, 0, 2);
            tblCentral.Controls.Add(tlpEmail, 0, 4);
            tblCentral.Controls.Add(tlpSenha, 0, 6);
            tblCentral.Dock = DockStyle.Fill;
            tblCentral.Location = new Point(15, 15);
            tblCentral.Margin = new Padding(0);
            tblCentral.Name = "tblCentral";
            tblCentral.RowCount = 9;
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblCentral.Size = new Size(754, 531);
            tblCentral.TabIndex = 0;
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
            tblBotoes.Location = new Point(0, 494);
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
            btnSalvar.TabIndex = 0;
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
            btnLimpar.TabIndex = 1;
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
            tlpInformacoesBase.Controls.Add(pcbImagemUsuario, 1, 1);
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
            // pcbImagemUsuario
            // 
            pcbImagemUsuario.BackColor = Color.WhiteSmoke;
            pcbImagemUsuario.BorderStyle = BorderStyle.FixedSingle;
            pcbImagemUsuario.Cursor = Cursors.Hand;
            pcbImagemUsuario.Dock = DockStyle.Fill;
            pcbImagemUsuario.Location = new Point(15, 15);
            pcbImagemUsuario.Margin = new Padding(0);
            pcbImagemUsuario.Name = "pcbImagemUsuario";
            pcbImagemUsuario.Size = new Size(135, 135);
            pcbImagemUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagemUsuario.TabIndex = 1;
            pcbImagemUsuario.TabStop = false;
            pcbImagemUsuario.Click += pcbImagemUsuario_Click;
            // 
            // tblInformacoesBaseDados
            // 
            tblInformacoesBaseDados.BackColor = Color.FromArgb(60, 75, 85);
            tblInformacoesBaseDados.ColumnCount = 1;
            tblInformacoesBaseDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblInformacoesBaseDados.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblInformacoesBaseDados.Controls.Add(tlpInformacoesBaseNomeCompleto, 0, 1);
            tblInformacoesBaseDados.Controls.Add(tlpInformacoesBaseUsuario, 0, 4);
            tblInformacoesBaseDados.Controls.Add(lblNomeCompleto, 0, 0);
            tblInformacoesBaseDados.Controls.Add(lblUsuario, 0, 3);
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
            // tlpInformacoesBaseNomeCompleto
            // 
            tlpInformacoesBaseNomeCompleto.AutoScroll = true;
            tlpInformacoesBaseNomeCompleto.BackColor = Color.White;
            tlpInformacoesBaseNomeCompleto.ColumnCount = 2;
            tlpInformacoesBaseNomeCompleto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInformacoesBaseNomeCompleto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpInformacoesBaseNomeCompleto.Controls.Add(txtNomeCompleto, 0, 0);
            tlpInformacoesBaseNomeCompleto.Controls.Add(pValidarNomeCompleto, 1, 0);
            tlpInformacoesBaseNomeCompleto.Dock = DockStyle.Fill;
            tlpInformacoesBaseNomeCompleto.Location = new Point(0, 34);
            tlpInformacoesBaseNomeCompleto.Margin = new Padding(0);
            tlpInformacoesBaseNomeCompleto.Name = "tlpInformacoesBaseNomeCompleto";
            tlpInformacoesBaseNomeCompleto.RowCount = 1;
            tlpInformacoesBaseNomeCompleto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInformacoesBaseNomeCompleto.Size = new Size(574, 26);
            tlpInformacoesBaseNomeCompleto.TabIndex = 0;
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
            txtNomeCompleto.PlaceholderText = "Digite seu nome completo";
            txtNomeCompleto.Size = new Size(554, 18);
            txtNomeCompleto.TabIndex = 1;
            txtNomeCompleto.TextChanged += txtNomeCompleto_TextChanged;
            // 
            // pValidarNomeCompleto
            // 
            pValidarNomeCompleto.BackColor = Color.FromArgb(16, 23, 28);
            pValidarNomeCompleto.Location = new Point(564, 0);
            pValidarNomeCompleto.Margin = new Padding(0);
            pValidarNomeCompleto.Name = "pValidarNomeCompleto";
            pValidarNomeCompleto.Size = new Size(10, 26);
            pValidarNomeCompleto.TabIndex = 29;
            // 
            // tlpInformacoesBaseUsuario
            // 
            tlpInformacoesBaseUsuario.AutoScroll = true;
            tlpInformacoesBaseUsuario.BackColor = Color.White;
            tlpInformacoesBaseUsuario.ColumnCount = 2;
            tlpInformacoesBaseUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInformacoesBaseUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpInformacoesBaseUsuario.Controls.Add(txtUsuario, 0, 0);
            tlpInformacoesBaseUsuario.Controls.Add(pValidarUsuario, 1, 0);
            tlpInformacoesBaseUsuario.Dock = DockStyle.Fill;
            tlpInformacoesBaseUsuario.Location = new Point(0, 109);
            tlpInformacoesBaseUsuario.Margin = new Padding(0);
            tlpInformacoesBaseUsuario.Name = "tlpInformacoesBaseUsuario";
            tlpInformacoesBaseUsuario.RowCount = 1;
            tlpInformacoesBaseUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInformacoesBaseUsuario.Size = new Size(574, 26);
            tlpInformacoesBaseUsuario.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(10, 4);
            txtUsuario.Margin = new Padding(10, 4, 0, 0);
            txtUsuario.MaxLength = 120;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite um nome de usuario";
            txtUsuario.Size = new Size(554, 18);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // pValidarUsuario
            // 
            pValidarUsuario.BackColor = Color.FromArgb(16, 23, 28);
            pValidarUsuario.Location = new Point(564, 0);
            pValidarUsuario.Margin = new Padding(0);
            pValidarUsuario.Name = "pValidarUsuario";
            pValidarUsuario.Size = new Size(10, 26);
            pValidarUsuario.TabIndex = 29;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.Dock = DockStyle.Fill;
            lblNomeCompleto.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeCompleto.ForeColor = SystemColors.ControlLightLight;
            lblNomeCompleto.Location = new Point(0, 0);
            lblNomeCompleto.Margin = new Padding(0);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Padding = new Padding(0, 0, 0, 5);
            lblNomeCompleto.Size = new Size(574, 34);
            lblNomeCompleto.TabIndex = 3;
            lblNomeCompleto.Text = "Nome completo:";
            lblNomeCompleto.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblUsuario
            // 
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Location = new Point(0, 75);
            lblUsuario.Margin = new Padding(0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Padding = new Padding(0, 0, 0, 5);
            lblUsuario.Size = new Size(574, 34);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuário:";
            lblUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tlpSetor
            // 
            tlpSetor.BackColor = Color.FromArgb(60, 75, 85);
            tlpSetor.ColumnCount = 5;
            tlpSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpSetor.Controls.Add(cboCargo, 3, 1);
            tlpSetor.Controls.Add(lblSetor, 1, 0);
            tlpSetor.Controls.Add(cboSetor, 1, 1);
            tlpSetor.Controls.Add(lblCargo, 3, 0);
            tlpSetor.Dock = DockStyle.Fill;
            tlpSetor.Location = new Point(0, 191);
            tlpSetor.Margin = new Padding(0);
            tlpSetor.Name = "tlpSetor";
            tlpSetor.RowCount = 3;
            tlpSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSetor.Size = new Size(754, 75);
            tlpSetor.TabIndex = 1;
            // 
            // cboCargo
            // 
            cboCargo.Dock = DockStyle.Fill;
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(387, 34);
            cboCargo.Margin = new Padding(0);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(352, 26);
            cboCargo.TabIndex = 1;
            cboCargo.SelectedIndexChanged += cboCargo_SelectedIndexChanged;
            // 
            // lblSetor
            // 
            lblSetor.Dock = DockStyle.Fill;
            lblSetor.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSetor.ForeColor = SystemColors.ControlLightLight;
            lblSetor.Location = new Point(15, 0);
            lblSetor.Margin = new Padding(0);
            lblSetor.Name = "lblSetor";
            lblSetor.Padding = new Padding(0, 0, 0, 5);
            lblSetor.Size = new Size(352, 34);
            lblSetor.TabIndex = 5;
            lblSetor.Text = "Setor:";
            lblSetor.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboSetor
            // 
            cboSetor.Dock = DockStyle.Fill;
            cboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSetor.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboSetor.FormattingEnabled = true;
            cboSetor.Location = new Point(15, 34);
            cboSetor.Margin = new Padding(0);
            cboSetor.Name = "cboSetor";
            cboSetor.Size = new Size(352, 26);
            cboSetor.TabIndex = 0;
            cboSetor.SelectedIndexChanged += cboSetor_SelectedIndexChanged;
            // 
            // lblCargo
            // 
            lblCargo.Dock = DockStyle.Fill;
            lblCargo.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCargo.ForeColor = SystemColors.ControlLightLight;
            lblCargo.Location = new Point(387, 0);
            lblCargo.Margin = new Padding(0);
            lblCargo.Name = "lblCargo";
            lblCargo.Padding = new Padding(0, 0, 0, 5);
            lblCargo.Size = new Size(352, 34);
            lblCargo.TabIndex = 8;
            lblCargo.Text = "Cargo:";
            lblCargo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tlpEmail
            // 
            tlpEmail.BackColor = Color.FromArgb(60, 75, 85);
            tlpEmail.ColumnCount = 5;
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpEmail.Controls.Add(tlpDigitarEmail, 1, 1);
            tlpEmail.Controls.Add(lblEmail, 1, 0);
            tlpEmail.Controls.Add(lblConfirmarEmail, 3, 0);
            tlpEmail.Controls.Add(tableLayoutPanel1, 3, 1);
            tlpEmail.Dock = DockStyle.Fill;
            tlpEmail.Location = new Point(0, 292);
            tlpEmail.Margin = new Padding(0);
            tlpEmail.Name = "tlpEmail";
            tlpEmail.RowCount = 3;
            tlpEmail.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpEmail.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpEmail.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpEmail.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            tlpDigitarEmail.Controls.Add(txtEmail, 0, 0);
            tlpDigitarEmail.Controls.Add(pValidarEmail, 1, 0);
            tlpDigitarEmail.Dock = DockStyle.Fill;
            tlpDigitarEmail.Location = new Point(15, 34);
            tlpDigitarEmail.Margin = new Padding(0);
            tlpDigitarEmail.Name = "tlpDigitarEmail";
            tlpDigitarEmail.RowCount = 1;
            tlpDigitarEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDigitarEmail.Size = new Size(352, 26);
            tlpDigitarEmail.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(10, 4);
            txtEmail.Margin = new Padding(10, 4, 0, 0);
            txtEmail.MaxLength = 120;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu endereço de e-mail";
            txtEmail.Size = new Size(332, 18);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // pValidarEmail
            // 
            pValidarEmail.BackColor = Color.FromArgb(16, 23, 28);
            pValidarEmail.Location = new Point(342, 0);
            pValidarEmail.Margin = new Padding(0);
            pValidarEmail.Name = "pValidarEmail";
            pValidarEmail.Size = new Size(10, 26);
            pValidarEmail.TabIndex = 29;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(15, 0);
            lblEmail.Margin = new Padding(0);
            lblEmail.Name = "lblEmail";
            lblEmail.Padding = new Padding(0, 0, 0, 5);
            lblEmail.Size = new Size(352, 34);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblConfirmarEmail
            // 
            lblConfirmarEmail.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmarEmail.ForeColor = SystemColors.ControlLightLight;
            lblConfirmarEmail.Location = new Point(387, 0);
            lblConfirmarEmail.Margin = new Padding(0);
            lblConfirmarEmail.Name = "lblConfirmarEmail";
            lblConfirmarEmail.Padding = new Padding(0, 0, 0, 5);
            lblConfirmarEmail.Size = new Size(352, 34);
            lblConfirmarEmail.TabIndex = 18;
            lblConfirmarEmail.Text = "Confirmar Email:";
            lblConfirmarEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(txtConfirmarEmail, 0, 0);
            tableLayoutPanel1.Controls.Add(pValidarConfirmarEmail, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(387, 34);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(352, 26);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // txtConfirmarEmail
            // 
            txtConfirmarEmail.BorderStyle = BorderStyle.None;
            txtConfirmarEmail.Dock = DockStyle.Fill;
            txtConfirmarEmail.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarEmail.Location = new Point(10, 4);
            txtConfirmarEmail.Margin = new Padding(10, 4, 0, 0);
            txtConfirmarEmail.MaxLength = 120;
            txtConfirmarEmail.Name = "txtConfirmarEmail";
            txtConfirmarEmail.PlaceholderText = "Confirme seu endereço de e-mail";
            txtConfirmarEmail.Size = new Size(332, 18);
            txtConfirmarEmail.TabIndex = 1;
            txtConfirmarEmail.TextChanged += txtConfirmarEmail_TextChanged;
            // 
            // pValidarConfirmarEmail
            // 
            pValidarConfirmarEmail.BackColor = Color.FromArgb(16, 23, 28);
            pValidarConfirmarEmail.Location = new Point(342, 0);
            pValidarConfirmarEmail.Margin = new Padding(0);
            pValidarConfirmarEmail.Name = "pValidarConfirmarEmail";
            pValidarConfirmarEmail.Size = new Size(10, 26);
            pValidarConfirmarEmail.TabIndex = 29;
            // 
            // tlpSenha
            // 
            tlpSenha.BackColor = Color.FromArgb(60, 75, 85);
            tlpSenha.ColumnCount = 5;
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpSenha.Controls.Add(lblSenha, 1, 0);
            tlpSenha.Controls.Add(lblConfirmarSenha, 3, 0);
            tlpSenha.Controls.Add(tlpConfirmarSenha, 3, 1);
            tlpSenha.Controls.Add(tlpDigitarSenha, 1, 1);
            tlpSenha.Dock = DockStyle.Fill;
            tlpSenha.Location = new Point(0, 393);
            tlpSenha.Margin = new Padding(0);
            tlpSenha.Name = "tlpSenha";
            tlpSenha.RowCount = 3;
            tlpSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpSenha.Size = new Size(754, 75);
            tlpSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.ForeColor = SystemColors.ControlLightLight;
            lblSenha.Location = new Point(15, 0);
            lblSenha.Margin = new Padding(0);
            lblSenha.Name = "lblSenha";
            lblSenha.Padding = new Padding(0, 0, 0, 5);
            lblSenha.Size = new Size(352, 34);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha [0 / 8]:";
            lblSenha.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.Dock = DockStyle.Fill;
            lblConfirmarSenha.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmarSenha.ForeColor = SystemColors.ControlLightLight;
            lblConfirmarSenha.Location = new Point(387, 0);
            lblConfirmarSenha.Margin = new Padding(0);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Padding = new Padding(0, 0, 0, 5);
            lblConfirmarSenha.Size = new Size(352, 34);
            lblConfirmarSenha.TabIndex = 8;
            lblConfirmarSenha.Text = "Confirmar Senha [0 / 8]:";
            lblConfirmarSenha.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tlpConfirmarSenha
            // 
            tlpConfirmarSenha.AutoScroll = true;
            tlpConfirmarSenha.BackColor = Color.White;
            tlpConfirmarSenha.ColumnCount = 3;
            tlpConfirmarSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpConfirmarSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tlpConfirmarSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpConfirmarSenha.Controls.Add(txtConfirmarSenha, 0, 0);
            tlpConfirmarSenha.Controls.Add(pcbExibirConfirmarSenha, 1, 0);
            tlpConfirmarSenha.Controls.Add(pValidarConfirmarSenha, 2, 0);
            tlpConfirmarSenha.Dock = DockStyle.Fill;
            tlpConfirmarSenha.Location = new Point(387, 34);
            tlpConfirmarSenha.Margin = new Padding(0);
            tlpConfirmarSenha.Name = "tlpConfirmarSenha";
            tlpConfirmarSenha.RowCount = 1;
            tlpConfirmarSenha.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpConfirmarSenha.Size = new Size(352, 26);
            tlpConfirmarSenha.TabIndex = 15;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BorderStyle = BorderStyle.None;
            txtConfirmarSenha.Dock = DockStyle.Fill;
            txtConfirmarSenha.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarSenha.Location = new Point(10, 4);
            txtConfirmarSenha.Margin = new Padding(10, 4, 0, 0);
            txtConfirmarSenha.MaxLength = 120;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.PlaceholderText = "Confirme sua senha";
            txtConfirmarSenha.Size = new Size(298, 18);
            txtConfirmarSenha.TabIndex = 1;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // pcbExibirConfirmarSenha
            // 
            pcbExibirConfirmarSenha.Cursor = Cursors.Hand;
            pcbExibirConfirmarSenha.Dock = DockStyle.Fill;
            pcbExibirConfirmarSenha.Image = Properties.Resources.eyeBG_1;
            pcbExibirConfirmarSenha.Location = new Point(308, 0);
            pcbExibirConfirmarSenha.Margin = new Padding(0);
            pcbExibirConfirmarSenha.Name = "pcbExibirConfirmarSenha";
            pcbExibirConfirmarSenha.Size = new Size(34, 26);
            pcbExibirConfirmarSenha.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbExibirConfirmarSenha.TabIndex = 29;
            pcbExibirConfirmarSenha.TabStop = false;
            pcbExibirConfirmarSenha.Click += pcbExibirConfirmarSenha_Click;
            // 
            // pValidarConfirmarSenha
            // 
            pValidarConfirmarSenha.BackColor = Color.FromArgb(16, 23, 28);
            pValidarConfirmarSenha.Location = new Point(342, 0);
            pValidarConfirmarSenha.Margin = new Padding(0);
            pValidarConfirmarSenha.Name = "pValidarConfirmarSenha";
            pValidarConfirmarSenha.Size = new Size(10, 26);
            pValidarConfirmarSenha.TabIndex = 30;
            // 
            // tlpDigitarSenha
            // 
            tlpDigitarSenha.AutoScroll = true;
            tlpDigitarSenha.BackColor = Color.White;
            tlpDigitarSenha.ColumnCount = 3;
            tlpDigitarSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDigitarSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tlpDigitarSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpDigitarSenha.Controls.Add(txtSenha, 0, 0);
            tlpDigitarSenha.Controls.Add(pcbExibirSenha, 1, 0);
            tlpDigitarSenha.Controls.Add(pValidarSenha, 2, 0);
            tlpDigitarSenha.Dock = DockStyle.Fill;
            tlpDigitarSenha.Location = new Point(15, 34);
            tlpDigitarSenha.Margin = new Padding(0);
            tlpDigitarSenha.Name = "tlpDigitarSenha";
            tlpDigitarSenha.RowCount = 1;
            tlpDigitarSenha.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDigitarSenha.Size = new Size(352, 26);
            tlpDigitarSenha.TabIndex = 14;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Dock = DockStyle.Fill;
            txtSenha.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(10, 4);
            txtSenha.Margin = new Padding(10, 4, 0, 0);
            txtSenha.MaxLength = 120;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(298, 18);
            txtSenha.TabIndex = 0;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // pcbExibirSenha
            // 
            pcbExibirSenha.Cursor = Cursors.Hand;
            pcbExibirSenha.Dock = DockStyle.Fill;
            pcbExibirSenha.Image = Properties.Resources.eyeBG_1;
            pcbExibirSenha.Location = new Point(308, 0);
            pcbExibirSenha.Margin = new Padding(0);
            pcbExibirSenha.Name = "pcbExibirSenha";
            pcbExibirSenha.Size = new Size(34, 26);
            pcbExibirSenha.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbExibirSenha.TabIndex = 29;
            pcbExibirSenha.TabStop = false;
            pcbExibirSenha.Click += pcbExibirSenha_Click;
            // 
            // pValidarSenha
            // 
            pValidarSenha.BackColor = Color.FromArgb(16, 23, 28);
            pValidarSenha.Location = new Point(342, 0);
            pValidarSenha.Margin = new Padding(0);
            pValidarSenha.Name = "pValidarSenha";
            pValidarSenha.Size = new Size(10, 26);
            pValidarSenha.TabIndex = 30;
            // 
            // FrmAlterarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(784, 561);
            Controls.Add(tlpPrincipal);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "FrmAlterarUsuario";
            Text = "Cadastrar Usuário";
            FormClosed += FrmEstruturaBaseCadastro_FormClosed;
            Load += FrmEstruturaBaseCadastro_Load;
            tlpPrincipal.ResumeLayout(false);
            tblCentral.ResumeLayout(false);
            tblBotoes.ResumeLayout(false);
            tlpInformacoesBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbImagemUsuario).EndInit();
            tblInformacoesBaseDados.ResumeLayout(false);
            tlpInformacoesBaseNomeCompleto.ResumeLayout(false);
            tlpInformacoesBaseNomeCompleto.PerformLayout();
            tlpInformacoesBaseUsuario.ResumeLayout(false);
            tlpInformacoesBaseUsuario.PerformLayout();
            tlpSetor.ResumeLayout(false);
            tlpEmail.ResumeLayout(false);
            tlpDigitarEmail.ResumeLayout(false);
            tlpDigitarEmail.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tlpSenha.ResumeLayout(false);
            tlpConfirmarSenha.ResumeLayout(false);
            tlpConfirmarSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbExibirConfirmarSenha).EndInit();
            tlpDigitarSenha.ResumeLayout(false);
            tlpDigitarSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbExibirSenha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tblCentral;
        private TableLayoutPanel tblBotoes;
        private Button btnSalvar;
        private Button btnLimpar;
        private TableLayoutPanel tlpInformacoesBase;
        private TableLayoutPanel tlpSetor;
        private PictureBox pcbImagemUsuario;
        private TableLayoutPanel tblInformacoesBaseDados;
        private Label lblNomeCompleto;
        private Label lblUsuario;
        private Label lblSetor;
        private ComboBox cboSetor;
        private ComboBox cboCargo;
        private Label lblCargo;
        private TableLayoutPanel tlpEmail;
        private TableLayoutPanel tlpSenha;
        private Label lblSenha;
        private Label lblConfirmarSenha;
        private TableLayoutPanel tlpDigitarSenha;
        private TextBox txtSenha;
        private PictureBox pcbExibirSenha;
        private TableLayoutPanel tlpConfirmarSenha;
        private TextBox txtConfirmarSenha;
        private PictureBox pcbExibirConfirmarSenha;
        private TableLayoutPanel tlpDigitarEmail;
        private TextBox txtEmail;
        private Panel pValidarEmail;
        private Label lblEmail;
        private Label lblConfirmarEmail;
        private Panel pValidarConfirmarSenha;
        private Panel pValidarSenha;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtConfirmarEmail;
        private Panel pValidarConfirmarEmail;
        private TableLayoutPanel tlpInformacoesBaseNomeCompleto;
        private TextBox txtNomeCompleto;
        private Panel pValidarNomeCompleto;
        private TableLayoutPanel tlpInformacoesBaseUsuario;
        private TextBox txtUsuario;
        private Panel pValidarUsuario;
    }
}