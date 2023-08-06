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
            lblNomeMarca = new Label();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpar.BackColor = Color.White;
            btnLimpar.FlatAppearance.BorderColor = Color.Silver;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(284, 132);
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
            btnSalvar.Location = new Point(384, 132);
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
            btnSair.Location = new Point(12, 132);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
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
            txtDescricao.Location = new Point(12, 87);
            txtDescricao.MaxLength = 100;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(466, 26);
            txtDescricao.TabIndex = 12;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.ForeColor = Color.FromArgb(54, 54, 54);
            lblDescricao.Location = new Point(12, 60);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(369, 24);
            lblDescricao.TabIndex = 14;
            lblDescricao.Text = "Descrição:";
            lblDescricao.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(12, 32);
            txtNome.MaxLength = 40;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(466, 26);
            txtNome.TabIndex = 11;
            // 
            // lblNomeMarca
            // 
            lblNomeMarca.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeMarca.ForeColor = Color.FromArgb(54, 54, 54);
            lblNomeMarca.Location = new Point(12, 5);
            lblNomeMarca.Name = "lblNomeMarca";
            lblNomeMarca.Size = new Size(321, 24);
            lblNomeMarca.TabIndex = 13;
            lblNomeMarca.Text = "Nome:";
            lblNomeMarca.TextAlign = ContentAlignment.BottomLeft;
            // 
            // FrmCadastroSimples
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(490, 173);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtNome);
            Controls.Add(lblNomeMarca);
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
        private Label lblNomeMarca;
    }
}