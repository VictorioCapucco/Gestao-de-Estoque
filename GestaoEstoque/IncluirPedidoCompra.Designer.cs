namespace GestaoEstoque
{
    partial class IncluirPedidoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncluirPedidoCompra));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbInformacoesPedidoCompra = new System.Windows.Forms.GroupBox();
            this.btnConfirmarFornecedorLocal = new System.Windows.Forms.Button();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.gpbMateriais = new System.Windows.Forms.GroupBox();
            this.btnAdicionarMaterial = new System.Windows.Forms.Button();
            this.txtCodigoMaterial = new System.Windows.Forms.TextBox();
            this.lblCodigoMaterial = new System.Windows.Forms.Label();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.lstboxMateriais = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluirPedidoCompra = new System.Windows.Forms.Button();
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            this.gpbInformacoesPedidoCompra.SuspendLayout();
            this.gpbMateriais.SuspendLayout();
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
            this.toolStripMenu.TabIndex = 13;
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
            // gpbInformacoesPedidoCompra
            // 
            this.gpbInformacoesPedidoCompra.BackColor = System.Drawing.Color.DimGray;
            this.gpbInformacoesPedidoCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbInformacoesPedidoCompra.Controls.Add(this.btnConfirmarFornecedorLocal);
            this.gpbInformacoesPedidoCompra.Controls.Add(this.cmbLocal);
            this.gpbInformacoesPedidoCompra.Controls.Add(this.cmbFornecedor);
            this.gpbInformacoesPedidoCompra.Controls.Add(this.lblFornecedor);
            this.gpbInformacoesPedidoCompra.Controls.Add(this.lblLocal);
            this.gpbInformacoesPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbInformacoesPedidoCompra.Location = new System.Drawing.Point(41, 90);
            this.gpbInformacoesPedidoCompra.Name = "gpbInformacoesPedidoCompra";
            this.gpbInformacoesPedidoCompra.Size = new System.Drawing.Size(420, 141);
            this.gpbInformacoesPedidoCompra.TabIndex = 24;
            this.gpbInformacoesPedidoCompra.TabStop = false;
            // 
            // btnConfirmarFornecedorLocal
            // 
            this.btnConfirmarFornecedorLocal.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmarFornecedorLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarFornecedorLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarFornecedorLocal.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarFornecedorLocal.Location = new System.Drawing.Point(89, 96);
            this.btnConfirmarFornecedorLocal.Name = "btnConfirmarFornecedorLocal";
            this.btnConfirmarFornecedorLocal.Size = new System.Drawing.Size(239, 30);
            this.btnConfirmarFornecedorLocal.TabIndex = 23;
            this.btnConfirmarFornecedorLocal.Text = "Confirmar Fornecedor e Local";
            this.btnConfirmarFornecedorLocal.UseVisualStyleBackColor = false;
            this.btnConfirmarFornecedorLocal.Click += new System.EventHandler(this.btnConfirmarFornecedorLocal_Click);
            // 
            // cmbLocal
            // 
            this.cmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(170, 55);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(212, 26);
            this.cmbLocal.TabIndex = 22;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(170, 20);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(212, 26);
            this.cmbFornecedor.TabIndex = 21;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.BackColor = System.Drawing.Color.Gray;
            this.lblFornecedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(19, 19);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Padding = new System.Windows.Forms.Padding(17, 5, 17, 5);
            this.lblFornecedor.Size = new System.Drawing.Size(131, 28);
            this.lblFornecedor.TabIndex = 15;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.BackColor = System.Drawing.Color.Gray;
            this.lblLocal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(19, 53);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Padding = new System.Windows.Forms.Padding(40, 5, 39, 5);
            this.lblLocal.Size = new System.Drawing.Size(129, 28);
            this.lblLocal.TabIndex = 16;
            this.lblLocal.Text = "Local";
            // 
            // gpbMateriais
            // 
            this.gpbMateriais.BackColor = System.Drawing.Color.DimGray;
            this.gpbMateriais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbMateriais.Controls.Add(this.btnAdicionarMaterial);
            this.gpbMateriais.Controls.Add(this.txtCodigoMaterial);
            this.gpbMateriais.Controls.Add(this.lblCodigoMaterial);
            this.gpbMateriais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbMateriais.Location = new System.Drawing.Point(41, 237);
            this.gpbMateriais.Name = "gpbMateriais";
            this.gpbMateriais.Size = new System.Drawing.Size(420, 97);
            this.gpbMateriais.TabIndex = 26;
            this.gpbMateriais.TabStop = false;
            this.gpbMateriais.Visible = false;
            // 
            // btnAdicionarMaterial
            // 
            this.btnAdicionarMaterial.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarMaterial.Location = new System.Drawing.Point(142, 59);
            this.btnAdicionarMaterial.Name = "btnAdicionarMaterial";
            this.btnAdicionarMaterial.Size = new System.Drawing.Size(138, 30);
            this.btnAdicionarMaterial.TabIndex = 7;
            this.btnAdicionarMaterial.Text = "Adicionar Material";
            this.btnAdicionarMaterial.UseVisualStyleBackColor = false;
            this.btnAdicionarMaterial.Click += new System.EventHandler(this.btnAdicionarMaterial_Click);
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMaterial.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigoMaterial.Location = new System.Drawing.Point(232, 20);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.Size = new System.Drawing.Size(150, 26);
            this.txtCodigoMaterial.TabIndex = 6;
            this.txtCodigoMaterial.Text = "  F1 para consultar";
            this.txtCodigoMaterial.Click += new System.EventHandler(this.txtCodigoMaterial_Click);
            this.txtCodigoMaterial.Enter += new System.EventHandler(this.txtCodigoMaterial_Enter);
            this.txtCodigoMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoMaterial_KeyDown);
            this.txtCodigoMaterial.Leave += new System.EventHandler(this.txtCodigoMaterial_Leave);
            // 
            // lblCodigoMaterial
            // 
            this.lblCodigoMaterial.AutoSize = true;
            this.lblCodigoMaterial.BackColor = System.Drawing.Color.Gray;
            this.lblCodigoMaterial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMaterial.Location = new System.Drawing.Point(19, 18);
            this.lblCodigoMaterial.Name = "lblCodigoMaterial";
            this.lblCodigoMaterial.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblCodigoMaterial.Size = new System.Drawing.Size(194, 28);
            this.lblCodigoMaterial.TabIndex = 19;
            this.lblCodigoMaterial.Text = "Codigo do material";
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.BackColor = System.Drawing.Color.Transparent;
            this.lblLegenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.ForeColor = System.Drawing.Color.White;
            this.lblLegenda.Location = new System.Drawing.Point(488, 70);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(380, 18);
            this.lblLegenda.TabIndex = 31;
            this.lblLegenda.Text = "Codigo     Nome                        Quantidade";
            this.lblLegenda.Visible = false;
            // 
            // btnLixeira
            // 
            this.btnLixeira.BackgroundImage = global::GestaoEstoque.Properties.Resources.Lixeira;
            this.btnLixeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLixeira.Location = new System.Drawing.Point(730, 340);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(40, 37);
            this.btnLixeira.TabIndex = 29;
            this.btnLixeira.UseVisualStyleBackColor = true;
            this.btnLixeira.Visible = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenos.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(670, 340);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMenos.Size = new System.Drawing.Size(40, 37);
            this.btnMenos.TabIndex = 28;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Visible = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMais.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(624, 340);
            this.btnMais.Name = "btnMais";
            this.btnMais.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMais.Size = new System.Drawing.Size(40, 37);
            this.btnMais.TabIndex = 27;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Visible = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // lstboxMateriais
            // 
            this.lstboxMateriais.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxMateriais.FormattingEnabled = true;
            this.lstboxMateriais.ItemHeight = 16;
            this.lstboxMateriais.Location = new System.Drawing.Point(487, 90);
            this.lstboxMateriais.Name = "lstboxMateriais";
            this.lstboxMateriais.Size = new System.Drawing.Size(392, 244);
            this.lstboxMateriais.TabIndex = 30;
            this.lstboxMateriais.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(381, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 32);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluirPedidoCompra
            // 
            this.btnIncluirPedidoCompra.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIncluirPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirPedidoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirPedidoCompra.ForeColor = System.Drawing.Color.White;
            this.btnIncluirPedidoCompra.Location = new System.Drawing.Point(248, 412);
            this.btnIncluirPedidoCompra.Name = "btnIncluirPedidoCompra";
            this.btnIncluirPedidoCompra.Size = new System.Drawing.Size(237, 32);
            this.btnIncluirPedidoCompra.TabIndex = 32;
            this.btnIncluirPedidoCompra.Text = "Incluir pedido de compra";
            this.btnIncluirPedidoCompra.UseVisualStyleBackColor = false;
            this.btnIncluirPedidoCompra.Visible = false;
            this.btnIncluirPedidoCompra.Click += new System.EventHandler(this.btnIncluirPedidoCompra_Click);
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
            // IncluirPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluirPedidoCompra);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.btnLixeira);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.lstboxMateriais);
            this.Controls.Add(this.gpbMateriais);
            this.Controls.Add(this.gpbInformacoesPedidoCompra);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncluirPedidoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Incluir Pedido de Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncluirPedidoCompra_FormClosing);
            this.Load += new System.EventHandler(this.IncluirPedidoCompra_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbInformacoesPedidoCompra.ResumeLayout(false);
            this.gpbInformacoesPedidoCompra.PerformLayout();
            this.gpbMateriais.ResumeLayout(false);
            this.gpbMateriais.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbInformacoesPedidoCompra;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.GroupBox gpbMateriais;
        private System.Windows.Forms.Button btnAdicionarMaterial;
        private System.Windows.Forms.TextBox txtCodigoMaterial;
        private System.Windows.Forms.Label lblCodigoMaterial;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.Button btnLixeira;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.ListBox lstboxMateriais;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluirPedidoCompra;
        private System.Windows.Forms.Button btnConfirmarFornecedorLocal;
        private System.Windows.Forms.ToolStripButton toolStripVoltar;
    }
}