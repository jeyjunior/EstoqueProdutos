namespace Estoque.Telas_Principal
{
    partial class UCPrincipalBot
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
            lblBarraStatus = new Label();
            SuspendLayout();
            // 
            // lblBarraStatus
            // 
            lblBarraStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBarraStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarraStatus.ForeColor = Color.White;
            lblBarraStatus.Location = new Point(413, 1);
            lblBarraStatus.Name = "lblBarraStatus";
            lblBarraStatus.Size = new Size(349, 35);
            lblBarraStatus.TabIndex = 7;
            lblBarraStatus.Text = "Barra de status";
            lblBarraStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UCPrincipalBot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 23, 28);
            Controls.Add(lblBarraStatus);
            Name = "UCPrincipalBot";
            Size = new Size(784, 36);
            ResumeLayout(false);
        }

        #endregion

        private Label lblBarraStatus;
    }
}
