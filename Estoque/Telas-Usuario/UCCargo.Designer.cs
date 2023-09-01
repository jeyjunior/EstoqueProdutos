namespace Estoque.Telas_Usuario
{
    partial class UCCargo
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpComponenteDaPesquisa = new TableLayoutPanel();
            tlpComponentesRow1 = new TableLayoutPanel();
            cboSetor = new ComboBox();
            txtCargo = new TextBox();
            lblSetor = new Label();
            label1 = new Label();
            tblBotoes = new TableLayoutPanel();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnCadastrar = new Button();
            btnLimpar = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            dtgCargo = new DataGridView();
            colPK_Cargo = new DataGridViewTextBoxColumn();
            colNomeCargo = new DataGridViewTextBoxColumn();
            colFK_Setor = new DataGridViewTextBoxColumn();
            colNomeSetor = new DataGridViewTextBoxColumn();
            pnRegua = new Panel();
            pbBarraStatus = new Panel();
            lblTotalPesquisado = new Label();
            lblTotalRegistrado = new Label();
            tlpComponenteDaPesquisa.SuspendLayout();
            tlpComponentesRow1.SuspendLayout();
            tblBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCargo).BeginInit();
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
            tlpComponenteDaPesquisa.RowCount = 2;
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponenteDaPesquisa.Size = new Size(465, 117);
            tlpComponenteDaPesquisa.TabIndex = 9;
            // 
            // tlpComponentesRow1
            // 
            tlpComponentesRow1.ColumnCount = 1;
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpComponentesRow1.Controls.Add(cboSetor, 0, 3);
            tlpComponentesRow1.Controls.Add(txtCargo, 0, 1);
            tlpComponentesRow1.Controls.Add(lblSetor, 0, 0);
            tlpComponentesRow1.Controls.Add(label1, 0, 2);
            tlpComponentesRow1.Dock = DockStyle.Fill;
            tlpComponentesRow1.Location = new Point(14, 10);
            tlpComponentesRow1.Margin = new Padding(9, 0, 9, 9);
            tlpComponentesRow1.Name = "tlpComponentesRow1";
            tlpComponentesRow1.RowCount = 4;
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0006256F));
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9993744F));
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.Size = new Size(437, 93);
            tlpComponentesRow1.TabIndex = 10;
            // 
            // cboSetor
            // 
            cboSetor.Dock = DockStyle.Fill;
            cboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSetor.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSetor.FormattingEnabled = true;
            cboSetor.Location = new Point(3, 69);
            cboSetor.Name = "cboSetor";
            cboSetor.Size = new Size(431, 22);
            cboSetor.TabIndex = 21;
            // 
            // txtCargo
            // 
            txtCargo.BorderStyle = BorderStyle.FixedSingle;
            txtCargo.Dock = DockStyle.Fill;
            txtCargo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.Location = new Point(3, 23);
            txtCargo.MaxLength = 120;
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(431, 22);
            txtCargo.TabIndex = 15;
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
            lblSetor.Text = "Cargo:";
            lblSetor.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 46);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(437, 20);
            label1.TabIndex = 16;
            label1.Text = "Setor:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tblBotoes
            // 
            tblBotoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblBotoes.ColumnCount = 5;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblBotoes.Controls.Add(btnPesquisar, 0, 0);
            tblBotoes.Controls.Add(btnExcluir, 1, 0);
            tblBotoes.Controls.Add(btnAlterar, 2, 0);
            tblBotoes.Controls.Add(btnCadastrar, 3, 0);
            tblBotoes.Location = new Point(16, 147);
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
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.delete_outline_1;
            btnExcluir.Location = new Point(394, 0);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(35, 35);
            btnExcluir.TabIndex = 5;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = Properties.Resources.edit_outline_1;
            btnAlterar.Location = new Point(359, 0);
            btnAlterar.Margin = new Padding(0);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(35, 35);
            btnAlterar.TabIndex = 4;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = Properties.Resources.new_outline_1;
            btnCadastrar.Location = new Point(324, 0);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(35, 35);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.erase_outline_1;
            btnLimpar.Location = new Point(403, 197);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(35, 35);
            btnLimpar.TabIndex = 7;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_outline_1;
            btnCancelar.Location = new Point(438, 197);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(35, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(368, 197);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(35, 35);
            btnSalvar.TabIndex = 8;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dtgCargo
            // 
            dtgCargo.AllowUserToDeleteRows = false;
            dtgCargo.AllowUserToOrderColumns = true;
            dtgCargo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 235, 235);
            dtgCargo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgCargo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCargo.BackgroundColor = Color.FromArgb(235, 235, 235);
            dtgCargo.BorderStyle = BorderStyle.None;
            dtgCargo.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dtgCargo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 74, 84);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgCargo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgCargo.ColumnHeadersHeight = 35;
            dtgCargo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgCargo.Columns.AddRange(new DataGridViewColumn[] { colPK_Cargo, colNomeCargo, colFK_Setor, colNomeSetor });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(140, 200, 120);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgCargo.DefaultCellStyle = dataGridViewCellStyle5;
            dtgCargo.EnableHeadersVisualStyles = false;
            dtgCargo.GridColor = Color.White;
            dtgCargo.Location = new Point(15, 197);
            dtgCargo.MultiSelect = false;
            dtgCargo.Name = "dtgCargo";
            dtgCargo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgCargo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgCargo.RowHeadersVisible = false;
            dtgCargo.RowHeadersWidth = 55;
            dtgCargo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgCargo.RowTemplate.Height = 25;
            dtgCargo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCargo.Size = new Size(465, 200);
            dtgCargo.TabIndex = 10;
            // 
            // colPK_Cargo
            // 
            colPK_Cargo.DataPropertyName = "PK_Cargo";
            colPK_Cargo.HeaderText = "PK_Usuario";
            colPK_Cargo.MinimumWidth = 100;
            colPK_Cargo.Name = "colPK_Cargo";
            colPK_Cargo.ReadOnly = true;
            colPK_Cargo.Visible = false;
            // 
            // colNomeCargo
            // 
            colNomeCargo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNomeCargo.DataPropertyName = "NomeCargo";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            colNomeCargo.DefaultCellStyle = dataGridViewCellStyle3;
            colNomeCargo.HeaderText = "Cargo";
            colNomeCargo.MinimumWidth = 200;
            colNomeCargo.Name = "colNomeCargo";
            colNomeCargo.ReadOnly = true;
            // 
            // colFK_Setor
            // 
            colFK_Setor.DataPropertyName = "FK_Setor";
            colFK_Setor.HeaderText = "colFK_Setor";
            colFK_Setor.Name = "colFK_Setor";
            colFK_Setor.ReadOnly = true;
            colFK_Setor.Visible = false;
            // 
            // colNomeSetor
            // 
            colNomeSetor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNomeSetor.DataPropertyName = "NomeSetor";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new Padding(10, 0, 0, 0);
            colNomeSetor.DefaultCellStyle = dataGridViewCellStyle4;
            colNomeSetor.HeaderText = "Setor";
            colNomeSetor.MinimumWidth = 200;
            colNomeSetor.Name = "colNomeSetor";
            colNomeSetor.ReadOnly = true;
            // 
            // pnRegua
            // 
            pnRegua.BackColor = Color.Brown;
            pnRegua.Location = new Point(480, 397);
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
            // UCCargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(pnRegua);
            Controls.Add(tlpComponenteDaPesquisa);
            Controls.Add(btnLimpar);
            Controls.Add(tblBotoes);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(dtgCargo);
            Controls.Add(pbBarraStatus);
            Name = "UCCargo";
            Size = new Size(496, 432);
            Load += UCCargo_Load;
            VisibleChanged += UCCargo_VisibleChanged;
            tlpComponenteDaPesquisa.ResumeLayout(false);
            tlpComponentesRow1.ResumeLayout(false);
            tlpComponentesRow1.PerformLayout();
            tblBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgCargo).EndInit();
            pbBarraStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpComponenteDaPesquisa;
        private TableLayoutPanel tlpComponentesRow1;
        private TextBox txtCargo;
        private Label lblSetor;
        private TableLayoutPanel tblBotoes;
        private Button btnPesquisar;
        private Button btnSetorCargo;
        private Button btnCadastrarUsuario;
        private Button btnAlterar;
        private Button btnCadastrar;
        private DataGridView dtgCargo;
        private Button btnExcluir;
        private Panel pnRegua;
        private Panel pbBarraStatus;
        private Label lblTotalRegistrado;
        private Label lblTotalPesquisado;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label1;
        private ComboBox cboSetor;
        private DataGridViewTextBoxColumn colPK_Cargo;
        private DataGridViewTextBoxColumn colNomeCargo;
        private DataGridViewTextBoxColumn colFK_Setor;
        private DataGridViewTextBoxColumn colNomeSetor;
    }
}
