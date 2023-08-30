namespace Estoque.Telas_Usuario
{
    partial class UCSetor
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpComponenteDaPesquisa = new TableLayoutPanel();
            tlpComponentesRow1 = new TableLayoutPanel();
            txtSetor = new TextBox();
            lblSetor = new Label();
            tblBotoes = new TableLayoutPanel();
            btnPesquisar = new Button();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            dtgSetor = new DataGridView();
            colPK_Usuario = new DataGridViewTextBoxColumn();
            colSetor = new DataGridViewTextBoxColumn();
            pnRegua = new Panel();
            pbBarraStatus = new Panel();
            lblTotalPesquisado = new Label();
            lblTotalRegistrado = new Label();
            tlpComponenteDaPesquisa.SuspendLayout();
            tlpComponentesRow1.SuspendLayout();
            tblBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSetor).BeginInit();
            pbBarraStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tlpComponenteDaPesquisa
            // 
            tlpComponenteDaPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpComponenteDaPesquisa.BackColor = Color.FromArgb(60, 75, 85);
            tlpComponenteDaPesquisa.ColumnCount = 1;
            tlpComponenteDaPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpComponenteDaPesquisa.Controls.Add(tlpComponentesRow1, 0, 1);
            tlpComponenteDaPesquisa.Location = new Point(15, 15);
            tlpComponenteDaPesquisa.Margin = new Padding(5);
            tlpComponenteDaPesquisa.Name = "tlpComponenteDaPesquisa";
            tlpComponenteDaPesquisa.Padding = new Padding(5);
            tlpComponenteDaPesquisa.RowCount = 3;
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpComponenteDaPesquisa.Size = new Size(465, 82);
            tlpComponenteDaPesquisa.TabIndex = 9;
            // 
            // tlpComponentesRow1
            // 
            tlpComponentesRow1.ColumnCount = 1;
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.Controls.Add(txtSetor, 0, 1);
            tlpComponentesRow1.Controls.Add(lblSetor, 0, 0);
            tlpComponentesRow1.Dock = DockStyle.Fill;
            tlpComponentesRow1.Location = new Point(14, 10);
            tlpComponentesRow1.Margin = new Padding(9, 0, 9, 9);
            tlpComponentesRow1.Name = "tlpComponentesRow1";
            tlpComponentesRow1.RowCount = 2;
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponentesRow1.Size = new Size(437, 48);
            tlpComponentesRow1.TabIndex = 10;
            // 
            // txtSetor
            // 
            txtSetor.BorderStyle = BorderStyle.FixedSingle;
            txtSetor.Dock = DockStyle.Fill;
            txtSetor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSetor.Location = new Point(3, 23);
            txtSetor.MaxLength = 120;
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(431, 27);
            txtSetor.TabIndex = 15;
            // 
            // lblSetor
            // 
            lblSetor.Dock = DockStyle.Fill;
            lblSetor.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSetor.ForeColor = SystemColors.ControlLightLight;
            lblSetor.Location = new Point(0, 0);
            lblSetor.Margin = new Padding(0);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(437, 20);
            lblSetor.TabIndex = 11;
            lblSetor.Text = "Setor:";
            lblSetor.TextAlign = ContentAlignment.BottomLeft;
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
            tblBotoes.Controls.Add(btnCadastrar, 6, 0);
            tblBotoes.Controls.Add(btnExcluir, 2, 0);
            tblBotoes.Controls.Add(btnAlterar, 4, 0);
            tblBotoes.Location = new Point(15, 110);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(464, 35);
            tblBotoes.TabIndex = 11;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.search_1;
            btnPesquisar.Location = new Point(429, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(35, 35);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(309, 0);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(35, 35);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(389, 0);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(35, 35);
            btnExcluir.TabIndex = 5;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(349, 0);
            btnAlterar.Margin = new Padding(0);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(35, 35);
            btnAlterar.TabIndex = 4;
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // dtgSetor
            // 
            dtgSetor.AllowUserToDeleteRows = false;
            dtgSetor.AllowUserToOrderColumns = true;
            dtgSetor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 235, 235);
            dtgSetor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgSetor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgSetor.BackgroundColor = Color.FromArgb(235, 235, 235);
            dtgSetor.BorderStyle = BorderStyle.None;
            dtgSetor.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dtgSetor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 74, 84);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgSetor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgSetor.ColumnHeadersHeight = 35;
            dtgSetor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgSetor.Columns.AddRange(new DataGridViewColumn[] { colPK_Usuario, colSetor });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(140, 200, 120);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgSetor.DefaultCellStyle = dataGridViewCellStyle3;
            dtgSetor.EnableHeadersVisualStyles = false;
            dtgSetor.GridColor = Color.White;
            dtgSetor.Location = new Point(15, 159);
            dtgSetor.Name = "dtgSetor";
            dtgSetor.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgSetor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgSetor.RowHeadersVisible = false;
            dtgSetor.RowHeadersWidth = 55;
            dtgSetor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgSetor.RowTemplate.Height = 25;
            dtgSetor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgSetor.Size = new Size(465, 239);
            dtgSetor.TabIndex = 10;
            // 
            // colPK_Usuario
            // 
            colPK_Usuario.DataPropertyName = "PK_Setor";
            colPK_Usuario.HeaderText = "PK_Usuario";
            colPK_Usuario.MinimumWidth = 100;
            colPK_Usuario.Name = "colPK_Usuario";
            colPK_Usuario.ReadOnly = true;
            colPK_Usuario.Visible = false;
            // 
            // colSetor
            // 
            colSetor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSetor.DataPropertyName = "NomeSetor";
            colSetor.HeaderText = "Setor";
            colSetor.MinimumWidth = 200;
            colSetor.Name = "colSetor";
            colSetor.ReadOnly = true;
            // 
            // pnRegua
            // 
            pnRegua.BackColor = Color.Brown;
            pnRegua.Location = new Point(481, -1);
            pnRegua.Name = "pnRegua";
            pnRegua.Size = new Size(15, 15);
            pnRegua.TabIndex = 12;
            pnRegua.Visible = false;
            // 
            // pbBarraStatus
            // 
            pbBarraStatus.BackColor = Color.FromArgb(16, 23, 28);
            pbBarraStatus.Controls.Add(lblTotalPesquisado);
            pbBarraStatus.Controls.Add(lblTotalRegistrado);
            pbBarraStatus.Location = new Point(0, 412);
            pbBarraStatus.Name = "pbBarraStatus";
            pbBarraStatus.Size = new Size(496, 20);
            pbBarraStatus.TabIndex = 13;
            // 
            // lblTotalPesquisado
            // 
            lblTotalPesquisado.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPesquisado.ForeColor = SystemColors.ControlLightLight;
            lblTotalPesquisado.Location = new Point(0, 0);
            lblTotalPesquisado.Margin = new Padding(0);
            lblTotalPesquisado.Name = "lblTotalPesquisado";
            lblTotalPesquisado.Padding = new Padding(15, 0, 0, 0);
            lblTotalPesquisado.Size = new Size(236, 20);
            lblTotalPesquisado.TabIndex = 13;
            lblTotalPesquisado.Text = "Pesquisado: 100000";
            // 
            // lblTotalRegistrado
            // 
            lblTotalRegistrado.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalRegistrado.ForeColor = SystemColors.ControlLightLight;
            lblTotalRegistrado.Location = new Point(236, 0);
            lblTotalRegistrado.Margin = new Padding(0);
            lblTotalRegistrado.Name = "lblTotalRegistrado";
            lblTotalRegistrado.Padding = new Padding(0, 0, 15, 0);
            lblTotalRegistrado.Size = new Size(260, 20);
            lblTotalRegistrado.TabIndex = 12;
            lblTotalRegistrado.Text = "Registrado: 100000";
            lblTotalRegistrado.TextAlign = ContentAlignment.TopRight;
            // 
            // UCSetor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(pnRegua);
            Controls.Add(tlpComponenteDaPesquisa);
            Controls.Add(tblBotoes);
            Controls.Add(dtgSetor);
            Controls.Add(pbBarraStatus);
            Name = "UCSetor";
            Size = new Size(496, 432);
            Load += UCSetor_Load;
            VisibleChanged += UCSetor_VisibleChanged;
            tlpComponenteDaPesquisa.ResumeLayout(false);
            tlpComponentesRow1.ResumeLayout(false);
            tlpComponentesRow1.PerformLayout();
            tblBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgSetor).EndInit();
            pbBarraStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpComponenteDaPesquisa;
        private TableLayoutPanel tlpComponentesRow1;
        private TextBox txtSetor;
        private Label lblSetor;
        private TableLayoutPanel tblBotoes;
        private Button btnPesquisar;
        private Button btnSetorCargo;
        private Button btnCadastrarUsuario;
        private Button btnAlterar;
        private Button btnCadastrar;
        private DataGridView dtgSetor;
        private DataGridViewTextBoxColumn colPK_Usuario;
        private DataGridViewTextBoxColumn colSetor;
        private Button btnExcluir;
        private Panel pnRegua;
        private Panel pbBarraStatus;
        private Label lblTotalRegistrado;
        private Label lblTotalPesquisado;
    }
}
