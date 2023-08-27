namespace Estoque.Telas_Produto
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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            tlpComponenteDaPesquisa = new TableLayoutPanel();
            tlpComponentesRow1 = new TableLayoutPanel();
            txtNome = new TextBox();
            lblCargo = new Label();
            cboCargo = new ComboBox();
            lblSetor = new Label();
            lblNomeUsuario = new Label();
            cboSetor = new ComboBox();
            btnPesquisar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnCadastrarUsuario = new Button();
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
            tlpComponenteDaPesquisa.SuspendLayout();
            tlpComponentesRow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).BeginInit();
            tblBotoes.SuspendLayout();
            tlpComponentesRow0.SuspendLayout();
            SuspendLayout();
            // 
            // tlpComponenteDaPesquisa
            // 
            tlpComponenteDaPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpComponenteDaPesquisa.BackColor = Color.FromArgb(60, 75, 85);
            tlpComponenteDaPesquisa.ColumnCount = 1;
            tlpComponenteDaPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpComponenteDaPesquisa.Controls.Add(tlpComponentesRow1, 0, 0);
            tlpComponenteDaPesquisa.Location = new Point(25, 26);
            tlpComponenteDaPesquisa.Margin = new Padding(5);
            tlpComponenteDaPesquisa.Name = "tlpComponenteDaPesquisa";
            tlpComponenteDaPesquisa.Padding = new Padding(5);
            tlpComponenteDaPesquisa.RowCount = 2;
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponenteDaPesquisa.Size = new Size(570, 82);
            tlpComponenteDaPesquisa.TabIndex = 0;
            // 
            // tlpComponentesRow1
            // 
            tlpComponentesRow1.ColumnCount = 5;
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.Controls.Add(txtNome, 0, 1);
            tlpComponentesRow1.Controls.Add(lblCargo, 4, 0);
            tlpComponentesRow1.Controls.Add(cboCargo, 4, 1);
            tlpComponentesRow1.Controls.Add(lblSetor, 2, 0);
            tlpComponentesRow1.Controls.Add(lblNomeUsuario, 0, 0);
            tlpComponentesRow1.Controls.Add(cboSetor, 2, 1);
            tlpComponentesRow1.Dock = DockStyle.Fill;
            tlpComponentesRow1.Location = new Point(14, 5);
            tlpComponentesRow1.Margin = new Padding(9, 0, 9, 9);
            tlpComponentesRow1.Name = "tlpComponentesRow1";
            tlpComponentesRow1.RowCount = 2;
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponentesRow1.Size = new Size(542, 53);
            tlpComponentesRow1.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Dock = DockStyle.Fill;
            txtNome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(3, 23);
            txtNome.MaxLength = 120;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(164, 27);
            txtNome.TabIndex = 15;
            // 
            // lblCargo
            // 
            lblCargo.Dock = DockStyle.Fill;
            lblCargo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargo.ForeColor = SystemColors.ControlLightLight;
            lblCargo.Location = new Point(370, 0);
            lblCargo.Margin = new Padding(0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(172, 20);
            lblCargo.TabIndex = 12;
            lblCargo.Text = "Cargo:";
            lblCargo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboCargo
            // 
            cboCargo.Dock = DockStyle.Fill;
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(373, 23);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(166, 26);
            cboCargo.TabIndex = 10;
            cboCargo.SelectedIndexChanged += cboCargo_SelectedIndexChanged;
            // 
            // lblSetor
            // 
            lblSetor.Dock = DockStyle.Fill;
            lblSetor.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSetor.ForeColor = SystemColors.ControlLightLight;
            lblSetor.Location = new Point(185, 0);
            lblSetor.Margin = new Padding(0);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(170, 20);
            lblSetor.TabIndex = 11;
            lblSetor.Text = "Setor:";
            lblSetor.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Dock = DockStyle.Fill;
            lblNomeUsuario.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeUsuario.ForeColor = SystemColors.ControlLightLight;
            lblNomeUsuario.Location = new Point(0, 0);
            lblNomeUsuario.Margin = new Padding(0);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(170, 20);
            lblNomeUsuario.TabIndex = 11;
            lblNomeUsuario.Text = "Nome:";
            lblNomeUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboSetor
            // 
            cboSetor.Dock = DockStyle.Fill;
            cboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSetor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboSetor.FormattingEnabled = true;
            cboSetor.Location = new Point(188, 23);
            cboSetor.Name = "cboSetor";
            cboSetor.Size = new Size(164, 26);
            cboSetor.TabIndex = 8;
            cboSetor.SelectedIndexChanged += cboSetor_SelectedIndexChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.search_1;
            btnPesquisar.Location = new Point(535, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(35, 35);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(455, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(415, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(495, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.Location = new Point(375, 0);
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
            dataGridViewCellStyle16.BackColor = Color.FromArgb(241, 241, 241);
            dtgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dtgUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgUsuarios.BackgroundColor = Color.FromArgb(80, 90, 100);
            dtgUsuarios.BorderStyle = BorderStyle.None;
            dtgUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dtgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(60, 74, 84);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dtgUsuarios.ColumnHeadersHeight = 35;
            dtgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgUsuarios.Columns.AddRange(new DataGridViewColumn[] { colPK_Produto, colNome, colVolume, colDescricao, colAltura, colLargura, colComprimento, colFK_Formato, colFK_Imagem, colFK_Categoria, colFK_Marca, colFK_Embalagem, colFK_UnidadeMedida });
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle29.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle29.SelectionForeColor = Color.White;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.False;
            dtgUsuarios.DefaultCellStyle = dataGridViewCellStyle29;
            dtgUsuarios.EnableHeadersVisualStyles = false;
            dtgUsuarios.GridColor = Color.White;
            dtgUsuarios.Location = new Point(25, 165);
            dtgUsuarios.Name = "dtgUsuarios";
            dtgUsuarios.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle30.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle30.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.True;
            dtgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            dtgUsuarios.RowHeadersVisible = false;
            dtgUsuarios.RowHeadersWidth = 55;
            dtgUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgUsuarios.RowTemplate.Height = 19;
            dtgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsuarios.Size = new Size(570, 285);
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
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewCellStyle18.Padding = new Padding(0, 0, 3, 0);
            colVolume.DefaultCellStyle = dataGridViewCellStyle18;
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
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.Padding = new Padding(3, 0, 0, 0);
            colDescricao.DefaultCellStyle = dataGridViewCellStyle19;
            colDescricao.HeaderText = "Descricao";
            colDescricao.MinimumWidth = 300;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            // 
            // colAltura
            // 
            colAltura.DataPropertyName = "Altura";
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            dataGridViewCellStyle20.Padding = new Padding(0, 0, 3, 0);
            colAltura.DefaultCellStyle = dataGridViewCellStyle20;
            colAltura.HeaderText = "Altura";
            colAltura.MinimumWidth = 100;
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            colAltura.Visible = false;
            // 
            // colLargura
            // 
            colLargura.DataPropertyName = "Largura";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.Padding = new Padding(0, 0, 3, 0);
            colLargura.DefaultCellStyle = dataGridViewCellStyle21;
            colLargura.HeaderText = "Largura";
            colLargura.MinimumWidth = 100;
            colLargura.Name = "colLargura";
            colLargura.ReadOnly = true;
            colLargura.Visible = false;
            // 
            // colComprimento
            // 
            colComprimento.DataPropertyName = "Comprimento";
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = null;
            dataGridViewCellStyle22.Padding = new Padding(0, 0, 3, 0);
            colComprimento.DefaultCellStyle = dataGridViewCellStyle22;
            colComprimento.HeaderText = "Comprimento";
            colComprimento.MinimumWidth = 100;
            colComprimento.Name = "colComprimento";
            colComprimento.ReadOnly = true;
            colComprimento.Visible = false;
            // 
            // colFK_Formato
            // 
            colFK_Formato.DataPropertyName = "FK_Formato";
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.Padding = new Padding(3, 0, 0, 0);
            colFK_Formato.DefaultCellStyle = dataGridViewCellStyle23;
            colFK_Formato.HeaderText = "Formato";
            colFK_Formato.MinimumWidth = 120;
            colFK_Formato.Name = "colFK_Formato";
            colFK_Formato.ReadOnly = true;
            colFK_Formato.Width = 120;
            // 
            // colFK_Imagem
            // 
            colFK_Imagem.DataPropertyName = "FK_Imagem";
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.Padding = new Padding(3, 0, 0, 0);
            colFK_Imagem.DefaultCellStyle = dataGridViewCellStyle24;
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
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.Padding = new Padding(3, 0, 0, 0);
            colFK_Categoria.DefaultCellStyle = dataGridViewCellStyle25;
            colFK_Categoria.HeaderText = "Categoria";
            colFK_Categoria.MinimumWidth = 120;
            colFK_Categoria.Name = "colFK_Categoria";
            colFK_Categoria.ReadOnly = true;
            colFK_Categoria.Width = 120;
            // 
            // colFK_Marca
            // 
            colFK_Marca.DataPropertyName = "FK_Marca";
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.Padding = new Padding(3, 0, 0, 0);
            colFK_Marca.DefaultCellStyle = dataGridViewCellStyle26;
            colFK_Marca.HeaderText = "Marca";
            colFK_Marca.MinimumWidth = 120;
            colFK_Marca.Name = "colFK_Marca";
            colFK_Marca.ReadOnly = true;
            colFK_Marca.Width = 120;
            // 
            // colFK_Embalagem
            // 
            colFK_Embalagem.DataPropertyName = "FK_Embalagem";
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.Padding = new Padding(3, 0, 0, 0);
            colFK_Embalagem.DefaultCellStyle = dataGridViewCellStyle27;
            colFK_Embalagem.HeaderText = "Embalagem";
            colFK_Embalagem.MinimumWidth = 120;
            colFK_Embalagem.Name = "colFK_Embalagem";
            colFK_Embalagem.ReadOnly = true;
            colFK_Embalagem.Width = 120;
            // 
            // colFK_UnidadeMedida
            // 
            colFK_UnidadeMedida.DataPropertyName = "FK_UnidadeMedida";
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.Padding = new Padding(3, 0, 0, 0);
            colFK_UnidadeMedida.DefaultCellStyle = dataGridViewCellStyle28;
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
            tblBotoes.Controls.Add(btnCadastrarUsuario, 8, 0);
            tblBotoes.Controls.Add(button1, 4, 0);
            tblBotoes.Controls.Add(button2, 6, 0);
            tblBotoes.Location = new Point(25, 118);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(570, 35);
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
            Controls.Add(tlpComponenteDaPesquisa);
            Controls.Add(tblBotoes);
            Controls.Add(dtgUsuarios);
            Margin = new Padding(15);
            MinimumSize = new Size(623, 468);
            Name = "UCUsuario";
            Padding = new Padding(15);
            Size = new Size(623, 468);
            Load += UCProdutos_Load;
            ParentChanged += UCProdutos_ParentChanged;
            tlpComponenteDaPesquisa.ResumeLayout(false);
            tlpComponentesRow1.ResumeLayout(false);
            tlpComponentesRow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            tblBotoes.ResumeLayout(false);
            tlpComponentesRow0.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cboCargo;
        private ComboBox cboSetor;
        private Button btnPesquisar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnCadastrarUsuario;
        private DataGridView dtgUsuarios;
        private TableLayoutPanel tblBotoes;
        private TableLayoutPanel tlpComponentesRow1;
        private Label lblCargo;
        private Label lblSetor;
        private Label lblNomeUsuario;
        private TableLayoutPanel tlpComponenteDaPesquisa;
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
        private TextBox txtNome;
    }
}
