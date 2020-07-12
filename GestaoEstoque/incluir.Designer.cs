namespace GestaoEstoque
{
    partial class Incluir
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incluir));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbIncluir = new System.Windows.Forms.GroupBox();
            this.btnIncluirUnidadeMedida = new System.Windows.Forms.Button();
            this.btnIncluirUsuario = new System.Windows.Forms.Button();
            this.btnIncluirTipoMaterial = new System.Windows.Forms.Button();
            this.btnIncluirTipoTransferencia = new System.Windows.Forms.Button();
            this.btnIncluirTransferenciaEntrada = new System.Windows.Forms.Button();
            this.btnIncluirRecebimento = new System.Windows.Forms.Button();
            this.btnIncluirLocais = new System.Windows.Forms.Button();
            this.btnIncluirPedidoCompra = new System.Windows.Forms.Button();
            this.btnIncluirTransferenciaSaida = new System.Windows.Forms.Button();
            this.btnIncluirMaterial = new System.Windows.Forms.Button();
            this.btnIncluirFornecedor = new System.Windows.Forms.Button();
            this.btnOperações = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.gpbIncluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Purple;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripIncluir,
            this.toolStripSeparator1,
            this.toolStripConsultar,
            this.toolStripSeparator2});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(941, 42);
            this.toolStripMenu.TabIndex = 12;
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
            this.gpbIncluir.Controls.Add(this.btnOperações);
            this.gpbIncluir.Controls.Add(this.btnCadastros);
            this.gpbIncluir.Controls.Add(this.btnIncluirUnidadeMedida);
            this.gpbIncluir.Controls.Add(this.btnIncluirUsuario);
            this.gpbIncluir.Controls.Add(this.btnIncluirPedidoCompra);
            this.gpbIncluir.Controls.Add(this.btnIncluirTipoMaterial);
            this.gpbIncluir.Controls.Add(this.btnIncluirTipoTransferencia);
            this.gpbIncluir.Controls.Add(this.btnIncluirTransferenciaEntrada);
            this.gpbIncluir.Controls.Add(this.btnIncluirRecebimento);
            this.gpbIncluir.Controls.Add(this.btnIncluirLocais);
            this.gpbIncluir.Controls.Add(this.btnIncluirTransferenciaSaida);
            this.gpbIncluir.Controls.Add(this.btnIncluirMaterial);
            this.gpbIncluir.Controls.Add(this.btnIncluirFornecedor);
            this.gpbIncluir.Location = new System.Drawing.Point(123, 126);
            this.gpbIncluir.Name = "gpbIncluir";
            this.gpbIncluir.Size = new System.Drawing.Size(717, 294);
            this.gpbIncluir.TabIndex = 11;
            this.gpbIncluir.TabStop = false;
            // 
            // btnIncluirUnidadeMedida
            // 
            this.btnIncluirUnidadeMedida.BackColor = System.Drawing.Color.Black;
            this.btnIncluirUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirUnidadeMedida.ForeColor = System.Drawing.Color.White;
            this.btnIncluirUnidadeMedida.Location = new System.Drawing.Point(99, 213);
            this.btnIncluirUnidadeMedida.Name = "btnIncluirUnidadeMedida";
            this.btnIncluirUnidadeMedida.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirUnidadeMedida.TabIndex = 11;
            this.btnIncluirUnidadeMedida.Text = "Incluir Unidade de Medida";
            this.btnIncluirUnidadeMedida.UseVisualStyleBackColor = false;
            this.btnIncluirUnidadeMedida.Visible = false;
            this.btnIncluirUnidadeMedida.Click += new System.EventHandler(this.btnIncluirUnidadeMedida_Click);
            // 
            // btnIncluirUsuario
            // 
            this.btnIncluirUsuario.BackColor = System.Drawing.Color.Black;
            this.btnIncluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirUsuario.ForeColor = System.Drawing.Color.White;
            this.btnIncluirUsuario.Location = new System.Drawing.Point(99, 254);
            this.btnIncluirUsuario.Name = "btnIncluirUsuario";
            this.btnIncluirUsuario.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirUsuario.TabIndex = 10;
            this.btnIncluirUsuario.Text = "Incluir Usuário";
            this.btnIncluirUsuario.UseVisualStyleBackColor = false;
            this.btnIncluirUsuario.Visible = false;
            this.btnIncluirUsuario.Click += new System.EventHandler(this.btnIncluirUsuario_Click);
            // 
            // btnIncluirTipoMaterial
            // 
            this.btnIncluirTipoMaterial.BackColor = System.Drawing.Color.Black;
            this.btnIncluirTipoMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirTipoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTipoMaterial.ForeColor = System.Drawing.Color.White;
            this.btnIncluirTipoMaterial.Location = new System.Drawing.Point(99, 170);
            this.btnIncluirTipoMaterial.Name = "btnIncluirTipoMaterial";
            this.btnIncluirTipoMaterial.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirTipoMaterial.TabIndex = 5;
            this.btnIncluirTipoMaterial.Text = "Incluir Tipo de Material";
            this.btnIncluirTipoMaterial.UseVisualStyleBackColor = false;
            this.btnIncluirTipoMaterial.Visible = false;
            this.btnIncluirTipoMaterial.Click += new System.EventHandler(this.btnIncluirTipoMaterial_Click);
            // 
            // btnIncluirTipoTransferencia
            // 
            this.btnIncluirTipoTransferencia.BackColor = System.Drawing.Color.Black;
            this.btnIncluirTipoTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirTipoTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTipoTransferencia.ForeColor = System.Drawing.Color.White;
            this.btnIncluirTipoTransferencia.Location = new System.Drawing.Point(438, 140);
            this.btnIncluirTipoTransferencia.Name = "btnIncluirTipoTransferencia";
            this.btnIncluirTipoTransferencia.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirTipoTransferencia.TabIndex = 9;
            this.btnIncluirTipoTransferencia.Text = "Incluir Tipo de Transferência";
            this.btnIncluirTipoTransferencia.UseVisualStyleBackColor = false;
            this.btnIncluirTipoTransferencia.Visible = false;
            this.btnIncluirTipoTransferencia.Click += new System.EventHandler(this.btnIncluirTipoSaida_Click);
            // 
            // btnIncluirTransferenciaEntrada
            // 
            this.btnIncluirTransferenciaEntrada.BackColor = System.Drawing.Color.Black;
            this.btnIncluirTransferenciaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirTransferenciaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTransferenciaEntrada.ForeColor = System.Drawing.Color.White;
            this.btnIncluirTransferenciaEntrada.Location = new System.Drawing.Point(438, 92);
            this.btnIncluirTransferenciaEntrada.Name = "btnIncluirTransferenciaEntrada";
            this.btnIncluirTransferenciaEntrada.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirTransferenciaEntrada.TabIndex = 8;
            this.btnIncluirTransferenciaEntrada.Text = "Incluir Transferência entrada";
            this.btnIncluirTransferenciaEntrada.UseVisualStyleBackColor = false;
            this.btnIncluirTransferenciaEntrada.Visible = false;
            this.btnIncluirTransferenciaEntrada.Click += new System.EventHandler(this.btnIncluirSaida_Click);
            // 
            // btnIncluirRecebimento
            // 
            this.btnIncluirRecebimento.BackColor = System.Drawing.Color.Black;
            this.btnIncluirRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirRecebimento.ForeColor = System.Drawing.Color.White;
            this.btnIncluirRecebimento.Location = new System.Drawing.Point(438, 43);
            this.btnIncluirRecebimento.Name = "btnIncluirRecebimento";
            this.btnIncluirRecebimento.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirRecebimento.TabIndex = 7;
            this.btnIncluirRecebimento.Text = "Incluir Recebimento";
            this.btnIncluirRecebimento.UseVisualStyleBackColor = false;
            this.btnIncluirRecebimento.Visible = false;
            this.btnIncluirRecebimento.Click += new System.EventHandler(this.btnIncluirRecebimento_Click);
            // 
            // btnIncluirLocais
            // 
            this.btnIncluirLocais.BackColor = System.Drawing.Color.Black;
            this.btnIncluirLocais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirLocais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirLocais.ForeColor = System.Drawing.Color.White;
            this.btnIncluirLocais.Location = new System.Drawing.Point(99, 124);
            this.btnIncluirLocais.Name = "btnIncluirLocais";
            this.btnIncluirLocais.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirLocais.TabIndex = 6;
            this.btnIncluirLocais.Text = "Incluir Locais";
            this.btnIncluirLocais.UseVisualStyleBackColor = false;
            this.btnIncluirLocais.Visible = false;
            this.btnIncluirLocais.Click += new System.EventHandler(this.btnIncluirLocais_Click);
            // 
            // btnIncluirPedidoCompra
            // 
            this.btnIncluirPedidoCompra.BackColor = System.Drawing.Color.Black;
            this.btnIncluirPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirPedidoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirPedidoCompra.ForeColor = System.Drawing.Color.White;
            this.btnIncluirPedidoCompra.Location = new System.Drawing.Point(438, 237);
            this.btnIncluirPedidoCompra.Name = "btnIncluirPedidoCompra";
            this.btnIncluirPedidoCompra.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirPedidoCompra.TabIndex = 4;
            this.btnIncluirPedidoCompra.Text = "Incluir Pedido de Compra";
            this.btnIncluirPedidoCompra.UseVisualStyleBackColor = false;
            this.btnIncluirPedidoCompra.Visible = false;
            this.btnIncluirPedidoCompra.Click += new System.EventHandler(this.btnIncluirPedidoCompra_Click);
            // 
            // btnIncluirTransferenciaSaida
            // 
            this.btnIncluirTransferenciaSaida.BackColor = System.Drawing.Color.Black;
            this.btnIncluirTransferenciaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirTransferenciaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTransferenciaSaida.ForeColor = System.Drawing.Color.White;
            this.btnIncluirTransferenciaSaida.Location = new System.Drawing.Point(438, 188);
            this.btnIncluirTransferenciaSaida.Name = "btnIncluirTransferenciaSaida";
            this.btnIncluirTransferenciaSaida.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirTransferenciaSaida.TabIndex = 3;
            this.btnIncluirTransferenciaSaida.Text = "Incluir Transferência saída";
            this.btnIncluirTransferenciaSaida.UseVisualStyleBackColor = false;
            this.btnIncluirTransferenciaSaida.Visible = false;
            this.btnIncluirTransferenciaSaida.Click += new System.EventHandler(this.btnIncluirRequisicaoSaida_Click);
            // 
            // btnIncluirMaterial
            // 
            this.btnIncluirMaterial.BackColor = System.Drawing.Color.Black;
            this.btnIncluirMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirMaterial.ForeColor = System.Drawing.Color.White;
            this.btnIncluirMaterial.Location = new System.Drawing.Point(99, 76);
            this.btnIncluirMaterial.Name = "btnIncluirMaterial";
            this.btnIncluirMaterial.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirMaterial.TabIndex = 2;
            this.btnIncluirMaterial.Text = "Incluir Material";
            this.btnIncluirMaterial.UseVisualStyleBackColor = false;
            this.btnIncluirMaterial.Visible = false;
            this.btnIncluirMaterial.Click += new System.EventHandler(this.btnIncluirMaterial_Click);
            // 
            // btnIncluirFornecedor
            // 
            this.btnIncluirFornecedor.BackColor = System.Drawing.Color.Black;
            this.btnIncluirFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnIncluirFornecedor.Location = new System.Drawing.Point(99, 28);
            this.btnIncluirFornecedor.Name = "btnIncluirFornecedor";
            this.btnIncluirFornecedor.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirFornecedor.TabIndex = 1;
            this.btnIncluirFornecedor.Text = "Incluir Fornecedor";
            this.btnIncluirFornecedor.UseVisualStyleBackColor = false;
            this.btnIncluirFornecedor.Visible = false;
            this.btnIncluirFornecedor.Click += new System.EventHandler(this.btnIncluirFornecedor_Click);
            // 
            // btnOperações
            // 
            this.btnOperações.BackColor = System.Drawing.Color.Black;
            this.btnOperações.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperações.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperações.ForeColor = System.Drawing.Color.White;
            this.btnOperações.Location = new System.Drawing.Point(446, 130);
            this.btnOperações.Name = "btnOperações";
            this.btnOperações.Size = new System.Drawing.Size(241, 32);
            this.btnOperações.TabIndex = 16;
            this.btnOperações.Text = "Operações";
            this.btnOperações.UseVisualStyleBackColor = false;
            this.btnOperações.Click += new System.EventHandler(this.btnOperações_Click_1);
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.Black;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.White;
            this.btnCadastros.Location = new System.Drawing.Point(79, 130);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(241, 32);
            this.btnCadastros.TabIndex = 15;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // Incluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbIncluir);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Incluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Incluir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Incluir_FormClosing);
            this.Load += new System.EventHandler(this.Incluir_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbIncluir.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox gpbIncluir;
        private System.Windows.Forms.Button btnIncluirTipoTransferencia;
        private System.Windows.Forms.Button btnIncluirTransferenciaEntrada;
        private System.Windows.Forms.Button btnIncluirRecebimento;
        private System.Windows.Forms.Button btnIncluirLocais;
        private System.Windows.Forms.Button btnIncluirPedidoCompra;
        private System.Windows.Forms.Button btnIncluirTransferenciaSaida;
        private System.Windows.Forms.Button btnIncluirMaterial;
        private System.Windows.Forms.Button btnIncluirFornecedor;
        private System.Windows.Forms.Button btnIncluirUsuario;
        private System.Windows.Forms.Button btnIncluirTipoMaterial;
        private System.Windows.Forms.Button btnIncluirUnidadeMedida;
        private System.Windows.Forms.Button btnOperações;
        private System.Windows.Forms.Button btnCadastros;
    }
}

