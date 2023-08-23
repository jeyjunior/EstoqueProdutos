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
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
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
            button4 = new Button();
            dtgUsuarios = new DataGridView();
            colPK_Produto = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colVolume = new DataGridViewTextBoxColumn();
            colDescricao = new DataGridViewTextBoxColumn();
            colAltura = new DataGridViewTextBoxColumn();
            colLargura = new DataGridViewTextBoxColumn();
            colComprimento = new DataGridViewTextBoxColumn();
            colFK_Formato = new DataGridViewTextBoxColumn();
            colFK_Imagem = new DataGridViewTextBoxColumn();
            colFK_Categoria = new DataGridViewTextBoxColumn();
            colFK_Marca = new DataGridViewTextBoxColumn();
            colFK_Embalagem = new DataGridViewTextBoxColumn();
            colFK_UnidadeMedida = new DataGridViewTextBoxColumn();
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
            // button4
            // 
            button4.Location = new Point(432, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
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
            dtgUsuarios.Columns.AddRange(new DataGridViewColumn[] { colPK_Produto, colNome, colVolume, colDescricao, colAltura, colLargura, colComprimento, colFK_Formato, colFK_Imagem, colFK_Categoria, colFK_Marca, colFK_Embalagem, colFK_UnidadeMedida });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dtgUsuarios.DefaultCellStyle = dataGridViewCellStyle14;
            dtgUsuarios.EnableHeadersVisualStyles = false;
            dtgUsuarios.GridColor = Color.White;
            dtgUsuarios.Location = new Point(10, 134);
            dtgUsuarios.Name = "dtgUsuarios";
            dtgUsuarios.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dtgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dtgUsuarios.RowHeadersVisible = false;
            dtgUsuarios.RowHeadersWidth = 55;
            dtgUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgUsuarios.RowTemplate.Height = 19;
            dtgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsuarios.Size = new Size(627, 333);
            dtgUsuarios.TabIndex = 6;
            // 
            // colPK_Produto
            // 
            colPK_Produto.DataPropertyName = "PK_Produto";
            colPK_Produto.HeaderText = "PK_Produto";
            colPK_Produto.MinimumWidth = 100;
            colPK_Produto.Name = "colPK_Produto";
            colPK_Produto.ReadOnly = true;
            colPK_Produto.Visible = false;
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNome.DataPropertyName = "Nome";
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 100;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colVolume
            // 
            colVolume.DataPropertyName = "Volume";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 3, 0);
            colVolume.DefaultCellStyle = dataGridViewCellStyle3;
            colVolume.HeaderText = "Volume";
            colVolume.MinimumWidth = 100;
            colVolume.Name = "colVolume";
            colVolume.ReadOnly = true;
            colVolume.Visible = false;
            // 
            // colDescricao
            // 
            colDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new Padding(3, 0, 0, 0);
            colDescricao.DefaultCellStyle = dataGridViewCellStyle4;
            colDescricao.HeaderText = "Descricao";
            colDescricao.MinimumWidth = 300;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            // 
            // colAltura
            // 
            colAltura.DataPropertyName = "Altura";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new Padding(0, 0, 3, 0);
            colAltura.DefaultCellStyle = dataGridViewCellStyle5;
            colAltura.HeaderText = "Altura";
            colAltura.MinimumWidth = 100;
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            colAltura.Visible = false;
            // 
            // colLargura
            // 
            colLargura.DataPropertyName = "Largura";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.Padding = new Padding(0, 0, 3, 0);
            colLargura.DefaultCellStyle = dataGridViewCellStyle6;
            colLargura.HeaderText = "Largura";
            colLargura.MinimumWidth = 100;
            colLargura.Name = "colLargura";
            colLargura.ReadOnly = true;
            colLargura.Visible = false;
            // 
            // colComprimento
            // 
            colComprimento.DataPropertyName = "Comprimento";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new Padding(0, 0, 3, 0);
            colComprimento.DefaultCellStyle = dataGridViewCellStyle7;
            colComprimento.HeaderText = "Comprimento";
            colComprimento.MinimumWidth = 100;
            colComprimento.Name = "colComprimento";
            colComprimento.ReadOnly = true;
            colComprimento.Visible = false;
            // 
            // colFK_Formato
            // 
            colFK_Formato.DataPropertyName = "FK_Formato";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Padding = new Padding(3, 0, 0, 0);
            colFK_Formato.DefaultCellStyle = dataGridViewCellStyle8;
            colFK_Formato.HeaderText = "Formato";
            colFK_Formato.MinimumWidth = 120;
            colFK_Formato.Name = "colFK_Formato";
            colFK_Formato.ReadOnly = true;
            colFK_Formato.Width = 120;
            // 
            // colFK_Imagem
            // 
            colFK_Imagem.DataPropertyName = "FK_Imagem";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Padding = new Padding(3, 0, 0, 0);
            colFK_Imagem.DefaultCellStyle = dataGridViewCellStyle9;
            colFK_Imagem.HeaderText = "Imagem";
            colFK_Imagem.MinimumWidth = 120;
            colFK_Imagem.Name = "colFK_Imagem";
            colFK_Imagem.ReadOnly = true;
            colFK_Imagem.Visible = false;
            colFK_Imagem.Width = 120;
            // 
            // colFK_Categoria
            // 
            colFK_Categoria.DataPropertyName = "FK_Categoria";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Padding = new Padding(3, 0, 0, 0);
            colFK_Categoria.DefaultCellStyle = dataGridViewCellStyle10;
            colFK_Categoria.HeaderText = "Categoria";
            colFK_Categoria.MinimumWidth = 120;
            colFK_Categoria.Name = "colFK_Categoria";
            colFK_Categoria.ReadOnly = true;
            colFK_Categoria.Width = 120;
            // 
            // colFK_Marca
            // 
            colFK_Marca.DataPropertyName = "FK_Marca";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Padding = new Padding(3, 0, 0, 0);
            colFK_Marca.DefaultCellStyle = dataGridViewCellStyle11;
            colFK_Marca.HeaderText = "Marca";
            colFK_Marca.MinimumWidth = 120;
            colFK_Marca.Name = "colFK_Marca";
            colFK_Marca.ReadOnly = true;
            colFK_Marca.Width = 120;
            // 
            // colFK_Embalagem
            // 
            colFK_Embalagem.DataPropertyName = "FK_Embalagem";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Padding = new Padding(3, 0, 0, 0);
            colFK_Embalagem.DefaultCellStyle = dataGridViewCellStyle12;
            colFK_Embalagem.HeaderText = "Embalagem";
            colFK_Embalagem.MinimumWidth = 120;
            colFK_Embalagem.Name = "colFK_Embalagem";
            colFK_Embalagem.ReadOnly = true;
            colFK_Embalagem.Width = 120;
            // 
            // colFK_UnidadeMedida
            // 
            colFK_UnidadeMedida.DataPropertyName = "FK_UnidadeMedida";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Padding = new Padding(3, 0, 0, 0);
            colFK_UnidadeMedida.DefaultCellStyle = dataGridViewCellStyle13;
            colFK_UnidadeMedida.HeaderText = "UnidadeMedida";
            colFK_UnidadeMedida.MinimumWidth = 100;
            colFK_UnidadeMedida.Name = "colFK_UnidadeMedida";
            colFK_UnidadeMedida.ReadOnly = true;
            colFK_UnidadeMedida.Visible = false;
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
            tblBotoes.Controls.Add(button4, 8, 0);
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
        private Button button4;
        private DataGridView dtgUsuarios;
        private TableLayoutPanel tblBotoes;
        private TableLayoutPanel tlpComponentesRow1;
        private Label lblSetor;
        private Label lblCargo;
        private Label lblNomeUsuario;
        private TableLayoutPanel tlpComponentesRow0;
        private Label lblDescricao;
        private DataGridViewTextBoxColumn colPK_Produto;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colVolume;
        private DataGridViewTextBoxColumn colDescricao;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colLargura;
        private DataGridViewTextBoxColumn colComprimento;
        private DataGridViewTextBoxColumn colFK_Formato;
        private DataGridViewTextBoxColumn colFK_Imagem;
        private DataGridViewTextBoxColumn colFK_Categoria;
        private DataGridViewTextBoxColumn colFK_Marca;
        private DataGridViewTextBoxColumn colFK_Embalagem;
        private DataGridViewTextBoxColumn colFK_UnidadeMedida;
        private TextBox txtNomeUsuario;
    }
}
