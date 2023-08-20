namespace Estoque.Telas_Principal
{
    partial class UCPrincipalTop
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
            SuspendLayout();
            // 
            // lblTela
            // 
            lblTela.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTela.ForeColor = Color.White;
            lblTela.Location = new Point(17, 0);
            lblTela.Name = "lblTela";
            lblTela.Size = new Size(277, 35);
            lblTela.TabIndex = 5;
            lblTela.Text = "Tela aberta";
            lblTela.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(255, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(321, 35);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "José Junior";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UCPrincipalTop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 23, 28);
            Controls.Add(lblUsuario);
            Controls.Add(lblTela);
            Name = "UCPrincipalTop";
            Size = new Size(600, 35);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTela;
        private Label lblUsuario;
    }
}
