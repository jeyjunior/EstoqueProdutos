namespace Estoque.Telas_Principal
{
    partial class UCLogin
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
            components = new System.ComponentModel.Container();
            pcbBGLogin = new PictureBox();
            pCentral = new Panel();
            tlpPrincipal = new TableLayoutPanel();
            pcbLogo = new PictureBox();
            lblNomeEmpresa = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            btnEntrar = new Button();
            tblSenha = new TableLayoutPanel();
            pcbCheckBoxSenha = new PictureBox();
            txtSenha = new TextBox();
            tblEmail = new TableLayoutPanel();
            pcbCheckBoxEmail = new PictureBox();
            txtEmail = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pcbBGLogin).BeginInit();
            pCentral.SuspendLayout();
            tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            tblSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCheckBoxSenha).BeginInit();
            tblEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCheckBoxEmail).BeginInit();
            SuspendLayout();
            // 
            // pcbBGLogin
            // 
            pcbBGLogin.Dock = DockStyle.Fill;
            pcbBGLogin.Image = Properties.Resources.frameLogin;
            pcbBGLogin.Location = new Point(0, 0);
            pcbBGLogin.Name = "pcbBGLogin";
            pcbBGLogin.Size = new Size(410, 566);
            pcbBGLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBGLogin.TabIndex = 0;
            pcbBGLogin.TabStop = false;
            // 
            // pCentral
            // 
            pCentral.Controls.Add(tlpPrincipal);
            pCentral.Controls.Add(pcbBGLogin);
            pCentral.Location = new Point(277, 105);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(410, 566);
            pCentral.TabIndex = 1;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpPrincipal.BackColor = Color.FromArgb(80, 90, 100);
            tlpPrincipal.ColumnCount = 3;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.81818F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tlpPrincipal.Controls.Add(pcbLogo, 1, 0);
            tlpPrincipal.Controls.Add(lblNomeEmpresa, 1, 1);
            tlpPrincipal.Controls.Add(lblEmail, 1, 3);
            tlpPrincipal.Controls.Add(lblSenha, 1, 6);
            tlpPrincipal.Controls.Add(btnEntrar, 1, 9);
            tlpPrincipal.Controls.Add(tblSenha, 1, 7);
            tlpPrincipal.Controls.Add(tblEmail, 1, 4);
            tlpPrincipal.Location = new Point(16, 43);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 10;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 32.6727753F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 13.043478F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3864737F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 9.931004F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95170259F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 9.931004F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8827057F));
            tlpPrincipal.Size = new Size(378, 454);
            tlpPrincipal.TabIndex = 1;
            // 
            // pcbLogo
            // 
            pcbLogo.Dock = DockStyle.Fill;
            pcbLogo.Image = Properties.Resources.logoUCLogin;
            pcbLogo.Location = new Point(37, 3);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(303, 125);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // lblNomeEmpresa
            // 
            lblNomeEmpresa.AutoSize = true;
            lblNomeEmpresa.BackColor = Color.Transparent;
            lblNomeEmpresa.Dock = DockStyle.Fill;
            lblNomeEmpresa.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeEmpresa.ForeColor = SystemColors.Control;
            lblNomeEmpresa.Location = new Point(34, 131);
            lblNomeEmpresa.Margin = new Padding(0);
            lblNomeEmpresa.Name = "lblNomeEmpresa";
            lblNomeEmpresa.Size = new Size(309, 52);
            lblNomeEmpresa.TabIndex = 2;
            lblNomeEmpresa.Text = "JeyJr Tech";
            lblNomeEmpresa.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.FromArgb(80, 90, 100);
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.Control;
            lblEmail.Location = new Point(37, 188);
            lblEmail.Name = "lblEmail";
            lblEmail.Padding = new Padding(0, 0, 0, 5);
            lblEmail.Size = new Size(303, 41);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblSenha
            // 
            lblSenha.BackColor = Color.FromArgb(80, 90, 100);
            lblSenha.Dock = DockStyle.Fill;
            lblSenha.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.ForeColor = SystemColors.Control;
            lblSenha.Location = new Point(37, 278);
            lblSenha.Name = "lblSenha";
            lblSenha.Padding = new Padding(0, 0, 0, 5);
            lblSenha.Size = new Size(303, 27);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            lblSenha.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.Control;
            btnEntrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEntrar.Dock = DockStyle.Fill;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.FromArgb(80, 90, 100);
            btnEntrar.Location = new Point(37, 385);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(303, 66);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // tblSenha
            // 
            tblSenha.BackColor = Color.Transparent;
            tblSenha.BackgroundImage = Properties.Resources.bgRetangularBranco_300x50;
            tblSenha.BackgroundImageLayout = ImageLayout.Stretch;
            tblSenha.ColumnCount = 2;
            tblSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tblSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblSenha.Controls.Add(pcbCheckBoxSenha, 1, 0);
            tblSenha.Controls.Add(txtSenha, 0, 0);
            tblSenha.Dock = DockStyle.Fill;
            tblSenha.Location = new Point(34, 305);
            tblSenha.Margin = new Padding(0);
            tblSenha.Name = "tblSenha";
            tblSenha.Padding = new Padding(5);
            tblSenha.RowCount = 1;
            tblSenha.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSenha.Size = new Size(309, 39);
            tblSenha.TabIndex = 8;
            // 
            // pcbCheckBoxSenha
            // 
            pcbCheckBoxSenha.BackColor = Color.Transparent;
            pcbCheckBoxSenha.Cursor = Cursors.Hand;
            pcbCheckBoxSenha.Image = Properties.Resources.eyeBG_1;
            pcbCheckBoxSenha.Location = new Point(279, 12);
            pcbCheckBoxSenha.Margin = new Padding(5, 7, 0, 0);
            pcbCheckBoxSenha.Name = "pcbCheckBoxSenha";
            pcbCheckBoxSenha.Size = new Size(22, 14);
            pcbCheckBoxSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCheckBoxSenha.TabIndex = 5;
            pcbCheckBoxSenha.TabStop = false;
            pcbCheckBoxSenha.Click += pcbCheckBoxSenha_Click;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Dock = DockStyle.Fill;
            txtSenha.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(8, 8);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(263, 25);
            txtSenha.TabIndex = 6;
            // 
            // tblEmail
            // 
            tblEmail.BackColor = Color.Transparent;
            tblEmail.BackgroundImage = Properties.Resources.bgRetangularBranco_300x50;
            tblEmail.BackgroundImageLayout = ImageLayout.Stretch;
            tblEmail.ColumnCount = 2;
            tblEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tblEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblEmail.Controls.Add(pcbCheckBoxEmail, 1, 0);
            tblEmail.Controls.Add(txtEmail, 0, 0);
            tblEmail.Dock = DockStyle.Fill;
            tblEmail.Location = new Point(34, 229);
            tblEmail.Margin = new Padding(0);
            tblEmail.Name = "tblEmail";
            tblEmail.Padding = new Padding(5);
            tblEmail.RowCount = 1;
            tblEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblEmail.Size = new Size(309, 39);
            tblEmail.TabIndex = 9;
            // 
            // pcbCheckBoxEmail
            // 
            pcbCheckBoxEmail.BackColor = Color.Transparent;
            pcbCheckBoxEmail.Cursor = Cursors.Hand;
            pcbCheckBoxEmail.Image = Properties.Resources.chk_uncheck_32x32;
            pcbCheckBoxEmail.Location = new Point(282, 11);
            pcbCheckBoxEmail.Margin = new Padding(8, 6, 0, 0);
            pcbCheckBoxEmail.Name = "pcbCheckBoxEmail";
            pcbCheckBoxEmail.Size = new Size(18, 18);
            pcbCheckBoxEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCheckBoxEmail.TabIndex = 4;
            pcbCheckBoxEmail.TabStop = false;
            pcbCheckBoxEmail.Click += pcbCheckBoxEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(8, 8);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 25);
            txtEmail.TabIndex = 6;
            // 
            // UCLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 23, 28);
            Controls.Add(pCentral);
            Name = "UCLogin";
            Size = new Size(1366, 768);
            SizeChanged += UCLogin_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)pcbBGLogin).EndInit();
            pCentral.ResumeLayout(false);
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            tblSenha.ResumeLayout(false);
            tblSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCheckBoxSenha).EndInit();
            tblEmail.ResumeLayout(false);
            tblEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCheckBoxEmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbBGLogin;
        private Panel pCentral;
        private Label lblNomeEmpresa;
        private PictureBox pcbLogo;
        private TextBox txtSenha;
        private Label lblSenha;
        private Label lblEmail;
        private TableLayoutPanel tlpPrincipal;
        private Button btnEntrar;
        private TableLayoutPanel tblSenha;
        private TableLayoutPanel tblEmail;
        private TextBox txtEmail;
        private PictureBox pcbCheckBoxEmail;
        private PictureBox pcbCheckBoxSenha;
        private System.Windows.Forms.Timer timer1;
    }
}
