namespace GestaoEstoque
{
    partial class IncluirRequisicaoSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncluirRequisicaoSaida));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.lstboxMateriais = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirmarLocal = new System.Windows.Forms.Button();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblCodigoMaterial = new System.Windows.Forms.Label();
            this.btnAdicionarMaterial = new System.Windows.Forms.Button();
            this.txtCodigoMaterial = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluirRequisicaoSaida = new System.Windows.Forms.Button();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // btnLixeira
            // 
            this.btnLixeira.BackgroundImage = global::GestaoEstoque.Properties.Resources.Lixeira;
            this.btnLixeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLixeira.Location = new System.Drawing.Point(771, 347);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(40, 37);
            this.btnLixeira.TabIndex = 6;
            this.btnLixeira.UseVisualStyleBackColor = true;
            this.btnLixeira.Visible = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenos.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(711, 347);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMenos.Size = new System.Drawing.Size(40, 37);
            this.btnMenos.TabIndex = 5;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Visible = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMais.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(665, 347);
            this.btnMais.Name = "btnMais";
            this.btnMais.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMais.Size = new System.Drawing.Size(40, 37);
            this.btnMais.TabIndex = 4;
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
            this.lstboxMateriais.Location = new System.Drawing.Point(546, 121);
            this.lstboxMateriais.Name = "lstboxMateriais";
            this.lstboxMateriais.Size = new System.Drawing.Size(363, 212);
            this.lstboxMateriais.TabIndex = 9;
            this.lstboxMateriais.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnConfirmarLocal);
            this.groupBox1.Controls.Add(this.cmbLocal);
            this.groupBox1.Controls.Add(this.lblLocal);
            this.groupBox1.Controls.Add(this.lblCodigoMaterial);
            this.groupBox1.Controls.Add(this.btnAdicionarMaterial);
            this.groupBox1.Controls.Add(this.txtCodigoMaterial);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(33, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 216);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnConfirmarLocal
            // 
            this.btnConfirmarLocal.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarLocal.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarLocal.Location = new System.Drawing.Point(162, 107);
            this.btnConfirmarLocal.Name = "btnConfirmarLocal";
            this.btnConfirmarLocal.Size = new System.Drawing.Size(129, 30);
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
            this.cmbLocal.Location = new System.Drawing.Point(234, 67);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(174, 26);
            this.cmbLocal.TabIndex = 0;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.BackColor = System.Drawing.Color.Gray;
            this.lblLocal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(19, 65);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Padding = new System.Windows.Forms.Padding(72, 5, 72, 5);
            this.lblLocal.Size = new System.Drawing.Size(194, 28);
            this.lblLocal.TabIndex = 10;
            this.lblLocal.Text = "Local";
            // 
            // lblCodigoMaterial
            // 
            this.lblCodigoMaterial.AutoSize = true;
            this.lblCodigoMaterial.BackColor = System.Drawing.Color.Gray;
            this.lblCodigoMaterial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMaterial.Location = new System.Drawing.Point(19, 108);
            this.lblCodigoMaterial.Name = "lblCodigoMaterial";
            this.lblCodigoMaterial.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblCodigoMaterial.Size = new System.Drawing.Size(194, 28);
            this.lblCodigoMaterial.TabIndex = 11;
            this.lblCodigoMaterial.Text = "Codigo do material";
            this.lblCodigoMaterial.Visible = false;
            // 
            // btnAdicionarMaterial
            // 
            this.btnAdicionarMaterial.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarMaterial.Location = new System.Drawing.Point(172, 161);
            this.btnAdicionarMaterial.Name = "btnAdicionarMaterial";
            this.btnAdicionarMaterial.Size = new System.Drawing.Size(138, 30);
            this.btnAdicionarMaterial.TabIndex = 3;
            this.btnAdicionarMaterial.Text = "Adicionar Material";
            this.btnAdicionarMaterial.UseVisualStyleBackColor = false;
            this.btnAdicionarMaterial.Visible = false;
            this.btnAdicionarMaterial.Click += new System.EventHandler(this.btnAdicionarMaterial_Click);
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMaterial.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigoMaterial.Location = new System.Drawing.Point(234, 110);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.Size = new System.Drawing.Size(174, 26);
            this.txtCodigoMaterial.TabIndex = 2;
            this.txtCodigoMaterial.Text = "  F1 para consultar";
            this.txtCodigoMaterial.Visible = false;
            this.txtCodigoMaterial.Click += new System.EventHandler(this.txtCodigoMaterial_Click);
            this.txtCodigoMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoMaterial_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(494, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluirRequisicaoSaida
            // 
            this.btnIncluirRequisicaoSaida.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIncluirRequisicaoSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirRequisicaoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirRequisicaoSaida.ForeColor = System.Drawing.Color.White;
            this.btnIncluirRequisicaoSaida.Location = new System.Drawing.Point(285, 410);
            this.btnIncluirRequisicaoSaida.Name = "btnIncluirRequisicaoSaida";
            this.btnIncluirRequisicaoSaida.Size = new System.Drawing.Size(203, 32);
            this.btnIncluirRequisicaoSaida.TabIndex = 7;
            this.btnIncluirRequisicaoSaida.Text = "Incluir Requisição";
            this.btnIncluirRequisicaoSaida.UseVisualStyleBackColor = false;
            this.btnIncluirRequisicaoSaida.Visible = false;
            this.btnIncluirRequisicaoSaida.Click += new System.EventHandler(this.btnIncluirRequisicaoSaida_Click);
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.BackColor = System.Drawing.Color.Transparent;
            this.lblLegenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.ForeColor = System.Drawing.Color.White;
            this.lblLegenda.Location = new System.Drawing.Point(547, 100);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(350, 18);
            this.lblLegenda.TabIndex = 12;
            this.lblLegenda.Text = "Codigo     Nome                   Quantidade";
            this.lblLegenda.Visible = false;
            // 
            // IncluirRequisicaoSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.btnLixeira);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluirRequisicaoSaida);
            this.Controls.Add(this.lstboxMateriais);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncluirRequisicaoSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Incluir requisição de saída";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncluirRequisicaoSaida_FormClosing);
            this.Load += new System.EventHandler(this.IncluirRequisicaoSaida_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnLixeira;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.ListBox lstboxMateriais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluirRequisicaoSaida;
        private System.Windows.Forms.Button btnAdicionarMaterial;
        private System.Windows.Forms.TextBox txtCodigoMaterial;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblCodigoMaterial;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Button btnConfirmarLocal;
        private System.Windows.Forms.Label lblLegenda;
    }
}