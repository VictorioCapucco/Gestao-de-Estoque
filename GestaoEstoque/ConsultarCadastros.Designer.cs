namespace GestaoEstoque
{
    partial class ConsultarCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCadastros));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbIncluir = new System.Windows.Forms.GroupBox();
            this.btnConsultarLocais = new System.Windows.Forms.Button();
            this.btnConsultarTipoMaterial = new System.Windows.Forms.Button();
            this.btnConsultarUnidadeMedida = new System.Windows.Forms.Button();
            this.btnConsultarTipoTransferencia = new System.Windows.Forms.Button();
            this.btnConsultarUsuario = new System.Windows.Forms.Button();
            this.btnConsultarMaterial = new System.Windows.Forms.Button();
            this.btnConsultarFornecedor = new System.Windows.Forms.Button();
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
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // gpbIncluir
            // 
            this.gpbIncluir.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluir.Controls.Add(this.btnConsultarLocais);
            this.gpbIncluir.Controls.Add(this.btnConsultarTipoMaterial);
            this.gpbIncluir.Controls.Add(this.btnConsultarUnidadeMedida);
            this.gpbIncluir.Controls.Add(this.btnConsultarTipoTransferencia);
            this.gpbIncluir.Controls.Add(this.btnConsultarUsuario);
            this.gpbIncluir.Controls.Add(this.btnConsultarMaterial);
            this.gpbIncluir.Controls.Add(this.btnConsultarFornecedor);
            this.gpbIncluir.Location = new System.Drawing.Point(123, 126);
            this.gpbIncluir.Name = "gpbIncluir";
            this.gpbIncluir.Size = new System.Drawing.Size(717, 323);
            this.gpbIncluir.TabIndex = 17;
            this.gpbIncluir.TabStop = false;
            // 
            // btnConsultarLocais
            // 
            this.btnConsultarLocais.BackColor = System.Drawing.Color.Black;
            this.btnConsultarLocais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarLocais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLocais.ForeColor = System.Drawing.Color.White;
            this.btnConsultarLocais.Location = new System.Drawing.Point(242, 107);
            this.btnConsultarLocais.Name = "btnConsultarLocais";
            this.btnConsultarLocais.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarLocais.TabIndex = 24;
            this.btnConsultarLocais.Text = "Consultar Locais";
            this.btnConsultarLocais.UseVisualStyleBackColor = false;
            this.btnConsultarLocais.Click += new System.EventHandler(this.btnConsultarLocais_Click);
            // 
            // btnConsultarTipoMaterial
            // 
            this.btnConsultarTipoMaterial.BackColor = System.Drawing.Color.Black;
            this.btnConsultarTipoMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarTipoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTipoMaterial.ForeColor = System.Drawing.Color.White;
            this.btnConsultarTipoMaterial.Location = new System.Drawing.Point(242, 189);
            this.btnConsultarTipoMaterial.Name = "btnConsultarTipoMaterial";
            this.btnConsultarTipoMaterial.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarTipoMaterial.TabIndex = 23;
            this.btnConsultarTipoMaterial.Text = "Consultar Tipo Material";
            this.btnConsultarTipoMaterial.UseVisualStyleBackColor = false;
            this.btnConsultarTipoMaterial.Click += new System.EventHandler(this.btnConsultarTipoMaterial_Click);
            // 
            // btnConsultarUnidadeMedida
            // 
            this.btnConsultarUnidadeMedida.BackColor = System.Drawing.Color.Black;
            this.btnConsultarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarUnidadeMedida.ForeColor = System.Drawing.Color.White;
            this.btnConsultarUnidadeMedida.Location = new System.Drawing.Point(242, 148);
            this.btnConsultarUnidadeMedida.Name = "btnConsultarUnidadeMedida";
            this.btnConsultarUnidadeMedida.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarUnidadeMedida.TabIndex = 21;
            this.btnConsultarUnidadeMedida.Text = "Consultar Unidade de medida";
            this.btnConsultarUnidadeMedida.UseVisualStyleBackColor = false;
            this.btnConsultarUnidadeMedida.Click += new System.EventHandler(this.btnConsultarUnidadeMedida_Click);
            // 
            // btnConsultarTipoTransferencia
            // 
            this.btnConsultarTipoTransferencia.BackColor = System.Drawing.Color.Black;
            this.btnConsultarTipoTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarTipoTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTipoTransferencia.ForeColor = System.Drawing.Color.White;
            this.btnConsultarTipoTransferencia.Location = new System.Drawing.Point(241, 271);
            this.btnConsultarTipoTransferencia.Name = "btnConsultarTipoTransferencia";
            this.btnConsultarTipoTransferencia.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarTipoTransferencia.TabIndex = 20;
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
            this.btnConsultarUsuario.Location = new System.Drawing.Point(242, 230);
            this.btnConsultarUsuario.Name = "btnConsultarUsuario";
            this.btnConsultarUsuario.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarUsuario.TabIndex = 19;
            this.btnConsultarUsuario.Text = "Consultar Usuario";
            this.btnConsultarUsuario.UseVisualStyleBackColor = false;
            this.btnConsultarUsuario.Click += new System.EventHandler(this.btnConsultarUsuario_Click);
            // 
            // btnConsultarMaterial
            // 
            this.btnConsultarMaterial.BackColor = System.Drawing.Color.Black;
            this.btnConsultarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnConsultarMaterial.Location = new System.Drawing.Point(241, 66);
            this.btnConsultarMaterial.Name = "btnConsultarMaterial";
            this.btnConsultarMaterial.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarMaterial.TabIndex = 18;
            this.btnConsultarMaterial.Text = "Consultar Material";
            this.btnConsultarMaterial.UseVisualStyleBackColor = false;
            this.btnConsultarMaterial.Click += new System.EventHandler(this.btnConsultarMaterial_Click);
            // 
            // btnConsultarFornecedor
            // 
            this.btnConsultarFornecedor.BackColor = System.Drawing.Color.Black;
            this.btnConsultarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFornecedor.Location = new System.Drawing.Point(241, 25);
            this.btnConsultarFornecedor.Name = "btnConsultarFornecedor";
            this.btnConsultarFornecedor.Size = new System.Drawing.Size(241, 32);
            this.btnConsultarFornecedor.TabIndex = 17;
            this.btnConsultarFornecedor.Text = "Consultar Fornecedor";
            this.btnConsultarFornecedor.UseVisualStyleBackColor = false;
            this.btnConsultarFornecedor.Click += new System.EventHandler(this.btnConsultarFornecedor_Click);
            // 
            // ConsultarCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbIncluir);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConsultarCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar Cadastros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarCadastros_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarCadastros_Load);
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
        private System.Windows.Forms.Button btnConsultarTipoMaterial;
        private System.Windows.Forms.Button btnConsultarUnidadeMedida;
        private System.Windows.Forms.Button btnConsultarTipoTransferencia;
        private System.Windows.Forms.Button btnConsultarUsuario;
        private System.Windows.Forms.Button btnConsultarMaterial;
        private System.Windows.Forms.Button btnConsultarFornecedor;
        private System.Windows.Forms.Button btnConsultarLocais;
    }
}