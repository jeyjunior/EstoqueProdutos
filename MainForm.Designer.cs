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
            colID = new DataGridViewTextBoxColumn();
            colProduto = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colFornecedor = new DataGridViewTextBoxColumn();
            colPreco = new DataGridViewTextBoxColumn();
            colIDImagem = new DataGridViewTextBoxColumn();
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
            btnCadastrarProduto.Click += btnCadastrarProduto_Click;
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
            btnPesquisar.Click += btnPesquisar_Click;
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dtgProdutos.ColumnHeadersHeight = 35;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgProdutos.Columns.AddRange(new DataGridViewColumn[] { colID, colProduto, colCategoria, colFornecedor, colPreco, colIDImagem });
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
            dtgProdutos.RowsAdded += dtgProdutos_RowsAdded;
            // 
            // colID
            // 
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            colID.DefaultCellStyle = dataGridViewCellStyle14;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            colID.Width = 125;
            // 
            // colProduto
            // 
            colProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.Padding = new Padding(15, 0, 0, 0);
            colProduto.DefaultCellStyle = dataGridViewCellStyle15;
            colProduto.HeaderText = "PRODUTO";
            colProduto.MinimumWidth = 6;
            colProduto.Name = "colProduto";
            colProduto.ReadOnly = true;
            // 
            // colCategoria
            // 
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            colCategoria.DefaultCellStyle = dataGridViewCellStyle16;
            colCategoria.HeaderText = "CATEGORIA";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 230;
            // 
            // colFornecedor
            // 
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colFornecedor.DefaultCellStyle = dataGridViewCellStyle17;
            colFornecedor.HeaderText = "FORNECEDOR";
            colFornecedor.MinimumWidth = 6;
            colFornecedor.Name = "colFornecedor";
            colFornecedor.ReadOnly = true;
            colFornecedor.Width = 230;
            // 
            // colPreco
            // 
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Padding = new Padding(0, 0, 10, 0);
            colPreco.DefaultCellStyle = dataGridViewCellStyle18;
            colPreco.HeaderText = "PRECO";
            colPreco.MinimumWidth = 6;
            colPreco.Name = "colPreco";
            colPreco.ReadOnly = true;
            colPreco.Width = 150;
            // 
            // colIDImagem
            // 
            colIDImagem.HeaderText = "IMAGEM";
            colIDImagem.MinimumWidth = 6;
            colIDImagem.Name = "colIDImagem";
            colIDImagem.ReadOnly = true;
            colIDImagem.Visible = false;
            colIDImagem.Width = 125;
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
            Text = "Estoque";
            Load += MainForm_Load;
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
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colProduto;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colFornecedor;
        private DataGridViewTextBoxColumn colPreco;
        private DataGridViewTextBoxColumn colIDImagem;
    }
}