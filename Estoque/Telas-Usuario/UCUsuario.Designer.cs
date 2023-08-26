namespace Estoque.Telas
{
    partial class UCUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            tlpComponentesRow1 = new TableLayoutPanel();
            txtNomeUsuario = new TextBox();
            lblSetor = new Label();
            cboSetor = new ComboBox();
            lblCargo = new Label();
            lblNomeUsuario = new Label();
            cboCargo = new ComboBox();
            btnPesquisar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnCadastrarUsuario = new Button();
            dtgUsuarios = new DataGridView();
            colPK_Usuario = new DataGridViewTextBoxColumn();
            colID_Usuario = new DataGridViewTextBoxColumn();
            colNomeAbreviado = new DataGridViewTextBoxColumn();
            colNomeCompleto = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDataCadastro = new DataGridViewTextBoxColumn();
            colFK_Setor = new DataGridViewTextBoxColumn();
            colFK_Cargo = new DataGridViewTextBoxColumn();
            tblBotoes = new TableLayoutPanel();
            tlpComponentesRow0 = new TableLayoutPanel();
            lblDescricao = new Label();
            tlpComponentesRow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).BeginInit();
            tblBotoes.SuspendLayout();
            tlpComponentesRow0.SuspendLayout();
            SuspendLayout();
            // 
            // tlpComponentesRow1
            // 
            tlpComponentesRow1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpComponentesRow1.ColumnCount = 5;
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.Controls.Add(txtNomeUsuario, 0, 1);
            tlpComponentesRow1.Controls.Add(lblSetor, 4, 0);
            tlpComponentesRow1.Controls.Add(cboSetor, 4, 1);
            tlpComponentesRow1.Controls.Add(lblCargo, 2, 0);
            tlpComponentesRow1.Controls.Add(lblNomeUsuario, 0, 0);
            tlpComponentesRow1.Controls.Add(cboCargo, 2, 1);
            tlpComponentesRow1.Location = new Point(10, 18);
            tlpComponentesRow1.Margin = new Padding(9, 0, 9, 9);
            tlpComponentesRow1.Name = "tlpComponentesRow1";
            tlpComponentesRow1.RowCount = 2;
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponentesRow1.Size = new Size(627, 54);
            tlpComponentesRow1.TabIndex = 10;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNomeUsuario.Dock = DockStyle.Fill;
            txtNomeUsuario.Location = new Point(3, 23);
            txtNomeUsuario.MaxLength = 120;
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(199, 23);
            txtNomeUsuario.TabIndex = 15;
            // 
            // lblSetor
            // 
            lblSetor.Dock = DockStyle.Fill;
            lblSetor.ForeColor = SystemColors.ControlLightLight;
            lblSetor.Location = new Point(420, 0);
            lblSetor.Margin = new Padding(0);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(207, 20);
            lblSetor.TabIndex = 12;
            lblSetor.Text = "Setor:";
            lblSetor.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboSetor
            // 
            cboSetor.Dock = DockStyle.Fill;
            cboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSetor.FormattingEnabled = true;
            cboSetor.Location = new Point(423, 23);
            cboSetor.Name = "cboSetor";
            cboSetor.Size = new Size(201, 23);
            cboSetor.TabIndex = 10;
            // 
            // lblCargo
            // 
            lblCargo.Dock = DockStyle.Fill;
            lblCargo.ForeColor = SystemColors.ControlLightLight;
            lblCargo.Location = new Point(210, 0);
            lblCargo.Margin = new Padding(0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(205, 20);
            lblCargo.TabIndex = 11;
            lblCargo.Text = "Cargo:";
            lblCargo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Dock = DockStyle.Fill;
            lblNomeUsuario.ForeColor = SystemColors.ControlLightLight;
            lblNomeUsuario.Location = new Point(0, 0);
            lblNomeUsuario.Margin = new Padding(0);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(205, 20);
            lblNomeUsuario.TabIndex = 11;
            lblNomeUsuario.Text = "Nome:";
            lblNomeUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboCargo
            // 
            cboCargo.Dock = DockStyle.Fill;
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(213, 23);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(199, 23);
            cboCargo.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.search_1;
            btnPesquisar.Location = new Point(592, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(35, 35);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(512, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(472, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(552, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.Location = new Point(432, 0);
            btnCadastrarUsuario.Margin = new Padding(0);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(35, 35);
            btnCadastrarUsuario.TabIndex = 5;
            btnCadastrarUsuario.UseVisualStyleBackColor = true;
            btnCadastrarUsuario.Click += btnCadastrarUsuario_Click;
            // 
            // dtgUsuarios
            // 
            dtgUsuarios.AllowUserToDeleteRows = false;
            dtgUsuarios.AllowUserToOrderColumns = true;
            dtgUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 241, 241);
            dtgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgUsuarios.BackgroundColor = Color.FromArgb(80, 90, 100);
            dtgUsuarios.BorderStyle = BorderStyle.None;
            dtgUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dtgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 74, 84);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgUsuarios.ColumnHeadersHeight = 35;
            dtgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgUsuarios.Columns.AddRange(new DataGridViewColumn[] { colPK_Usuario, colID_Usuario, colNomeAbreviado, colNomeCompleto, colEmail, colDataCadastro, colFK_Setor, colFK_Cargo });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dtgUsuarios.DefaultCellStyle = dataGridViewCellStyle8;
            dtgUsuarios.EnableHeadersVisualStyles = false;
            dtgUsuarios.GridColor = Color.White;
            dtgUsuarios.Location = new Point(10, 134);
            dtgUsuarios.Name = "dtgUsuarios";
            dtgUsuarios.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dtgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dtgUsuarios.RowHeadersVisible = false;
            dtgUsuarios.RowHeadersWidth = 55;
            dtgUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgUsuarios.RowTemplate.Height = 19;
            dtgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsuarios.Size = new Size(627, 333);
            dtgUsuarios.TabIndex = 6;
            // 
            // colPK_Usuario
            // 
            colPK_Usuario.DataPropertyName = "PK_Usuario";
            colPK_Usuario.HeaderText = "PK_Usuario";
            colPK_Usuario.MinimumWidth = 100;
            colPK_Usuario.Name = "colPK_Usuario";
            colPK_Usuario.ReadOnly = true;
            colPK_Usuario.Visible = false;
            // 
            // colID_Usuario
            // 
            colID_Usuario.DataPropertyName = "ID_Usuario";
            colID_Usuario.HeaderText = "ID";
            colID_Usuario.MinimumWidth = 75;
            colID_Usuario.Name = "colID_Usuario";
            colID_Usuario.ReadOnly = true;
            colID_Usuario.Width = 75;
            // 
            // colNomeAbreviado
            // 
            colNomeAbreviado.DataPropertyName = "NomeAbreviado";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 3, 0);
            colNomeAbreviado.DefaultCellStyle = dataGridViewCellStyle3;
            colNomeAbreviado.HeaderText = "Usuario";
            colNomeAbreviado.MinimumWidth = 150;
            colNomeAbreviado.Name = "colNomeAbreviado";
            colNomeAbreviado.ReadOnly = true;
            colNomeAbreviado.Width = 150;
            // 
            // colNomeCompleto
            // 
            colNomeCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNomeCompleto.DataPropertyName = "NomeCompleto";
            colNomeCompleto.HeaderText = "NomeCompleto";
            colNomeCompleto.MinimumWidth = 100;
            colNomeCompleto.Name = "colNomeCompleto";
            colNomeCompleto.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 3, 0);
            colEmail.DefaultCellStyle = dataGridViewCellStyle4;
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 200;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 200;
            // 
            // colDataCadastro
            // 
            colDataCadastro.DataPropertyName = "DataCadastro";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new Padding(0, 0, 3, 0);
            colDataCadastro.DefaultCellStyle = dataGridViewCellStyle5;
            colDataCadastro.HeaderText = "DataCadastro";
            colDataCadastro.MinimumWidth = 100;
            colDataCadastro.Name = "colDataCadastro";
            colDataCadastro.ReadOnly = true;
            // 
            // colFK_Setor
            // 
            colFK_Setor.DataPropertyName = "FK_Setor";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Padding = new Padding(3, 0, 0, 0);
            colFK_Setor.DefaultCellStyle = dataGridViewCellStyle6;
            colFK_Setor.HeaderText = "Setor";
            colFK_Setor.MinimumWidth = 220;
            colFK_Setor.Name = "colFK_Setor";
            colFK_Setor.ReadOnly = true;
            colFK_Setor.Width = 220;
            // 
            // colFK_Cargo
            // 
            colFK_Cargo.DataPropertyName = "FK_Cargo";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Padding = new Padding(3, 0, 0, 0);
            colFK_Cargo.DefaultCellStyle = dataGridViewCellStyle7;
            colFK_Cargo.HeaderText = "Cargo";
            colFK_Cargo.MinimumWidth = 220;
            colFK_Cargo.Name = "colFK_Cargo";
            colFK_Cargo.ReadOnly = true;
            colFK_Cargo.Width = 220;
            // 
            // tblBotoes
            // 
            tblBotoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblBotoes.ColumnCount = 9;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.Controls.Add(btnPesquisar, 0, 0);
            tblBotoes.Controls.Add(button3, 2, 0);
            tblBotoes.Controls.Add(btnCadastrarUsuario, 8, 0);
            tblBotoes.Controls.Add(button1, 4, 0);
            tblBotoes.Controls.Add(button2, 6, 0);
            tblBotoes.Location = new Point(10, 81);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(627, 35);
            tblBotoes.TabIndex = 8;
            // 
            // tlpComponentesRow0
            // 
            tlpComponentesRow0.ColumnCount = 8;
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6314F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.3686F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tlpComponentesRow0.Controls.Add(lblDescricao, 2, 0);
            tlpComponentesRow0.Location = new Point(0, 0);
            tlpComponentesRow0.Name = "tlpComponentesRow0";
            tlpComponentesRow0.RowCount = 1;
            tlpComponentesRow0.Size = new Size(200, 100);
            tlpComponentesRow0.TabIndex = 0;
            // 
            // lblDescricao
            // 
            lblDescricao.Dock = DockStyle.Fill;
            lblDescricao.ForeColor = SystemColors.ControlLightLight;
            lblDescricao.Location = new Point(-22, 0);
            lblDescricao.Margin = new Padding(0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(1, 100);
            lblDescricao.TabIndex = 19;
            lblDescricao.Text = "Descrição do Produto:";
            lblDescricao.TextAlign = ContentAlignment.BottomLeft;
            // 
            // UCUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(tlpComponentesRow1);
            Controls.Add(tblBotoes);
            Controls.Add(dtgUsuarios);
            MinimumSize = new Size(650, 480);
            Name = "UCUsuario";
            Size = new Size(650, 480);
            Load += UCProdutos_Load;
            ParentChanged += UCProdutos_ParentChanged;
            tlpComponentesRow1.ResumeLayout(false);
            tlpComponentesRow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            tblBotoes.ResumeLayout(false);
            tlpComponentesRow0.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cboSetor;
        private ComboBox cboCargo;
        private Button btnPesquisar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnCadastrarUsuario;
        private DataGridView dtgUsuarios;
        private TableLayoutPanel tblBotoes;
        private TableLayoutPanel tlpComponentesRow1;
        private Label lblSetor;
        private Label lblCargo;
        private Label lblNomeUsuario;
        private TableLayoutPanel tlpComponentesRow0;
        private Label lblDescricao;
        private TextBox txtNomeUsuario;
        private DataGridViewTextBoxColumn colPK_Usuario;
        private DataGridViewTextBoxColumn colID_Usuario;
        private DataGridViewTextBoxColumn colNomeAbreviado;
        private DataGridViewTextBoxColumn colNomeCompleto;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDataCadastro;
        private DataGridViewTextBoxColumn colFK_Setor;
        private DataGridViewTextBoxColumn colFK_Cargo;
    }
}
