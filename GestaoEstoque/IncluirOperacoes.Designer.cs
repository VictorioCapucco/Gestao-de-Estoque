namespace GestaoEstoque
{
    partial class IncluirOperacoes_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncluirOperacoes_));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbIncluir = new System.Windows.Forms.GroupBox();
            this.btnIncluirEntradaManual = new System.Windows.Forms.Button();
            this.btnIncluirPedidoCompra = new System.Windows.Forms.Button();
            this.btnIncluirTransferenciaEntrada = new System.Windows.Forms.Button();
            this.btnIncluirRecebimento = new System.Windows.Forms.Button();
            this.btnIncluirTransferenciaSaida = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.gpbIncluir.SuspendLayout();
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
            this.toolStripMenu.TabIndex = 9;
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
            // gpbIncluir
            // 
            this.gpbIncluir.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluir.Controls.Add(this.btnIncluirEntradaManual);
            this.gpbIncluir.Controls.Add(this.btnIncluirPedidoCompra);
            this.gpbIncluir.Controls.Add(this.btnIncluirTransferenciaEntrada);
            this.gpbIncluir.Controls.Add(this.btnIncluirRecebimento);
            this.gpbIncluir.Controls.Add(this.btnIncluirTransferenciaSaida);
            this.gpbIncluir.Location = new System.Drawing.Point(123, 126);
            this.gpbIncluir.Name = "gpbIncluir";
            this.gpbIncluir.Size = new System.Drawing.Size(717, 294);
            this.gpbIncluir.TabIndex = 15;
            this.gpbIncluir.TabStop = false;
            // 
            // btnIncluirEntradaManual
            // 
            this.btnIncluirEntradaManual.BackColor = System.Drawing.Color.Black;
            this.btnIncluirEntradaManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirEntradaManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirEntradaManual.ForeColor = System.Drawing.Color.White;
            this.btnIncluirEntradaManual.Location = new System.Drawing.Point(241, 194);
            this.btnIncluirEntradaManual.Name = "btnIncluirEntradaManual";
            this.btnIncluirEntradaManual.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirEntradaManual.TabIndex = 17;
            this.btnIncluirEntradaManual.Text = "Incluir Entrada Manual";
            this.btnIncluirEntradaManual.UseVisualStyleBackColor = false;
            this.btnIncluirEntradaManual.Click += new System.EventHandler(this.btnIncluirEntradaManual_Click);
            // 
            // btnIncluirPedidoCompra
            // 
            this.btnIncluirPedidoCompra.BackColor = System.Drawing.Color.Black;
            this.btnIncluirPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirPedidoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirPedidoCompra.ForeColor = System.Drawing.Color.White;
            this.btnIncluirPedidoCompra.Location = new System.Drawing.Point(241, 248);
            this.btnIncluirPedidoCompra.Name = "btnIncluirPedidoCompra";
            this.btnIncluirPedidoCompra.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirPedidoCompra.TabIndex = 4;
            this.btnIncluirPedidoCompra.Text = "Incluir Pedido de Compra";
            this.btnIncluirPedidoCompra.UseVisualStyleBackColor = false;
            this.btnIncluirPedidoCompra.Click += new System.EventHandler(this.btnIncluirPedidoCompra_Click);
            // 
            // btnIncluirTransferenciaEntrada
            // 
            this.btnIncluirTransferenciaEntrada.BackColor = System.Drawing.Color.Black;
            this.btnIncluirTransferenciaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirTransferenciaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTransferenciaEntrada.ForeColor = System.Drawing.Color.White;
            this.btnIncluirTransferenciaEntrada.Location = new System.Drawing.Point(241, 86);
            this.btnIncluirTransferenciaEntrada.Name = "btnIncluirTransferenciaEntrada";
            this.btnIncluirTransferenciaEntrada.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirTransferenciaEntrada.TabIndex = 8;
            this.btnIncluirTransferenciaEntrada.Text = "Incluir Transferência entrada";
            this.btnIncluirTransferenciaEntrada.UseVisualStyleBackColor = false;
            this.btnIncluirTransferenciaEntrada.Click += new System.EventHandler(this.btnIncluirTransferenciaEntrada_Click);
            // 
            // btnIncluirRecebimento
            // 
            this.btnIncluirRecebimento.BackColor = System.Drawing.Color.Black;
            this.btnIncluirRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirRecebimento.ForeColor = System.Drawing.Color.White;
            this.btnIncluirRecebimento.Location = new System.Drawing.Point(241, 32);
            this.btnIncluirRecebimento.Name = "btnIncluirRecebimento";
            this.btnIncluirRecebimento.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirRecebimento.TabIndex = 7;
            this.btnIncluirRecebimento.Text = "Incluir Recebimento";
            this.btnIncluirRecebimento.UseVisualStyleBackColor = false;
            this.btnIncluirRecebimento.Click += new System.EventHandler(this.btnIncluirRecebimento_Click);
            // 
            // btnIncluirTransferenciaSaida
            // 
            this.btnIncluirTransferenciaSaida.BackColor = System.Drawing.Color.Black;
            this.btnIncluirTransferenciaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirTransferenciaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTransferenciaSaida.ForeColor = System.Drawing.Color.White;
            this.btnIncluirTransferenciaSaida.Location = new System.Drawing.Point(241, 140);
            this.btnIncluirTransferenciaSaida.Name = "btnIncluirTransferenciaSaida";
            this.btnIncluirTransferenciaSaida.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirTransferenciaSaida.TabIndex = 3;
            this.btnIncluirTransferenciaSaida.Text = "Incluir Transferência saída";
            this.btnIncluirTransferenciaSaida.UseVisualStyleBackColor = false;
            this.btnIncluirTransferenciaSaida.Click += new System.EventHandler(this.btnIncluirTransferenciaSaida_Click);
            // 
            // IncluirOperacoes_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbIncluir);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncluirOperacoes_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Incluir Operações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncluirOperacoes__FormClosing);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbIncluir.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gpbIncluir;
        private System.Windows.Forms.Button btnIncluirEntradaManual;
        private System.Windows.Forms.Button btnIncluirPedidoCompra;
        private System.Windows.Forms.Button btnIncluirTransferenciaEntrada;
        private System.Windows.Forms.Button btnIncluirRecebimento;
        private System.Windows.Forms.Button btnIncluirTransferenciaSaida;
    }
}