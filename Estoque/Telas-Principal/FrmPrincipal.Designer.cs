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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pCentral
            // 
            pCentral.BackColor = Color.MediumSeaGreen;
            pCentral.Dock = DockStyle.Fill;
            pCentral.Location = new Point(131, 0);
            pCentral.Margin = new Padding(0);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(653, 498);
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
            pDireita.Size = new Size(131, 498);
            pDireita.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.7257824F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.2742157F));
            tableLayoutPanel1.Controls.Add(pCentral, 1, 0);
            tableLayoutPanel1.Controls.Add(pDireita, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 36);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(784, 498);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pTop, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(pBot, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.52753067F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8099442F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.662522F));
            tableLayoutPanel2.Size = new Size(784, 561);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel2);
            MinimumSize = new Size(800, 600);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            Resize += FrmPrincipal_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pCentral;
        private Panel pTop;
        private Panel pBot;
        private Panel pDireita;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}