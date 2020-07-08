namespace GestaoEstoque
{
    partial class IncluirMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncluirMaterial));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbIncluirMaterial = new System.Windows.Forms.GroupBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.cmbTipoMaterial = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.gpbLocal = new System.Windows.Forms.GroupBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnAdicionarLocal = new System.Windows.Forms.Button();
            this.txtCodigoLocal = new System.Windows.Forms.TextBox();
            this.lblCodigoMaterial = new System.Windows.Forms.Label();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.lstboxLocais = new System.Windows.Forms.ListBox();
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            this.gpbIncluirMaterial.SuspendLayout();
            this.gpbLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Purple;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripVoltar,
            this.toolStripSeparator3,
            this.toolStripIncluir,
            this.toolStripSeparator1,
            this.toolStripConsultar,
            this.toolStripSeparator2});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(941, 42);
            this.toolStripMenu.TabIndex = 8;
            // 
            // toolStripIncluir
            // 
            this.toolStripIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripIncluir.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripIncluir.ForeColor = System.Drawing.Color.White;
            this.toolStripIncluir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripIncluir.Image")));
            this.toolStripIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripIncluir.Name = "toolStripIncluir";
            this.toolStripIncluir.Padding = new System.Windows.Forms.Padding(50, 10, 40, 0);
            this.toolStripIncluir.Size = new System.Drawing.Size(172, 39);
            this.toolStripIncluir.Text = "Incluir";
            this.toolStripIncluir.Click += new System.EventHandler(this.toolStripIncluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripConsultar
            // 
            this.toolStripConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripConsultar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripConsultar.ForeColor = System.Drawing.Color.White;
            this.toolStripConsultar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripConsultar.Image")));
            this.toolStripConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripConsultar.Name = "toolStripConsultar";
            this.toolStripConsultar.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripConsultar.Size = new System.Drawing.Size(167, 39);
            this.toolStripConsultar.Text = "Consultar";
            this.toolStripConsultar.Click += new System.EventHandler(this.toolStripConsultar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // gpbIncluirMaterial
            // 
            this.gpbIncluirMaterial.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluirMaterial.Controls.Add(this.lblUnidade);
            this.gpbIncluirMaterial.Controls.Add(this.cmbUnidade);
            this.gpbIncluirMaterial.Controls.Add(this.cmbTipoMaterial);
            this.gpbIncluirMaterial.Controls.Add(this.txtNome);
            this.gpbIncluirMaterial.Controls.Add(this.lblTipo);
            this.gpbIncluirMaterial.Controls.Add(this.lblNome);
            this.gpbIncluirMaterial.Location = new System.Drawing.Point(51, 89);
            this.gpbIncluirMaterial.Name = "gpbIncluirMaterial";
            this.gpbIncluirMaterial.Size = new System.Drawing.Size(460, 174);
            this.gpbIncluirMaterial.TabIndex = 7;
            this.gpbIncluirMaterial.TabStop = false;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.BackColor = System.Drawing.Color.Gray;
            this.lblUnidade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(33, 122);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Padding = new System.Windows.Forms.Padding(45, 5, 44, 5);
            this.lblUnidade.Size = new System.Drawing.Size(164, 28);
            this.lblUnidade.TabIndex = 13;
            this.lblUnidade.Text = "Unidade";
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(213, 122);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(212, 26);
            this.cmbUnidade.TabIndex = 7;
            // 
            // cmbTipoMaterial
            // 
            this.cmbTipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMaterial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMaterial.FormattingEnabled = true;
            this.cmbTipoMaterial.Location = new System.Drawing.Point(213, 81);
            this.cmbTipoMaterial.Name = "cmbTipoMaterial";
            this.cmbTipoMaterial.Size = new System.Drawing.Size(212, 26);
            this.cmbTipoMaterial.TabIndex = 2;
            this.cmbTipoMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipoMaterial_KeyDown);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(213, 39);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 27);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Gray;
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(33, 81);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Padding = new System.Windows.Forms.Padding(60, 5, 61, 5);
            this.lblTipo.Size = new System.Drawing.Size(164, 28);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Gray;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(33, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(55, 5, 54, 5);
            this.lblNome.Size = new System.Drawing.Size(164, 28);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(495, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 32);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(312, 412);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(154, 32);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // gpbLocal
            // 
            this.gpbLocal.BackColor = System.Drawing.Color.DimGray;
            this.gpbLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbLocal.Controls.Add(this.btnAjuda);
            this.gpbLocal.Controls.Add(this.btnAdicionarLocal);
            this.gpbLocal.Controls.Add(this.txtCodigoLocal);
            this.gpbLocal.Controls.Add(this.lblCodigoMaterial);
            this.gpbLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbLocal.Location = new System.Drawing.Point(51, 269);
            this.gpbLocal.Name = "gpbLocal";
            this.gpbLocal.Size = new System.Drawing.Size(460, 100);
            this.gpbLocal.TabIndex = 22;
            this.gpbLocal.TabStop = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Black;
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjuda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.White;
            this.btnAjuda.Location = new System.Drawing.Point(399, 19);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAjuda.Size = new System.Drawing.Size(26, 26);
            this.btnAjuda.TabIndex = 33;
            this.btnAjuda.Text = "? ";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnAdicionarLocal
            // 
            this.btnAdicionarLocal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarLocal.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarLocal.Location = new System.Drawing.Point(167, 58);
            this.btnAdicionarLocal.Name = "btnAdicionarLocal";
            this.btnAdicionarLocal.Size = new System.Drawing.Size(138, 30);
            this.btnAdicionarLocal.TabIndex = 7;
            this.btnAdicionarLocal.Text = "Adicionar Local";
            this.btnAdicionarLocal.UseVisualStyleBackColor = false;
            this.btnAdicionarLocal.Click += new System.EventHandler(this.btnAdicionarLocal_Click);
            // 
            // txtCodigoLocal
            // 
            this.txtCodigoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLocal.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigoLocal.Location = new System.Drawing.Point(213, 19);
            this.txtCodigoLocal.Name = "txtCodigoLocal";
            this.txtCodigoLocal.Size = new System.Drawing.Size(174, 26);
            this.txtCodigoLocal.TabIndex = 6;
            this.txtCodigoLocal.Text = "  F1 para consultar";
            this.txtCodigoLocal.Enter += new System.EventHandler(this.txtCodigoLocal_Enter);
            this.txtCodigoLocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoLocal_KeyDown);
            this.txtCodigoLocal.Leave += new System.EventHandler(this.txtCodigoLocal_Leave);
            // 
            // lblCodigoMaterial
            // 
            this.lblCodigoMaterial.AutoSize = true;
            this.lblCodigoMaterial.BackColor = System.Drawing.Color.Gray;
            this.lblCodigoMaterial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMaterial.Location = new System.Drawing.Point(33, 16);
            this.lblCodigoMaterial.Name = "lblCodigoMaterial";
            this.lblCodigoMaterial.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblCodigoMaterial.Size = new System.Drawing.Size(164, 28);
            this.lblCodigoMaterial.TabIndex = 19;
            this.lblCodigoMaterial.Text = "Codigo do local";
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.BackColor = System.Drawing.Color.Transparent;
            this.lblLegenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.ForeColor = System.Drawing.Color.White;
            this.lblLegenda.Location = new System.Drawing.Point(551, 73);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(350, 18);
            this.lblLegenda.TabIndex = 25;
            this.lblLegenda.Text = "Codigo     Nome                   Quantidade";
            // 
            // btnLixeira
            // 
            this.btnLixeira.BackgroundImage = global::GestaoEstoque.Properties.Resources.Lixeira;
            this.btnLixeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLixeira.Location = new System.Drawing.Point(717, 375);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(40, 37);
            this.btnLixeira.TabIndex = 23;
            this.btnLixeira.UseVisualStyleBackColor = true;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // lstboxLocais
            // 
            this.lstboxLocais.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxLocais.FormattingEnabled = true;
            this.lstboxLocais.ItemHeight = 16;
            this.lstboxLocais.Location = new System.Drawing.Point(550, 93);
            this.lstboxLocais.Name = "lstboxLocais";
            this.lstboxLocais.Size = new System.Drawing.Size(363, 276);
            this.lstboxLocais.TabIndex = 24;
            // 
            // toolStripVoltar
            // 
            this.toolStripVoltar.BackgroundImage = global::GestaoEstoque.Properties.Resources.Seta_Esquerda;
            this.toolStripVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripVoltar.Image = global::GestaoEstoque.Properties.Resources.Seta_Esquerda;
            this.toolStripVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripVoltar.Name = "toolStripVoltar";
            this.toolStripVoltar.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.toolStripVoltar.Size = new System.Drawing.Size(100, 39);
            this.toolStripVoltar.Text = "toolStripButton1";
            this.toolStripVoltar.Click += new System.EventHandler(this.toolStripVoltar_Click);
            // 
            // IncluirMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.btnLixeira);
            this.Controls.Add(this.lstboxLocais);
            this.Controls.Add(this.gpbLocal);
            this.Controls.Add(this.gpbIncluirMaterial);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncluirMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Incluir Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncluirMaterial_FormClosing);
            this.Load += new System.EventHandler(this.IncluirMaterial_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbIncluirMaterial.ResumeLayout(false);
            this.gpbIncluirMaterial.PerformLayout();
            this.gpbLocal.ResumeLayout(false);
            this.gpbLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox gpbIncluirMaterial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ComboBox cmbTipoMaterial;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.GroupBox gpbLocal;
        private System.Windows.Forms.Button btnAdicionarLocal;
        private System.Windows.Forms.TextBox txtCodigoLocal;
        private System.Windows.Forms.Label lblCodigoMaterial;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.Button btnLixeira;
        private System.Windows.Forms.ListBox lstboxLocais;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.ToolStripButton toolStripVoltar;
    }
}