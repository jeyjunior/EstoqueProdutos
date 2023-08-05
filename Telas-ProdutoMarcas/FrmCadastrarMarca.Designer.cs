namespace EstoqueProdutos.Telas_ProdutoMarcas
{
    partial class FrmCadastrarMarca
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
            gpMarca = new GroupBox();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtNomeMarca = new TextBox();
            lblNomeMarca = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnSair = new Button();
            gpMarca.SuspendLayout();
            SuspendLayout();
            // 
            // gpMarca
            // 
            gpMarca.Controls.Add(txtDescricao);
            gpMarca.Controls.Add(lblDescricao);
            gpMarca.Controls.Add(txtNomeMarca);
            gpMarca.Controls.Add(lblNomeMarca);
            gpMarca.Location = new Point(12, 4);
            gpMarca.Name = "gpMarca";
            gpMarca.Size = new Size(465, 148);
            gpMarca.TabIndex = 1;
            gpMarca.TabStop = false;
            gpMarca.Text = "Marca";
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescricao.Location = new Point(17, 101);
            txtDescricao.MaxLength = 100;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(426, 26);
            txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.ForeColor = Color.FromArgb(54, 54, 54);
            lblDescricao.Location = new Point(17, 74);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(329, 24);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição:";
            lblDescricao.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNomeMarca
            // 
            txtNomeMarca.BorderStyle = BorderStyle.FixedSingle;
            txtNomeMarca.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeMarca.ForeColor = Color.FromArgb(64, 64, 64);
            txtNomeMarca.Location = new Point(17, 46);
            txtNomeMarca.MaxLength = 40;
            txtNomeMarca.Name = "txtNomeMarca";
            txtNomeMarca.Size = new Size(426, 26);
            txtNomeMarca.TabIndex = 1;
            txtNomeMarca.TextChanged += txtNomeMarca_TextChanged;
            // 
            // lblNomeMarca
            // 
            lblNomeMarca.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeMarca.ForeColor = Color.FromArgb(54, 54, 54);
            lblNomeMarca.Location = new Point(17, 19);
            lblNomeMarca.Name = "lblNomeMarca";
            lblNomeMarca.Size = new Size(281, 24);
            lblNomeMarca.TabIndex = 2;
            lblNomeMarca.Text = "Nome da Marca:";
            lblNomeMarca.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpar.BackColor = Color.White;
            btnLimpar.FlatAppearance.BorderColor = Color.Silver;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(284, 165);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.Green;
            btnSalvar.FlatAppearance.BorderColor = Color.Green;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(384, 165);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSair.BackColor = Color.Red;
            btnSair.FlatAppearance.BorderColor = Color.DarkRed;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(12, 165);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmCadastrarMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(490, 206);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnSair);
            Controls.Add(gpMarca);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastrarMarca";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Marca";
            Load += FrmCadastrarMarca_Load;
            gpMarca.ResumeLayout(false);
            gpMarca.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpMarca;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtNomeMarca;
        private Label lblNomeMarca;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnSair;
    }
}