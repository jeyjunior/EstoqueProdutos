namespace EstoqueProdutos.Telas_Produtos
{
    partial class FrmBase
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
            components = new System.ComponentModel.Container();
            lblNome = new Label();
            txtModelo = new TextBox();
            gpbDadosGrupo = new GroupBox();
            cboBase = new ComboBox();
            pcbImagem = new PictureBox();
            toolTipCadastrarProduto = new ToolTip(components);
            btnBase = new Button();
            gpbDadosGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(162, 35);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Label";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(162, 58);
            txtModelo.MaxLength = 30;
            txtModelo.Name = "txtModelo";
            txtModelo.PlaceholderText = "Descrição";
            txtModelo.Size = new Size(370, 27);
            txtModelo.TabIndex = 0;
            // 
            // gpbDadosGrupo
            // 
            gpbDadosGrupo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpbDadosGrupo.Controls.Add(cboBase);
            gpbDadosGrupo.Controls.Add(pcbImagem);
            gpbDadosGrupo.Controls.Add(txtModelo);
            gpbDadosGrupo.Controls.Add(lblNome);
            gpbDadosGrupo.Location = new Point(12, 12);
            gpbDadosGrupo.Name = "gpbDadosGrupo";
            gpbDadosGrupo.Size = new Size(545, 177);
            gpbDadosGrupo.TabIndex = 2;
            gpbDadosGrupo.TabStop = false;
            gpbDadosGrupo.Text = "Dados do grupo";
            // 
            // cboBase
            // 
            cboBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBase.FormattingEnabled = true;
            cboBase.Location = new Point(162, 116);
            cboBase.Name = "cboBase";
            cboBase.Size = new Size(370, 28);
            cboBase.TabIndex = 7;
            // 
            // pcbImagem
            // 
            pcbImagem.BackColor = Color.White;
            pcbImagem.BorderStyle = BorderStyle.FixedSingle;
            pcbImagem.Location = new Point(19, 35);
            pcbImagem.Name = "pcbImagem";
            pcbImagem.Size = new Size(119, 109);
            pcbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagem.TabIndex = 4;
            pcbImagem.TabStop = false;
            pcbImagem.Click += pcbImagem_Click;
            // 
            // btnBase
            // 
            btnBase.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBase.BackColor = Color.Transparent;
            btnBase.FlatAppearance.BorderSize = 0;
            btnBase.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBase.ForeColor = Color.Black;
            btnBase.Image = Properties.Resources.save_color;
            btnBase.Location = new Point(512, 195);
            btnBase.Name = "btnBase";
            btnBase.Size = new Size(45, 45);
            btnBase.TabIndex = 9;
            btnBase.UseVisualStyleBackColor = false;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 249);
            Controls.Add(btnBase);
            Controls.Add(gpbDadosGrupo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmBase";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulario Base";
            Load += FrmCadastroProduto_Load;
            gpbDadosGrupo.ResumeLayout(false);
            gpbDadosGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private TextBox txtModelo;
        private GroupBox gpbDadosGrupo;
        private PictureBox pcbImagem;
        private ComboBox cboBase;
        private ToolTip toolTipCadastrarProduto;
        private Button btnBase;
    }
}