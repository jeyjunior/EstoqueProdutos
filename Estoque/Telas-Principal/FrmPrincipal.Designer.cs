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
            pDireita = new Panel();
            tlpCentral = new TableLayoutPanel();
            tblPrincipal = new TableLayoutPanel();
            tlpCentral.SuspendLayout();
            tblPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pCentral
            // 
            pCentral.BackColor = Color.MediumSeaGreen;
            pCentral.Dock = DockStyle.Fill;
            pCentral.Location = new Point(160, 0);
            pCentral.Margin = new Padding(0);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(624, 498);
            pCentral.TabIndex = 3;
            // 
            // pTop
            // 
            pTop.BackColor = Color.FromArgb(255, 128, 128);
            pTop.Dock = DockStyle.Fill;
            pTop.Location = new Point(0, 0);
            pTop.Margin = new Padding(0);
            pTop.Name = "pTop";
            pTop.Size = new Size(784, 36);
            pTop.TabIndex = 6;
            // 
            // pBot
            // 
            pBot.BackColor = Color.FromArgb(255, 128, 128);
            pBot.Dock = DockStyle.Fill;
            pBot.Location = new Point(0, 534);
            pBot.Margin = new Padding(0);
            pBot.Name = "pBot";
            pBot.Size = new Size(784, 27);
            pBot.TabIndex = 7;
            // 
            // pDireita
            // 
            pDireita.BackColor = Color.FromArgb(255, 192, 128);
            pDireita.Dock = DockStyle.Fill;
            pDireita.Location = new Point(0, 0);
            pDireita.Margin = new Padding(0);
            pDireita.Name = "pDireita";
            pDireita.Size = new Size(160, 498);
            pDireita.TabIndex = 8;
            // 
            // tlpCentral
            // 
            tlpCentral.ColumnCount = 2;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.Controls.Add(pCentral, 1, 0);
            tlpCentral.Controls.Add(pDireita, 0, 0);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(0, 36);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 1;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentral.Size = new Size(784, 498);
            tlpCentral.TabIndex = 9;
            // 
            // tblPrincipal
            // 
            tblPrincipal.ColumnCount = 1;
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPrincipal.Controls.Add(pTop, 0, 0);
            tblPrincipal.Controls.Add(tlpCentral, 0, 1);
            tblPrincipal.Controls.Add(pBot, 0, 2);
            tblPrincipal.Dock = DockStyle.Fill;
            tblPrincipal.Location = new Point(0, 0);
            tblPrincipal.Margin = new Padding(0);
            tblPrincipal.Name = "tblPrincipal";
            tblPrincipal.RowCount = 3;
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 6.52753067F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8099442F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 4.662522F));
            tblPrincipal.Size = new Size(784, 561);
            tblPrincipal.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(784, 561);
            Controls.Add(tblPrincipal);
            MinimumSize = new Size(800, 600);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            Resize += FrmPrincipal_Resize;
            tlpCentral.ResumeLayout(false);
            tblPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pCentral;
        private Panel pTop;
        private Panel pBot;
        private Panel pDireita;
        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tblPrincipal;
    }
}