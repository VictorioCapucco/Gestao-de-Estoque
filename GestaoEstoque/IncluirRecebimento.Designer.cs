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
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbIncluirRecebimento = new System.Windows.Forms.GroupBox();
            this.mskDataRecebimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataRecebimento = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.btnConfirmarLocal = new System.Windows.Forms.Button();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.btnUtilizarPedido = new System.Windows.Forms.Button();
            this.lblPedidoCompra = new System.Windows.Forms.Label();
            this.cmbPedidoCompra = new System.Windows.Forms.ComboBox();
            this.lblLegendaPedidoCompra = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lstboxMateriaisPedido = new System.Windows.Forms.ListBox();
            this.btnMandaPedido = new System.Windows.Forms.Button();
            this.btnMandaRecebimento = new System.Windows.Forms.Button();
            this.lblLegendaRecebimento = new System.Windows.Forms.Label();
            this.lstboxMateriaisRecebimento = new System.Windows.Forms.ListBox();
            this.toolStripMenu.SuspendLayout();
            this.gpbIncluirRecebimento.SuspendLayout();
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
            // gpbIncluirRecebimento
            // 
            this.gpbIncluirRecebimento.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluirRecebimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbIncluirRecebimento.Controls.Add(this.mskDataRecebimento);
            this.gpbIncluirRecebimento.Controls.Add(this.lblDataRecebimento);
            this.gpbIncluirRecebimento.Controls.Add(this.txtFornecedor);
            this.gpbIncluirRecebimento.Controls.Add(this.lblFornecedor);
            this.gpbIncluirRecebimento.Controls.Add(this.btnConfirmarLocal);
            this.gpbIncluirRecebimento.Controls.Add(this.cmbLocal);
            this.gpbIncluirRecebimento.Controls.Add(this.lblLocal);
            this.gpbIncluirRecebimento.Controls.Add(this.btnUtilizarPedido);
            this.gpbIncluirRecebimento.Controls.Add(this.lblPedidoCompra);
            this.gpbIncluirRecebimento.Controls.Add(this.cmbPedidoCompra);
            this.gpbIncluirRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbIncluirRecebimento.Location = new System.Drawing.Point(34, 80);
            this.gpbIncluirRecebimento.Name = "gpbIncluirRecebimento";
            this.gpbIncluirRecebimento.Size = new System.Drawing.Size(864, 121);
            this.gpbIncluirRecebimento.TabIndex = 13;
            this.gpbIncluirRecebimento.TabStop = false;
            // 
            // mskDataRecebimento
            // 
            this.mskDataRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataRecebimento.Location = new System.Drawing.Point(653, 70);
            this.mskDataRecebimento.Mask = "99/99/9999";
            this.mskDataRecebimento.Name = "mskDataRecebimento";
            this.mskDataRecebimento.Size = new System.Drawing.Size(86, 26);
            this.mskDataRecebimento.TabIndex = 4;
            this.mskDataRecebimento.Visible = false;
            // 
            // lblDataRecebimento
            // 
            this.lblDataRecebimento.AutoSize = true;
            this.lblDataRecebimento.BackColor = System.Drawing.Color.Gray;
            this.lblDataRecebimento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRecebimento.Location = new System.Drawing.Point(429, 68);
            this.lblDataRecebimento.Name = "lblDataRecebimento";
            this.lblDataRecebimento.Padding = new System.Windows.Forms.Padding(17, 5, 16, 5);
            this.lblDataRecebimento.Size = new System.Drawing.Size(218, 28);
            this.lblDataRecebimento.TabIndex = 12;
            this.lblDataRecebimento.Text = "Data do Recebimento";
            this.lblDataRecebimento.Visible = false;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(237, 70);
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
            this.lblFornecedor.Location = new System.Drawing.Point(33, 69);
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
            this.btnConfirmarLocal.Location = new System.Drawing.Point(432, 25);
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
            this.cmbLocal.Location = new System.Drawing.Point(237, 29);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(174, 26);
            this.cmbLocal.TabIndex = 0;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.BackColor = System.Drawing.Color.Gray;
            this.lblLocal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(33, 29);
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
            this.btnUtilizarPedido.Location = new System.Drawing.Point(432, 67);
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
            this.lblPedidoCompra.Location = new System.Drawing.Point(429, 29);
            this.lblPedidoCompra.Name = "lblPedidoCompra";
            this.lblPedidoCompra.Padding = new System.Windows.Forms.Padding(32, 5, 32, 5);
            this.lblPedidoCompra.Size = new System.Drawing.Size(218, 28);
            this.lblPedidoCompra.TabIndex = 10;
            this.lblPedidoCompra.Text = "Pedido de compra";
            this.lblPedidoCompra.Visible = false;
            // 
            // cmbPedidoCompra
            // 
            this.cmbPedidoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedidoCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPedidoCompra.FormattingEnabled = true;
            this.cmbPedidoCompra.Location = new System.Drawing.Point(653, 31);
            this.cmbPedidoCompra.Name = "cmbPedidoCompra";
            this.cmbPedidoCompra.Size = new System.Drawing.Size(174, 26);
            this.cmbPedidoCompra.TabIndex = 2;
            this.cmbPedidoCompra.Visible = false;
            this.cmbPedidoCompra.SelectedIndexChanged += new System.EventHandler(this.cmbPedidoCompra_SelectedIndexChanged);
            this.cmbPedidoCompra.SelectionChangeCommitted += new System.EventHandler(this.cmbPedidoCompra_SelectionChangeCommitted);
            // 
            // lblLegendaPedidoCompra
            // 
            this.lblLegendaPedidoCompra.AutoSize = true;
            this.lblLegendaPedidoCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendaPedidoCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegendaPedidoCompra.ForeColor = System.Drawing.Color.White;
            this.lblLegendaPedidoCompra.Location = new System.Drawing.Point(40, 216);
            this.lblLegendaPedidoCompra.Name = "lblLegendaPedidoCompra";
            this.lblLegendaPedidoCompra.Size = new System.Drawing.Size(157, 18);
            this.lblLegendaPedidoCompra.TabIndex = 15;
            this.lblLegendaPedidoCompra.Text = "Pedido de Compra";
            this.lblLegendaPedidoCompra.Visible = false;
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
            // lstboxMateriaisPedido
            // 
            this.lstboxMateriaisPedido.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxMateriaisPedido.FormattingEnabled = true;
            this.lstboxMateriaisPedido.ItemHeight = 16;
            this.lstboxMateriaisPedido.Location = new System.Drawing.Point(43, 238);
            this.lstboxMateriaisPedido.Name = "lstboxMateriaisPedido";
            this.lstboxMateriaisPedido.Size = new System.Drawing.Size(363, 164);
            this.lstboxMateriaisPedido.TabIndex = 7;
            this.lstboxMateriaisPedido.Visible = false;
            // 
            // btnMandaPedido
            // 
            this.btnMandaPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMandaPedido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMandaPedido.Location = new System.Drawing.Point(462, 351);
            this.btnMandaPedido.Name = "btnMandaPedido";
            this.btnMandaPedido.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMandaPedido.Size = new System.Drawing.Size(53, 37);
            this.btnMandaPedido.TabIndex = 18;
            this.btnMandaPedido.Text = "<<";
            this.btnMandaPedido.UseVisualStyleBackColor = true;
            this.btnMandaPedido.Visible = false;
            this.btnMandaPedido.Click += new System.EventHandler(this.btnMandaPedido_Click);
            // 
            // btnMandaRecebimento
            // 
            this.btnMandaRecebimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMandaRecebimento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMandaRecebimento.Location = new System.Drawing.Point(413, 261);
            this.btnMandaRecebimento.Name = "btnMandaRecebimento";
            this.btnMandaRecebimento.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMandaRecebimento.Size = new System.Drawing.Size(53, 37);
            this.btnMandaRecebimento.TabIndex = 17;
            this.btnMandaRecebimento.Text = ">>";
            this.btnMandaRecebimento.UseVisualStyleBackColor = true;
            this.btnMandaRecebimento.Visible = false;
            this.btnMandaRecebimento.Click += new System.EventHandler(this.btnMandaRecebimento_Click);
            // 
            // lblLegendaRecebimento
            // 
            this.lblLegendaRecebimento.AutoSize = true;
            this.lblLegendaRecebimento.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendaRecebimento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegendaRecebimento.ForeColor = System.Drawing.Color.White;
            this.lblLegendaRecebimento.Location = new System.Drawing.Point(518, 216);
            this.lblLegendaRecebimento.Name = "lblLegendaRecebimento";
            this.lblLegendaRecebimento.Size = new System.Drawing.Size(119, 18);
            this.lblLegendaRecebimento.TabIndex = 20;
            this.lblLegendaRecebimento.Text = "Recebimemto";
            this.lblLegendaRecebimento.Visible = false;
            // 
            // lstboxMateriaisRecebimento
            // 
            this.lstboxMateriaisRecebimento.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxMateriaisRecebimento.FormattingEnabled = true;
            this.lstboxMateriaisRecebimento.ItemHeight = 16;
            this.lstboxMateriaisRecebimento.Location = new System.Drawing.Point(521, 238);
            this.lstboxMateriaisRecebimento.Name = "lstboxMateriaisRecebimento";
            this.lstboxMateriaisRecebimento.Size = new System.Drawing.Size(363, 164);
            this.lstboxMateriaisRecebimento.TabIndex = 19;
            this.lstboxMateriaisRecebimento.Visible = false;
            // 
            // IncluirRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.lblLegendaRecebimento);
            this.Controls.Add(this.lstboxMateriaisRecebimento);
            this.Controls.Add(this.btnMandaPedido);
            this.Controls.Add(this.btnMandaRecebimento);
            this.Controls.Add(this.lblLegendaPedidoCompra);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lstboxMateriaisPedido);
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
        private System.Windows.Forms.Label lblDataRecebimento;
        private System.Windows.Forms.MaskedTextBox mskDataRecebimento;
        private System.Windows.Forms.Label lblLegendaPedidoCompra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ListBox lstboxMateriaisPedido;
        private System.Windows.Forms.Button btnConfirmarLocal;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ToolStripButton toolStripVoltar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnMandaPedido;
        private System.Windows.Forms.Button btnMandaRecebimento;
        private System.Windows.Forms.Label lblLegendaRecebimento;
        private System.Windows.Forms.ListBox lstboxMateriaisRecebimento;
    }
}