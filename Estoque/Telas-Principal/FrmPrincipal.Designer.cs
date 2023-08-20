namespace EstoqueProdutos.Telas_Principal
{
    partial class FrmPrincipal
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
            pCentral = new Panel();
            pTop = new Panel();
            pBot = new Panel();
            pRight = new Panel();
            SuspendLayout();
            // 
            // pCentral
            // 
            pCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCentral.BackColor = Color.Transparent;
            pCentral.Location = new Point(129, 40);
            pCentral.Margin = new Padding(0);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(650, 480);
            pCentral.TabIndex = 3;
            // 
            // pTop
            // 
            pTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pTop.BackColor = Color.FromArgb(255, 128, 128);
            pTop.Location = new Point(0, 0);
            pTop.Name = "pTop";
            pTop.Size = new Size(784, 35);
            pTop.TabIndex = 6;
            // 
            // pBot
            // 
            pBot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBot.BackColor = Color.FromArgb(255, 128, 128);
            pBot.Location = new Point(0, 526);
            pBot.Name = "pBot";
            pBot.Size = new Size(784, 35);
            pBot.TabIndex = 7;
            // 
            // pRight
            // 
            pRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pRight.BackColor = Color.FromArgb(255, 192, 128);
            pRight.Location = new Point(0, 34);
            pRight.Name = "pRight";
            pRight.Size = new Size(125, 493);
            pRight.TabIndex = 8;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(784, 561);
            Controls.Add(pBot);
            Controls.Add(pTop);
            Controls.Add(pCentral);
            Controls.Add(pRight);
            MinimumSize = new Size(800, 600);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel pCentral;
        private Panel pTop;
        private Panel pBot;
        private Panel pRight;
    }
}