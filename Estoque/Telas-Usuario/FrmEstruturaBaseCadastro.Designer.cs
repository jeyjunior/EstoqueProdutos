namespace Estoque.Telas_Usuario
{
    partial class FrmEstruturaBaseCadastro
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pcbImagemUsuario = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            textBox1 = new TextBox();
            lblNomeCompleto = new Label();
            label1 = new Label();
            txtNomeCompleto = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            cboSetor = new ComboBox();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            pcbValidacaoEmail = new PictureBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            pcbSenha = new PictureBox();
            pictureBox1 = new PictureBox();
            tlpPrincipal.SuspendLayout();
            tblCentral.SuspendLayout();
            tblBotoes.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagemUsuario).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbValidacaoEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tblCentral.Controls.Add(tableLayoutPanel1, 0, 0);
            tblCentral.Controls.Add(tableLayoutPanel2, 0, 2);
            tblCentral.Controls.Add(tableLayoutPanel3, 0, 4);
            tblCentral.Controls.Add(tableLayoutPanel4, 0, 6);
            tblCentral.Dock = DockStyle.Fill;
            tblCentral.Location = new Point(15, 15);
            tblCentral.Margin = new Padding(0);
            tblCentral.Name = "tblCentral";
            tblCentral.RowCount = 9;
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblCentral.Size = new Size(754, 531);
            tblCentral.TabIndex = 0;
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
            tblBotoes.Location = new Point(0, 496);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(754, 35);
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
            btnSalvar.Size = new Size(90, 35);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalvar.UseVisualStyleBackColor = true;
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
            btnLimpar.Size = new Size(90, 35);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(192, 255, 192);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Controls.Add(pcbImagemUsuario, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(754, 165);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pcbImagemUsuario
            // 
            pcbImagemUsuario.BackColor = Color.Gray;
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
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(60, 75, 85);
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(textBox1, 0, 4);
            tableLayoutPanel5.Controls.Add(lblNomeCompleto, 0, 0);
            tableLayoutPanel5.Controls.Add(label1, 0, 3);
            tableLayoutPanel5.Controls.Add(txtNomeCompleto, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(165, 15);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(574, 135);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 109);
            textBox1.Margin = new Padding(0);
            textBox1.MaxLength = 1000;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(574, 25);
            textBox1.TabIndex = 6;
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
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 75);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 5);
            label1.Size = new Size(574, 34);
            label1.TabIndex = 4;
            label1.Text = "Usuário:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.BorderStyle = BorderStyle.FixedSingle;
            txtNomeCompleto.Dock = DockStyle.Fill;
            txtNomeCompleto.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCompleto.Location = new Point(0, 34);
            txtNomeCompleto.Margin = new Padding(0);
            txtNomeCompleto.MaxLength = 1000;
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(574, 25);
            txtNomeCompleto.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(60, 75, 85);
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.Controls.Add(comboBox1, 3, 2);
            tableLayoutPanel2.Controls.Add(label2, 1, 1);
            tableLayoutPanel2.Controls.Add(cboSetor, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 3, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 180);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.Size = new Size(754, 90);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(387, 49);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(352, 26);
            comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(15, 15);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 5);
            label2.Size = new Size(352, 34);
            label2.TabIndex = 5;
            label2.Text = "Setor:";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboSetor
            // 
            cboSetor.Dock = DockStyle.Fill;
            cboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSetor.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboSetor.FormattingEnabled = true;
            cboSetor.Location = new Point(15, 49);
            cboSetor.Margin = new Padding(0);
            cboSetor.Name = "cboSetor";
            cboSetor.Size = new Size(352, 26);
            cboSetor.TabIndex = 6;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(387, 15);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 5);
            label3.Size = new Size(352, 34);
            label3.TabIndex = 8;
            label3.Text = "Cargo:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(60, 75, 85);
            tableLayoutPanel3.ColumnCount = 7;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel3.Controls.Add(pcbValidacaoEmail, 2, 2);
            tableLayoutPanel3.Controls.Add(txtEmail, 1, 2);
            tableLayoutPanel3.Controls.Add(label4, 1, 1);
            tableLayoutPanel3.Controls.Add(label5, 4, 1);
            tableLayoutPanel3.Controls.Add(textBox2, 4, 2);
            tableLayoutPanel3.Controls.Add(pictureBox2, 5, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 285);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel3.Size = new Size(754, 90);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // pcbValidacaoEmail
            // 
            pcbValidacaoEmail.Dock = DockStyle.Fill;
            pcbValidacaoEmail.Image = Properties.Resources.circulo_verde;
            pcbValidacaoEmail.Location = new Point(333, 49);
            pcbValidacaoEmail.Margin = new Padding(0);
            pcbValidacaoEmail.Name = "pcbValidacaoEmail";
            pcbValidacaoEmail.Size = new Size(34, 26);
            pcbValidacaoEmail.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbValidacaoEmail.TabIndex = 26;
            pcbValidacaoEmail.TabStop = false;
            pcbValidacaoEmail.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(15, 49);
            txtEmail.Margin = new Padding(0);
            txtEmail.MaxLength = 120;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 25);
            txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(15, 15);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 0, 5);
            label4.Size = new Size(318, 34);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(387, 15);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 5);
            label5.Size = new Size(318, 34);
            label5.TabIndex = 8;
            label5.Text = "Confirmar Email:";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(387, 49);
            textBox2.Margin = new Padding(0);
            textBox2.MaxLength = 120;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(318, 25);
            textBox2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.circulo_verde;
            pictureBox2.Location = new Point(705, 49);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(60, 75, 85);
            tableLayoutPanel4.ColumnCount = 7;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel4.Controls.Add(label6, 1, 1);
            tableLayoutPanel4.Controls.Add(label7, 4, 1);
            tableLayoutPanel4.Controls.Add(textBox4, 4, 2);
            tableLayoutPanel4.Controls.Add(pcbSenha, 2, 2);
            tableLayoutPanel4.Controls.Add(pictureBox1, 5, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 390);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.Size = new Size(754, 90);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(15, 49);
            textBox3.Margin = new Padding(0);
            textBox3.MaxLength = 120;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(318, 25);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(15, 15);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 5);
            label6.Size = new Size(318, 34);
            label6.TabIndex = 5;
            label6.Text = "Senha:";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(387, 15);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 0, 5);
            label7.Size = new Size(318, 34);
            label7.TabIndex = 8;
            label7.Text = "Confirmar Senha:";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Dock = DockStyle.Fill;
            textBox4.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(387, 49);
            textBox4.Margin = new Padding(0);
            textBox4.MaxLength = 120;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(318, 25);
            textBox4.TabIndex = 12;
            // 
            // pcbSenha
            // 
            pcbSenha.Dock = DockStyle.Fill;
            pcbSenha.Image = Properties.Resources.eye_1;
            pcbSenha.Location = new Point(333, 49);
            pcbSenha.Margin = new Padding(0);
            pcbSenha.Name = "pcbSenha";
            pcbSenha.Size = new Size(34, 26);
            pcbSenha.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSenha.TabIndex = 15;
            pcbSenha.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.eye_1;
            pictureBox1.Location = new Point(705, 49);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FrmEstruturaBaseCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(784, 561);
            Controls.Add(tlpPrincipal);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "FrmEstruturaBaseCadastro";
            Text = "FrmEstruturaBase";
            Load += FrmEstruturaBaseCadastro_Load;
            tlpPrincipal.ResumeLayout(false);
            tblCentral.ResumeLayout(false);
            tblBotoes.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbImagemUsuario).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbValidacaoEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tblCentral;
        private TableLayoutPanel tblBotoes;
        private Button btnSalvar;
        private Button btnLimpar;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pcbImagemUsuario;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblNomeCompleto;
        private Label label1;
        private TextBox textBox1;
        private TextBox txtNomeCompleto;
        private Label label2;
        private ComboBox cboSetor;
        private ComboBox comboBox1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private Label label7;
        private TextBox txtEmail;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pcbSenha;
        private PictureBox pictureBox1;
        private PictureBox pcbValidacaoEmail;
        private PictureBox pictureBox2;
    }
}