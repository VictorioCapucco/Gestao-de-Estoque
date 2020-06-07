﻿namespace GestaoEstoque
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
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbIncluir = new System.Windows.Forms.GroupBox();
            this.btnIncluirUsuario = new System.Windows.Forms.Button();
            this.btnIncluirTipoMaterial = new System.Windows.Forms.Button();
            this.btnIncluirTipoSaida = new System.Windows.Forms.Button();
            this.btnIncluirSaida = new System.Windows.Forms.Button();
            this.btnIncluirRecebimento = new System.Windows.Forms.Button();
            this.btnIncluirLocais = new System.Windows.Forms.Button();
            this.btnIncluirPedidoCompra = new System.Windows.Forms.Button();
            this.btnIncluirRequisicaoSaida = new System.Windows.Forms.Button();
            this.btnIncluirMaterial = new System.Windows.Forms.Button();
            this.btnIncluirFornecedor = new System.Windows.Forms.Button();
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
            this.toolStripSeparator2,
            this.toolStripExcluir,
            this.toolStripSeparator3});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(941, 42);
            this.toolStripMenu.TabIndex = 0;
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
            // gpbIncluir
            // 
            this.gpbIncluir.Controls.Add(this.btnIncluirUsuario);
            this.gpbIncluir.Controls.Add(this.btnIncluirTipoMaterial);
            this.gpbIncluir.Controls.Add(this.btnIncluirTipoSaida);
            this.gpbIncluir.Controls.Add(this.btnIncluirSaida);
            this.gpbIncluir.Controls.Add(this.btnIncluirRecebimento);
            this.gpbIncluir.Controls.Add(this.btnIncluirLocais);
            this.gpbIncluir.Controls.Add(this.btnIncluirPedidoCompra);
            this.gpbIncluir.Controls.Add(this.btnIncluirRequisicaoSaida);
            this.gpbIncluir.Controls.Add(this.btnIncluirMaterial);
            this.gpbIncluir.Controls.Add(this.btnIncluirFornecedor);
            this.gpbIncluir.Location = new System.Drawing.Point(123, 126);
            this.gpbIncluir.Name = "gpbIncluir";
            this.gpbIncluir.Size = new System.Drawing.Size(717, 294);
            this.gpbIncluir.TabIndex = 1;
            this.gpbIncluir.TabStop = false;
            // 
            // btnIncluirUsuario
            // 
            this.btnIncluirUsuario.BackColor = System.Drawing.Color.Black;
            this.btnIncluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirUsuario.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirUsuario.ForeColor = System.Drawing.Color.White;
            this.btnIncluirUsuario.Location = new System.Drawing.Point(391, 237);
            this.btnIncluirUsuario.Name = "btnIncluirUsuario";
            this.btnIncluirUsuario.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirUsuario.TabIndex = 12;
            this.btnIncluirUsuario.Text = "Incluir Usuário";
            this.btnIncluirUsuario.UseVisualStyleBackColor = false;
            // 
            // btnIncluirTipoMaterial
            // 
            this.btnIncluirTipoMaterial.BackColor = System.Drawing.Color.Black;
            this.btnIncluirTipoMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirTipoMaterial.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTipoMaterial.ForeColor = System.Drawing.Color.White;
            this.btnIncluirTipoMaterial.Location = new System.Drawing.Point(100, 237);
            this.btnIncluirTipoMaterial.Name = "btnIncluirTipoMaterial";
            this.btnIncluirTipoMaterial.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirTipoMaterial.TabIndex = 11;
            this.btnIncluirTipoMaterial.Text = "Incluir Tipo de Material";
            this.btnIncluirTipoMaterial.UseVisualStyleBackColor = false;
            this.btnIncluirTipoMaterial.Click += new System.EventHandler(this.btnIncluirTipoMaterial_Click);
            // 
            // btnIncluirTipoSaida
            // 
            this.btnIncluirTipoSaida.BackColor = System.Drawing.Color.Black;
            this.btnIncluirTipoSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirTipoSaida.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTipoSaida.ForeColor = System.Drawing.Color.White;
            this.btnIncluirTipoSaida.Location = new System.Drawing.Point(391, 189);
            this.btnIncluirTipoSaida.Name = "btnIncluirTipoSaida";
            this.btnIncluirTipoSaida.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirTipoSaida.TabIndex = 10;
            this.btnIncluirTipoSaida.Text = "Incluir Tipo de Saída";
            this.btnIncluirTipoSaida.UseVisualStyleBackColor = false;
            this.btnIncluirTipoSaida.Click += new System.EventHandler(this.btnIncluirTipoSaida_Click);
            // 
            // btnIncluirSaida
            // 
            this.btnIncluirSaida.BackColor = System.Drawing.Color.Black;
            this.btnIncluirSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirSaida.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirSaida.ForeColor = System.Drawing.Color.White;
            this.btnIncluirSaida.Location = new System.Drawing.Point(391, 141);
            this.btnIncluirSaida.Name = "btnIncluirSaida";
            this.btnIncluirSaida.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirSaida.TabIndex = 9;
            this.btnIncluirSaida.Text = "Incluir Saída";
            this.btnIncluirSaida.UseVisualStyleBackColor = false;
            // 
            // btnIncluirRecebimento
            // 
            this.btnIncluirRecebimento.BackColor = System.Drawing.Color.Black;
            this.btnIncluirRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirRecebimento.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirRecebimento.ForeColor = System.Drawing.Color.White;
            this.btnIncluirRecebimento.Location = new System.Drawing.Point(391, 93);
            this.btnIncluirRecebimento.Name = "btnIncluirRecebimento";
            this.btnIncluirRecebimento.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirRecebimento.TabIndex = 8;
            this.btnIncluirRecebimento.Text = "Incluir Recebimento";
            this.btnIncluirRecebimento.UseVisualStyleBackColor = false;
            // 
            // btnIncluirLocais
            // 
            this.btnIncluirLocais.BackColor = System.Drawing.Color.Black;
            this.btnIncluirLocais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirLocais.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirLocais.ForeColor = System.Drawing.Color.White;
            this.btnIncluirLocais.Location = new System.Drawing.Point(391, 45);
            this.btnIncluirLocais.Name = "btnIncluirLocais";
            this.btnIncluirLocais.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirLocais.TabIndex = 7;
            this.btnIncluirLocais.Text = "Incluir Locais";
            this.btnIncluirLocais.UseVisualStyleBackColor = false;
            this.btnIncluirLocais.Click += new System.EventHandler(this.btnIncluirLocais_Click);
            // 
            // btnIncluirPedidoCompra
            // 
            this.btnIncluirPedidoCompra.BackColor = System.Drawing.Color.Black;
            this.btnIncluirPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirPedidoCompra.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirPedidoCompra.ForeColor = System.Drawing.Color.White;
            this.btnIncluirPedidoCompra.Location = new System.Drawing.Point(100, 189);
            this.btnIncluirPedidoCompra.Name = "btnIncluirPedidoCompra";
            this.btnIncluirPedidoCompra.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirPedidoCompra.TabIndex = 5;
            this.btnIncluirPedidoCompra.Text = "Incluir Pedido de Compra";
            this.btnIncluirPedidoCompra.UseVisualStyleBackColor = false;
            // 
            // btnIncluirRequisicaoSaida
            // 
            this.btnIncluirRequisicaoSaida.BackColor = System.Drawing.Color.Black;
            this.btnIncluirRequisicaoSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirRequisicaoSaida.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirRequisicaoSaida.ForeColor = System.Drawing.Color.White;
            this.btnIncluirRequisicaoSaida.Location = new System.Drawing.Point(100, 141);
            this.btnIncluirRequisicaoSaida.Name = "btnIncluirRequisicaoSaida";
            this.btnIncluirRequisicaoSaida.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirRequisicaoSaida.TabIndex = 4;
            this.btnIncluirRequisicaoSaida.Text = "Incluir Requisição de saída";
            this.btnIncluirRequisicaoSaida.UseVisualStyleBackColor = false;
            // 
            // btnIncluirMaterial
            // 
            this.btnIncluirMaterial.BackColor = System.Drawing.Color.Black;
            this.btnIncluirMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirMaterial.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirMaterial.ForeColor = System.Drawing.Color.White;
            this.btnIncluirMaterial.Location = new System.Drawing.Point(100, 93);
            this.btnIncluirMaterial.Name = "btnIncluirMaterial";
            this.btnIncluirMaterial.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirMaterial.TabIndex = 3;
            this.btnIncluirMaterial.Text = "Incluir Material";
            this.btnIncluirMaterial.UseVisualStyleBackColor = false;
            // 
            // btnIncluirFornecedor
            // 
            this.btnIncluirFornecedor.BackColor = System.Drawing.Color.Black;
            this.btnIncluirFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirFornecedor.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnIncluirFornecedor.Location = new System.Drawing.Point(100, 45);
            this.btnIncluirFornecedor.Name = "btnIncluirFornecedor";
            this.btnIncluirFornecedor.Size = new System.Drawing.Size(241, 32);
            this.btnIncluirFornecedor.TabIndex = 2;
            this.btnIncluirFornecedor.Text = "Incluir Fornecedor";
            this.btnIncluirFornecedor.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox gpbIncluir;
        private System.Windows.Forms.Button btnIncluirTipoSaida;
        private System.Windows.Forms.Button btnIncluirSaida;
        private System.Windows.Forms.Button btnIncluirRecebimento;
        private System.Windows.Forms.Button btnIncluirLocais;
        private System.Windows.Forms.Button btnIncluirPedidoCompra;
        private System.Windows.Forms.Button btnIncluirRequisicaoSaida;
        private System.Windows.Forms.Button btnIncluirMaterial;
        private System.Windows.Forms.Button btnIncluirFornecedor;
        private System.Windows.Forms.Button btnIncluirUsuario;
        private System.Windows.Forms.Button btnIncluirTipoMaterial;
    }
}
