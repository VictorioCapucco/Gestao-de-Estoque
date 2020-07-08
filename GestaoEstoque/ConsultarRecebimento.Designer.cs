namespace GestaoEstoque
{
    partial class ConsultarRecebimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarRecebimento));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbConsultar = new System.Windows.Forms.GroupBox();
            this.lblDataRecebimento = new System.Windows.Forms.Label();
            this.mskDataRecebimento = new System.Windows.Forms.MaskedTextBox();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.lstboxMateriais = new System.Windows.Forms.ListBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnConfirmarFornecedor = new System.Windows.Forms.Button();
            this.cmbRecebimento = new System.Windows.Forms.ComboBox();
            this.lblRecebimento = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.btnConfirmarLocal = new System.Windows.Forms.Button();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.gpbConsultar.SuspendLayout();
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
            this.toolStripMenu.TabIndex = 18;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
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
            // gpbConsultar
            // 
            this.gpbConsultar.BackColor = System.Drawing.Color.DimGray;
            this.gpbConsultar.Controls.Add(this.lblDataRecebimento);
            this.gpbConsultar.Controls.Add(this.mskDataRecebimento);
            this.gpbConsultar.Controls.Add(this.lblLegenda);
            this.gpbConsultar.Controls.Add(this.lstboxMateriais);
            this.gpbConsultar.Controls.Add(this.btnConsultar);
            this.gpbConsultar.Controls.Add(this.btnConfirmarFornecedor);
            this.gpbConsultar.Controls.Add(this.cmbRecebimento);
            this.gpbConsultar.Controls.Add(this.lblRecebimento);
            this.gpbConsultar.Controls.Add(this.cmbFornecedor);
            this.gpbConsultar.Controls.Add(this.lblFornecedor);
            this.gpbConsultar.Controls.Add(this.btnConfirmarLocal);
            this.gpbConsultar.Controls.Add(this.cmbLocal);
            this.gpbConsultar.Controls.Add(this.lblLocal);
            this.gpbConsultar.Controls.Add(this.btnCancelar);
            this.gpbConsultar.Location = new System.Drawing.Point(112, 55);
            this.gpbConsultar.Name = "gpbConsultar";
            this.gpbConsultar.Size = new System.Drawing.Size(717, 411);
            this.gpbConsultar.TabIndex = 19;
            this.gpbConsultar.TabStop = false;
            // 
            // lblDataRecebimento
            // 
            this.lblDataRecebimento.AutoSize = true;
            this.lblDataRecebimento.BackColor = System.Drawing.Color.Gray;
            this.lblDataRecebimento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRecebimento.Location = new System.Drawing.Point(133, 320);
            this.lblDataRecebimento.Name = "lblDataRecebimento";
            this.lblDataRecebimento.Padding = new System.Windows.Forms.Padding(17, 5, 16, 5);
            this.lblDataRecebimento.Size = new System.Drawing.Size(218, 28);
            this.lblDataRecebimento.TabIndex = 35;
            this.lblDataRecebimento.Text = "Data do Recebimento";
            this.lblDataRecebimento.Visible = false;
            // 
            // mskDataRecebimento
            // 
            this.mskDataRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataRecebimento.Location = new System.Drawing.Point(368, 320);
            this.mskDataRecebimento.Mask = "99/99/9999";
            this.mskDataRecebimento.Name = "mskDataRecebimento";
            this.mskDataRecebimento.Size = new System.Drawing.Size(86, 26);
            this.mskDataRecebimento.TabIndex = 34;
            this.mskDataRecebimento.Visible = false;
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.BackColor = System.Drawing.Color.Transparent;
            this.lblLegenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.ForeColor = System.Drawing.Color.White;
            this.lblLegenda.Location = new System.Drawing.Point(133, 147);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(380, 18);
            this.lblLegenda.TabIndex = 33;
            this.lblLegenda.Text = "Codigo     Nome                        Quantidade";
            this.lblLegenda.Visible = false;
            // 
            // lstboxMateriais
            // 
            this.lstboxMateriais.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxMateriais.FormattingEnabled = true;
            this.lstboxMateriais.ItemHeight = 16;
            this.lstboxMateriais.Location = new System.Drawing.Point(133, 167);
            this.lstboxMateriais.Name = "lstboxMateriais";
            this.lstboxMateriais.Size = new System.Drawing.Size(428, 148);
            this.lstboxMateriais.TabIndex = 32;
            this.lstboxMateriais.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(244, 147);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(210, 30);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "Consultar Recebimento";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Visible = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnConfirmarFornecedor
            // 
            this.btnConfirmarFornecedor.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarFornecedor.Location = new System.Drawing.Point(261, 112);
            this.btnConfirmarFornecedor.Name = "btnConfirmarFornecedor";
            this.btnConfirmarFornecedor.Size = new System.Drawing.Size(180, 30);
            this.btnConfirmarFornecedor.TabIndex = 21;
            this.btnConfirmarFornecedor.Text = "Confirmar Fornecedor";
            this.btnConfirmarFornecedor.UseVisualStyleBackColor = false;
            this.btnConfirmarFornecedor.Visible = false;
            this.btnConfirmarFornecedor.Click += new System.EventHandler(this.btnConfirmarFornecedor_Click);
            // 
            // cmbRecebimento
            // 
            this.cmbRecebimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecebimento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecebimento.FormattingEnabled = true;
            this.cmbRecebimento.Location = new System.Drawing.Point(346, 114);
            this.cmbRecebimento.Name = "cmbRecebimento";
            this.cmbRecebimento.Size = new System.Drawing.Size(212, 26);
            this.cmbRecebimento.TabIndex = 19;
            this.cmbRecebimento.Visible = false;
            // 
            // lblRecebimento
            // 
            this.lblRecebimento.AutoSize = true;
            this.lblRecebimento.BackColor = System.Drawing.Color.Gray;
            this.lblRecebimento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecebimento.Location = new System.Drawing.Point(130, 112);
            this.lblRecebimento.Name = "lblRecebimento";
            this.lblRecebimento.Padding = new System.Windows.Forms.Padding(41, 5, 42, 5);
            this.lblRecebimento.Size = new System.Drawing.Size(197, 28);
            this.lblRecebimento.TabIndex = 20;
            this.lblRecebimento.Text = "Recebimento";
            this.lblRecebimento.Visible = false;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(346, 77);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(212, 26);
            this.cmbFornecedor.TabIndex = 17;
            this.cmbFornecedor.Visible = false;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.BackColor = System.Drawing.Color.Gray;
            this.lblFornecedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(130, 75);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Padding = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.lblFornecedor.Size = new System.Drawing.Size(197, 28);
            this.lblFornecedor.TabIndex = 18;
            this.lblFornecedor.Text = "Fornecedor";
            this.lblFornecedor.Visible = false;
            // 
            // btnConfirmarLocal
            // 
            this.btnConfirmarLocal.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarLocal.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarLocal.Location = new System.Drawing.Point(261, 74);
            this.btnConfirmarLocal.Name = "btnConfirmarLocal";
            this.btnConfirmarLocal.Size = new System.Drawing.Size(180, 30);
            this.btnConfirmarLocal.TabIndex = 1;
            this.btnConfirmarLocal.Text = "Confirmar Local";
            this.btnConfirmarLocal.UseVisualStyleBackColor = false;
            this.btnConfirmarLocal.Click += new System.EventHandler(this.btnConfirmarLocal_Click);
            // 
            // cmbLocal
            // 
            this.cmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(346, 38);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(212, 26);
            this.cmbLocal.TabIndex = 0;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.BackColor = System.Drawing.Color.Gray;
            this.lblLocal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(130, 36);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Padding = new System.Windows.Forms.Padding(73, 5, 74, 5);
            this.lblLocal.Size = new System.Drawing.Size(197, 28);
            this.lblLocal.TabIndex = 14;
            this.lblLocal.Text = "Local";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(289, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 32);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ConsultarRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbConsultar);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConsultarRecebimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar Recebimento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarRecebimento_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarRecebimento_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbConsultar.ResumeLayout(false);
            this.gpbConsultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripVoltar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox gpbConsultar;
        private System.Windows.Forms.Button btnConfirmarLocal;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConfirmarFornecedor;
        private System.Windows.Forms.ComboBox cmbRecebimento;
        private System.Windows.Forms.Label lblRecebimento;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.ListBox lstboxMateriais;
        private System.Windows.Forms.Label lblDataRecebimento;
        private System.Windows.Forms.MaskedTextBox mskDataRecebimento;
    }
}