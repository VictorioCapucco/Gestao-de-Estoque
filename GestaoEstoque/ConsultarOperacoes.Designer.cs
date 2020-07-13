namespace GestaoEstoque
{
    partial class ConsultarOperacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarOperacoes));
            this.gpbIncluir = new System.Windows.Forms.GroupBox();
            this.btnConsultarTransferencias = new System.Windows.Forms.Button();
            this.btnConsultarRecebimento = new System.Windows.Forms.Button();
            this.btnConsultarPedidoCompra = new System.Windows.Forms.Button();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbIncluir.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbIncluir
            // 
            this.gpbIncluir.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluir.Controls.Add(this.btnConsultarTransferencias);
            this.gpbIncluir.Controls.Add(this.btnConsultarRecebimento);
            this.gpbIncluir.Controls.Add(this.btnConsultarPedidoCompra);
            this.gpbIncluir.Location = new System.Drawing.Point(123, 126);
            this.gpbIncluir.Name = "gpbIncluir";
            this.gpbIncluir.Size = new System.Drawing.Size(717, 294);
            this.gpbIncluir.TabIndex = 16;
            this.gpbIncluir.TabStop = false;
            // 
            // btnConsultarTransferencias
            // 
            this.btnConsultarTransferencias.BackColor = System.Drawing.Color.Black;
            this.btnConsultarTransferencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarTransferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTransferencias.ForeColor = System.Drawing.Color.White;
            this.btnConsultarTransferencias.Location = new System.Drawing.Point(243, 135);
            this.btnConsultarTransferencias.Name = "btnConsultarTransferencias";
            this.btnConsultarTransferencias.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarTransferencias.TabIndex = 11;
            this.btnConsultarTransferencias.Text = "Consultar Transferências";
            this.btnConsultarTransferencias.UseVisualStyleBackColor = false;
            this.btnConsultarTransferencias.Click += new System.EventHandler(this.btnConsultarTransferencias_Click);
            // 
            // btnConsultarRecebimento
            // 
            this.btnConsultarRecebimento.BackColor = System.Drawing.Color.Black;
            this.btnConsultarRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarRecebimento.ForeColor = System.Drawing.Color.White;
            this.btnConsultarRecebimento.Location = new System.Drawing.Point(243, 69);
            this.btnConsultarRecebimento.Name = "btnConsultarRecebimento";
            this.btnConsultarRecebimento.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarRecebimento.TabIndex = 10;
            this.btnConsultarRecebimento.Text = "Consultar Recebimento";
            this.btnConsultarRecebimento.UseVisualStyleBackColor = false;
            this.btnConsultarRecebimento.Click += new System.EventHandler(this.btnConsultarRecebimento_Click);
            // 
            // btnConsultarPedidoCompra
            // 
            this.btnConsultarPedidoCompra.BackColor = System.Drawing.Color.Black;
            this.btnConsultarPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarPedidoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPedidoCompra.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPedidoCompra.Location = new System.Drawing.Point(243, 201);
            this.btnConsultarPedidoCompra.Name = "btnConsultarPedidoCompra";
            this.btnConsultarPedidoCompra.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarPedidoCompra.TabIndex = 9;
            this.btnConsultarPedidoCompra.Text = "Consultar Pedido de compra";
            this.btnConsultarPedidoCompra.UseVisualStyleBackColor = false;
            this.btnConsultarPedidoCompra.Click += new System.EventHandler(this.btnConsultarPedidoCompra_Click);
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
            this.toolStripMenu.TabIndex = 17;
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
            // ConsultarOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.gpbIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConsultarOperacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar Operacoes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarOperacoes_FormClosing);
            this.gpbIncluir.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbIncluir;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripVoltar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnConsultarRecebimento;
        private System.Windows.Forms.Button btnConsultarPedidoCompra;
        private System.Windows.Forms.Button btnConsultarTransferencias;
    }
}