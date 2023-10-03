namespace Estoque.Telas_Principal
{
    partial class UCTelaPrincipalCima
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
            lblTela = new Label();
            lblUsuario = new Label();
            pcbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTela
            // 
            lblTela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTela.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTela.ForeColor = Color.White;
            lblTela.Location = new Point(334, 3);
            lblTela.Name = "lblTela";
            lblTela.Size = new Size(215, 28);
            lblTela.TabIndex = 5;
            lblTela.Text = "Tela aberta";
            lblTela.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(20, 2);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(276, 29);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "José Junior";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pcbLogo
            // 
            pcbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pcbLogo.Location = new Point(556, 1);
            pcbLogo.Margin = new Padding(0);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(32, 32);
            pcbLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbLogo.TabIndex = 7;
            pcbLogo.TabStop = false;
            // 
            // UCTelaPrincipalCima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 23, 28);
            Controls.Add(pcbLogo);
            Controls.Add(lblUsuario);
            Controls.Add(lblTela);
            Name = "UCTelaPrincipalCima";
            Size = new Size(600, 35);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTela;
        private Label lblUsuario;
        private PictureBox pcbLogo;
    }
}
