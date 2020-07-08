namespace GestaoEstoque
{
    partial class IncluirRecebimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncluirRecebimento));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbIncluirRecebimento = new System.Windows.Forms.GroupBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.btnConfirmarLocal = new System.Windows.Forms.Button();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.btnUtilizarPedido = new System.Windows.Forms.Button();
            this.lblPedidoCompra = new System.Windows.Forms.Label();
            this.cmbPedidoCompra = new System.Windows.Forms.ComboBox();
            this.gpbData = new System.Windows.Forms.GroupBox();
            this.lblDataRecebimento = new System.Windows.Forms.Label();
            this.mskDataRecebimento = new System.Windows.Forms.MaskedTextBox();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lstboxMateriais = new System.Windows.Forms.ListBox();
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenu.SuspendLayout();
            this.gpbIncluirRecebimento.SuspendLayout();
            this.gpbData.SuspendLayout();
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
            this.toolStripMenu.TabIndex = 16;
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
            // gpbIncluirRecebimento
            // 
            this.gpbIncluirRecebimento.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluirRecebimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbIncluirRecebimento.Controls.Add(this.txtFornecedor);
            this.gpbIncluirRecebimento.Controls.Add(this.lblFornecedor);
            this.gpbIncluirRecebimento.Controls.Add(this.btnConfirmarLocal);
            this.gpbIncluirRecebimento.Controls.Add(this.cmbLocal);
            this.gpbIncluirRecebimento.Controls.Add(this.lblLocal);
            this.gpbIncluirRecebimento.Controls.Add(this.btnUtilizarPedido);
            this.gpbIncluirRecebimento.Controls.Add(this.lblPedidoCompra);
            this.gpbIncluirRecebimento.Controls.Add(this.cmbPedidoCompra);
            this.gpbIncluirRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbIncluirRecebimento.Location = new System.Drawing.Point(34, 93);
            this.gpbIncluirRecebimento.Name = "gpbIncluirRecebimento";
            this.gpbIncluirRecebimento.Size = new System.Drawing.Size(499, 211);
            this.gpbIncluirRecebimento.TabIndex = 13;
            this.gpbIncluirRecebimento.TabStop = false;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(258, 124);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(174, 27);
            this.txtFornecedor.TabIndex = 8;
            this.txtFornecedor.Visible = false;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.BackColor = System.Drawing.Color.Gray;
            this.lblFornecedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(54, 123);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Padding = new System.Windows.Forms.Padding(48, 5, 49, 5);
            this.lblFornecedor.Size = new System.Drawing.Size(194, 28);
            this.lblFornecedor.TabIndex = 11;
            this.lblFornecedor.Text = "Fornecedor";
            this.lblFornecedor.Visible = false;
            // 
            // btnConfirmarLocal
            // 
            this.btnConfirmarLocal.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarLocal.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarLocal.Location = new System.Drawing.Point(131, 84);
            this.btnConfirmarLocal.Name = "btnConfirmarLocal";
            this.btnConfirmarLocal.Size = new System.Drawing.Size(239, 30);
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
            this.cmbLocal.Location = new System.Drawing.Point(258, 47);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(174, 26);
            this.cmbLocal.TabIndex = 0;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.BackColor = System.Drawing.Color.Gray;
            this.lblLocal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(54, 47);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Padding = new System.Windows.Forms.Padding(72, 5, 72, 5);
            this.lblLocal.Size = new System.Drawing.Size(194, 28);
            this.lblLocal.TabIndex = 9;
            this.lblLocal.Text = "Local";
            // 
            // btnUtilizarPedido
            // 
            this.btnUtilizarPedido.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUtilizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizarPedido.ForeColor = System.Drawing.Color.White;
            this.btnUtilizarPedido.Location = new System.Drawing.Point(131, 165);
            this.btnUtilizarPedido.Name = "btnUtilizarPedido";
            this.btnUtilizarPedido.Size = new System.Drawing.Size(239, 30);
            this.btnUtilizarPedido.TabIndex = 3;
            this.btnUtilizarPedido.Text = "Utilizar este pedido";
            this.btnUtilizarPedido.UseVisualStyleBackColor = false;
            this.btnUtilizarPedido.Visible = false;
            this.btnUtilizarPedido.Click += new System.EventHandler(this.btnUtilizarPedido_Click);
            // 
            // lblPedidoCompra
            // 
            this.lblPedidoCompra.AutoSize = true;
            this.lblPedidoCompra.BackColor = System.Drawing.Color.Gray;
            this.lblPedidoCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoCompra.Location = new System.Drawing.Point(54, 85);
            this.lblPedidoCompra.Name = "lblPedidoCompra";
            this.lblPedidoCompra.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblPedidoCompra.Size = new System.Drawing.Size(194, 28);
            this.lblPedidoCompra.TabIndex = 10;
            this.lblPedidoCompra.Text = "Pedido de compra";
            this.lblPedidoCompra.Visible = false;
            // 
            // cmbPedidoCompra
            // 
            this.cmbPedidoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedidoCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPedidoCompra.FormattingEnabled = true;
            this.cmbPedidoCompra.Location = new System.Drawing.Point(258, 87);
            this.cmbPedidoCompra.Name = "cmbPedidoCompra";
            this.cmbPedidoCompra.Size = new System.Drawing.Size(174, 26);
            this.cmbPedidoCompra.TabIndex = 2;
            this.cmbPedidoCompra.Visible = false;
            this.cmbPedidoCompra.SelectedIndexChanged += new System.EventHandler(this.cmbPedidoCompra_SelectedIndexChanged);
            this.cmbPedidoCompra.SelectionChangeCommitted += new System.EventHandler(this.cmbPedidoCompra_SelectionChangeCommitted);
            // 
            // gpbData
            // 
            this.gpbData.BackColor = System.Drawing.Color.DimGray;
            this.gpbData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbData.Controls.Add(this.lblDataRecebimento);
            this.gpbData.Controls.Add(this.mskDataRecebimento);
            this.gpbData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbData.Location = new System.Drawing.Point(34, 310);
            this.gpbData.Name = "gpbData";
            this.gpbData.Size = new System.Drawing.Size(499, 65);
            this.gpbData.TabIndex = 14;
            this.gpbData.TabStop = false;
            this.gpbData.Visible = false;
            // 
            // lblDataRecebimento
            // 
            this.lblDataRecebimento.AutoSize = true;
            this.lblDataRecebimento.BackColor = System.Drawing.Color.Gray;
            this.lblDataRecebimento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRecebimento.Location = new System.Drawing.Point(79, 22);
            this.lblDataRecebimento.Name = "lblDataRecebimento";
            this.lblDataRecebimento.Padding = new System.Windows.Forms.Padding(17, 5, 16, 5);
            this.lblDataRecebimento.Size = new System.Drawing.Size(218, 28);
            this.lblDataRecebimento.TabIndex = 12;
            this.lblDataRecebimento.Text = "Data do Recebimento";
            // 
            // mskDataRecebimento
            // 
            this.mskDataRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataRecebimento.Location = new System.Drawing.Point(315, 24);
            this.mskDataRecebimento.Mask = "99/99/9999";
            this.mskDataRecebimento.Name = "mskDataRecebimento";
            this.mskDataRecebimento.Size = new System.Drawing.Size(86, 26);
            this.mskDataRecebimento.TabIndex = 4;
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.BackColor = System.Drawing.Color.Transparent;
            this.lblLegenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.ForeColor = System.Drawing.Color.White;
            this.lblLegenda.Location = new System.Drawing.Point(552, 79);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(350, 18);
            this.lblLegenda.TabIndex = 15;
            this.lblLegenda.Text = "Codigo     Nome                   Quantidade";
            this.lblLegenda.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(401, 428);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(254, 428);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(203, 32);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir Recebimento";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Visible = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lstboxMateriais
            // 
            this.lstboxMateriais.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxMateriais.FormattingEnabled = true;
            this.lstboxMateriais.ItemHeight = 16;
            this.lstboxMateriais.Location = new System.Drawing.Point(551, 99);
            this.lstboxMateriais.Name = "lstboxMateriais";
            this.lstboxMateriais.Size = new System.Drawing.Size(363, 276);
            this.lstboxMateriais.TabIndex = 7;
            this.lstboxMateriais.Visible = false;
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
            // IncluirRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lstboxMateriais);
            this.Controls.Add(this.gpbData);
            this.Controls.Add(this.gpbIncluirRecebimento);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncluirRecebimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Incluir Recebimento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncluirRecebimento_FormClosing);
            this.Load += new System.EventHandler(this.IncluirRecebimento_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbIncluirRecebimento.ResumeLayout(false);
            this.gpbIncluirRecebimento.PerformLayout();
            this.gpbData.ResumeLayout(false);
            this.gpbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox gpbIncluirRecebimento;
        private System.Windows.Forms.Button btnUtilizarPedido;
        private System.Windows.Forms.Label lblPedidoCompra;
        private System.Windows.Forms.ComboBox cmbPedidoCompra;
        private System.Windows.Forms.GroupBox gpbData;
        private System.Windows.Forms.Label lblDataRecebimento;
        private System.Windows.Forms.MaskedTextBox mskDataRecebimento;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ListBox lstboxMateriais;
        private System.Windows.Forms.Button btnConfirmarLocal;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ToolStripButton toolStripVoltar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}