namespace Estoque.Telas_Mensagens
{
    partial class UCAlertas
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
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.Dock = DockStyle.Fill;
            lblMensagem.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensagem.ForeColor = Color.Black;
            lblMensagem.Location = new Point(0, 0);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Padding = new Padding(12, 0, 12, 0);
            lblMensagem.Size = new Size(400, 50);
            lblMensagem.TabIndex = 0;
            lblMensagem.Text = "Esta é uma mensagem de teste apenas para validar o tamanho do campo";
            lblMensagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCAlertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblMensagem);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Name = "UCAlertas";
            Size = new Size(400, 50);
            Load += UCFeedback_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblMensagem;
    }
}
