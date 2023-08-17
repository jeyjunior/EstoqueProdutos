namespace EstoqueProdutos.Telas_Produto
{
    partial class FrmProdutos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dtgProdutos = new DataGridView();
            btnCadastrar = new Button();
            button2 = new Button();
            button3 = new Button();
            btnPesquisar = new Button();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            txtNome = new TextBox();
            lblNome = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            SuspendLayout();
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AllowUserToOrderColumns = true;
            dtgProdutos.AllowUserToResizeRows = false;
            dtgProdutos.BackgroundColor = SystemColors.ActiveCaption;
            dtgProdutos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Verdana", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgProdutos.ColumnHeadersHeight = 40;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgProdutos.Columns.AddRange(new DataGridViewColumn[] { colPK_Produto, colNome, colVolume, colDescricao, colDataFabricacao, colDataValidade, colAltura, colLargura, colComprimento, colFK_Formato, colFK_Imagem, colFK_Categoria, colFK_Marca, colFK_Embalagem, colFK_UnidadeMedida });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            dtgProdutos.GridColor = Color.WhiteSmoke;
            dtgProdutos.Location = new Point(10, 75);
            dtgProdutos.Margin = new Padding(3, 2, 3, 2);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgProdutos.RowHeadersVisible = false;
            dtgProdutos.RowHeadersWidth = 51;
            dtgProdutos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtgProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgProdutos.RowTemplate.Height = 29;
            dtgProdutos.Size = new Size(1158, 436);
            dtgProdutos.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(10, 12);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(57, 49);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(73, 12);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(57, 49);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(135, 12);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(57, 49);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(1111, 12);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(57, 49);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(876, 18);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FlatStyle = FlatStyle.Flat;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(876, 36);
            cboCategoria.MaxDropDownItems = 100;
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(216, 23);
            cboCategoria.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(584, 36);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(286, 23);
            txtNome.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(584, 18);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(106, 15);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome do produto:";
            // 
            // colPK_Produto
            // 
            colPK_Produto.DataPropertyName = "PK_Produto";
            colPK_Produto.HeaderText = "PK_Produto";
            colPK_Produto.MinimumWidth = 100;
            colPK_Produto.Name = "colPK_Produto";
            colPK_Produto.Visible = false;
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNome.DataPropertyName = "Nome";
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 120;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colVolume
            // 
            colVolume.DataPropertyName = "Volume";
            colVolume.HeaderText = "Volume";
            colVolume.MinimumWidth = 100;
            colVolume.Name = "colVolume";
            colVolume.ReadOnly = true;
            // 
            // colDescricao
            // 
            colDescricao.DataPropertyName = "Descricao";
            colDescricao.HeaderText = "Descricao";
            colDescricao.MinimumWidth = 150;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            colDescricao.Width = 150;
            // 
            // colDataFabricacao
            // 
            colDataFabricacao.DataPropertyName = "DataFabricacao";
            colDataFabricacao.HeaderText = "Fabricacao";
            colDataFabricacao.MinimumWidth = 100;
            colDataFabricacao.Name = "colDataFabricacao";
            colDataFabricacao.ReadOnly = true;
            // 
            // colDataValidade
            // 
            colDataValidade.DataPropertyName = "DataValidade ";
            colDataValidade.HeaderText = "Validade ";
            colDataValidade.MinimumWidth = 100;
            colDataValidade.Name = "colDataValidade";
            colDataValidade.ReadOnly = true;
            // 
            // colAltura
            // 
            colAltura.DataPropertyName = "Altura";
            colAltura.HeaderText = "Altura";
            colAltura.MinimumWidth = 100;
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            // 
            // colLargura
            // 
            colLargura.DataPropertyName = "Largura";
            colLargura.HeaderText = "Largura";
            colLargura.MinimumWidth = 100;
            colLargura.Name = "colLargura";
            colLargura.ReadOnly = true;
            // 
            // colComprimento
            // 
            colComprimento.DataPropertyName = "Comprimento";
            colComprimento.HeaderText = "Comprimento";
            colComprimento.MinimumWidth = 100;
            colComprimento.Name = "colComprimento";
            colComprimento.ReadOnly = true;
            // 
            // colFK_Formato
            // 
            colFK_Formato.DataPropertyName = "FK_Formato";
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
            colFK_Imagem.MinimumWidth = 120;
            colFK_Imagem.Name = "colFK_Imagem";
            colFK_Imagem.ReadOnly = true;
            colFK_Imagem.Width = 120;
            // 
            // colFK_Categoria
            // 
            colFK_Categoria.DataPropertyName = "FK_Categoria";
            colFK_Categoria.HeaderText = "Categoria";
            colFK_Categoria.MinimumWidth = 120;
            colFK_Categoria.Name = "colFK_Categoria";
            colFK_Categoria.ReadOnly = true;
            colFK_Categoria.Width = 120;
            // 
            // colFK_Marca
            // 
            colFK_Marca.DataPropertyName = "FK_Marca";
            colFK_Marca.HeaderText = "Marca";
            colFK_Marca.MinimumWidth = 120;
            colFK_Marca.Name = "colFK_Marca";
            colFK_Marca.ReadOnly = true;
            colFK_Marca.Width = 120;
            // 
            // colFK_Embalagem
            // 
            colFK_Embalagem.DataPropertyName = "FK_Embalagem";
            colFK_Embalagem.HeaderText = "Embalagem";
            colFK_Embalagem.MinimumWidth = 120;
            colFK_Embalagem.Name = "colFK_Embalagem";
            colFK_Embalagem.ReadOnly = true;
            colFK_Embalagem.Width = 120;
            // 
            // colFK_UnidadeMedida
            // 
            colFK_UnidadeMedida.DataPropertyName = "FK_UnidadeMedida";
            colFK_UnidadeMedida.HeaderText = "UnidadeMedida";
            colFK_UnidadeMedida.MinimumWidth = 120;
            colFK_UnidadeMedida.Name = "colFK_UnidadeMedida";
            colFK_UnidadeMedida.ReadOnly = true;
            colFK_UnidadeMedida.Width = 120;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 541);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(cboCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(btnPesquisar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCadastrar);
            Controls.Add(dtgProdutos);
            Name = "FrmProdutos";
            Text = "Produtos";
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgProdutos;
        private Button btnCadastrar;
        private Button button2;
        private Button button3;
        private Button btnPesquisar;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private TextBox txtNome;
        private Label lblNome;
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
    }
}