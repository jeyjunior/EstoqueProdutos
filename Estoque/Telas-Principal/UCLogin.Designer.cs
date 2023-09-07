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
            pcbBGLogin = new PictureBox();
            pCentral = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            pcbCheckBoxSenha = new PictureBox();
            txtSenha = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pcbCheckBoxEmail = new PictureBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbBGLogin).BeginInit();
            pCentral.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCheckBoxSenha).BeginInit();
            tableLayoutPanel3.SuspendLayout();
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
            pCentral.Controls.Add(tableLayoutPanel1);
            pCentral.Controls.Add(pcbBGLogin);
            pCentral.Location = new Point(277, 105);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(410, 566);
            pCentral.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.FromArgb(80, 90, 100);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.81818F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 6);
            tableLayoutPanel1.Controls.Add(button1, 1, 9);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 4);
            tableLayoutPanel1.Location = new Point(16, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.6727753F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.043478F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3864737F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.931004F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95170259F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.931004F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8827057F));
            tableLayoutPanel1.Size = new Size(378, 454);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logoUCLogin;
            pictureBox1.Location = new Point(37, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(34, 135);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(309, 54);
            label1.TabIndex = 2;
            label1.Text = "JeyJr Tech";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(80, 90, 100);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(37, 194);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 5);
            label2.Size = new Size(303, 43);
            label2.TabIndex = 3;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(80, 90, 100);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(37, 288);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 5);
            label3.Size = new Size(303, 28);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(80, 90, 100);
            button1.Location = new Point(37, 385);
            button1.Name = "button1";
            button1.Size = new Size(303, 66);
            button1.TabIndex = 7;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.BackgroundImage = Properties.Resources.bgRetangularBranco_300x50;
            tableLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(pcbCheckBoxSenha, 1, 0);
            tableLayoutPanel2.Controls.Add(txtSenha, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(34, 316);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(309, 41);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // pcbCheckBoxSenha
            // 
            pcbCheckBoxSenha.BackColor = Color.Transparent;
            pcbCheckBoxSenha.Cursor = Cursors.Hand;
            pcbCheckBoxSenha.Image = Properties.Resources.eyeBG_1;
            pcbCheckBoxSenha.Location = new Point(279, 15);
            pcbCheckBoxSenha.Margin = new Padding(5, 10, 0, 0);
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.BackgroundImage = Properties.Resources.bgRetangularBranco_300x50;
            tableLayoutPanel3.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(pcbCheckBoxEmail, 1, 0);
            tableLayoutPanel3.Controls.Add(txtEmail, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(34, 237);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(309, 41);
            tableLayoutPanel3.TabIndex = 9;
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCheckBoxSenha).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCheckBoxEmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbBGLogin;
        private Panel pCentral;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtSenha;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtEmail;
        private PictureBox pcbCheckBoxEmail;
        private PictureBox pcbCheckBoxSenha;
    }
}
