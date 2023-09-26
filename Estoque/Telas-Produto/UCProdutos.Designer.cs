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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
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
            tlpCentral = new TableLayoutPanel();
            tlpComboBoxs = new TableLayoutPanel();
            cboCategoria = new ComboBox();
            lblCategoria = new Label();
            lblEmbalagem = new Label();
            lblMarca = new Label();
            lblFormato = new Label();
            cboEmbalagem = new ComboBox();
            cboMarca = new ComboBox();
            cboFormato = new ComboBox();
            dtgProdutos = new DataGridView();
            tlpBotoes = new TableLayoutPanel();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnLimpar = new Button();
            tlpTextBox = new TableLayoutPanel();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            txtDescricaoProduto = new TextBox();
            lblDescricaoProduto = new Label();
            tblPrincipal = new TableLayoutPanel();
            tblBotoes = new TableLayoutPanel();
            tblSetor = new TableLayoutPanel();
            txtNome = new TextBox();
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
            tlpCentral.SuspendLayout();
            tlpComboBoxs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            tlpBotoes.SuspendLayout();
            tlpTextBox.SuspendLayout();
            tblPrincipal.SuspendLayout();
            tblSetor.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCentral
            // 
            tlpCentral.ColumnCount = 1;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.Controls.Add(tlpComboBoxs, 0, 1);
            tlpCentral.Controls.Add(dtgProdutos, 0, 5);
            tlpCentral.Controls.Add(tlpBotoes, 0, 3);
            tlpCentral.Controls.Add(tlpTextBox, 0, 0);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(15, 15);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 6;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.Size = new Size(530, 530);
            tlpCentral.TabIndex = 0;
            // 
            // tlpComboBoxs
            // 
            tlpComboBoxs.BackColor = Color.FromArgb(60, 75, 85);
            tlpComboBoxs.ColumnCount = 7;
            tlpComboBoxs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComboBoxs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComboBoxs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComboBoxs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComboBoxs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComboBoxs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComboBoxs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComboBoxs.Controls.Add(cboCategoria, 0, 1);
            tlpComboBoxs.Controls.Add(lblCategoria, 0, 0);
            tlpComboBoxs.Controls.Add(lblEmbalagem, 2, 0);
            tlpComboBoxs.Controls.Add(lblMarca, 4, 0);
            tlpComboBoxs.Controls.Add(lblFormato, 6, 0);
            tlpComboBoxs.Controls.Add(cboEmbalagem, 2, 1);
            tlpComboBoxs.Controls.Add(cboMarca, 4, 1);
            tlpComboBoxs.Controls.Add(cboFormato, 6, 1);
            tlpComboBoxs.Location = new Point(0, 80);
            tlpComboBoxs.Margin = new Padding(0);
            tlpComboBoxs.Name = "tlpComboBoxs";
            tlpComboBoxs.Padding = new Padding(15, 0, 15, 0);
            tlpComboBoxs.RowCount = 2;
            tlpComboBoxs.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpComboBoxs.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpComboBoxs.Size = new Size(530, 80);
            tlpComboBoxs.TabIndex = 18;
            // 
            // cboCategoria
            // 
            cboCategoria.Dock = DockStyle.Fill;
            cboCategoria.DropDownHeight = 200;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.IntegralHeight = false;
            cboCategoria.Location = new Point(18, 35);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(107, 26);
            cboCategoria.TabIndex = 27;
            // 
            // lblCategoria
            // 
            lblCategoria.Dock = DockStyle.Fill;
            lblCategoria.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.ForeColor = SystemColors.ControlLightLight;
            lblCategoria.Location = new Point(15, 0);
            lblCategoria.Margin = new Padding(0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(113, 32);
            lblCategoria.TabIndex = 22;
            lblCategoria.Text = "Categoria:";
            lblCategoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmbalagem
            // 
            lblEmbalagem.Dock = DockStyle.Fill;
            lblEmbalagem.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmbalagem.ForeColor = SystemColors.ControlLightLight;
            lblEmbalagem.Location = new Point(143, 0);
            lblEmbalagem.Margin = new Padding(0);
            lblEmbalagem.Name = "lblEmbalagem";
            lblEmbalagem.Size = new Size(113, 32);
            lblEmbalagem.TabIndex = 23;
            lblEmbalagem.Text = "Embalagem:";
            lblEmbalagem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMarca
            // 
            lblMarca.Dock = DockStyle.Fill;
            lblMarca.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarca.ForeColor = SystemColors.ControlLightLight;
            lblMarca.Location = new Point(271, 0);
            lblMarca.Margin = new Padding(0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(113, 32);
            lblMarca.TabIndex = 24;
            lblMarca.Text = "Marca:";
            lblMarca.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFormato
            // 
            lblFormato.Dock = DockStyle.Fill;
            lblFormato.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormato.ForeColor = SystemColors.ControlLightLight;
            lblFormato.Location = new Point(399, 0);
            lblFormato.Margin = new Padding(0);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(116, 32);
            lblFormato.TabIndex = 25;
            lblFormato.Text = "Formato:";
            lblFormato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboEmbalagem
            // 
            cboEmbalagem.Dock = DockStyle.Fill;
            cboEmbalagem.DropDownHeight = 200;
            cboEmbalagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmbalagem.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboEmbalagem.FormattingEnabled = true;
            cboEmbalagem.IntegralHeight = false;
            cboEmbalagem.Location = new Point(146, 35);
            cboEmbalagem.Name = "cboEmbalagem";
            cboEmbalagem.Size = new Size(107, 26);
            cboEmbalagem.TabIndex = 26;
            // 
            // cboMarca
            // 
            cboMarca.Dock = DockStyle.Fill;
            cboMarca.DropDownHeight = 200;
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboMarca.FormattingEnabled = true;
            cboMarca.IntegralHeight = false;
            cboMarca.Location = new Point(274, 35);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(107, 26);
            cboMarca.TabIndex = 28;
            // 
            // cboFormato
            // 
            cboFormato.Dock = DockStyle.Fill;
            cboFormato.DropDownHeight = 200;
            cboFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormato.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboFormato.FormattingEnabled = true;
            cboFormato.IntegralHeight = false;
            cboFormato.Location = new Point(402, 35);
            cboFormato.Name = "cboFormato";
            cboFormato.Size = new Size(110, 26);
            cboFormato.TabIndex = 29;
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AllowUserToOrderColumns = true;
            dtgProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 235, 235);
            dtgProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgProdutos.BackgroundColor = Color.FromArgb(235, 235, 235);
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle13.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(140, 200, 120);
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dtgProdutos.DefaultCellStyle = dataGridViewCellStyle13;
            dtgProdutos.Dock = DockStyle.Fill;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.White;
            dtgProdutos.Location = new Point(0, 225);
            dtgProdutos.Margin = new Padding(0);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dtgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dtgProdutos.RowHeadersVisible = false;
            dtgProdutos.RowHeadersWidth = 55;
            dtgProdutos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgProdutos.RowTemplate.Height = 25;
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(530, 305);
            dtgProdutos.TabIndex = 17;
            // 
            // tlpBotoes
            // 
            tlpBotoes.ColumnCount = 8;
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.Controls.Add(btnPesquisar, 0, 0);
            tlpBotoes.Controls.Add(btnExcluir, 7, 0);
            tlpBotoes.Controls.Add(btnCancelar, 1, 0);
            tlpBotoes.Controls.Add(btnSalvar, 2, 0);
            tlpBotoes.Controls.Add(btnCadastrar, 5, 0);
            tlpBotoes.Controls.Add(btnAlterar, 4, 0);
            tlpBotoes.Controls.Add(btnLimpar, 3, 0);
            tlpBotoes.Dock = DockStyle.Fill;
            tlpBotoes.Location = new Point(0, 175);
            tlpBotoes.Margin = new Padding(0);
            tlpBotoes.Name = "tlpBotoes";
            tlpBotoes.RightToLeft = RightToLeft.Yes;
            tlpBotoes.RowCount = 1;
            tlpBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoes.Size = new Size(530, 35);
            tlpBotoes.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.search_1;
            btnPesquisar.Location = new Point(495, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(35, 35);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.delete_outline_1;
            btnExcluir.Location = new Point(0, 0);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(35, 35);
            btnExcluir.TabIndex = 5;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_outline_1;
            btnCancelar.Location = new Point(460, 0);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(35, 35);
            btnCancelar.TabIndex = 16;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(425, 0);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(35, 35);
            btnSalvar.TabIndex = 15;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = Properties.Resources.new_outline_1;
            btnCadastrar.Location = new Point(320, 0);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(35, 35);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = Properties.Resources.edit_outline_1;
            btnAlterar.Location = new Point(355, 0);
            btnAlterar.Margin = new Padding(0);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(35, 35);
            btnAlterar.TabIndex = 4;
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.erase_outline_1;
            btnLimpar.Location = new Point(390, 0);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(35, 35);
            btnLimpar.TabIndex = 14;
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // tlpTextBox
            // 
            tlpTextBox.BackColor = Color.FromArgb(60, 75, 85);
            tlpTextBox.ColumnCount = 3;
            tlpTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTextBox.Controls.Add(txtNomeProduto, 0, 1);
            tlpTextBox.Controls.Add(lblNomeProduto, 0, 0);
            tlpTextBox.Controls.Add(txtDescricaoProduto, 2, 1);
            tlpTextBox.Controls.Add(lblDescricaoProduto, 2, 0);
            tlpTextBox.Location = new Point(0, 0);
            tlpTextBox.Margin = new Padding(0);
            tlpTextBox.Name = "tlpTextBox";
            tlpTextBox.Padding = new Padding(15, 0, 15, 0);
            tlpTextBox.RowCount = 2;
            tlpTextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpTextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpTextBox.Size = new Size(530, 80);
            tlpTextBox.TabIndex = 15;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProduto.Dock = DockStyle.Fill;
            txtNomeProduto.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeProduto.Location = new Point(18, 35);
            txtNomeProduto.MaxLength = 120;
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(236, 27);
            txtNomeProduto.TabIndex = 22;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.Dock = DockStyle.Fill;
            lblNomeProduto.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeProduto.ForeColor = SystemColors.ControlLightLight;
            lblNomeProduto.Location = new Point(15, 0);
            lblNomeProduto.Margin = new Padding(0);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(242, 32);
            lblNomeProduto.TabIndex = 21;
            lblNomeProduto.Text = "Nome produto:";
            lblNomeProduto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.BorderStyle = BorderStyle.FixedSingle;
            txtDescricaoProduto.Dock = DockStyle.Fill;
            txtDescricaoProduto.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricaoProduto.Location = new Point(275, 35);
            txtDescricaoProduto.MaxLength = 120;
            txtDescricaoProduto.Name = "txtDescricaoProduto";
            txtDescricaoProduto.Size = new Size(237, 27);
            txtDescricaoProduto.TabIndex = 19;
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.Dock = DockStyle.Fill;
            lblDescricaoProduto.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricaoProduto.ForeColor = SystemColors.ControlLightLight;
            lblDescricaoProduto.Location = new Point(272, 0);
            lblDescricaoProduto.Margin = new Padding(0);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(243, 32);
            lblDescricaoProduto.TabIndex = 23;
            lblDescricaoProduto.Text = "Descrição produto:";
            lblDescricaoProduto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblPrincipal
            // 
            tblPrincipal.ColumnCount = 3;
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblPrincipal.Controls.Add(tlpCentral, 1, 1);
            tblPrincipal.Dock = DockStyle.Fill;
            tblPrincipal.Location = new Point(0, 0);
            tblPrincipal.Margin = new Padding(0);
            tblPrincipal.Name = "tblPrincipal";
            tblPrincipal.RowCount = 3;
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblPrincipal.Size = new Size(560, 560);
            tblPrincipal.TabIndex = 1;
            // 
            // tblBotoes
            // 
            tblBotoes.ColumnCount = 6;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.Location = new Point(0, 0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblBotoes.Size = new Size(200, 100);
            tblBotoes.TabIndex = 0;
            // 
            // tblSetor
            // 
            tblSetor.BackColor = Color.FromArgb(60, 75, 85);
            tblSetor.ColumnCount = 7;
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6122952F));
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6123066F));
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6123066F));
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.1630907F));
            tblSetor.Controls.Add(txtNome, 0, 1);
            tblSetor.Location = new Point(0, 0);
            tblSetor.Name = "tblSetor";
            tblSetor.RowCount = 2;
            tblSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblSetor.Size = new Size(200, 100);
            tblSetor.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Dock = DockStyle.Fill;
            txtNome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(3, 23);
            txtNome.MaxLength = 120;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(38, 27);
            txtNome.TabIndex = 19;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
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
            colDescricao.HeaderText = "Descrição";
            colDescricao.MinimumWidth = 300;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            // 
            // colAltura
            // 
            colAltura.DataPropertyName = "Altura";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
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
            colFK_Imagem.HeaderText = "Imagem";
            colFK_Imagem.Name = "colFK_Imagem";
            colFK_Imagem.ReadOnly = true;
            colFK_Imagem.Visible = false;
            // 
            // colFK_Categoria
            // 
            colFK_Categoria.DataPropertyName = "FK_Categoria";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Padding = new Padding(3, 0, 0, 0);
            colFK_Categoria.DefaultCellStyle = dataGridViewCellStyle9;
            colFK_Categoria.HeaderText = "Categoria";
            colFK_Categoria.MinimumWidth = 120;
            colFK_Categoria.Name = "colFK_Categoria";
            colFK_Categoria.ReadOnly = true;
            colFK_Categoria.Width = 120;
            // 
            // colFK_Marca
            // 
            colFK_Marca.DataPropertyName = "FK_Marca";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Padding = new Padding(3, 0, 0, 0);
            colFK_Marca.DefaultCellStyle = dataGridViewCellStyle10;
            colFK_Marca.HeaderText = "Marca";
            colFK_Marca.MinimumWidth = 120;
            colFK_Marca.Name = "colFK_Marca";
            colFK_Marca.ReadOnly = true;
            colFK_Marca.Width = 120;
            // 
            // colFK_Embalagem
            // 
            colFK_Embalagem.DataPropertyName = "FK_Embalagem";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Padding = new Padding(3, 0, 0, 0);
            colFK_Embalagem.DefaultCellStyle = dataGridViewCellStyle11;
            colFK_Embalagem.HeaderText = "Embalagem";
            colFK_Embalagem.MinimumWidth = 120;
            colFK_Embalagem.Name = "colFK_Embalagem";
            colFK_Embalagem.ReadOnly = true;
            colFK_Embalagem.Width = 120;
            // 
            // colFK_UnidadeMedida
            // 
            colFK_UnidadeMedida.DataPropertyName = "FK_UnidadeMedida";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Padding = new Padding(3, 0, 0, 0);
            colFK_UnidadeMedida.DefaultCellStyle = dataGridViewCellStyle12;
            colFK_UnidadeMedida.HeaderText = "UnidadeMedida";
            colFK_UnidadeMedida.MinimumWidth = 100;
            colFK_UnidadeMedida.Name = "colFK_UnidadeMedida";
            colFK_UnidadeMedida.ReadOnly = true;
            colFK_UnidadeMedida.Visible = false;
            // 
            // UCProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(tblPrincipal);
            Name = "UCProdutos";
            Size = new Size(560, 560);
            tlpCentral.ResumeLayout(false);
            tlpComboBoxs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            tlpBotoes.ResumeLayout(false);
            tlpTextBox.ResumeLayout(false);
            tlpTextBox.PerformLayout();
            tblPrincipal.ResumeLayout(false);
            tblSetor.ResumeLayout(false);
            tblSetor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tblPrincipal;
        private TableLayoutPanel tblBotoes;
        private Button btnPesquisar;
        private Button btnLimpar;
        private TableLayoutPanel tlpBotoes;
        private Button button1;
        private Button button2;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnCadastrar;
        private Button btnSalvar;
        private Button btnCancelar;
        private TableLayoutPanel tlpTextBox;
        private TextBox txtDescricaoProduto;
        private Label lblNomeProduto;
        private TableLayoutPanel tblSetor;
        private TextBox txtNome;
        private Label lblSetor;
        private DataGridView dtgProdutos;
        private TextBox txtNomeProduto;
        private Label lblDescricaoProduto;
        private TableLayoutPanel tlpComboBoxs;
        private Label lblCategoria;
        private Label lblEmbalagem;
        private Label lblMarca;
        private Label lblFormato;
        private ComboBox cboCategoria;
        private ComboBox cboEmbalagem;
        private ComboBox cboMarca;
        private ComboBox cboFormato;
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
