namespace Estoque.Telas_Produto
{
    partial class FrmConfigurarGrid
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
            tlpColunas = new TableLayoutPanel();
            lblCategoria = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pcbNome = new PictureBox();
            pcbDescricao = new PictureBox();
            pcbVolume = new PictureBox();
            pcbUnMedida = new PictureBox();
            pcbAltura = new PictureBox();
            pcbLargura = new PictureBox();
            pcbComprimento = new PictureBox();
            pcbFormato = new PictureBox();
            pcbCategoria = new PictureBox();
            pcbMarca = new PictureBox();
            pcbEmbalagem = new PictureBox();
            tlpCentral.SuspendLayout();
            tlpColunas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDescricao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUnMedida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLargura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbComprimento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFormato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMarca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbEmbalagem).BeginInit();
            SuspendLayout();
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.FromArgb(16, 23, 28);
            tlpCentral.ColumnCount = 1;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.Controls.Add(lblCategoria, 0, 0);
            tlpCentral.Controls.Add(tlpColunas, 0, 1);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(0, 0);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 2;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.Size = new Size(205, 450);
            tlpCentral.TabIndex = 0;
            // 
            // tlpColunas
            // 
            tlpColunas.BackColor = Color.FromArgb(80, 90, 100);
            tlpColunas.ColumnCount = 5;
            tlpColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpColunas.Controls.Add(pcbEmbalagem, 1, 10);
            tlpColunas.Controls.Add(pcbMarca, 1, 9);
            tlpColunas.Controls.Add(pcbCategoria, 1, 8);
            tlpColunas.Controls.Add(pcbFormato, 1, 7);
            tlpColunas.Controls.Add(pcbComprimento, 1, 6);
            tlpColunas.Controls.Add(pcbLargura, 1, 5);
            tlpColunas.Controls.Add(label1, 3, 0);
            tlpColunas.Controls.Add(label3, 3, 1);
            tlpColunas.Controls.Add(label2, 3, 2);
            tlpColunas.Controls.Add(label4, 3, 4);
            tlpColunas.Controls.Add(label7, 3, 5);
            tlpColunas.Controls.Add(label6, 3, 3);
            tlpColunas.Controls.Add(label9, 3, 10);
            tlpColunas.Controls.Add(label5, 3, 9);
            tlpColunas.Controls.Add(label8, 3, 8);
            tlpColunas.Controls.Add(label11, 3, 7);
            tlpColunas.Controls.Add(label10, 3, 6);
            tlpColunas.Controls.Add(pcbNome, 1, 0);
            tlpColunas.Controls.Add(pcbDescricao, 1, 1);
            tlpColunas.Controls.Add(pcbVolume, 1, 2);
            tlpColunas.Controls.Add(pcbUnMedida, 1, 3);
            tlpColunas.Controls.Add(pcbAltura, 1, 4);
            tlpColunas.Dock = DockStyle.Fill;
            tlpColunas.Location = new Point(0, 45);
            tlpColunas.Margin = new Padding(0);
            tlpColunas.Name = "tlpColunas";
            tlpColunas.RowCount = 12;
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpColunas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpColunas.Size = new Size(205, 405);
            tlpColunas.TabIndex = 0;
            // 
            // lblCategoria
            // 
            lblCategoria.Dock = DockStyle.Fill;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.ForeColor = SystemColors.ControlLightLight;
            lblCategoria.Location = new Point(0, 0);
            lblCategoria.Margin = new Padding(0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Padding = new Padding(20, 0, 0, 0);
            lblCategoria.Size = new Size(205, 45);
            lblCategoria.TabIndex = 23;
            lblCategoria.Text = "Exibir colunas";
            lblCategoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(55, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(135, 35);
            label1.TabIndex = 24;
            label1.Text = "Nome";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(55, 70);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(135, 35);
            label2.TabIndex = 25;
            label2.Text = "Volume";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(55, 35);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(135, 35);
            label3.TabIndex = 26;
            label3.Text = "Descrição";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(55, 140);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(135, 35);
            label4.TabIndex = 27;
            label4.Text = "Altura";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(55, 315);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(135, 35);
            label5.TabIndex = 28;
            label5.Text = "Marca";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(55, 105);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(135, 35);
            label6.TabIndex = 29;
            label6.Text = "Un. de Medida";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(55, 175);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(135, 35);
            label7.TabIndex = 30;
            label7.Text = "Largura";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(55, 280);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(135, 35);
            label8.TabIndex = 31;
            label8.Text = "Categoria";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(55, 350);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(135, 35);
            label9.TabIndex = 32;
            label9.Text = "Embalagem";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(55, 210);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(135, 35);
            label10.TabIndex = 33;
            label10.Text = "Comprimento";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(55, 245);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(135, 35);
            label11.TabIndex = 34;
            label11.Text = "Formato";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pcbNome
            // 
            pcbNome.BackColor = Color.Transparent;
            pcbNome.Cursor = Cursors.Hand;
            pcbNome.Dock = DockStyle.Fill;
            pcbNome.Image = Properties.Resources.chk_uncheck_32x32;
            pcbNome.Location = new Point(25, 10);
            pcbNome.Margin = new Padding(10);
            pcbNome.Name = "pcbNome";
            pcbNome.Size = new Size(15, 15);
            pcbNome.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbNome.TabIndex = 35;
            pcbNome.TabStop = false;
            // 
            // pcbDescricao
            // 
            pcbDescricao.BackColor = Color.Transparent;
            pcbDescricao.Cursor = Cursors.Hand;
            pcbDescricao.Dock = DockStyle.Fill;
            pcbDescricao.Image = Properties.Resources.chk_uncheck_32x32;
            pcbDescricao.Location = new Point(25, 45);
            pcbDescricao.Margin = new Padding(10);
            pcbDescricao.Name = "pcbDescricao";
            pcbDescricao.Size = new Size(15, 15);
            pcbDescricao.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDescricao.TabIndex = 36;
            pcbDescricao.TabStop = false;
            // 
            // pcbVolume
            // 
            pcbVolume.BackColor = Color.Transparent;
            pcbVolume.Cursor = Cursors.Hand;
            pcbVolume.Dock = DockStyle.Fill;
            pcbVolume.Image = Properties.Resources.chk_uncheck_32x32;
            pcbVolume.Location = new Point(25, 80);
            pcbVolume.Margin = new Padding(10);
            pcbVolume.Name = "pcbVolume";
            pcbVolume.Size = new Size(15, 15);
            pcbVolume.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbVolume.TabIndex = 37;
            pcbVolume.TabStop = false;
            // 
            // pcbUnMedida
            // 
            pcbUnMedida.BackColor = Color.Transparent;
            pcbUnMedida.Cursor = Cursors.Hand;
            pcbUnMedida.Dock = DockStyle.Fill;
            pcbUnMedida.Image = Properties.Resources.chk_uncheck_32x32;
            pcbUnMedida.Location = new Point(25, 115);
            pcbUnMedida.Margin = new Padding(10);
            pcbUnMedida.Name = "pcbUnMedida";
            pcbUnMedida.Size = new Size(15, 15);
            pcbUnMedida.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUnMedida.TabIndex = 38;
            pcbUnMedida.TabStop = false;
            // 
            // pcbAltura
            // 
            pcbAltura.BackColor = Color.Transparent;
            pcbAltura.Cursor = Cursors.Hand;
            pcbAltura.Dock = DockStyle.Fill;
            pcbAltura.Image = Properties.Resources.chk_uncheck_32x32;
            pcbAltura.Location = new Point(25, 150);
            pcbAltura.Margin = new Padding(10);
            pcbAltura.Name = "pcbAltura";
            pcbAltura.Size = new Size(15, 15);
            pcbAltura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAltura.TabIndex = 39;
            pcbAltura.TabStop = false;
            // 
            // pcbLargura
            // 
            pcbLargura.BackColor = Color.Transparent;
            pcbLargura.Cursor = Cursors.Hand;
            pcbLargura.Dock = DockStyle.Fill;
            pcbLargura.Image = Properties.Resources.chk_uncheck_32x32;
            pcbLargura.Location = new Point(25, 185);
            pcbLargura.Margin = new Padding(10);
            pcbLargura.Name = "pcbLargura";
            pcbLargura.Size = new Size(15, 15);
            pcbLargura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLargura.TabIndex = 40;
            pcbLargura.TabStop = false;
            // 
            // pcbComprimento
            // 
            pcbComprimento.BackColor = Color.Transparent;
            pcbComprimento.Cursor = Cursors.Hand;
            pcbComprimento.Dock = DockStyle.Fill;
            pcbComprimento.Image = Properties.Resources.chk_uncheck_32x32;
            pcbComprimento.Location = new Point(25, 220);
            pcbComprimento.Margin = new Padding(10);
            pcbComprimento.Name = "pcbComprimento";
            pcbComprimento.Size = new Size(15, 15);
            pcbComprimento.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbComprimento.TabIndex = 41;
            pcbComprimento.TabStop = false;
            // 
            // pcbFormato
            // 
            pcbFormato.BackColor = Color.Transparent;
            pcbFormato.Cursor = Cursors.Hand;
            pcbFormato.Dock = DockStyle.Fill;
            pcbFormato.Image = Properties.Resources.chk_uncheck_32x32;
            pcbFormato.Location = new Point(25, 255);
            pcbFormato.Margin = new Padding(10);
            pcbFormato.Name = "pcbFormato";
            pcbFormato.Size = new Size(15, 15);
            pcbFormato.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFormato.TabIndex = 42;
            pcbFormato.TabStop = false;
            // 
            // pcbCategoria
            // 
            pcbCategoria.BackColor = Color.Transparent;
            pcbCategoria.Cursor = Cursors.Hand;
            pcbCategoria.Dock = DockStyle.Fill;
            pcbCategoria.Image = Properties.Resources.chk_uncheck_32x32;
            pcbCategoria.Location = new Point(25, 290);
            pcbCategoria.Margin = new Padding(10);
            pcbCategoria.Name = "pcbCategoria";
            pcbCategoria.Size = new Size(15, 15);
            pcbCategoria.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCategoria.TabIndex = 43;
            pcbCategoria.TabStop = false;
            // 
            // pcbMarca
            // 
            pcbMarca.BackColor = Color.Transparent;
            pcbMarca.Cursor = Cursors.Hand;
            pcbMarca.Dock = DockStyle.Fill;
            pcbMarca.Image = Properties.Resources.chk_uncheck_32x32;
            pcbMarca.Location = new Point(25, 325);
            pcbMarca.Margin = new Padding(10);
            pcbMarca.Name = "pcbMarca";
            pcbMarca.Size = new Size(15, 15);
            pcbMarca.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMarca.TabIndex = 44;
            pcbMarca.TabStop = false;
            // 
            // pcbEmbalagem
            // 
            pcbEmbalagem.BackColor = Color.Transparent;
            pcbEmbalagem.Cursor = Cursors.Hand;
            pcbEmbalagem.Dock = DockStyle.Fill;
            pcbEmbalagem.Image = Properties.Resources.chk_uncheck_32x32;
            pcbEmbalagem.Location = new Point(25, 360);
            pcbEmbalagem.Margin = new Padding(10);
            pcbEmbalagem.Name = "pcbEmbalagem";
            pcbEmbalagem.Size = new Size(15, 15);
            pcbEmbalagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbEmbalagem.TabIndex = 45;
            pcbEmbalagem.TabStop = false;
            // 
            // FrmConfigurarGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(205, 450);
            Controls.Add(tlpCentral);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConfigurarGrid";
            StartPosition = FormStartPosition.CenterScreen;
            tlpCentral.ResumeLayout(false);
            tlpColunas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbNome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDescricao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUnMedida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLargura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbComprimento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFormato).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMarca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbEmbalagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tlpColunas;
        private Label lblCategoria;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label8;
        private Label label5;
        private Label label9;
        private Label label6;
        private PictureBox pcbLargura;
        private PictureBox pcbNome;
        private PictureBox pcbDescricao;
        private PictureBox pcbVolume;
        private PictureBox pcbUnMedida;
        private PictureBox pcbAltura;
        private PictureBox pcbEmbalagem;
        private PictureBox pcbMarca;
        private PictureBox pcbCategoria;
        private PictureBox pcbFormato;
        private PictureBox pcbComprimento;
    }
}