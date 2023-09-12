namespace Estoque.Telas_Usuario
{
    partial class UCCadastrarCargo
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
            tlpCentral = new TableLayoutPanel();
            dtgCargo = new DataGridView();
            colPK_Cargo = new DataGridViewTextBoxColumn();
            colNomeCargo = new DataGridViewTextBoxColumn();
            colFK_Setor = new DataGridViewTextBoxColumn();
            colNomeSetor = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCargo = new Label();
            txtCargo = new TextBox();
            tlpBotoes = new TableLayoutPanel();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnLimpar = new Button();
            tblSetor = new TableLayoutPanel();
            cboSetor = new ComboBox();
            lblSetor = new Label();
            tblPrincipal = new TableLayoutPanel();
            pBarraStatus = new Panel();
            lblTotalPesquisado = new Label();
            lblTotalRegistrado = new Label();
            tlpCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCargo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tlpBotoes.SuspendLayout();
            tblSetor.SuspendLayout();
            tblPrincipal.SuspendLayout();
            pBarraStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.Transparent;
            tlpCentral.ColumnCount = 1;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.Controls.Add(dtgCargo, 0, 5);
            tlpCentral.Controls.Add(tableLayoutPanel1, 0, 0);
            tlpCentral.Controls.Add(tlpBotoes, 0, 3);
            tlpCentral.Controls.Add(tblSetor, 0, 1);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(0, 15);
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
            tlpCentral.Size = new Size(560, 530);
            tlpCentral.TabIndex = 0;
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
            dtgCargo.Location = new Point(0, 225);
            dtgCargo.Margin = new Padding(0);
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
            dtgCargo.Size = new Size(560, 305);
            dtgCargo.TabIndex = 17;
            // 
            // colPK_Cargo
            // 
            colPK_Cargo.DataPropertyName = "PK_Cargo";
            colPK_Cargo.HeaderText = "PK_Cargo";
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(60, 75, 85);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblCargo, 0, 0);
            tableLayoutPanel1.Controls.Add(txtCargo, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(560, 80);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // lblCargo
            // 
            lblCargo.Dock = DockStyle.Fill;
            lblCargo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargo.ForeColor = SystemColors.ControlLightLight;
            lblCargo.Location = new Point(15, 0);
            lblCargo.Margin = new Padding(0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(530, 32);
            lblCargo.TabIndex = 17;
            lblCargo.Text = "Cargo:";
            lblCargo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCargo
            // 
            txtCargo.BorderStyle = BorderStyle.FixedSingle;
            txtCargo.Dock = DockStyle.Fill;
            txtCargo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.Location = new Point(18, 35);
            txtCargo.MaxLength = 120;
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(524, 27);
            txtCargo.TabIndex = 16;
            // 
            // tlpBotoes
            // 
            tlpBotoes.BackColor = Color.Transparent;
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
            tlpBotoes.Size = new Size(560, 35);
            tlpBotoes.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.search_1;
            btnPesquisar.Location = new Point(525, 0);
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
            btnExcluir.Location = new Point(0, 0);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(35, 35);
            btnExcluir.TabIndex = 5;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_outline_1;
            btnCancelar.Location = new Point(490, 0);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(35, 35);
            btnCancelar.TabIndex = 16;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(455, 0);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(35, 35);
            btnSalvar.TabIndex = 15;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = Properties.Resources.new_outline_1;
            btnCadastrar.Location = new Point(350, 0);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(35, 35);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = Properties.Resources.edit_outline_1;
            btnAlterar.Location = new Point(385, 0);
            btnAlterar.Margin = new Padding(0);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(35, 35);
            btnAlterar.TabIndex = 4;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.erase_outline_1;
            btnLimpar.Location = new Point(420, 0);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(35, 35);
            btnLimpar.TabIndex = 14;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // tblSetor
            // 
            tblSetor.BackColor = Color.FromArgb(60, 75, 85);
            tblSetor.ColumnCount = 1;
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSetor.Controls.Add(cboSetor, 0, 1);
            tblSetor.Controls.Add(lblSetor, 0, 0);
            tblSetor.Dock = DockStyle.Fill;
            tblSetor.Location = new Point(0, 80);
            tblSetor.Margin = new Padding(0);
            tblSetor.Name = "tblSetor";
            tblSetor.Padding = new Padding(15, 0, 15, 0);
            tblSetor.RowCount = 2;
            tblSetor.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblSetor.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblSetor.Size = new Size(560, 80);
            tblSetor.TabIndex = 14;
            // 
            // cboSetor
            // 
            cboSetor.Dock = DockStyle.Fill;
            cboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSetor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboSetor.FormattingEnabled = true;
            cboSetor.Location = new Point(18, 35);
            cboSetor.Name = "cboSetor";
            cboSetor.Size = new Size(524, 26);
            cboSetor.TabIndex = 22;
            // 
            // lblSetor
            // 
            lblSetor.Dock = DockStyle.Fill;
            lblSetor.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSetor.ForeColor = SystemColors.ControlLightLight;
            lblSetor.Location = new Point(15, 0);
            lblSetor.Margin = new Padding(0);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(530, 32);
            lblSetor.TabIndex = 17;
            lblSetor.Text = "Setor:";
            lblSetor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblPrincipal
            // 
            tblPrincipal.BackColor = Color.Transparent;
            tblPrincipal.ColumnCount = 1;
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPrincipal.Controls.Add(tlpCentral, 0, 1);
            tblPrincipal.Controls.Add(pBarraStatus, 0, 2);
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
            // pBarraStatus
            // 
            pBarraStatus.BackColor = Color.FromArgb(16, 23, 28);
            pBarraStatus.Controls.Add(lblTotalPesquisado);
            pBarraStatus.Controls.Add(lblTotalRegistrado);
            pBarraStatus.Dock = DockStyle.Fill;
            pBarraStatus.Location = new Point(0, 545);
            pBarraStatus.Margin = new Padding(0);
            pBarraStatus.Name = "pBarraStatus";
            pBarraStatus.Size = new Size(560, 15);
            pBarraStatus.TabIndex = 1;
            // 
            // lblTotalPesquisado
            // 
            lblTotalPesquisado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalPesquisado.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPesquisado.ForeColor = SystemColors.ControlLightLight;
            lblTotalPesquisado.Location = new Point(0, 0);
            lblTotalPesquisado.Margin = new Padding(0);
            lblTotalPesquisado.Name = "lblTotalPesquisado";
            lblTotalPesquisado.Padding = new Padding(15, 0, 0, 0);
            lblTotalPesquisado.Size = new Size(266, 17);
            lblTotalPesquisado.TabIndex = 14;
            lblTotalPesquisado.Text = "Pesquisado: 100000";
            lblTotalPesquisado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalRegistrado
            // 
            lblTotalRegistrado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalRegistrado.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalRegistrado.ForeColor = SystemColors.ControlLightLight;
            lblTotalRegistrado.Location = new Point(266, 0);
            lblTotalRegistrado.Margin = new Padding(0);
            lblTotalRegistrado.Name = "lblTotalRegistrado";
            lblTotalRegistrado.Padding = new Padding(0, 0, 15, 0);
            lblTotalRegistrado.Size = new Size(294, 17);
            lblTotalRegistrado.TabIndex = 13;
            lblTotalRegistrado.Text = "Registrado: 100000";
            lblTotalRegistrado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UCCadastrarCargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(tblPrincipal);
            Name = "UCCadastrarCargo";
            Size = new Size(560, 560);
            Load += UCCadastrarSetor_Load;
            tlpCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgCargo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tlpBotoes.ResumeLayout(false);
            tblSetor.ResumeLayout(false);
            tblPrincipal.ResumeLayout(false);
            pBarraStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tblPrincipal;
        private TableLayoutPanel tblBotoes;
        private Button btnPesquisar;
        private Button btnLimpar;
        private TableLayoutPanel tlpBotoes;
        private Button btnPesqusiar;
        private Button button2;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnCadastrar;
        private Button btnSalvar;
        private Button btnCancelar;
        private TableLayoutPanel tblSetor;
        private Label lblSetor;
        private Panel pBarraStatus;
        private Label lblTotalRegistrado;
        private Label lblTotalPesquisado;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCargo;
        private TextBox txtCargo;
        private DataGridView dtgCargo;
        private DataGridViewTextBoxColumn colPK_Cargo;
        private DataGridViewTextBoxColumn colNomeCargo;
        private DataGridViewTextBoxColumn colFK_Setor;
        private DataGridViewTextBoxColumn colNomeSetor;
        private ComboBox cboSetor;
    }
}
