namespace Estoque.Telas_Usuario
{
    partial class FrmCadastrarSetorCargo
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
            tab = new TableLayoutPanel();
            btnCargo = new Button();
            btnSetor = new Button();
            tblPrincipal = new TableLayoutPanel();
            pnCentral = new Panel();
            tab.SuspendLayout();
            tblPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // tab
            // 
            tab.BackColor = Color.FromArgb(32, 46, 56);
            tab.ColumnCount = 3;
            tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tab.Controls.Add(btnCargo, 1, 0);
            tab.Controls.Add(btnSetor, 0, 0);
            tab.Dock = DockStyle.Fill;
            tab.Location = new Point(0, 0);
            tab.Margin = new Padding(0);
            tab.Name = "tab";
            tab.RowCount = 1;
            tab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tab.Size = new Size(496, 45);
            tab.TabIndex = 0;
            // 
            // btnCargo
            // 
            btnCargo.Cursor = Cursors.Hand;
            btnCargo.Dock = DockStyle.Fill;
            btnCargo.FlatAppearance.BorderSize = 0;
            btnCargo.FlatStyle = FlatStyle.Flat;
            btnCargo.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargo.ForeColor = Color.White;
            btnCargo.Location = new Point(165, 0);
            btnCargo.Margin = new Padding(0);
            btnCargo.Name = "btnCargo";
            btnCargo.Size = new Size(165, 45);
            btnCargo.TabIndex = 1;
            btnCargo.Text = "Cargo";
            btnCargo.UseVisualStyleBackColor = true;
            btnCargo.Click += btnCargo_Click;
            // 
            // btnSetor
            // 
            btnSetor.Cursor = Cursors.Hand;
            btnSetor.Dock = DockStyle.Fill;
            btnSetor.FlatAppearance.BorderSize = 0;
            btnSetor.FlatStyle = FlatStyle.Flat;
            btnSetor.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetor.ForeColor = Color.White;
            btnSetor.Location = new Point(0, 0);
            btnSetor.Margin = new Padding(0);
            btnSetor.Name = "btnSetor";
            btnSetor.Size = new Size(165, 45);
            btnSetor.TabIndex = 0;
            btnSetor.Text = "Setor";
            btnSetor.UseVisualStyleBackColor = true;
            btnSetor.Click += btnSetor_Click;
            // 
            // tblPrincipal
            // 
            tblPrincipal.ColumnCount = 1;
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPrincipal.Controls.Add(tab, 0, 0);
            tblPrincipal.Controls.Add(pnCentral, 0, 1);
            tblPrincipal.Dock = DockStyle.Fill;
            tblPrincipal.Location = new Point(0, 0);
            tblPrincipal.Name = "tblPrincipal";
            tblPrincipal.RowCount = 2;
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPrincipal.Size = new Size(496, 473);
            tblPrincipal.TabIndex = 1;
            // 
            // pnCentral
            // 
            pnCentral.Dock = DockStyle.Fill;
            pnCentral.Location = new Point(0, 45);
            pnCentral.Margin = new Padding(0);
            pnCentral.Name = "pnCentral";
            pnCentral.Size = new Size(496, 428);
            pnCentral.TabIndex = 1;
            // 
            // FrmCadastrarSetorCargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            ClientSize = new Size(496, 473);
            Controls.Add(tblPrincipal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(512, 512);
            MinimizeBox = false;
            MinimumSize = new Size(512, 512);
            Name = "FrmCadastrarSetorCargo";
            Text = "Cadastrar Usuário";
            FormClosed += FrmCadastrarUsuario_FormClosed;
            Load += FrmCadastrarUsuario_Load;
            tab.ResumeLayout(false);
            tblPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tab;
        private TableLayoutPanel tblPrincipal;
        private Button btnCargo;
        private Button btnSetor;
        private Panel pnCentral;
    }
}