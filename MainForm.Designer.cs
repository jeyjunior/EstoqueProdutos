namespace EstoqueProdutos
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            pnlSide = new Panel();
            pnlMain = new Panel();
            progressBar = new ProgressBar();
            lblTItulo = new Label();
            btnDeletarProduto = new Button();
            btnEditarProduto = new Button();
            btnCadastrarProduto = new Button();
            btnPesquisar = new Button();
            lblContagem = new Label();
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
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSide.BackColor = Color.White;
            pnlSide.BorderStyle = BorderStyle.FixedSingle;
            pnlSide.Location = new Point(9, 12);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(70, 649);
            pnlSide.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.White;
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Controls.Add(progressBar);
            pnlMain.Controls.Add(lblTItulo);
            pnlMain.Controls.Add(btnDeletarProduto);
            pnlMain.Controls.Add(btnEditarProduto);
            pnlMain.Controls.Add(btnCadastrarProduto);
            pnlMain.Controls.Add(btnPesquisar);
            pnlMain.Controls.Add(lblContagem);
            pnlMain.Controls.Add(dtgProdutos);
            pnlMain.Location = new Point(95, 12);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1155, 649);
            pnlMain.TabIndex = 1;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(8, 609);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1136, 10);
            progressBar.TabIndex = 7;
            // 
            // lblTItulo
            // 
            lblTItulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTItulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTItulo.Location = new Point(350, 7);
            lblTItulo.Name = "lblTItulo";
            lblTItulo.Size = new Size(358, 54);
            lblTItulo.TabIndex = 6;
            lblTItulo.Text = "PRODUTOS";
            lblTItulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDeletarProduto
            // 
            btnDeletarProduto.Location = new Point(113, 13);
            btnDeletarProduto.Name = "btnDeletarProduto";
            btnDeletarProduto.Size = new Size(45, 45);
            btnDeletarProduto.TabIndex = 5;
            btnDeletarProduto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProduto
            // 
            btnEditarProduto.Location = new Point(62, 13);
            btnEditarProduto.Name = "btnEditarProduto";
            btnEditarProduto.Size = new Size(45, 45);
            btnEditarProduto.TabIndex = 4;
            btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.Image = Properties.Resources.new_color;
            btnCadastrarProduto.Location = new Point(11, 13);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(45, 45);
            btnCadastrarProduto.TabIndex = 3;
            btnCadastrarProduto.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.Image = Properties.Resources.search;
            btnPesquisar.Location = new Point(964, 13);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(179, 45);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblContagem
            // 
            lblContagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContagem.Location = new Point(0, 622);
            lblContagem.Name = "lblContagem";
            lblContagem.Size = new Size(1150, 24);
            lblContagem.TabIndex = 1;
            lblContagem.Text = "Total: 1000";
            lblContagem.TextAlign = ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dtgProdutos.ColumnHeadersHeight = 35;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgProdutos.Columns.AddRange(new DataGridViewColumn[] { colPK_ID, colNOME, colPRECO, colEmbalagem, colVolume, colSigla, colCategoria, colFornecedor, colDescricao, colFK_Imagem_ID });
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.WhiteSmoke;
            dtgProdutos.Location = new Point(8, 70);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dtgProdutos.RowHeadersVisible = false;
            dtgProdutos.RowHeadersWidth = 100;
            dtgProdutos.RowTemplate.Height = 29;
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(1136, 537);
            dtgProdutos.TabIndex = 0;
            // 
            // colPK_ID
            // 
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            colPK_ID.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.Padding = new Padding(5, 0, 0, 0);
            colNOME.DefaultCellStyle = dataGridViewCellStyle12;
            colNOME.HeaderText = "Produto";
            colNOME.MinimumWidth = 6;
            colNOME.Name = "colNOME";
            colNOME.ReadOnly = true;
            // 
            // colPRECO
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.Format = "R$ #,##0.00";
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.Padding = new Padding(0, 0, 5, 0);
            colPRECO.DefaultCellStyle = dataGridViewCellStyle13;
            colPRECO.HeaderText = "Preço";
            colPRECO.MinimumWidth = 6;
            colPRECO.Name = "colPRECO";
            colPRECO.ReadOnly = true;
            colPRECO.Resizable = DataGridViewTriState.False;
            colPRECO.Width = 130;
            // 
            // colEmbalagem
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            colEmbalagem.DefaultCellStyle = dataGridViewCellStyle14;
            colEmbalagem.HeaderText = "Embalagem";
            colEmbalagem.MinimumWidth = 6;
            colEmbalagem.Name = "colEmbalagem";
            colEmbalagem.ReadOnly = true;
            colEmbalagem.Resizable = DataGridViewTriState.False;
            colEmbalagem.Width = 110;
            // 
            // colVolume
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.Padding = new Padding(0, 0, 3, 0);
            colVolume.DefaultCellStyle = dataGridViewCellStyle15;
            colVolume.HeaderText = "Volume";
            colVolume.MinimumWidth = 6;
            colVolume.Name = "colVolume";
            colVolume.ReadOnly = true;
            colVolume.Resizable = DataGridViewTriState.False;
            colVolume.Width = 80;
            // 
            // colSigla
            // 
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            colSigla.DefaultCellStyle = dataGridViewCellStyle16;
            colSigla.HeaderText = "Un";
            colSigla.MinimumWidth = 6;
            colSigla.Name = "colSigla";
            colSigla.ReadOnly = true;
            colSigla.Resizable = DataGridViewTriState.False;
            colSigla.Width = 35;
            // 
            // colCategoria
            // 
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            colCategoria.DefaultCellStyle = dataGridViewCellStyle17;
            colCategoria.HeaderText = "Categoria";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 150;
            // 
            // colFornecedor
            // 
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.Padding = new Padding(5, 0, 0, 0);
            colFornecedor.DefaultCellStyle = dataGridViewCellStyle18;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1262, 673);
            Controls.Add(pnlMain);
            Controls.Add(pnlSide);
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide;
        private Panel pnlMain;
        private Label lblContagem;
        private DataGridView dtgProdutos;
        private Button btnDeletarProduto;
        private Button btnEditarProduto;
        private Button btnCadastrarProduto;
        private Button btnPesquisar;
        private Label lblTItulo;
        private ProgressBar progressBar;
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
    }
}