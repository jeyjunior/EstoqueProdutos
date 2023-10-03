namespace Estoque.Telas_Mensagens
{
    partial class FrmMensagem
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
            tlpCentral = new TableLayoutPanel();
            pTopR = new Panel();
            pTopM = new Panel();
            lblTitulo = new Label();
            tblBotoes = new TableLayoutPanel();
            btnAfirmacao = new Button();
            btnNegacao = new Button();
            pTopL = new Panel();
            lblMensagem = new Label();
            tlpCentral.SuspendLayout();
            pTopM.SuspendLayout();
            tblBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.FromArgb(80, 90, 100);
            tlpCentral.ColumnCount = 3;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpCentral.Controls.Add(pTopR, 2, 0);
            tlpCentral.Controls.Add(pTopM, 1, 0);
            tlpCentral.Controls.Add(tblBotoes, 1, 2);
            tlpCentral.Controls.Add(pTopL, 0, 0);
            tlpCentral.Controls.Add(lblMensagem, 1, 1);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(1, 1);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 4;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.Size = new Size(398, 198);
            tlpCentral.TabIndex = 2;
            // 
            // pTopR
            // 
            pTopR.BackColor = Color.FromArgb(255, 255, 132);
            pTopR.Dock = DockStyle.Fill;
            pTopR.Location = new Point(383, 0);
            pTopR.Margin = new Padding(0);
            pTopR.Name = "pTopR";
            pTopR.Size = new Size(15, 30);
            pTopR.TabIndex = 7;
            // 
            // pTopM
            // 
            pTopM.BackColor = Color.FromArgb(81, 140, 173);
            pTopM.Controls.Add(lblTitulo);
            pTopM.Dock = DockStyle.Fill;
            pTopM.Location = new Point(15, 0);
            pTopM.Margin = new Padding(0);
            pTopM.Name = "pTopM";
            pTopM.Size = new Size(368, 30);
            pTopM.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(0, 0, 0, 5);
            lblTitulo.Size = new Size(368, 30);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Título";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblBotoes
            // 
            tblBotoes.ColumnCount = 4;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBotoes.Controls.Add(btnAfirmacao, 0, 0);
            tblBotoes.Controls.Add(btnNegacao, 2, 0);
            tblBotoes.Dock = DockStyle.Fill;
            tblBotoes.Location = new Point(15, 148);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(368, 35);
            tblBotoes.TabIndex = 5;
            // 
            // btnAfirmacao
            // 
            btnAfirmacao.Dock = DockStyle.Fill;
            btnAfirmacao.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAfirmacao.ForeColor = Color.FromArgb(66, 142, 79);
            btnAfirmacao.Location = new Point(278, 0);
            btnAfirmacao.Margin = new Padding(0);
            btnAfirmacao.Name = "btnAfirmacao";
            btnAfirmacao.Size = new Size(90, 35);
            btnAfirmacao.TabIndex = 0;
            btnAfirmacao.Text = "Sim";
            btnAfirmacao.UseVisualStyleBackColor = true;
            // 
            // btnNegacao
            // 
            btnNegacao.Dock = DockStyle.Fill;
            btnNegacao.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNegacao.ForeColor = Color.FromArgb(255, 88, 88);
            btnNegacao.Location = new Point(183, 0);
            btnNegacao.Margin = new Padding(0);
            btnNegacao.Name = "btnNegacao";
            btnNegacao.Size = new Size(90, 35);
            btnNegacao.TabIndex = 1;
            btnNegacao.Text = "Não";
            btnNegacao.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNegacao.UseVisualStyleBackColor = true;
            // 
            // pTopL
            // 
            pTopL.BackColor = Color.FromArgb(255, 255, 132);
            pTopL.Dock = DockStyle.Fill;
            pTopL.Location = new Point(0, 0);
            pTopL.Margin = new Padding(0);
            pTopL.Name = "pTopL";
            pTopL.Size = new Size(15, 30);
            pTopL.TabIndex = 6;
            // 
            // lblMensagem
            // 
            lblMensagem.Dock = DockStyle.Fill;
            lblMensagem.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensagem.ForeColor = SystemColors.ControlLightLight;
            lblMensagem.Location = new Point(15, 30);
            lblMensagem.Margin = new Padding(0);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Padding = new Padding(10);
            lblMensagem.Size = new Size(368, 118);
            lblMensagem.TabIndex = 9;
            lblMensagem.Text = "Mensagem: ";
            // 
            // FrmMensagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(400, 200);
            Controls.Add(tlpCentral);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMensagem";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMensagem";
            tlpCentral.ResumeLayout(false);
            pTopM.ResumeLayout(false);
            tblBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCentral;
        private Panel pTopR;
        private Panel pTopM;
        private Label lblTitulo;
        private TableLayoutPanel tblBotoes;
        private Button btnAfirmacao;
        private Button btnNegacao;
        private Panel pTopL;
        private Label lblMensagem;
    }
}