namespace EstoqueProdutos.Telas_Base
{
    partial class FrmCadastroSimples
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
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnSair = new Button();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpar.BackColor = Color.White;
            btnLimpar.FlatAppearance.BorderColor = Color.Silver;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(248, 107);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(82, 37);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.LightGray;
            btnSalvar.Enabled = false;
            btnSalvar.FlatAppearance.BorderColor = Color.LightGray;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(336, 107);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 37);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.EnabledChanged += btnSalvar_EnabledChanged;
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
            btnSair.Location = new Point(10, 107);
            btnSair.Margin = new Padding(3, 2, 3, 2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(82, 37);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescricao.Location = new Point(10, 66);
            txtDescricao.Margin = new Padding(3, 2, 3, 2);
            txtDescricao.MaxLength = 100;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(408, 22);
            txtDescricao.TabIndex = 12;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.ForeColor = Color.FromArgb(54, 54, 54);
            lblDescricao.Location = new Point(10, 46);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(323, 18);
            lblDescricao.TabIndex = 14;
            lblDescricao.Text = "Descrição:";
            lblDescricao.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(10, 24);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.MaxLength = 40;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(408, 22);
            txtNome.TabIndex = 11;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(54, 54, 54);
            lblNome.Location = new Point(10, 4);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(281, 18);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome:";
            lblNome.TextAlign = ContentAlignment.BottomLeft;
            // 
            // FrmCadastroSimples
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(429, 158);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnSair);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastroSimples";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnSair;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtNome;
        private Label lblNome;
    }
}