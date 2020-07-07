namespace GestaoEstoque
{
    partial class Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbConsultar = new System.Windows.Forms.GroupBox();
            this.btnConsultarTipoTransferencia = new System.Windows.Forms.Button();
            this.btnConsultarUsuario = new System.Windows.Forms.Button();
            this.btnConsultarSaida = new System.Windows.Forms.Button();
            this.btnConsultarRecebimento = new System.Windows.Forms.Button();
            this.btnConsultarLocais = new System.Windows.Forms.Button();
            this.btnConsultarPedidoCompra = new System.Windows.Forms.Button();
            this.btnConsultarRequisicaoSaida = new System.Windows.Forms.Button();
            this.btnConsultarMaterial = new System.Windows.Forms.Button();
            this.btnConsultarFornecedor = new System.Windows.Forms.Button();
            this.btnConsultarUnidadeMedida = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.gpbConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Purple;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripIncluir,
            this.toolStripSeparator1,
            this.toolStripConsultar,
            this.toolStripSeparator2,
            this.toolStripExcluir,
            this.toolStripSeparator3});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(941, 42);
            this.toolStripMenu.TabIndex = 1;
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
            // toolStripExcluir
            // 
            this.toolStripExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripExcluir.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripExcluir.ForeColor = System.Drawing.Color.White;
            this.toolStripExcluir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExcluir.Image")));
            this.toolStripExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExcluir.Name = "toolStripExcluir";
            this.toolStripExcluir.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripExcluir.Size = new System.Drawing.Size(136, 39);
            this.toolStripExcluir.Text = "Excluir";
            this.toolStripExcluir.Click += new System.EventHandler(this.toolStripExcluir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // gpbConsultar
            // 
            this.gpbConsultar.BackColor = System.Drawing.Color.DimGray;
            this.gpbConsultar.Controls.Add(this.btnConsultarUnidadeMedida);
            this.gpbConsultar.Controls.Add(this.btnConsultarTipoTransferencia);
            this.gpbConsultar.Controls.Add(this.btnConsultarUsuario);
            this.gpbConsultar.Controls.Add(this.btnConsultarSaida);
            this.gpbConsultar.Controls.Add(this.btnConsultarRecebimento);
            this.gpbConsultar.Controls.Add(this.btnConsultarLocais);
            this.gpbConsultar.Controls.Add(this.btnConsultarPedidoCompra);
            this.gpbConsultar.Controls.Add(this.btnConsultarRequisicaoSaida);
            this.gpbConsultar.Controls.Add(this.btnConsultarMaterial);
            this.gpbConsultar.Controls.Add(this.btnConsultarFornecedor);
            this.gpbConsultar.Location = new System.Drawing.Point(123, 126);
            this.gpbConsultar.Name = "gpbConsultar";
            this.gpbConsultar.Size = new System.Drawing.Size(717, 294);
            this.gpbConsultar.TabIndex = 2;
            this.gpbConsultar.TabStop = false;
            // 
            // btnConsultarTipoTransferencia
            // 
            this.btnConsultarTipoTransferencia.BackColor = System.Drawing.Color.Black;
            this.btnConsultarTipoTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarTipoTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTipoTransferencia.ForeColor = System.Drawing.Color.White;
            this.btnConsultarTipoTransferencia.Location = new System.Drawing.Point(100, 240);
            this.btnConsultarTipoTransferencia.Name = "btnConsultarTipoTransferencia";
            this.btnConsultarTipoTransferencia.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarTipoTransferencia.TabIndex = 11;
            this.btnConsultarTipoTransferencia.Text = "Consultar Tipo de transferência";
            this.btnConsultarTipoTransferencia.UseVisualStyleBackColor = false;
            this.btnConsultarTipoTransferencia.Click += new System.EventHandler(this.btnConsultarTipoTransferencia_Click);
            // 
            // btnConsultarUsuario
            // 
            this.btnConsultarUsuario.BackColor = System.Drawing.Color.Black;
            this.btnConsultarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnConsultarUsuario.Location = new System.Drawing.Point(391, 190);
            this.btnConsultarUsuario.Name = "btnConsultarUsuario";
            this.btnConsultarUsuario.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarUsuario.TabIndex = 10;
            this.btnConsultarUsuario.Text = "Consultar Usuario";
            this.btnConsultarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnConsultarSaida
            // 
            this.btnConsultarSaida.BackColor = System.Drawing.Color.Black;
            this.btnConsultarSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarSaida.ForeColor = System.Drawing.Color.White;
            this.btnConsultarSaida.Location = new System.Drawing.Point(391, 138);
            this.btnConsultarSaida.Name = "btnConsultarSaida";
            this.btnConsultarSaida.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarSaida.TabIndex = 9;
            this.btnConsultarSaida.Text = "Consultar Saida";
            this.btnConsultarSaida.UseVisualStyleBackColor = false;
            // 
            // btnConsultarRecebimento
            // 
            this.btnConsultarRecebimento.BackColor = System.Drawing.Color.Black;
            this.btnConsultarRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarRecebimento.ForeColor = System.Drawing.Color.White;
            this.btnConsultarRecebimento.Location = new System.Drawing.Point(391, 86);
            this.btnConsultarRecebimento.Name = "btnConsultarRecebimento";
            this.btnConsultarRecebimento.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarRecebimento.TabIndex = 8;
            this.btnConsultarRecebimento.Text = "Consultar Recebimento";
            this.btnConsultarRecebimento.UseVisualStyleBackColor = false;
            // 
            // btnConsultarLocais
            // 
            this.btnConsultarLocais.BackColor = System.Drawing.Color.Black;
            this.btnConsultarLocais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarLocais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLocais.ForeColor = System.Drawing.Color.White;
            this.btnConsultarLocais.Location = new System.Drawing.Point(391, 34);
            this.btnConsultarLocais.Name = "btnConsultarLocais";
            this.btnConsultarLocais.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarLocais.TabIndex = 7;
            this.btnConsultarLocais.Text = "Consultar Locais";
            this.btnConsultarLocais.UseVisualStyleBackColor = false;
            // 
            // btnConsultarPedidoCompra
            // 
            this.btnConsultarPedidoCompra.BackColor = System.Drawing.Color.Black;
            this.btnConsultarPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarPedidoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPedidoCompra.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPedidoCompra.Location = new System.Drawing.Point(100, 190);
            this.btnConsultarPedidoCompra.Name = "btnConsultarPedidoCompra";
            this.btnConsultarPedidoCompra.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarPedidoCompra.TabIndex = 5;
            this.btnConsultarPedidoCompra.Text = "Consultar Pedido de compra";
            this.btnConsultarPedidoCompra.UseVisualStyleBackColor = false;
            // 
            // btnConsultarRequisicaoSaida
            // 
            this.btnConsultarRequisicaoSaida.BackColor = System.Drawing.Color.Black;
            this.btnConsultarRequisicaoSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarRequisicaoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarRequisicaoSaida.ForeColor = System.Drawing.Color.White;
            this.btnConsultarRequisicaoSaida.Location = new System.Drawing.Point(100, 138);
            this.btnConsultarRequisicaoSaida.Name = "btnConsultarRequisicaoSaida";
            this.btnConsultarRequisicaoSaida.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarRequisicaoSaida.TabIndex = 4;
            this.btnConsultarRequisicaoSaida.Text = "Consultar Requisição de saída";
            this.btnConsultarRequisicaoSaida.UseVisualStyleBackColor = false;
            // 
            // btnConsultarMaterial
            // 
            this.btnConsultarMaterial.BackColor = System.Drawing.Color.Black;
            this.btnConsultarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnConsultarMaterial.Location = new System.Drawing.Point(100, 86);
            this.btnConsultarMaterial.Name = "btnConsultarMaterial";
            this.btnConsultarMaterial.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarMaterial.TabIndex = 3;
            this.btnConsultarMaterial.Text = "Consultar Material";
            this.btnConsultarMaterial.UseVisualStyleBackColor = false;
            // 
            // btnConsultarFornecedor
            // 
            this.btnConsultarFornecedor.BackColor = System.Drawing.Color.Black;
            this.btnConsultarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFornecedor.Location = new System.Drawing.Point(100, 34);
            this.btnConsultarFornecedor.Name = "btnConsultarFornecedor";
            this.btnConsultarFornecedor.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarFornecedor.TabIndex = 2;
            this.btnConsultarFornecedor.Text = "Consultar Fornecedor";
            this.btnConsultarFornecedor.UseVisualStyleBackColor = false;
            // 
            // btnConsultarUnidadeMedida
            // 
            this.btnConsultarUnidadeMedida.BackColor = System.Drawing.Color.Black;
            this.btnConsultarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarUnidadeMedida.ForeColor = System.Drawing.Color.White;
            this.btnConsultarUnidadeMedida.Location = new System.Drawing.Point(391, 240);
            this.btnConsultarUnidadeMedida.Name = "btnConsultarUnidadeMedida";
            this.btnConsultarUnidadeMedida.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarUnidadeMedida.TabIndex = 12;
            this.btnConsultarUnidadeMedida.Text = "Consultar Unidade de medida";
            this.btnConsultarUnidadeMedida.UseVisualStyleBackColor = false;
            this.btnConsultarUnidadeMedida.Click += new System.EventHandler(this.btnConsultarUnidadeMedida_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbConsultar);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Consultar_FormClosing);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbConsultar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox gpbConsultar;
        private System.Windows.Forms.Button btnConsultarUsuario;
        private System.Windows.Forms.Button btnConsultarSaida;
        private System.Windows.Forms.Button btnConsultarRecebimento;
        private System.Windows.Forms.Button btnConsultarLocais;
        private System.Windows.Forms.Button btnConsultarPedidoCompra;
        private System.Windows.Forms.Button btnConsultarRequisicaoSaida;
        private System.Windows.Forms.Button btnConsultarMaterial;
        private System.Windows.Forms.Button btnConsultarFornecedor;
        private System.Windows.Forms.Button btnConsultarTipoTransferencia;
        private System.Windows.Forms.Button btnConsultarUnidadeMedida;
    }
}