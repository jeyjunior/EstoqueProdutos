namespace Estoque.Telas_Usuario
{
    partial class FrmCadastrarUsuario
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
            tlpUsuario = new TableLayoutPanel();
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            lblNomeAbreviado = new Label();
            txtNomeAbreviado = new TextBox();
            pcbImagemUsuario = new PictureBox();
            tlpSetor = new TableLayoutPanel();
            cboCargo = new ComboBox();
            lblCargo = new Label();
            cboSetor = new ComboBox();
            lblSetor = new Label();
            txtEmail = new TextBox();
            txtConfirmarEmail = new TextBox();
            pcbSenha = new PictureBox();
            txtSenha = new TextBox();
            lblEmail = new Label();
            pcbConfirmarSenha = new PictureBox();
            txtConfirmarSenha = new TextBox();
            lblSenha = new Label();
            lblConfirmarEmail = new Label();
            tblBotoes = new TableLayoutPanel();
            btnSalvar = new Button();
            btnLimpar = new Button();
            pn1 = new Panel();
            pictureBox1 = new PictureBox();
            pn3 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pcbValidacaoEmail = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            pcbValidacaoConfirmacaoSenha = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            pcbValidacaoConfirmarEmail = new PictureBox();
            pn2 = new Panel();
            tlpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagemUsuario).BeginInit();
            tlpSetor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbConfirmarSenha).BeginInit();
            tblBotoes.SuspendLayout();
            pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pn3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbValidacaoEmail).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbValidacaoConfirmacaoSenha).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbValidacaoConfirmarEmail).BeginInit();
            pn2.SuspendLayout();
            SuspendLayout();
            // 
            // tlpUsuario
            // 
            tlpUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpUsuario.ColumnCount = 1;
            tlpUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpUsuario.Controls.Add(lblNomeCompleto, 0, 0);
            tlpUsuario.Controls.Add(txtNomeCompleto, 0, 1);
            tlpUsuario.Controls.Add(lblNomeAbreviado, 0, 2);
            tlpUsuario.Controls.Add(txtNomeAbreviado, 0, 3);
            tlpUsuario.Location = new Point(125, 14);
            tlpUsuario.Margin = new Padding(9, 9, 9, 0);
            tlpUsuario.Name = "tlpUsuario";
            tlpUsuario.RowCount = 4;
            tlpUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tlpUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tlpUsuario.Size = new Size(320, 93);
            tlpUsuario.TabIndex = 11;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.Dock = DockStyle.Fill;
            lblNomeCompleto.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeCompleto.ForeColor = SystemColors.ControlLightLight;
            lblNomeCompleto.Location = new Point(0, 0);
            lblNomeCompleto.Margin = new Padding(0);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(320, 20);
            lblNomeCompleto.TabIndex = 2;
            lblNomeCompleto.Text = "Nome completo:";
            lblNomeCompleto.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.BorderStyle = BorderStyle.FixedSingle;
            txtNomeCompleto.Dock = DockStyle.Fill;
            txtNomeCompleto.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCompleto.Location = new Point(3, 23);
            txtNomeCompleto.MaxLength = 1000;
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(314, 22);
            txtNomeCompleto.TabIndex = 0;
            // 
            // lblNomeAbreviado
            // 
            lblNomeAbreviado.Dock = DockStyle.Fill;
            lblNomeAbreviado.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeAbreviado.ForeColor = SystemColors.ControlLightLight;
            lblNomeAbreviado.Location = new Point(0, 43);
            lblNomeAbreviado.Margin = new Padding(0);
            lblNomeAbreviado.Name = "lblNomeAbreviado";
            lblNomeAbreviado.Size = new Size(320, 20);
            lblNomeAbreviado.TabIndex = 19;
            lblNomeAbreviado.Text = "Usuário:";
            lblNomeAbreviado.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNomeAbreviado
            // 
            txtNomeAbreviado.BorderStyle = BorderStyle.FixedSingle;
            txtNomeAbreviado.Dock = DockStyle.Fill;
            txtNomeAbreviado.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeAbreviado.Location = new Point(3, 66);
            txtNomeAbreviado.MaxLength = 120;
            txtNomeAbreviado.Name = "txtNomeAbreviado";
            txtNomeAbreviado.Size = new Size(314, 22);
            txtNomeAbreviado.TabIndex = 1;
            // 
            // pcbImagemUsuario
            // 
            pcbImagemUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pcbImagemUsuario.BackColor = Color.Gray;
            pcbImagemUsuario.BorderStyle = BorderStyle.FixedSingle;
            pcbImagemUsuario.Cursor = Cursors.Hand;
            pcbImagemUsuario.Location = new Point(16, 15);
            pcbImagemUsuario.Name = "pcbImagemUsuario";
            pcbImagemUsuario.Size = new Size(90, 92);
            pcbImagemUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagemUsuario.TabIndex = 0;
            pcbImagemUsuario.TabStop = false;
            pcbImagemUsuario.Click += pcbImagemUsuario_Click;
            // 
            // tlpSetor
            // 
            tlpSetor.ColumnCount = 1;
            tlpSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpSetor.Controls.Add(cboCargo, 0, 3);
            tlpSetor.Controls.Add(lblCargo, 0, 2);
            tlpSetor.Controls.Add(cboSetor, 0, 1);
            tlpSetor.Controls.Add(lblSetor, 0, 0);
            tlpSetor.Location = new Point(16, 9);
            tlpSetor.Margin = new Padding(9);
            tlpSetor.Name = "tlpSetor";
            tlpSetor.RowCount = 4;
            tlpSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tlpSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tlpSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSetor.Size = new Size(432, 92);
            tlpSetor.TabIndex = 11;
            // 
            // cboCargo
            // 
            cboCargo.Dock = DockStyle.Fill;
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(3, 66);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(426, 22);
            cboCargo.TabIndex = 2;
            // 
            // lblCargo
            // 
            lblCargo.Dock = DockStyle.Fill;
            lblCargo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCargo.ForeColor = SystemColors.ControlLightLight;
            lblCargo.Location = new Point(0, 45);
            lblCargo.Margin = new Padding(0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(432, 18);
            lblCargo.TabIndex = 19;
            lblCargo.Text = "Cargo:";
            lblCargo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboSetor
            // 
            cboSetor.Dock = DockStyle.Fill;
            cboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSetor.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSetor.FormattingEnabled = true;
            cboSetor.Location = new Point(3, 23);
            cboSetor.Name = "cboSetor";
            cboSetor.Size = new Size(426, 22);
            cboSetor.TabIndex = 1;
            cboSetor.SelectedIndexChanged += cboSetor_SelectedIndexChanged;
            // 
            // lblSetor
            // 
            lblSetor.Dock = DockStyle.Fill;
            lblSetor.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSetor.ForeColor = SystemColors.ControlLightLight;
            lblSetor.Location = new Point(0, 0);
            lblSetor.Margin = new Padding(0);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(432, 20);
            lblSetor.TabIndex = 2;
            lblSetor.Text = "Setor:";
            lblSetor.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(3, 31);
            txtEmail.MaxLength = 120;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 22);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtConfirmarEmail
            // 
            txtConfirmarEmail.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarEmail.Dock = DockStyle.Fill;
            txtConfirmarEmail.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarEmail.Location = new Point(224, 31);
            txtConfirmarEmail.MaxLength = 120;
            txtConfirmarEmail.Name = "txtConfirmarEmail";
            txtConfirmarEmail.Size = new Size(188, 22);
            txtConfirmarEmail.TabIndex = 1;
            txtConfirmarEmail.TextChanged += txtConfirmarEmail_TextChanged;
            txtConfirmarEmail.Enter += txtConfirmarEmail_Enter;
            txtConfirmarEmail.Leave += txtConfirmarEmail_Leave;
            // 
            // pcbSenha
            // 
            pcbSenha.Dock = DockStyle.Fill;
            pcbSenha.Image = Properties.Resources.eye_1;
            pcbSenha.Location = new Point(197, 87);
            pcbSenha.Name = "pcbSenha";
            pcbSenha.Size = new Size(16, 24);
            pcbSenha.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSenha.TabIndex = 14;
            pcbSenha.TabStop = false;
            pcbSenha.MouseDown += pcbSenha_MouseDown;
            pcbSenha.MouseUp += pcbSenha_MouseUp;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Dock = DockStyle.Fill;
            txtSenha.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(3, 87);
            txtSenha.MaxLength = 120;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(188, 22);
            txtSenha.TabIndex = 2;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(0, 0);
            lblEmail.Margin = new Padding(0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(163, 19);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pcbConfirmarSenha
            // 
            pcbConfirmarSenha.Dock = DockStyle.Fill;
            pcbConfirmarSenha.Image = Properties.Resources.eye_1;
            pcbConfirmarSenha.Location = new Point(418, 87);
            pcbConfirmarSenha.Name = "pcbConfirmarSenha";
            pcbConfirmarSenha.Size = new Size(17, 24);
            pcbConfirmarSenha.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbConfirmarSenha.TabIndex = 23;
            pcbConfirmarSenha.TabStop = false;
            pcbConfirmarSenha.MouseDown += pcbConfirmarSenha_MouseDown;
            pcbConfirmarSenha.MouseUp += pcbConfirmarSenha_MouseUp;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarSenha.Dock = DockStyle.Fill;
            txtConfirmarSenha.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarSenha.Location = new Point(224, 87);
            txtConfirmarSenha.MaxLength = 120;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(188, 22);
            txtConfirmarSenha.TabIndex = 3;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            txtConfirmarSenha.Enter += txtConfirmarSenha_Enter;
            txtConfirmarSenha.Leave += txtConfirmarSenha_Leave;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.ForeColor = SystemColors.ControlLightLight;
            lblSenha.Location = new Point(0, 56);
            lblSenha.Margin = new Padding(0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(191, 20);
            lblSenha.TabIndex = 19;
            lblSenha.Text = "Senha:";
            lblSenha.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblConfirmarEmail
            // 
            lblConfirmarEmail.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmarEmail.ForeColor = SystemColors.ControlLightLight;
            lblConfirmarEmail.Location = new Point(0, 0);
            lblConfirmarEmail.Margin = new Padding(0);
            lblConfirmarEmail.Name = "lblConfirmarEmail";
            lblConfirmarEmail.Size = new Size(117, 19);
            lblConfirmarEmail.TabIndex = 21;
            lblConfirmarEmail.Text = "Confirmar email:";
            lblConfirmarEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tblBotoes
            // 
            tblBotoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblBotoes.ColumnCount = 4;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBotoes.Controls.Add(btnSalvar, 0, 0);
            tblBotoes.Controls.Add(btnLimpar, 2, 0);
            tblBotoes.Location = new Point(12, 418);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(457, 37);
            tblBotoes.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Fill;
            btnSalvar.ForeColor = Color.FromArgb(66, 142, 79);
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(367, 0);
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
            btnLimpar.Location = new Point(272, 0);
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
            // pn1
            // 
            pn1.BackColor = Color.FromArgb(60, 75, 85);
            pn1.Controls.Add(tlpUsuario);
            pn1.Controls.Add(pcbImagemUsuario);
            pn1.Controls.Add(pictureBox1);
            pn1.Location = new Point(12, 12);
            pn1.Name = "pn1";
            pn1.Size = new Size(460, 123);
            pn1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pn3
            // 
            pn3.BackColor = Color.FromArgb(60, 75, 85);
            pn3.Controls.Add(tableLayoutPanel5);
            pn3.Location = new Point(12, 265);
            pn3.Name = "pn3";
            pn3.Size = new Size(460, 140);
            pn3.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel2, 3, 2);
            tableLayoutPanel5.Controls.Add(txtConfirmarEmail, 3, 1);
            tableLayoutPanel5.Controls.Add(txtEmail, 0, 1);
            tableLayoutPanel5.Controls.Add(pcbSenha, 1, 3);
            tableLayoutPanel5.Controls.Add(txtConfirmarSenha, 3, 3);
            tableLayoutPanel5.Controls.Add(txtSenha, 0, 3);
            tableLayoutPanel5.Controls.Add(pcbConfirmarSenha, 4, 3);
            tableLayoutPanel5.Controls.Add(lblSenha, 0, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel1, 3, 0);
            tableLayoutPanel5.Location = new Point(19, 12);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Size = new Size(438, 114);
            tableLayoutPanel5.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.3248749F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.675127F));
            tableLayoutPanel3.Controls.Add(pcbValidacaoEmail, 1, 0);
            tableLayoutPanel3.Controls.Add(lblEmail, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(188, 22);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // pcbValidacaoEmail
            // 
            pcbValidacaoEmail.Dock = DockStyle.Fill;
            pcbValidacaoEmail.Image = Properties.Resources.circulo_verde;
            pcbValidacaoEmail.Location = new Point(169, 3);
            pcbValidacaoEmail.Name = "pcbValidacaoEmail";
            pcbValidacaoEmail.Size = new Size(16, 16);
            pcbValidacaoEmail.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbValidacaoEmail.TabIndex = 25;
            pcbValidacaoEmail.TabStop = false;
            pcbValidacaoEmail.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.3248749F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.675127F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(pcbValidacaoConfirmacaoSenha, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(221, 56);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(194, 28);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(165, 22);
            label1.TabIndex = 25;
            label1.Text = "Confirmar senha:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pcbValidacaoConfirmacaoSenha
            // 
            pcbValidacaoConfirmacaoSenha.Dock = DockStyle.Fill;
            pcbValidacaoConfirmacaoSenha.Image = Properties.Resources.circulo_verde;
            pcbValidacaoConfirmacaoSenha.Location = new Point(174, 3);
            pcbValidacaoConfirmacaoSenha.Name = "pcbValidacaoConfirmacaoSenha";
            pcbValidacaoConfirmacaoSenha.Size = new Size(17, 22);
            pcbValidacaoConfirmacaoSenha.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbValidacaoConfirmacaoSenha.TabIndex = 24;
            pcbValidacaoConfirmacaoSenha.TabStop = false;
            pcbValidacaoConfirmacaoSenha.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.3248749F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.675127F));
            tableLayoutPanel1.Controls.Add(pcbValidacaoConfirmarEmail, 1, 0);
            tableLayoutPanel1.Controls.Add(lblConfirmarEmail, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(224, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(188, 22);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // pcbValidacaoConfirmarEmail
            // 
            pcbValidacaoConfirmarEmail.Dock = DockStyle.Fill;
            pcbValidacaoConfirmarEmail.Image = Properties.Resources.circulo_verde;
            pcbValidacaoConfirmarEmail.Location = new Point(169, 3);
            pcbValidacaoConfirmarEmail.Name = "pcbValidacaoConfirmarEmail";
            pcbValidacaoConfirmarEmail.Size = new Size(16, 16);
            pcbValidacaoConfirmarEmail.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbValidacaoConfirmarEmail.TabIndex = 24;
            pcbValidacaoConfirmarEmail.TabStop = false;
            pcbValidacaoConfirmarEmail.Visible = false;
            // 
            // pn2
            // 
            pn2.BackColor = Color.FromArgb(60, 75, 85);
            pn2.Controls.Add(tlpSetor);
            pn2.Location = new Point(12, 141);
            pn2.Name = "pn2";
            pn2.Size = new Size(460, 118);
            pn2.TabIndex = 1;
            // 
            // FrmCadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(481, 469);
            Controls.Add(pn2);
            Controls.Add(pn3);
            Controls.Add(pn1);
            Controls.Add(tblBotoes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(497, 508);
            MinimizeBox = false;
            MinimumSize = new Size(497, 508);
            Name = "FrmCadastrarUsuario";
            Text = "Cadastrar Usuário";
            FormClosed += FrmCadastrarUsuario_FormClosed;
            Load += FrmCadastrarUsuario_Load;
            tlpUsuario.ResumeLayout(false);
            tlpUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagemUsuario).EndInit();
            tlpSetor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbConfirmarSenha).EndInit();
            tblBotoes.ResumeLayout(false);
            pn1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pn3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbValidacaoEmail).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbValidacaoConfirmacaoSenha).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbValidacaoConfirmarEmail).EndInit();
            pn2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pcbImagemUsuario;
        private TableLayoutPanel tlpUsuario;
        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Label lblNomeAbreviado;
        private TextBox txtNomeAbreviado;
        private TableLayoutPanel tlpSetor;
        private Label lblSetor;
        private Label lblCargo;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSenha;
        private Label lblConfirmarEmail;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private TextBox txtConfirmarEmail;
        private TableLayoutPanel tblBotoes;
        private Button btnLimpar;
        private ComboBox cboCargo;
        private ComboBox cboSetor;
        private Panel pn1;
        private Panel pn3;
        private Button btnSalvar;
        private Panel pn2;
        private PictureBox pcbSenha;
        private PictureBox pcbConfirmarSenha;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox pcbValidacaoConfirmarEmail;
        private PictureBox pcbValidacaoEmail;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private PictureBox pcbValidacaoConfirmacaoSenha;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
    }
}