namespace EstoqueProdutos
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProdutos = new Button();
            SuspendLayout();
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(398, 560);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(108, 79);
            btnProdutos.TabIndex = 0;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnProdutos);
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProdutos;
    }
}