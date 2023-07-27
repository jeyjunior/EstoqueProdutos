namespace EstoqueProdutos.Telas_Produtos
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            btnPesquisar = new Button();
            dtgProdutos = new DataGridView();
            colPK_ID = new DataGridViewTextBoxColumn();
            colNOME = new DataGridViewTextBoxColumn();
            colPRECO = new DataGridViewTextBoxColumn();
            colEmbalagem = new DataGridViewTextBoxColumn();
            colVolume = new DataGridViewTextBoxColumn();
            colSigla = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colFornecedor = new DataGridViewTextBoxColumn();
            colDescricao = new DataGridViewTextBoxColumn();
            colFK_Imagem_ID = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            btnCadastrar = new Button();
            pnlTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.Image = Properties.Resources.search;
            btnPesquisar.Location = new Point(1038, 17);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(180, 45);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AllowUserToResizeColumns = false;
            dtgProdutos.AllowUserToResizeRows = false;
            dtgProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgProdutos.BackgroundColor = Color.WhiteSmoke;
            dtgProdutos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgProdutos.ColumnHeadersHeight = 35;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgProdutos.Columns.AddRange(new DataGridViewColumn[] { colPK_ID, colNOME, colPRECO, colEmbalagem, colVolume, colSigla, colCategoria, colFornecedor, colDescricao, colFK_Imagem_ID });
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.WhiteSmoke;
            dtgProdutos.Location = new Point(12, 96);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dtgProdutos.RowHeadersVisible = false;
            dtgProdutos.RowHeadersWidth = 100;
            dtgProdutos.RowTemplate.Height = 29;
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(1238, 533);
            dtgProdutos.TabIndex = 0;
            // 
            // colPK_ID
            // 
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            colPK_ID.DefaultCellStyle = dataGridViewCellStyle2;
            colPK_ID.HeaderText = "PK_ID";
            colPK_ID.MinimumWidth = 6;
            colPK_ID.Name = "colPK_ID";
            colPK_ID.ReadOnly = true;
            colPK_ID.Visible = false;
            colPK_ID.Width = 125;
            // 
            // colNOME
            // 
            colNOME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 0, 0);
            colNOME.DefaultCellStyle = dataGridViewCellStyle3;
            colNOME.HeaderText = "Produto";
            colNOME.MinimumWidth = 6;
            colNOME.Name = "colNOME";
            colNOME.ReadOnly = true;
            // 
            // colPRECO
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.Format = "R$ #,##0.00";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 5, 0);
            colPRECO.DefaultCellStyle = dataGridViewCellStyle4;
            colPRECO.HeaderText = "Preço";
            colPRECO.MinimumWidth = 6;
            colPRECO.Name = "colPRECO";
            colPRECO.ReadOnly = true;
            colPRECO.Resizable = DataGridViewTriState.False;
            colPRECO.Width = 130;
            // 
            // colEmbalagem
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            colEmbalagem.DefaultCellStyle = dataGridViewCellStyle5;
            colEmbalagem.HeaderText = "Embalagem";
            colEmbalagem.MinimumWidth = 6;
            colEmbalagem.Name = "colEmbalagem";
            colEmbalagem.ReadOnly = true;
            colEmbalagem.Resizable = DataGridViewTriState.False;
            colEmbalagem.Width = 110;
            // 
            // colVolume
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.Padding = new Padding(0, 0, 3, 0);
            colVolume.DefaultCellStyle = dataGridViewCellStyle6;
            colVolume.HeaderText = "Volume";
            colVolume.MinimumWidth = 6;
            colVolume.Name = "colVolume";
            colVolume.ReadOnly = true;
            colVolume.Resizable = DataGridViewTriState.False;
            colVolume.Width = 80;
            // 
            // colSigla
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            colSigla.DefaultCellStyle = dataGridViewCellStyle7;
            colSigla.HeaderText = "Un";
            colSigla.MinimumWidth = 6;
            colSigla.Name = "colSigla";
            colSigla.ReadOnly = true;
            colSigla.Resizable = DataGridViewTriState.False;
            colSigla.Width = 35;
            // 
            // colCategoria
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            colCategoria.DefaultCellStyle = dataGridViewCellStyle8;
            colCategoria.HeaderText = "Categoria";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 150;
            // 
            // colFornecedor
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.Padding = new Padding(5, 0, 0, 0);
            colFornecedor.DefaultCellStyle = dataGridViewCellStyle9;
            colFornecedor.HeaderText = "Fornecedor";
            colFornecedor.MinimumWidth = 6;
            colFornecedor.Name = "colFornecedor";
            colFornecedor.ReadOnly = true;
            colFornecedor.Width = 200;
            // 
            // colDescricao
            // 
            colDescricao.HeaderText = "Descricao";
            colDescricao.MinimumWidth = 6;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            colDescricao.Visible = false;
            colDescricao.Width = 125;
            // 
            // colFK_Imagem_ID
            // 
            colFK_Imagem_ID.HeaderText = "Imagem";
            colFK_Imagem_ID.MinimumWidth = 6;
            colFK_Imagem_ID.Name = "colFK_Imagem_ID";
            colFK_Imagem_ID.ReadOnly = true;
            colFK_Imagem_ID.Visible = false;
            colFK_Imagem_ID.Width = 125;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.RoyalBlue;
            btnEditar.Image = Properties.Resources.edit_color;
            btnEditar.Location = new Point(202, 17);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(180, 45);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.Teal;
            btnCadastrar.Image = Properties.Resources.new_color;
            btnCadastrar.Location = new Point(16, 17);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(180, 45);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BackColor = SystemColors.Control;
            pnlTop.Controls.Add(btnCadastrar);
            pnlTop.Controls.Add(btnPesquisar);
            pnlTop.Controls.Add(btnEditar);
            pnlTop.Location = new Point(12, 12);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1238, 78);
            pnlTop.TabIndex = 7;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1262, 673);
            Controls.Add(pnlTop);
            Controls.Add(dtgProdutos);
            Name = "FrmProdutos";
            Text = "Produtos";
            FormClosed += FrmProdutos_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnEditarProduto;
        private Button btnCadastrarProduto;
        private Button btnPesquisar;
        private DataGridView dtgProdutos;
        private DataGridViewTextBoxColumn colPK_ID;
        private DataGridViewTextBoxColumn colNOME;
        private DataGridViewTextBoxColumn colPRECO;
        private DataGridViewTextBoxColumn colEmbalagem;
        private DataGridViewTextBoxColumn colVolume;
        private DataGridViewTextBoxColumn colSigla;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colFornecedor;
        private DataGridViewTextBoxColumn colDescricao;
        private DataGridViewTextBoxColumn colFK_Imagem_ID;
        private Button btnCadastrar;
        private Button btnEditar;
        private Panel pnlTop;
    }
}