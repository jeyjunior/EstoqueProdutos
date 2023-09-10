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
            lblNomeCompleto = new Label();
            lblNomeAbreviado = new Label();
            txtNomeAbreviado = new TextBox();
            pcbImagemUsuario = new PictureBox();
            tlpSetor = new TableLayoutPanel();
            cboCargo = new ComboBox();
            lblCargo = new Label();
            cboSetor = new ComboBox();
            lblSetor = new Label();
            tblBotoes = new TableLayoutPanel();
            btnSalvar = new Button();
            btnLimpar = new Button();
            pn1 = new Panel();
            pictureBox1 = new PictureBox();
            pn2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            pnRegua = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbImagemUsuario).BeginInit();
            tlpSetor.SuspendLayout();
            tblBotoes.SuspendLayout();
            pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pn2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeCompleto.ForeColor = SystemColors.ControlLightLight;
            lblNomeCompleto.Location = new Point(0, 0);
            lblNomeCompleto.Margin = new Padding(0);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(204, 20);
            lblNomeCompleto.TabIndex = 2;
            lblNomeCompleto.Text = "Nome do produto:";
            lblNomeCompleto.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblNomeAbreviado
            // 
            lblNomeAbreviado.Dock = DockStyle.Fill;
            lblNomeAbreviado.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeAbreviado.ForeColor = SystemColors.ControlLightLight;
            lblNomeAbreviado.Location = new Point(214, 0);
            lblNomeAbreviado.Margin = new Padding(0);
            lblNomeAbreviado.Name = "lblNomeAbreviado";
            lblNomeAbreviado.Size = new Size(113, 21);
            lblNomeAbreviado.TabIndex = 19;
            lblNomeAbreviado.Text = "Fabricação:";
            lblNomeAbreviado.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtNomeAbreviado
            // 
            txtNomeAbreviado.BorderStyle = BorderStyle.FixedSingle;
            txtNomeAbreviado.Dock = DockStyle.Fill;
            txtNomeAbreviado.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeAbreviado.Location = new Point(3, 21);
            txtNomeAbreviado.MaxLength = 120;
            txtNomeAbreviado.Name = "txtNomeAbreviado";
            txtNomeAbreviado.Size = new Size(445, 22);
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
            pcbImagemUsuario.Size = new Size(90, 94);
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
            tlpSetor.Size = new Size(568, 92);
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
            cboCargo.Size = new Size(562, 22);
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
            lblCargo.Size = new Size(568, 18);
            lblCargo.TabIndex = 19;
            lblCargo.Text = "Marca:";
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
            cboSetor.Size = new Size(562, 22);
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
            lblSetor.Size = new Size(568, 20);
            lblSetor.TabIndex = 2;
            lblSetor.Text = "Categoria:";
            lblSetor.TextAlign = ContentAlignment.BottomLeft;
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
            tblBotoes.Location = new Point(12, 507);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(599, 37);
            tblBotoes.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Fill;
            btnSalvar.ForeColor = Color.FromArgb(66, 142, 79);
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(509, 0);
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
            btnLimpar.Location = new Point(414, 0);
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
            pn1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pn1.BackColor = Color.FromArgb(60, 75, 85);
            pn1.Controls.Add(tableLayoutPanel4);
            pn1.Controls.Add(pcbImagemUsuario);
            pn1.Controls.Add(pictureBox1);
            pn1.Location = new Point(12, 12);
            pn1.Name = "pn1";
            pn1.Size = new Size(599, 125);
            pn1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 102);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pn2
            // 
            pn2.BackColor = Color.FromArgb(60, 75, 85);
            pn2.Controls.Add(tlpSetor);
            pn2.Location = new Point(12, 377);
            pn2.Name = "pn2";
            pn2.Size = new Size(599, 118);
            pn2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Location = new Point(127, 11);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel4.Size = new Size(451, 98);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // pnRegua
            // 
            pnRegua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnRegua.BackColor = Color.Brown;
            pnRegua.Location = new Point(607, 1);
            pnRegua.Name = "pnRegua";
            pnRegua.Size = new Size(15, 14);
            pnRegua.TabIndex = 12;
            pnRegua.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.36842F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel6.Controls.Add(lblNomeAbreviado, 2, 0);
            tableLayoutPanel6.Controls.Add(lblNomeCompleto, 0, 0);
            tableLayoutPanel6.Controls.Add(dateTimePicker1, 2, 1);
            tableLayoutPanel6.Controls.Add(dateTimePicker2, 4, 1);
            tableLayoutPanel6.Controls.Add(label2, 4, 0);
            tableLayoutPanel6.Controls.Add(textBox5, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel6.Size = new Size(451, 53);
            tableLayoutPanel6.TabIndex = 14;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label3, 0, 0);
            tableLayoutPanel7.Controls.Add(txtNomeAbreviado, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 53);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.Size = new Size(451, 45);
            tableLayoutPanel7.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(214, 24);
            dateTimePicker1.Margin = new Padding(0, 3, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Size = new Size(113, 22);
            dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Fill;
            dateTimePicker2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(337, 24);
            dateTimePicker2.Margin = new Padding(0, 3, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowCheckBox = true;
            dateTimePicker2.Size = new Size(114, 22);
            dateTimePicker2.TabIndex = 21;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(337, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 22;
            label2.Text = "Validade:";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(451, 18);
            label3.TabIndex = 23;
            label3.Text = "Descrição:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 75, 85);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(12, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 86);
            panel2.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label5, 4, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 4, 1);
            tableLayoutPanel1.Location = new Point(16, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(568, 49);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 75, 85);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new Point(12, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 79);
            panel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Controls.Add(label7, 2, 0);
            tableLayoutPanel2.Controls.Add(label8, 4, 0);
            tableLayoutPanel2.Controls.Add(textBox4, 2, 1);
            tableLayoutPanel2.Controls.Add(comboBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(comboBox2, 4, 1);
            tableLayoutPanel2.Location = new Point(16, 15);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Size = new Size(568, 46);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(182, 19);
            label1.TabIndex = 3;
            label1.Text = "Altura:";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(192, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(182, 19);
            label4.TabIndex = 4;
            label4.Text = "Largura:";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(384, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(184, 19);
            label5.TabIndex = 5;
            label5.Text = "Comprimento:";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(301, 18);
            label6.TabIndex = 6;
            label6.Text = "Tipo de embalagem:";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(311, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(164, 18);
            label7.TabIndex = 7;
            label7.Text = "Volume:";
            label7.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(485, 0);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(83, 18);
            label8.TabIndex = 8;
            label8.Text = "Un.:";
            label8.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(195, 22);
            textBox1.MaxLength = 1000;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 22);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(3, 22);
            textBox2.MaxLength = 1000;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 22);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(387, 22);
            textBox3.MaxLength = 1000;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 22);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(314, 21);
            textBox4.MaxLength = 1000;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 22);
            textBox4.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 22);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(488, 21);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(77, 22);
            comboBox2.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Dock = DockStyle.Fill;
            textBox5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(3, 24);
            textBox5.MaxLength = 1000;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(198, 22);
            textBox5.TabIndex = 23;
            // 
            // FrmCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(623, 558);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnRegua);
            Controls.Add(pn2);
            Controls.Add(pn1);
            Controls.Add(tblBotoes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(497, 508);
            Name = "FrmCadastrarProduto";
            Text = "Cadastrar Produto";
            FormClosed += FrmCadastrarUsuario_FormClosed;
            Load += FrmCadastrarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pcbImagemUsuario).EndInit();
            tlpSetor.ResumeLayout(false);
            tblBotoes.ResumeLayout(false);
            pn1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pn2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pcbImagemUsuario;
        private Label lblNomeCompleto;
        private Label lblNomeAbreviado;
        private TextBox txtNomeAbreviado;
        private TableLayoutPanel tlpSetor;
        private Label lblSetor;
        private Label lblCargo;
        private TableLayoutPanel tblBotoes;
        private Button btnLimpar;
        private ComboBox cboCargo;
        private ComboBox cboSetor;
        private Panel pn1;
        private Button btnSalvar;
        private Panel pn2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel pnRegua;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}