namespace Estoque.Telas_Produto
{
    partial class FrmConfigurarColunas
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
            lblTitulo = new Label();
            tlpColunas = new TableLayoutPanel();
            pcbEmbalagem = new PictureBox();
            pcbMarca = new PictureBox();
            pcbCategoria = new PictureBox();
            pcbFormato = new PictureBox();
            pcbComprimento = new PictureBox();
            pcbLargura = new PictureBox();
            lblNome = new Label();
            lblDescricao = new Label();
            lblVolume = new Label();
            lblAltura = new Label();
            lblLargura = new Label();
            lblMedida = new Label();
            lblEmbalagem = new Label();
            lblMarca = new Label();
            lblCategoria = new Label();
            lblFormato = new Label();
            lblComprimento = new Label();
            pcbNome = new PictureBox();
            pcbDescricao = new PictureBox();
            pcbVolume = new PictureBox();
            pcbUnMedida = new PictureBox();
            pcbAltura = new PictureBox();
            tblBotoes = new TableLayoutPanel();
            btnSalvar = new Button();
            btnFechar = new Button();
            tlpCentral.SuspendLayout();
            tlpColunas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbEmbalagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMarca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFormato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbComprimento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLargura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbNome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDescricao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUnMedida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAltura).BeginInit();
            tblBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.FromArgb(16, 23, 28);
            tlpCentral.ColumnCount = 1;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.Controls.Add(lblTitulo, 0, 0);
            tlpCentral.Controls.Add(tlpColunas, 0, 1);
            tlpCentral.Controls.Add(tblBotoes, 0, 3);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(3, 3);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 5;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.Size = new Size(220, 499);
            tlpCentral.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(220, 45);
            lblTitulo.TabIndex = 23;
            lblTitulo.Text = "Exibir colunas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
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
            tlpColunas.Controls.Add(lblNome, 3, 0);
            tlpColunas.Controls.Add(lblDescricao, 3, 1);
            tlpColunas.Controls.Add(lblVolume, 3, 2);
            tlpColunas.Controls.Add(lblAltura, 3, 4);
            tlpColunas.Controls.Add(lblLargura, 3, 5);
            tlpColunas.Controls.Add(lblMedida, 3, 3);
            tlpColunas.Controls.Add(lblEmbalagem, 3, 10);
            tlpColunas.Controls.Add(lblMarca, 3, 9);
            tlpColunas.Controls.Add(lblCategoria, 3, 8);
            tlpColunas.Controls.Add(lblFormato, 3, 7);
            tlpColunas.Controls.Add(lblComprimento, 3, 6);
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
            tlpColunas.Size = new Size(220, 389);
            tlpColunas.TabIndex = 0;
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
            pcbEmbalagem.Click += pcb_Click;
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
            pcbMarca.Click += pcb_Click;
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
            pcbCategoria.Click += pcb_Click;
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
            pcbFormato.Click += pcb_Click;
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
            pcbComprimento.Click += pcb_Click;
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
            pcbLargura.Click += pcb_Click;
            // 
            // lblNome
            // 
            lblNome.Dock = DockStyle.Fill;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ControlLightLight;
            lblNome.Location = new Point(55, 0);
            lblNome.Margin = new Padding(0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(150, 35);
            lblNome.TabIndex = 24;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescricao
            // 
            lblDescricao.Dock = DockStyle.Fill;
            lblDescricao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescricao.ForeColor = SystemColors.ControlLightLight;
            lblDescricao.Location = new Point(55, 35);
            lblDescricao.Margin = new Padding(0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(150, 35);
            lblDescricao.TabIndex = 26;
            lblDescricao.Text = "Descrição";
            lblDescricao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVolume
            // 
            lblVolume.Dock = DockStyle.Fill;
            lblVolume.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVolume.ForeColor = SystemColors.ControlLightLight;
            lblVolume.Location = new Point(55, 70);
            lblVolume.Margin = new Padding(0);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(150, 35);
            lblVolume.TabIndex = 25;
            lblVolume.Text = "Volume";
            lblVolume.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAltura
            // 
            lblAltura.Dock = DockStyle.Fill;
            lblAltura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAltura.ForeColor = SystemColors.ControlLightLight;
            lblAltura.Location = new Point(55, 140);
            lblAltura.Margin = new Padding(0);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(150, 35);
            lblAltura.TabIndex = 27;
            lblAltura.Text = "Altura";
            lblAltura.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLargura
            // 
            lblLargura.Dock = DockStyle.Fill;
            lblLargura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLargura.ForeColor = SystemColors.ControlLightLight;
            lblLargura.Location = new Point(55, 175);
            lblLargura.Margin = new Padding(0);
            lblLargura.Name = "lblLargura";
            lblLargura.Size = new Size(150, 35);
            lblLargura.TabIndex = 30;
            lblLargura.Text = "Largura";
            lblLargura.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMedida
            // 
            lblMedida.Dock = DockStyle.Fill;
            lblMedida.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedida.ForeColor = SystemColors.ControlLightLight;
            lblMedida.Location = new Point(55, 105);
            lblMedida.Margin = new Padding(0);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(150, 35);
            lblMedida.TabIndex = 29;
            lblMedida.Text = "Un. de Medida";
            lblMedida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmbalagem
            // 
            lblEmbalagem.Dock = DockStyle.Fill;
            lblEmbalagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmbalagem.ForeColor = SystemColors.ControlLightLight;
            lblEmbalagem.Location = new Point(55, 350);
            lblEmbalagem.Margin = new Padding(0);
            lblEmbalagem.Name = "lblEmbalagem";
            lblEmbalagem.Size = new Size(150, 35);
            lblEmbalagem.TabIndex = 32;
            lblEmbalagem.Text = "Embalagem";
            lblEmbalagem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMarca
            // 
            lblMarca.Dock = DockStyle.Fill;
            lblMarca.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.ForeColor = SystemColors.ControlLightLight;
            lblMarca.Location = new Point(55, 315);
            lblMarca.Margin = new Padding(0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(150, 35);
            lblMarca.TabIndex = 28;
            lblMarca.Text = "Marca";
            lblMarca.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategoria
            // 
            lblCategoria.Dock = DockStyle.Fill;
            lblCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.ForeColor = SystemColors.ControlLightLight;
            lblCategoria.Location = new Point(55, 280);
            lblCategoria.Margin = new Padding(0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(150, 35);
            lblCategoria.TabIndex = 31;
            lblCategoria.Text = "Categoria";
            lblCategoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFormato
            // 
            lblFormato.Dock = DockStyle.Fill;
            lblFormato.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormato.ForeColor = SystemColors.ControlLightLight;
            lblFormato.Location = new Point(55, 245);
            lblFormato.Margin = new Padding(0);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(150, 35);
            lblFormato.TabIndex = 34;
            lblFormato.Text = "Formato";
            lblFormato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblComprimento
            // 
            lblComprimento.Dock = DockStyle.Fill;
            lblComprimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComprimento.ForeColor = SystemColors.ControlLightLight;
            lblComprimento.Location = new Point(55, 210);
            lblComprimento.Margin = new Padding(0);
            lblComprimento.Name = "lblComprimento";
            lblComprimento.Size = new Size(150, 35);
            lblComprimento.TabIndex = 33;
            lblComprimento.Text = "Comprimento";
            lblComprimento.TextAlign = ContentAlignment.MiddleLeft;
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
            pcbNome.Click += pcb_Click;
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
            pcbDescricao.Click += pcb_Click;
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
            pcbVolume.Click += pcb_Click;
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
            pcbUnMedida.Click += pcb_Click;
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
            pcbAltura.Click += pcb_Click;
            // 
            // tblBotoes
            // 
            tblBotoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblBotoes.BackColor = Color.FromArgb(16, 23, 28);
            tblBotoes.ColumnCount = 5;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblBotoes.Controls.Add(btnSalvar, 1, 0);
            tblBotoes.Controls.Add(btnFechar, 3, 0);
            tblBotoes.Location = new Point(0, 449);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(220, 35);
            tblBotoes.TabIndex = 24;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Fill;
            btnSalvar.ForeColor = Color.FromArgb(66, 142, 79);
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(115, 0);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(10, 0, 0, 0);
            btnSalvar.Size = new Size(90, 35);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Dock = DockStyle.Fill;
            btnFechar.ForeColor = Color.FromArgb(178, 88, 88);
            btnFechar.Image = Properties.Resources.cancel_outline_1;
            btnFechar.Location = new Point(15, 0);
            btnFechar.Margin = new Padding(0);
            btnFechar.Name = "btnFechar";
            btnFechar.Padding = new Padding(5, 0, 0, 0);
            btnFechar.Size = new Size(90, 35);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnLimpar_Click;
            // 
            // FrmConfigurarColunas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 23, 28);
            ClientSize = new Size(226, 505);
            Controls.Add(tlpCentral);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(200, 490);
            Name = "FrmConfigurarColunas";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmConfigurarColunas_Load;
            tlpCentral.ResumeLayout(false);
            tlpColunas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbEmbalagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMarca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFormato).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbComprimento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLargura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbNome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDescricao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUnMedida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAltura).EndInit();
            tblBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tlpColunas;
        private Label lblTitulo;
        private Label lblNome;
        private Label lblDescricao;
        private Label lblVolume;
        private Label lblAltura;
        private Label lblLargura;
        private Label lblComprimento;
        private Label lblFormato;
        private Label lblCategoria;
        private Label lblMarca;
        private Label lblMedida;
        private PictureBox pcbLargura;
        private PictureBox pcbNome;
        private PictureBox pcbDescricao;
        private PictureBox pcbVolume;
        private PictureBox pcbUnMedida;
        private PictureBox pcbAltura;
        private PictureBox pcbMarca;
        private PictureBox pcbCategoria;
        private PictureBox pcbFormato;
        private PictureBox pcbComprimento;
        private PictureBox pcbEmbalagem;
        private Label lblEmbalagem;
        private TableLayoutPanel tblBotoes;
        private Button btnSalvar;
        private Button btnFechar;
    }
}