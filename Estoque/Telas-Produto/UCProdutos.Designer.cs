namespace Estoque.Telas_Produto
{
    partial class UCProduto
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
            tlpComponenteDaPesquisa = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDescricaoProduto = new Label();
            txtDescricaoProduto = new TextBox();
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            tlpComponentesRow1 = new TableLayoutPanel();
            cboFormato = new ComboBox();
            lblFormato = new Label();
            lblMarca = new Label();
            cboMarca = new ComboBox();
            lblEmbalagem = new Label();
            lblCategoria = new Label();
            cboEmbalagem = new ComboBox();
            cboCategoria = new ComboBox();
            btnPesquisar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dtgProdutos = new DataGridView();
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
            tableLayoutPanel1.SuspendLayout();
            tlpComponentesRow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
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
            tlpComponenteDaPesquisa.Controls.Add(tableLayoutPanel1, 0, 0);
            tlpComponenteDaPesquisa.Controls.Add(tlpComponentesRow1, 0, 2);
            tlpComponenteDaPesquisa.Location = new Point(25, 26);
            tlpComponenteDaPesquisa.Margin = new Padding(5);
            tlpComponenteDaPesquisa.Name = "tlpComponenteDaPesquisa";
            tlpComponenteDaPesquisa.Padding = new Padding(5);
            tlpComponenteDaPesquisa.RowCount = 4;
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponenteDaPesquisa.Size = new Size(570, 156);
            tlpComponenteDaPesquisa.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6314F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.3686F));
            tableLayoutPanel1.Controls.Add(lblDescricaoProduto, 2, 0);
            tableLayoutPanel1.Controls.Add(txtDescricaoProduto, 2, 1);
            tableLayoutPanel1.Controls.Add(lblNomeProduto, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNomeProduto, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(14, 14);
            tableLayoutPanel1.Margin = new Padding(9, 9, 9, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(542, 54);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.Dock = DockStyle.Fill;
            lblDescricaoProduto.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricaoProduto.ForeColor = SystemColors.ControlLightLight;
            lblDescricaoProduto.Location = new Point(234, 0);
            lblDescricaoProduto.Margin = new Padding(0);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(308, 20);
            lblDescricaoProduto.TabIndex = 19;
            lblDescricaoProduto.Text = "Descrição do Produto:";
            lblDescricaoProduto.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.BorderStyle = BorderStyle.FixedSingle;
            txtDescricaoProduto.Dock = DockStyle.Fill;
            txtDescricaoProduto.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricaoProduto.Location = new Point(237, 23);
            txtDescricaoProduto.MaxLength = 120;
            txtDescricaoProduto.Name = "txtDescricaoProduto";
            txtDescricaoProduto.Size = new Size(302, 27);
            txtDescricaoProduto.TabIndex = 18;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.Dock = DockStyle.Fill;
            lblNomeProduto.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeProduto.ForeColor = SystemColors.ControlLightLight;
            lblNomeProduto.Location = new Point(0, 0);
            lblNomeProduto.Margin = new Padding(0);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(219, 20);
            lblNomeProduto.TabIndex = 2;
            lblNomeProduto.Text = "Nome do Produto:";
            lblNomeProduto.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProduto.Dock = DockStyle.Fill;
            txtNomeProduto.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeProduto.Location = new Point(3, 23);
            txtNomeProduto.MaxLength = 120;
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(213, 27);
            txtNomeProduto.TabIndex = 2;
            // 
            // tlpComponentesRow1
            // 
            tlpComponentesRow1.ColumnCount = 7;
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.Controls.Add(cboFormato, 6, 1);
            tlpComponentesRow1.Controls.Add(lblFormato, 6, 0);
            tlpComponentesRow1.Controls.Add(lblMarca, 4, 0);
            tlpComponentesRow1.Controls.Add(cboMarca, 4, 1);
            tlpComponentesRow1.Controls.Add(lblEmbalagem, 2, 0);
            tlpComponentesRow1.Controls.Add(lblCategoria, 0, 0);
            tlpComponentesRow1.Controls.Add(cboEmbalagem, 2, 1);
            tlpComponentesRow1.Controls.Add(cboCategoria, 0, 1);
            tlpComponentesRow1.Dock = DockStyle.Fill;
            tlpComponentesRow1.Location = new Point(14, 78);
            tlpComponentesRow1.Margin = new Padding(9, 0, 9, 9);
            tlpComponentesRow1.Name = "tlpComponentesRow1";
            tlpComponentesRow1.RowCount = 2;
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponentesRow1.Size = new Size(542, 54);
            tlpComponentesRow1.TabIndex = 10;
            // 
            // cboFormato
            // 
            cboFormato.Dock = DockStyle.Fill;
            cboFormato.DropDownHeight = 200;
            cboFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormato.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboFormato.FormattingEnabled = true;
            cboFormato.IntegralHeight = false;
            cboFormato.Location = new Point(420, 23);
            cboFormato.MaxDropDownItems = 50;
            cboFormato.Name = "cboFormato";
            cboFormato.Size = new Size(119, 26);
            cboFormato.TabIndex = 12;
            // 
            // lblFormato
            // 
            lblFormato.Dock = DockStyle.Fill;
            lblFormato.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormato.ForeColor = SystemColors.ControlLightLight;
            lblFormato.Location = new Point(417, 0);
            lblFormato.Margin = new Padding(0);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(125, 20);
            lblFormato.TabIndex = 14;
            lblFormato.Text = "Formato:";
            lblFormato.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblMarca
            // 
            lblMarca.Dock = DockStyle.Fill;
            lblMarca.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarca.ForeColor = SystemColors.ControlLightLight;
            lblMarca.Location = new Point(278, 0);
            lblMarca.Margin = new Padding(0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(124, 20);
            lblMarca.TabIndex = 12;
            lblMarca.Text = "Marca:";
            lblMarca.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboMarca
            // 
            cboMarca.Dock = DockStyle.Fill;
            cboMarca.DropDownHeight = 200;
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboMarca.FormattingEnabled = true;
            cboMarca.IntegralHeight = false;
            cboMarca.Location = new Point(281, 23);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(118, 26);
            cboMarca.TabIndex = 10;
            // 
            // lblEmbalagem
            // 
            lblEmbalagem.Dock = DockStyle.Fill;
            lblEmbalagem.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmbalagem.ForeColor = SystemColors.ControlLightLight;
            lblEmbalagem.Location = new Point(139, 0);
            lblEmbalagem.Margin = new Padding(0);
            lblEmbalagem.Name = "lblEmbalagem";
            lblEmbalagem.Size = new Size(124, 20);
            lblEmbalagem.TabIndex = 11;
            lblEmbalagem.Text = "Embalagem:";
            lblEmbalagem.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblCategoria
            // 
            lblCategoria.Dock = DockStyle.Fill;
            lblCategoria.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.ForeColor = SystemColors.ControlLightLight;
            lblCategoria.Location = new Point(0, 0);
            lblCategoria.Margin = new Padding(0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(124, 20);
            lblCategoria.TabIndex = 11;
            lblCategoria.Text = "Categoria:";
            lblCategoria.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboEmbalagem
            // 
            cboEmbalagem.Dock = DockStyle.Fill;
            cboEmbalagem.DropDownHeight = 200;
            cboEmbalagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmbalagem.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboEmbalagem.FormattingEnabled = true;
            cboEmbalagem.IntegralHeight = false;
            cboEmbalagem.Location = new Point(142, 23);
            cboEmbalagem.Name = "cboEmbalagem";
            cboEmbalagem.Size = new Size(118, 26);
            cboEmbalagem.TabIndex = 8;
            // 
            // cboCategoria
            // 
            cboCategoria.Dock = DockStyle.Fill;
            cboCategoria.DropDownHeight = 200;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.IntegralHeight = false;
            cboCategoria.Location = new Point(3, 23);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(118, 26);
            cboCategoria.TabIndex = 4;
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
            // button4
            // 
            button4.Location = new Point(375, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AllowUserToOrderColumns = true;
            dtgProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 241, 241);
            dtgProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgProdutos.BackgroundColor = Color.FromArgb(80, 90, 100);
            dtgProdutos.BorderStyle = BorderStyle.None;
            dtgProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dtgProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 74, 84);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgProdutos.ColumnHeadersHeight = 35;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgProdutos.Columns.AddRange(new DataGridViewColumn[] { colPK_Produto, colNome, colVolume, colDescricao, colAltura, colLargura, colComprimento, colFK_Formato, colFK_Imagem, colFK_Categoria, colFK_Marca, colFK_Embalagem, colFK_UnidadeMedida });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle14.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dtgProdutos.DefaultCellStyle = dataGridViewCellStyle14;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.White;
            dtgProdutos.Location = new Point(25, 239);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dtgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dtgProdutos.RowHeadersVisible = false;
            dtgProdutos.RowHeadersWidth = 55;
            dtgProdutos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgProdutos.RowTemplate.Height = 25;
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(570, 201);
            dtgProdutos.TabIndex = 6;
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
            tblBotoes.Location = new Point(25, 192);
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
            // UCProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(tlpComponenteDaPesquisa);
            Controls.Add(tblBotoes);
            Controls.Add(dtgProdutos);
            Margin = new Padding(15);
            MinimumSize = new Size(623, 468);
            Name = "UCProduto";
            Padding = new Padding(15);
            Size = new Size(623, 468);
            Load += UCProdutos_Load;
            ParentChanged += UCProdutos_ParentChanged;
            tlpComponenteDaPesquisa.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tlpComponentesRow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            tblBotoes.ResumeLayout(false);
            tlpComponentesRow0.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cboCategoria;
        private ComboBox cboMarca;
        private ComboBox cboEmbalagem;
        private Button btnPesquisar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dtgProdutos;
        private TableLayoutPanel tblBotoes;
        private ComboBox cboFormato;
        private TableLayoutPanel tlpComponentesRow1;
        private Label lblFormato;
        private Label lblMarca;
        private Label lblEmbalagem;
        private Label lblCategoria;
        private TableLayoutPanel tlpComponenteDaPesquisa;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDescricaoProduto;
        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private TableLayoutPanel tlpComponentesRow0;
        private Label lblDescricao;
        private TextBox txtDescricaoProduto;
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
    }
}
