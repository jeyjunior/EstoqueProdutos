namespace Estoque.Telas_Mensagens
{
    partial class UCMensagem
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
            tlpCentral = new TableLayoutPanel();
            tblBotoes = new TableLayoutPanel();
            btnAfirmacao = new Button();
            btnNegacao = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblTitulo = new Label();
            lblMensagem = new Label();
            tlpCentral.SuspendLayout();
            tblBotoes.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCentral
            // 
            tlpCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCentral.BackColor = Color.FromArgb(80, 90, 100);
            tlpCentral.ColumnCount = 3;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpCentral.Controls.Add(panel3, 2, 0);
            tlpCentral.Controls.Add(panel2, 1, 0);
            tlpCentral.Controls.Add(tblBotoes, 1, 2);
            tlpCentral.Controls.Add(panel1, 0, 0);
            tlpCentral.Controls.Add(lblMensagem, 1, 1);
            tlpCentral.Location = new Point(5, 5);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 4;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.Size = new Size(390, 190);
            tlpCentral.TabIndex = 0;
            tlpCentral.Paint += tableLayoutPanel1_Paint;
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
            tblBotoes.Location = new Point(15, 140);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(360, 35);
            tblBotoes.TabIndex = 5;
            // 
            // btnAfirmacao
            // 
            btnAfirmacao.Dock = DockStyle.Fill;
            btnAfirmacao.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAfirmacao.ForeColor = Color.FromArgb(66, 142, 79);
            btnAfirmacao.Location = new Point(270, 0);
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
            btnNegacao.Location = new Point(175, 0);
            btnNegacao.Margin = new Padding(0);
            btnNegacao.Name = "btnNegacao";
            btnNegacao.Size = new Size(90, 35);
            btnNegacao.TabIndex = 1;
            btnNegacao.Text = "Não";
            btnNegacao.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNegacao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 23, 28);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(15, 30);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 23, 28);
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(15, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 30);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 23, 28);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(375, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 30);
            panel3.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(0, 0, 0, 5);
            lblTitulo.Size = new Size(360, 30);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Título";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
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
            lblMensagem.Size = new Size(360, 110);
            lblMensagem.TabIndex = 9;
            lblMensagem.Text = "Mensagem: ";
            // 
            // UCMensagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 23, 28);
            Controls.Add(tlpCentral);
            Margin = new Padding(0);
            Name = "UCMensagem";
            Size = new Size(400, 200);
            tlpCentral.ResumeLayout(false);
            tblBotoes.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tblBotoes;
        private Button btnAfirmacao;
        private Button btnNegacao;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label lblTitulo;
        private Label lblMensagem;
    }
}
