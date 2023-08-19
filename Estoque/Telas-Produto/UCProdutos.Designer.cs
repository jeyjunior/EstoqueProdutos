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
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
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
            panel1 = new Panel();
            cboFornecedor = new ComboBox();
            lblFornecedor = new Label();
            cboMarca = new ComboBox();
            lblMarca = new Label();
            cboEmbalagem = new ComboBox();
            lblEmbalagem = new Label();
            cboCategoria = new ComboBox();
            lblCategoria = new Label();
            lblValidade = new Label();
            lblFabricacao = new Label();
            dtpValidade = new DateTimePicker();
            lblNomeDoProduto = new Label();
            dtpFabricacao = new DateTimePicker();
            txtNomeProduto = new TextBox();
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
            progressBar1 = new ProgressBar();
            tblBotoes = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            tblBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(60, 75, 85);
            panel1.Controls.Add(cboFornecedor);
            panel1.Controls.Add(lblFornecedor);
            panel1.Controls.Add(cboMarca);
            panel1.Controls.Add(lblMarca);
            panel1.Controls.Add(cboEmbalagem);
            panel1.Controls.Add(lblEmbalagem);
            panel1.Controls.Add(cboCategoria);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblValidade);
            panel1.Controls.Add(lblFabricacao);
            panel1.Controls.Add(dtpValidade);
            panel1.Controls.Add(lblNomeDoProduto);
            panel1.Controls.Add(dtpFabricacao);
            panel1.Controls.Add(txtNomeProduto);
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 121);
            panel1.TabIndex = 0;
            // 
            // cboFornecedor
            // 
            cboFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Location = new Point(475, 80);
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(145, 23);
            cboFornecedor.TabIndex = 12;
            // 
            // lblFornecedor
            // 
            lblFornecedor.ForeColor = SystemColors.ControlLightLight;
            lblFornecedor.Location = new Point(475, 62);
            lblFornecedor.Margin = new Padding(0);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(145, 15);
            lblFornecedor.TabIndex = 13;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(320, 80);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(145, 23);
            cboMarca.TabIndex = 10;
            // 
            // lblMarca
            // 
            lblMarca.ForeColor = SystemColors.ControlLightLight;
            lblMarca.Location = new Point(320, 62);
            lblMarca.Margin = new Padding(0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(145, 15);
            lblMarca.TabIndex = 11;
            lblMarca.Text = "Marca:";
            // 
            // cboEmbalagem
            // 
            cboEmbalagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmbalagem.FormattingEnabled = true;
            cboEmbalagem.Location = new Point(165, 80);
            cboEmbalagem.Name = "cboEmbalagem";
            cboEmbalagem.Size = new Size(145, 23);
            cboEmbalagem.TabIndex = 8;
            // 
            // lblEmbalagem
            // 
            lblEmbalagem.ForeColor = SystemColors.ControlLightLight;
            lblEmbalagem.Location = new Point(165, 62);
            lblEmbalagem.Margin = new Padding(0);
            lblEmbalagem.Name = "lblEmbalagem";
            lblEmbalagem.Size = new Size(145, 15);
            lblEmbalagem.TabIndex = 9;
            lblEmbalagem.Text = "Embalagem:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(10, 80);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(145, 23);
            cboCategoria.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.ForeColor = SystemColors.ControlLightLight;
            lblCategoria.Location = new Point(10, 62);
            lblCategoria.Margin = new Padding(0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(145, 15);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria:";
            // 
            // lblValidade
            // 
            lblValidade.ForeColor = SystemColors.ControlLightLight;
            lblValidade.Location = new Point(510, 10);
            lblValidade.Margin = new Padding(0);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(110, 15);
            lblValidade.TabIndex = 6;
            lblValidade.Text = "Validade:";
            // 
            // lblFabricacao
            // 
            lblFabricacao.ForeColor = SystemColors.ControlLightLight;
            lblFabricacao.Location = new Point(390, 10);
            lblFabricacao.Margin = new Padding(0);
            lblFabricacao.Name = "lblFabricacao";
            lblFabricacao.Size = new Size(110, 15);
            lblFabricacao.TabIndex = 5;
            lblFabricacao.Text = "Fabricação:";
            // 
            // dtpValidade
            // 
            dtpValidade.Format = DateTimePickerFormat.Short;
            dtpValidade.Location = new Point(510, 28);
            dtpValidade.Margin = new Padding(0);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(110, 23);
            dtpValidade.TabIndex = 4;
            dtpValidade.Value = new DateTime(2023, 8, 19, 12, 36, 18, 0);
            // 
            // lblNomeDoProduto
            // 
            lblNomeDoProduto.ForeColor = SystemColors.ControlLightLight;
            lblNomeDoProduto.Location = new Point(10, 10);
            lblNomeDoProduto.Margin = new Padding(0);
            lblNomeDoProduto.Name = "lblNomeDoProduto";
            lblNomeDoProduto.Size = new Size(148, 15);
            lblNomeDoProduto.TabIndex = 1;
            lblNomeDoProduto.Text = "Nome do Produto:";
            // 
            // dtpFabricacao
            // 
            dtpFabricacao.Format = DateTimePickerFormat.Short;
            dtpFabricacao.Location = new Point(390, 28);
            dtpFabricacao.Margin = new Padding(0);
            dtpFabricacao.Name = "dtpFabricacao";
            dtpFabricacao.Size = new Size(110, 23);
            dtpFabricacao.TabIndex = 3;
            dtpFabricacao.Value = new DateTime(2023, 8, 19, 12, 36, 18, 0);
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProduto.Location = new Point(10, 28);
            txtNomeProduto.MaxLength = 120;
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(370, 23);
            txtNomeProduto.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.search_1;
            btnPesquisar.Location = new Point(936, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(35, 35);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(856, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(816, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(896, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.new_1;
            button4.Location = new Point(776, 0);
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
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dtgProdutos.DefaultCellStyle = dataGridViewCellStyle15;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.FromArgb(80, 90, 100);
            dtgProdutos.Location = new Point(10, 190);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dtgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dtgProdutos.RowHeadersVisible = false;
            dtgProdutos.RowHeadersWidth = 55;
            dtgProdutos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgProdutos.RowTemplate.Height = 19;
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(971, 360);
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
            // 
            // colDescricao
            // 
            colDescricao.DataPropertyName = "Descricao";
            colDescricao.HeaderText = "Descricao";
            colDescricao.MinimumWidth = 100;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            // 
            // colDataFabricacao
            // 
            colDataFabricacao.DataPropertyName = "DataFabricacao";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            colDataFabricacao.DefaultCellStyle = dataGridViewCellStyle4;
            colDataFabricacao.HeaderText = "Fabricacao";
            colDataFabricacao.MinimumWidth = 100;
            colDataFabricacao.Name = "colDataFabricacao";
            colDataFabricacao.ReadOnly = true;
            // 
            // colDataValidade
            // 
            colDataValidade.DataPropertyName = "DataValidade";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            colDataValidade.DefaultCellStyle = dataGridViewCellStyle5;
            colDataValidade.HeaderText = "Validade";
            colDataValidade.MinimumWidth = 100;
            colDataValidade.Name = "colDataValidade";
            colDataValidade.ReadOnly = true;
            // 
            // colAltura
            // 
            colAltura.DataPropertyName = "Altura";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.Padding = new Padding(0, 0, 3, 0);
            colAltura.DefaultCellStyle = dataGridViewCellStyle6;
            colAltura.HeaderText = "Altura";
            colAltura.MinimumWidth = 100;
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            // 
            // colLargura
            // 
            colLargura.DataPropertyName = "Largura";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.Padding = new Padding(0, 0, 3, 0);
            colLargura.DefaultCellStyle = dataGridViewCellStyle7;
            colLargura.HeaderText = "Largura";
            colLargura.MinimumWidth = 100;
            colLargura.Name = "colLargura";
            colLargura.ReadOnly = true;
            // 
            // colComprimento
            // 
            colComprimento.DataPropertyName = "Comprimento";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.Padding = new Padding(0, 0, 3, 0);
            colComprimento.DefaultCellStyle = dataGridViewCellStyle8;
            colComprimento.HeaderText = "Comprimento";
            colComprimento.MinimumWidth = 100;
            colComprimento.Name = "colComprimento";
            colComprimento.ReadOnly = true;
            // 
            // colFK_Formato
            // 
            colFK_Formato.DataPropertyName = "FK_Formato";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Padding = new Padding(3, 0, 0, 0);
            colFK_Formato.DefaultCellStyle = dataGridViewCellStyle9;
            colFK_Formato.HeaderText = "FK_Formato";
            colFK_Formato.MinimumWidth = 100;
            colFK_Formato.Name = "colFK_Formato";
            colFK_Formato.ReadOnly = true;
            // 
            // colFK_Imagem
            // 
            colFK_Imagem.DataPropertyName = "FK_Imagem";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Padding = new Padding(3, 0, 0, 0);
            colFK_Imagem.DefaultCellStyle = dataGridViewCellStyle10;
            colFK_Imagem.HeaderText = "FK_Imagem";
            colFK_Imagem.MinimumWidth = 100;
            colFK_Imagem.Name = "colFK_Imagem";
            colFK_Imagem.ReadOnly = true;
            // 
            // colFK_Categoria
            // 
            colFK_Categoria.DataPropertyName = "FK_Categoria";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Padding = new Padding(3, 0, 0, 0);
            colFK_Categoria.DefaultCellStyle = dataGridViewCellStyle11;
            colFK_Categoria.HeaderText = "FK_Categoria";
            colFK_Categoria.MinimumWidth = 100;
            colFK_Categoria.Name = "colFK_Categoria";
            colFK_Categoria.ReadOnly = true;
            // 
            // colFK_Marca
            // 
            colFK_Marca.DataPropertyName = "FK_Marca";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Padding = new Padding(3, 0, 0, 0);
            colFK_Marca.DefaultCellStyle = dataGridViewCellStyle12;
            colFK_Marca.HeaderText = "FK_Marca";
            colFK_Marca.MinimumWidth = 100;
            colFK_Marca.Name = "colFK_Marca";
            colFK_Marca.ReadOnly = true;
            // 
            // colFK_Embalagem
            // 
            colFK_Embalagem.DataPropertyName = "FK_Embalagem";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Padding = new Padding(3, 0, 0, 0);
            colFK_Embalagem.DefaultCellStyle = dataGridViewCellStyle13;
            colFK_Embalagem.HeaderText = "FK_Embalagem";
            colFK_Embalagem.MinimumWidth = 100;
            colFK_Embalagem.Name = "colFK_Embalagem";
            colFK_Embalagem.ReadOnly = true;
            // 
            // colFK_UnidadeMedida
            // 
            colFK_UnidadeMedida.DataPropertyName = "FK_UnidadeMedida";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Padding = new Padding(3, 0, 0, 0);
            colFK_UnidadeMedida.DefaultCellStyle = dataGridViewCellStyle14;
            colFK_UnidadeMedida.HeaderText = "FK_UnidadeMedida";
            colFK_UnidadeMedida.MinimumWidth = 100;
            colFK_UnidadeMedida.Name = "colFK_UnidadeMedida";
            colFK_UnidadeMedida.ReadOnly = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(10, 505);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(627, 5);
            progressBar1.TabIndex = 7;
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
            tblBotoes.Location = new Point(10, 144);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(971, 35);
            tblBotoes.TabIndex = 8;
            // 
            // UCProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            Controls.Add(tblBotoes);
            Controls.Add(dtgProdutos);
            MinimumSize = new Size(660, 520);
            Name = "UCProdutos";
            Size = new Size(994, 571);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            tblBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNomeDoProduto;
        private TextBox txtNomeProduto;
        private DateTimePicker dtpFabricacao;
        private ComboBox cboCategoria;
        private DateTimePicker dtpValidade;
        private Label lblValidade;
        private Label lblFabricacao;
        private ComboBox cboFornecedor;
        private Label lblFornecedor;
        private ComboBox cboMarca;
        private Label lblMarca;
        private ComboBox cboEmbalagem;
        private Label lblEmbalagem;
        private Label lblCategoria;
        private Button btnPesquisar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dtgProdutos;
        private ProgressBar progressBar1;
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
        private TableLayoutPanel tblBotoes;
    }
}
