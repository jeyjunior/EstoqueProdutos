namespace Estoque.Telas_Produto
{
    partial class UCProdutos
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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
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
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tlpComponenteDaPesquisa = new TableLayoutPanel();
            tlpComponentesRow1 = new TableLayoutPanel();
            cboFormato = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            cboMarca = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            cboEmbalagem = new ComboBox();
            cboCategoria = new ComboBox();
            tlpComponentesRow0 = new TableLayoutPanel();
            lblDescricao = new Label();
            txtDescricaoProduto = new TextBox();
            chkDatas = new CheckBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtNomeProduto = new TextBox();
            dtpFabricacao = new DateTimePicker();
            dtpValidade = new DateTimePicker();
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
            colDataFabricacao = new DataGridViewTextBoxColumn();
            colDataValidade = new DataGridViewTextBoxColumn();
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
            panel1.SuspendLayout();
            tlpComponenteDaPesquisa.SuspendLayout();
            tlpComponentesRow1.SuspendLayout();
            tlpComponentesRow0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            tblBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(60, 75, 85);
            panel1.Controls.Add(tlpComponenteDaPesquisa);
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 120);
            panel1.TabIndex = 0;
            // 
            // tlpComponenteDaPesquisa
            // 
            tlpComponenteDaPesquisa.ColumnCount = 1;
            tlpComponenteDaPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpComponenteDaPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpComponenteDaPesquisa.Controls.Add(tlpComponentesRow1, 0, 1);
            tlpComponenteDaPesquisa.Controls.Add(tlpComponentesRow0, 0, 0);
            tlpComponenteDaPesquisa.Dock = DockStyle.Fill;
            tlpComponenteDaPesquisa.Location = new Point(0, 0);
            tlpComponenteDaPesquisa.Name = "tlpComponenteDaPesquisa";
            tlpComponenteDaPesquisa.RowCount = 2;
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpComponenteDaPesquisa.Size = new Size(627, 120);
            tlpComponenteDaPesquisa.TabIndex = 0;
            // 
            // tlpComponentesRow1
            // 
            tlpComponentesRow1.ColumnCount = 7;
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.Controls.Add(cboFormato, 6, 1);
            tlpComponentesRow1.Controls.Add(label7, 6, 0);
            tlpComponentesRow1.Controls.Add(label6, 4, 0);
            tlpComponentesRow1.Controls.Add(cboMarca, 4, 1);
            tlpComponentesRow1.Controls.Add(label5, 2, 0);
            tlpComponentesRow1.Controls.Add(label4, 0, 0);
            tlpComponentesRow1.Controls.Add(cboEmbalagem, 2, 1);
            tlpComponentesRow1.Controls.Add(cboCategoria, 0, 1);
            tlpComponentesRow1.Dock = DockStyle.Fill;
            tlpComponentesRow1.Location = new Point(9, 60);
            tlpComponentesRow1.Margin = new Padding(9, 0, 9, 9);
            tlpComponentesRow1.Name = "tlpComponentesRow1";
            tlpComponentesRow1.RowCount = 2;
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponentesRow1.Size = new Size(609, 51);
            tlpComponentesRow1.TabIndex = 10;
            // 
            // cboFormato
            // 
            cboFormato.Dock = DockStyle.Fill;
            cboFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormato.FormattingEnabled = true;
            cboFormato.Location = new Point(462, 23);
            cboFormato.Name = "cboFormato";
            cboFormato.Size = new Size(144, 23);
            cboFormato.TabIndex = 12;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(459, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(150, 20);
            label7.TabIndex = 14;
            label7.Text = "Formato:";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(306, 0);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 12;
            label6.Text = "Marca:";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboMarca
            // 
            cboMarca.Dock = DockStyle.Fill;
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(309, 23);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(142, 23);
            cboMarca.TabIndex = 10;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(153, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 11;
            label5.Text = "Embalagem:";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 11;
            label4.Text = "Categoria:";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboEmbalagem
            // 
            cboEmbalagem.Dock = DockStyle.Fill;
            cboEmbalagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmbalagem.FormattingEnabled = true;
            cboEmbalagem.Location = new Point(156, 23);
            cboEmbalagem.Name = "cboEmbalagem";
            cboEmbalagem.Size = new Size(142, 23);
            cboEmbalagem.TabIndex = 8;
            // 
            // cboCategoria
            // 
            cboCategoria.Dock = DockStyle.Fill;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(3, 23);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(142, 23);
            cboCategoria.TabIndex = 4;
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
            tlpComponentesRow0.Controls.Add(txtDescricaoProduto, 2, 1);
            tlpComponentesRow0.Controls.Add(chkDatas, 4, 1);
            tlpComponentesRow0.Controls.Add(label3, 7, 0);
            tlpComponentesRow0.Controls.Add(label1, 0, 0);
            tlpComponentesRow0.Controls.Add(label2, 5, 0);
            tlpComponentesRow0.Controls.Add(txtNomeProduto, 0, 1);
            tlpComponentesRow0.Controls.Add(dtpFabricacao, 5, 1);
            tlpComponentesRow0.Controls.Add(dtpValidade, 7, 1);
            tlpComponentesRow0.Dock = DockStyle.Fill;
            tlpComponentesRow0.Location = new Point(9, 9);
            tlpComponentesRow0.Margin = new Padding(9, 9, 9, 0);
            tlpComponentesRow0.Name = "tlpComponentesRow0";
            tlpComponentesRow0.RowCount = 2;
            tlpComponentesRow0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponentesRow0.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponentesRow0.Size = new Size(609, 51);
            tlpComponentesRow0.TabIndex = 9;
            // 
            // lblDescricao
            // 
            lblDescricao.Dock = DockStyle.Fill;
            lblDescricao.ForeColor = SystemColors.ControlLightLight;
            lblDescricao.Location = new Point(148, 0);
            lblDescricao.Margin = new Padding(0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(200, 20);
            lblDescricao.TabIndex = 19;
            lblDescricao.Text = "Descrição do Produto:";
            lblDescricao.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.BorderStyle = BorderStyle.FixedSingle;
            txtDescricaoProduto.Dock = DockStyle.Fill;
            txtDescricaoProduto.Location = new Point(151, 23);
            txtDescricaoProduto.MaxLength = 120;
            txtDescricaoProduto.Name = "txtDescricaoProduto";
            txtDescricaoProduto.Size = new Size(194, 23);
            txtDescricaoProduto.TabIndex = 18;
            // 
            // chkDatas
            // 
            chkDatas.AutoSize = true;
            chkDatas.CheckAlign = ContentAlignment.MiddleRight;
            chkDatas.Dock = DockStyle.Fill;
            chkDatas.Location = new Point(353, 20);
            chkDatas.Margin = new Padding(0, 0, 5, 0);
            chkDatas.Name = "chkDatas";
            chkDatas.Size = new Size(30, 31);
            chkDatas.TabIndex = 14;
            chkDatas.TextAlign = ContentAlignment.MiddleCenter;
            chkDatas.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkDatas.UseVisualStyleBackColor = true;
            chkDatas.CheckedChanged += chkDatas_CheckedChanged;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(506, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 10;
            label3.Text = "Validade:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome do Produto:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(388, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 17;
            label2.Text = "Fabricação:";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProduto.Dock = DockStyle.Fill;
            txtNomeProduto.Location = new Point(3, 23);
            txtNomeProduto.MaxLength = 120;
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(137, 23);
            txtNomeProduto.TabIndex = 2;
            // 
            // dtpFabricacao
            // 
            dtpFabricacao.Dock = DockStyle.Fill;
            dtpFabricacao.Format = DateTimePickerFormat.Short;
            dtpFabricacao.Location = new Point(388, 20);
            dtpFabricacao.Margin = new Padding(0);
            dtpFabricacao.Name = "dtpFabricacao";
            dtpFabricacao.Size = new Size(113, 23);
            dtpFabricacao.TabIndex = 3;
            dtpFabricacao.Value = new DateTime(2023, 8, 19, 12, 36, 18, 0);
            dtpFabricacao.ValueChanged += dtpFabricacao_ValueChanged;
            // 
            // dtpValidade
            // 
            dtpValidade.Dock = DockStyle.Fill;
            dtpValidade.Format = DateTimePickerFormat.Short;
            dtpValidade.Location = new Point(506, 20);
            dtpValidade.Margin = new Padding(0);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(103, 23);
            dtpValidade.TabIndex = 4;
            dtpValidade.Value = new DateTime(2023, 8, 19, 12, 36, 18, 0);
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
            // dtgProdutos
            // 
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
            dtgProdutos.Columns.AddRange(new DataGridViewColumn[] { colPK_Produto, colNome, colVolume, colDescricao, colDataFabricacao, colDataValidade, colAltura, colLargura, colComprimento, colFK_Formato, colFK_Imagem, colFK_Categoria, colFK_Marca, colFK_Embalagem, colFK_UnidadeMedida });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dtgProdutos.DefaultCellStyle = dataGridViewCellStyle16;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.White;
            dtgProdutos.Location = new Point(10, 185);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dtgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dtgProdutos.RowHeadersVisible = false;
            dtgProdutos.RowHeadersWidth = 55;
            dtgProdutos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgProdutos.RowTemplate.Height = 19;
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(627, 282);
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
            colDescricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new Padding(3, 0, 0, 0);
            colDescricao.DefaultCellStyle = dataGridViewCellStyle4;
            colDescricao.HeaderText = "Descricao";
            colDescricao.MinimumWidth = 250;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            colDescricao.Width = 250;
            // 
            // colDataFabricacao
            // 
            colDataFabricacao.DataPropertyName = "DataFabricacao";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            colDataFabricacao.DefaultCellStyle = dataGridViewCellStyle5;
            colDataFabricacao.HeaderText = "Fabricacao";
            colDataFabricacao.MinimumWidth = 90;
            colDataFabricacao.Name = "colDataFabricacao";
            colDataFabricacao.ReadOnly = true;
            colDataFabricacao.Width = 90;
            // 
            // colDataValidade
            // 
            colDataValidade.DataPropertyName = "DataValidade";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            colDataValidade.DefaultCellStyle = dataGridViewCellStyle6;
            colDataValidade.HeaderText = "Validade";
            colDataValidade.MinimumWidth = 90;
            colDataValidade.Name = "colDataValidade";
            colDataValidade.ReadOnly = true;
            colDataValidade.Width = 90;
            // 
            // colAltura
            // 
            colAltura.DataPropertyName = "Altura";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new Padding(0, 0, 3, 0);
            colAltura.DefaultCellStyle = dataGridViewCellStyle7;
            colAltura.HeaderText = "Altura";
            colAltura.MinimumWidth = 100;
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            colAltura.Visible = false;
            // 
            // colLargura
            // 
            colLargura.DataPropertyName = "Largura";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.Padding = new Padding(0, 0, 3, 0);
            colLargura.DefaultCellStyle = dataGridViewCellStyle8;
            colLargura.HeaderText = "Largura";
            colLargura.MinimumWidth = 100;
            colLargura.Name = "colLargura";
            colLargura.ReadOnly = true;
            colLargura.Visible = false;
            // 
            // colComprimento
            // 
            colComprimento.DataPropertyName = "Comprimento";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.Padding = new Padding(0, 0, 3, 0);
            colComprimento.DefaultCellStyle = dataGridViewCellStyle9;
            colComprimento.HeaderText = "Comprimento";
            colComprimento.MinimumWidth = 100;
            colComprimento.Name = "colComprimento";
            colComprimento.ReadOnly = true;
            colComprimento.Visible = false;
            // 
            // colFK_Formato
            // 
            colFK_Formato.DataPropertyName = "FK_Formato";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Padding = new Padding(3, 0, 0, 0);
            colFK_Formato.DefaultCellStyle = dataGridViewCellStyle10;
            colFK_Formato.HeaderText = "Formato";
            colFK_Formato.MinimumWidth = 120;
            colFK_Formato.Name = "colFK_Formato";
            colFK_Formato.ReadOnly = true;
            colFK_Formato.Width = 120;
            // 
            // colFK_Imagem
            // 
            colFK_Imagem.DataPropertyName = "FK_Imagem";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Padding = new Padding(3, 0, 0, 0);
            colFK_Imagem.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Padding = new Padding(3, 0, 0, 0);
            colFK_Categoria.DefaultCellStyle = dataGridViewCellStyle12;
            colFK_Categoria.HeaderText = "Categoria";
            colFK_Categoria.MinimumWidth = 120;
            colFK_Categoria.Name = "colFK_Categoria";
            colFK_Categoria.ReadOnly = true;
            colFK_Categoria.Width = 120;
            // 
            // colFK_Marca
            // 
            colFK_Marca.DataPropertyName = "FK_Marca";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Padding = new Padding(3, 0, 0, 0);
            colFK_Marca.DefaultCellStyle = dataGridViewCellStyle13;
            colFK_Marca.HeaderText = "Marca";
            colFK_Marca.MinimumWidth = 120;
            colFK_Marca.Name = "colFK_Marca";
            colFK_Marca.ReadOnly = true;
            colFK_Marca.Width = 120;
            // 
            // colFK_Embalagem
            // 
            colFK_Embalagem.DataPropertyName = "FK_Embalagem";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Padding = new Padding(3, 0, 0, 0);
            colFK_Embalagem.DefaultCellStyle = dataGridViewCellStyle14;
            colFK_Embalagem.HeaderText = "Embalagem";
            colFK_Embalagem.MinimumWidth = 120;
            colFK_Embalagem.Name = "colFK_Embalagem";
            colFK_Embalagem.ReadOnly = true;
            colFK_Embalagem.Width = 120;
            // 
            // colFK_UnidadeMedida
            // 
            colFK_UnidadeMedida.DataPropertyName = "FK_UnidadeMedida";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Padding = new Padding(3, 0, 0, 0);
            colFK_UnidadeMedida.DefaultCellStyle = dataGridViewCellStyle15;
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
            tblBotoes.Location = new Point(10, 140);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(627, 35);
            tblBotoes.TabIndex = 8;
            // 
            // UCProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(panel1);
            Controls.Add(tblBotoes);
            Controls.Add(dtgProdutos);
            MinimumSize = new Size(650, 480);
            Name = "UCProdutos";
            Size = new Size(650, 480);
            Load += UCProdutos_Load;
            panel1.ResumeLayout(false);
            tlpComponenteDaPesquisa.ResumeLayout(false);
            tlpComponentesRow1.ResumeLayout(false);
            tlpComponentesRow0.ResumeLayout(false);
            tlpComponentesRow0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            tblBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNomeProduto;
        private DateTimePicker dtpFabricacao;
        private ComboBox cboCategoria;
        private DateTimePicker dtpValidade;
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
        private CheckBox chkDatas;
        private DataGridViewTextBoxColumn colPK_Produto;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colVolume;
        private DataGridViewTextBoxColumn colDescricao;
        private DataGridViewTextBoxColumn colDataFabricacao;
        private DataGridViewTextBoxColumn colDataValidade;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colLargura;
        private DataGridViewTextBoxColumn colComprimento;
        private DataGridViewTextBoxColumn colFK_Formato;
        private DataGridViewTextBoxColumn colFK_Imagem;
        private DataGridViewTextBoxColumn colFK_Categoria;
        private DataGridViewTextBoxColumn colFK_Marca;
        private DataGridViewTextBoxColumn colFK_Embalagem;
        private DataGridViewTextBoxColumn colFK_UnidadeMedida;
        private TableLayoutPanel tlpComponentesRow0;
        private Label label1;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tlpComponentesRow1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TableLayoutPanel tlpComponenteDaPesquisa;
        private Label lblDescricao;
        private TextBox txtDescricaoProduto;
    }
}
