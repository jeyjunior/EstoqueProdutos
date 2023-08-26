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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            lblNomeAbreviado = new Label();
            txtNomeAbreviado = new TextBox();
            pcbImagemUsuario = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            cboCargo = new ComboBox();
            lblSetor = new Label();
            lblCargo = new Label();
            cboSetor = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSenha = new Label();
            label5 = new Label();
            lblConfirmarEmail = new Label();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            txtConfirmarEmail = new TextBox();
            tblBotoes = new TableLayoutPanel();
            button1 = new Button();
            btnLimpar = new Button();
            pn1 = new Panel();
            pn2 = new Panel();
            pn3 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagemUsuario).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tblBotoes.SuspendLayout();
            pn1.SuspendLayout();
            pn2.SuspendLayout();
            pn3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lblNomeCompleto, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNomeCompleto, 0, 1);
            tableLayoutPanel1.Controls.Add(lblNomeAbreviado, 0, 2);
            tableLayoutPanel1.Controls.Add(txtNomeAbreviado, 0, 3);
            tableLayoutPanel1.Location = new Point(125, 14);
            tableLayoutPanel1.Margin = new Padding(9, 9, 9, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new Size(320, 93);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.Dock = DockStyle.Fill;
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
            txtNomeCompleto.Location = new Point(3, 23);
            txtNomeCompleto.MaxLength = 1000;
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(314, 23);
            txtNomeCompleto.TabIndex = 2;
            // 
            // lblNomeAbreviado
            // 
            lblNomeAbreviado.Dock = DockStyle.Fill;
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
            txtNomeAbreviado.Location = new Point(3, 66);
            txtNomeAbreviado.MaxLength = 120;
            txtNomeAbreviado.Name = "txtNomeAbreviado";
            txtNomeAbreviado.Size = new Size(314, 23);
            txtNomeAbreviado.TabIndex = 18;
            // 
            // pcbImagemUsuario
            // 
            pcbImagemUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pcbImagemUsuario.Cursor = Cursors.Hand;
            pcbImagemUsuario.Location = new Point(16, 14);
            pcbImagemUsuario.Name = "pcbImagemUsuario";
            pcbImagemUsuario.Size = new Size(90, 93);
            pcbImagemUsuario.TabIndex = 0;
            pcbImagemUsuario.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(cboCargo, 0, 3);
            tableLayoutPanel2.Controls.Add(lblSetor, 0, 0);
            tableLayoutPanel2.Controls.Add(lblCargo, 0, 2);
            tableLayoutPanel2.Controls.Add(cboSetor, 0, 1);
            tableLayoutPanel2.Location = new Point(13, 16);
            tableLayoutPanel2.Margin = new Padding(9, 9, 9, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(432, 90);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // cboCargo
            // 
            cboCargo.Dock = DockStyle.Fill;
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(3, 66);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(426, 23);
            cboCargo.TabIndex = 21;
            // 
            // lblSetor
            // 
            lblSetor.Dock = DockStyle.Fill;
            lblSetor.ForeColor = SystemColors.ControlLightLight;
            lblSetor.Location = new Point(0, 0);
            lblSetor.Margin = new Padding(0);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(432, 20);
            lblSetor.TabIndex = 2;
            lblSetor.Text = "Setor:";
            lblSetor.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblCargo
            // 
            lblCargo.Dock = DockStyle.Fill;
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
            cboSetor.FormattingEnabled = true;
            cboSetor.Location = new Point(3, 23);
            cboSetor.Name = "cboSetor";
            cboSetor.Size = new Size(426, 23);
            cboSetor.TabIndex = 20;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblEmail, 0, 0);
            tableLayoutPanel3.Controls.Add(txtEmail, 0, 1);
            tableLayoutPanel3.Controls.Add(lblSenha, 0, 2);
            tableLayoutPanel3.Controls.Add(label5, 2, 2);
            tableLayoutPanel3.Controls.Add(lblConfirmarEmail, 2, 0);
            tableLayoutPanel3.Controls.Add(txtSenha, 0, 3);
            tableLayoutPanel3.Controls.Add(txtConfirmarSenha, 2, 3);
            tableLayoutPanel3.Controls.Add(txtConfirmarEmail, 2, 1);
            tableLayoutPanel3.Location = new Point(13, 9);
            tableLayoutPanel3.Margin = new Padding(9, 9, 9, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.Size = new Size(432, 93);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(0, 0);
            lblEmail.Margin = new Padding(0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(212, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(3, 23);
            txtEmail.MaxLength = 120;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.ForeColor = SystemColors.ControlLightLight;
            lblSenha.Location = new Point(0, 43);
            lblSenha.Margin = new Padding(0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(212, 20);
            lblSenha.TabIndex = 19;
            lblSenha.Text = "Senha:";
            lblSenha.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(220, 43);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(212, 20);
            label5.TabIndex = 20;
            label5.Text = "Confirmar senha:";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblConfirmarEmail
            // 
            lblConfirmarEmail.Dock = DockStyle.Fill;
            lblConfirmarEmail.ForeColor = SystemColors.ControlLightLight;
            lblConfirmarEmail.Location = new Point(220, 0);
            lblConfirmarEmail.Margin = new Padding(0);
            lblConfirmarEmail.Name = "lblConfirmarEmail";
            lblConfirmarEmail.Size = new Size(212, 20);
            lblConfirmarEmail.TabIndex = 21;
            lblConfirmarEmail.Text = "Confirmar email:";
            lblConfirmarEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(3, 66);
            txtSenha.MaxLength = 120;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(206, 23);
            txtSenha.TabIndex = 18;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarSenha.Dock = DockStyle.Fill;
            txtConfirmarSenha.Location = new Point(223, 66);
            txtConfirmarSenha.MaxLength = 120;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(206, 23);
            txtConfirmarSenha.TabIndex = 22;
            // 
            // txtConfirmarEmail
            // 
            txtConfirmarEmail.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarEmail.Dock = DockStyle.Fill;
            txtConfirmarEmail.Location = new Point(223, 23);
            txtConfirmarEmail.MaxLength = 120;
            txtConfirmarEmail.Name = "txtConfirmarEmail";
            txtConfirmarEmail.Size = new Size(206, 23);
            txtConfirmarEmail.TabIndex = 23;
            // 
            // tblBotoes
            // 
            tblBotoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblBotoes.ColumnCount = 4;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBotoes.Controls.Add(button1, 0, 0);
            tblBotoes.Controls.Add(btnLimpar, 2, 0);
            tblBotoes.Location = new Point(12, 400);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(460, 37);
            tblBotoes.TabIndex = 9;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.ForeColor = Color.FromArgb(66, 142, 79);
            button1.Image = Properties.Resources.save_outline_4;
            button1.Location = new Point(370, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(90, 37);
            button1.TabIndex = 5;
            button1.Text = "Salvar";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Dock = DockStyle.Fill;
            btnLimpar.ForeColor = Color.FromArgb(142, 66, 66);
            btnLimpar.Image = Properties.Resources.erase_outline_4;
            btnLimpar.Location = new Point(275, 0);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Padding = new Padding(5, 0, 0, 0);
            btnLimpar.Size = new Size(90, 37);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // pn1
            // 
            pn1.BackColor = Color.FromArgb(60, 75, 85);
            pn1.Controls.Add(tableLayoutPanel1);
            pn1.Controls.Add(pcbImagemUsuario);
            pn1.Location = new Point(12, 12);
            pn1.Name = "pn1";
            pn1.Size = new Size(460, 123);
            pn1.TabIndex = 10;
            // 
            // pn2
            // 
            pn2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pn2.BackColor = Color.FromArgb(60, 75, 85);
            pn2.Controls.Add(tableLayoutPanel2);
            pn2.Location = new Point(12, 141);
            pn2.Name = "pn2";
            pn2.Size = new Size(460, 124);
            pn2.TabIndex = 11;
            // 
            // pn3
            // 
            pn3.BackColor = Color.FromArgb(60, 75, 85);
            pn3.Controls.Add(tableLayoutPanel3);
            pn3.Location = new Point(12, 273);
            pn3.Name = "pn3";
            pn3.Size = new Size(460, 118);
            pn3.TabIndex = 12;
            // 
            // FrmCadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(484, 451);
            Controls.Add(pn3);
            Controls.Add(pn2);
            Controls.Add(pn1);
            Controls.Add(tblBotoes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(500, 490);
            MinimizeBox = false;
            MinimumSize = new Size(500, 490);
            Name = "FrmCadastrarUsuario";
            Text = "Cadastrar Usuário";
            FormClosed += FrmCadastrarUsuario_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagemUsuario).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tblBotoes.ResumeLayout(false);
            pn1.ResumeLayout(false);
            pn2.ResumeLayout(false);
            pn3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pcbImagemUsuario;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Label lblNomeAbreviado;
        private TextBox txtNomeAbreviado;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblSetor;
        private Label lblCargo;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSenha;
        private Label label5;
        private Label lblConfirmarEmail;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private TextBox txtConfirmarEmail;
        private TableLayoutPanel tblBotoes;
        private Button btnLimpar;
        private ComboBox cboCargo;
        private ComboBox cboSetor;
        private Panel pn1;
        private Panel pn2;
        private Panel pn3;
        private Button button1;
    }
}