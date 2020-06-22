namespace GestaoEstoque
{
    partial class IncluirTransferenciaSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncluirTransferenciaSaida));
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
            this.gpbIncluirTransferencia = new System.Windows.Forms.GroupBox();
            this.btnConfirmarLocalOrigem = new System.Windows.Forms.Button();
            this.btnConfirmarLocalDestino = new System.Windows.Forms.Button();
            this.cmbLocalDestino = new System.Windows.Forms.ComboBox();
            this.lblLocalDestino = new System.Windows.Forms.Label();
            this.btnConfirmarTipoTransferencia = new System.Windows.Forms.Button();
            this.lblTipoTransferencia = new System.Windows.Forms.Label();
            this.cmbTipoTransferencia = new System.Windows.Forms.ComboBox();
            this.lblDataTransferencia = new System.Windows.Forms.Label();
            this.cmbLocalOrigem = new System.Windows.Forms.ComboBox();
            this.mskDataTransferencia = new System.Windows.Forms.MaskedTextBox();
            this.lblLocalOrigem = new System.Windows.Forms.Label();
            this.lblCodigoMaterial = new System.Windows.Forms.Label();
            this.btnAdicionarMaterial = new System.Windows.Forms.Button();
            this.txtCodigoMaterial = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluirTransferência = new System.Windows.Forms.Button();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.gpbMateriais = new System.Windows.Forms.GroupBox();
            this.toolStripMenu.SuspendLayout();
            this.gpbIncluirTransferencia.SuspendLayout();
            this.gpbMateriais.SuspendLayout();
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
            this.toolStripMenu.TabIndex = 22;
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
            this.btnLixeira.Location = new System.Drawing.Point(772, 369);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(40, 37);
            this.btnLixeira.TabIndex = 10;
            this.btnLixeira.UseVisualStyleBackColor = true;
            this.btnLixeira.Visible = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenos.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(712, 369);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMenos.Size = new System.Drawing.Size(40, 37);
            this.btnMenos.TabIndex = 9;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Visible = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMais.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(666, 369);
            this.btnMais.Name = "btnMais";
            this.btnMais.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMais.Size = new System.Drawing.Size(40, 37);
            this.btnMais.TabIndex = 8;
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
            this.lstboxMateriais.Location = new System.Drawing.Point(546, 85);
            this.lstboxMateriais.Name = "lstboxMateriais";
            this.lstboxMateriais.Size = new System.Drawing.Size(363, 276);
            this.lstboxMateriais.TabIndex = 13;
            this.lstboxMateriais.Visible = false;
            // 
            // gpbIncluirTransferencia
            // 
            this.gpbIncluirTransferencia.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluirTransferencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbIncluirTransferencia.Controls.Add(this.btnConfirmarLocalOrigem);
            this.gpbIncluirTransferencia.Controls.Add(this.btnConfirmarLocalDestino);
            this.gpbIncluirTransferencia.Controls.Add(this.cmbLocalDestino);
            this.gpbIncluirTransferencia.Controls.Add(this.lblLocalDestino);
            this.gpbIncluirTransferencia.Controls.Add(this.btnConfirmarTipoTransferencia);
            this.gpbIncluirTransferencia.Controls.Add(this.lblTipoTransferencia);
            this.gpbIncluirTransferencia.Controls.Add(this.cmbTipoTransferencia);
            this.gpbIncluirTransferencia.Controls.Add(this.lblDataTransferencia);
            this.gpbIncluirTransferencia.Controls.Add(this.cmbLocalOrigem);
            this.gpbIncluirTransferencia.Controls.Add(this.mskDataTransferencia);
            this.gpbIncluirTransferencia.Controls.Add(this.lblLocalOrigem);
            this.gpbIncluirTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbIncluirTransferencia.Location = new System.Drawing.Point(41, 81);
            this.gpbIncluirTransferencia.Name = "gpbIncluirTransferencia";
            this.gpbIncluirTransferencia.Size = new System.Drawing.Size(499, 176);
            this.gpbIncluirTransferencia.TabIndex = 20;
            this.gpbIncluirTransferencia.TabStop = false;
            // 
            // btnConfirmarLocalOrigem
            // 
            this.btnConfirmarLocalOrigem.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmarLocalOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarLocalOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarLocalOrigem.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarLocalOrigem.Location = new System.Drawing.Point(136, 97);
            this.btnConfirmarLocalOrigem.Name = "btnConfirmarLocalOrigem";
            this.btnConfirmarLocalOrigem.Size = new System.Drawing.Size(239, 30);
            this.btnConfirmarLocalOrigem.TabIndex = 3;
            this.btnConfirmarLocalOrigem.Text = "Confirmar Local Origem";
            this.btnConfirmarLocalOrigem.UseVisualStyleBackColor = false;
            this.btnConfirmarLocalOrigem.Visible = false;
            this.btnConfirmarLocalOrigem.Click += new System.EventHandler(this.btnConfirmarLocalOrigem_Click);
            // 
            // btnConfirmarLocalDestino
            // 
            this.btnConfirmarLocalDestino.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmarLocalDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarLocalDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarLocalDestino.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarLocalDestino.Location = new System.Drawing.Point(135, 133);
            this.btnConfirmarLocalDestino.Name = "btnConfirmarLocalDestino";
            this.btnConfirmarLocalDestino.Size = new System.Drawing.Size(239, 30);
            this.btnConfirmarLocalDestino.TabIndex = 5;
            this.btnConfirmarLocalDestino.Text = "Confirmar Local Destino";
            this.btnConfirmarLocalDestino.UseVisualStyleBackColor = false;
            this.btnConfirmarLocalDestino.Visible = false;
            this.btnConfirmarLocalDestino.Click += new System.EventHandler(this.btnConfirmarLocalDestino_Click);
            // 
            // cmbLocalDestino
            // 
            this.cmbLocalDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalDestino.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalDestino.FormattingEnabled = true;
            this.cmbLocalDestino.Location = new System.Drawing.Point(275, 97);
            this.cmbLocalDestino.Name = "cmbLocalDestino";
            this.cmbLocalDestino.Size = new System.Drawing.Size(174, 26);
            this.cmbLocalDestino.TabIndex = 4;
            this.cmbLocalDestino.Visible = false;
            // 
            // lblLocalDestino
            // 
            this.lblLocalDestino.AutoSize = true;
            this.lblLocalDestino.BackColor = System.Drawing.Color.Gray;
            this.lblLocalDestino.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDestino.Location = new System.Drawing.Point(60, 97);
            this.lblLocalDestino.Name = "lblLocalDestino";
            this.lblLocalDestino.Padding = new System.Windows.Forms.Padding(38, 5, 37, 5);
            this.lblLocalDestino.Size = new System.Drawing.Size(194, 28);
            this.lblLocalDestino.TabIndex = 17;
            this.lblLocalDestino.Text = "Local Destino";
            this.lblLocalDestino.Visible = false;
            // 
            // btnConfirmarTipoTransferencia
            // 
            this.btnConfirmarTipoTransferencia.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmarTipoTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarTipoTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarTipoTransferencia.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarTipoTransferencia.Location = new System.Drawing.Point(136, 63);
            this.btnConfirmarTipoTransferencia.Name = "btnConfirmarTipoTransferencia";
            this.btnConfirmarTipoTransferencia.Size = new System.Drawing.Size(239, 30);
            this.btnConfirmarTipoTransferencia.TabIndex = 1;
            this.btnConfirmarTipoTransferencia.Text = "Confirmar Tipo de Transferencia";
            this.btnConfirmarTipoTransferencia.UseVisualStyleBackColor = false;
            this.btnConfirmarTipoTransferencia.Click += new System.EventHandler(this.btnConfirmarTipoTransferencia_Click);
            // 
            // lblTipoTransferencia
            // 
            this.lblTipoTransferencia.AutoSize = true;
            this.lblTipoTransferencia.BackColor = System.Drawing.Color.Gray;
            this.lblTipoTransferencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTransferencia.Location = new System.Drawing.Point(60, 29);
            this.lblTipoTransferencia.Name = "lblTipoTransferencia";
            this.lblTipoTransferencia.Padding = new System.Windows.Forms.Padding(18, 5, 19, 5);
            this.lblTipoTransferencia.Size = new System.Drawing.Size(194, 28);
            this.lblTipoTransferencia.TabIndex = 15;
            this.lblTipoTransferencia.Text = "Tipo Transferência";
            // 
            // cmbTipoTransferencia
            // 
            this.cmbTipoTransferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTransferencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoTransferencia.FormattingEnabled = true;
            this.cmbTipoTransferencia.Location = new System.Drawing.Point(275, 29);
            this.cmbTipoTransferencia.Name = "cmbTipoTransferencia";
            this.cmbTipoTransferencia.Size = new System.Drawing.Size(174, 26);
            this.cmbTipoTransferencia.TabIndex = 0;
            // 
            // lblDataTransferencia
            // 
            this.lblDataTransferencia.AutoSize = true;
            this.lblDataTransferencia.BackColor = System.Drawing.Color.Gray;
            this.lblDataTransferencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTransferencia.Location = new System.Drawing.Point(60, 133);
            this.lblDataTransferencia.Name = "lblDataTransferencia";
            this.lblDataTransferencia.Padding = new System.Windows.Forms.Padding(17, 5, 16, 5);
            this.lblDataTransferencia.Size = new System.Drawing.Size(194, 28);
            this.lblDataTransferencia.TabIndex = 18;
            this.lblDataTransferencia.Text = "Data Transferência";
            this.lblDataTransferencia.Visible = false;
            // 
            // cmbLocalOrigem
            // 
            this.cmbLocalOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalOrigem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalOrigem.FormattingEnabled = true;
            this.cmbLocalOrigem.Location = new System.Drawing.Point(275, 63);
            this.cmbLocalOrigem.Name = "cmbLocalOrigem";
            this.cmbLocalOrigem.Size = new System.Drawing.Size(174, 26);
            this.cmbLocalOrigem.TabIndex = 2;
            this.cmbLocalOrigem.Visible = false;
            // 
            // mskDataTransferencia
            // 
            this.mskDataTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataTransferencia.Location = new System.Drawing.Point(275, 132);
            this.mskDataTransferencia.Mask = "99/99/9999";
            this.mskDataTransferencia.Name = "mskDataTransferencia";
            this.mskDataTransferencia.Size = new System.Drawing.Size(86, 26);
            this.mskDataTransferencia.TabIndex = 5;
            this.mskDataTransferencia.Visible = false;
            // 
            // lblLocalOrigem
            // 
            this.lblLocalOrigem.AutoSize = true;
            this.lblLocalOrigem.BackColor = System.Drawing.Color.Gray;
            this.lblLocalOrigem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalOrigem.Location = new System.Drawing.Point(60, 63);
            this.lblLocalOrigem.Name = "lblLocalOrigem";
            this.lblLocalOrigem.Padding = new System.Windows.Forms.Padding(40, 5, 39, 5);
            this.lblLocalOrigem.Size = new System.Drawing.Size(194, 28);
            this.lblLocalOrigem.TabIndex = 16;
            this.lblLocalOrigem.Text = "Local Origem";
            this.lblLocalOrigem.Visible = false;
            // 
            // lblCodigoMaterial
            // 
            this.lblCodigoMaterial.AutoSize = true;
            this.lblCodigoMaterial.BackColor = System.Drawing.Color.Gray;
            this.lblCodigoMaterial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMaterial.Location = new System.Drawing.Point(60, 19);
            this.lblCodigoMaterial.Name = "lblCodigoMaterial";
            this.lblCodigoMaterial.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblCodigoMaterial.Size = new System.Drawing.Size(194, 28);
            this.lblCodigoMaterial.TabIndex = 19;
            this.lblCodigoMaterial.Text = "Codigo do material";
            // 
            // btnAdicionarMaterial
            // 
            this.btnAdicionarMaterial.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarMaterial.Location = new System.Drawing.Point(183, 60);
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
            this.txtCodigoMaterial.Location = new System.Drawing.Point(275, 21);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.Size = new System.Drawing.Size(174, 26);
            this.txtCodigoMaterial.TabIndex = 6;
            this.txtCodigoMaterial.Text = "  F1 para consultar";
            this.txtCodigoMaterial.Click += new System.EventHandler(this.txtCodigoMaterial_Click);
            this.txtCodigoMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoMaterial_KeyDown);
            this.txtCodigoMaterial.Leave += new System.EventHandler(this.txtCodigoMaterial_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(385, 428);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 32);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluirTransferência
            // 
            this.btnIncluirTransferência.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIncluirTransferência.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirTransferência.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTransferência.ForeColor = System.Drawing.Color.White;
            this.btnIncluirTransferência.Location = new System.Drawing.Point(176, 428);
            this.btnIncluirTransferência.Name = "btnIncluirTransferência";
            this.btnIncluirTransferência.Size = new System.Drawing.Size(203, 32);
            this.btnIncluirTransferência.TabIndex = 11;
            this.btnIncluirTransferência.Text = "Incluir Transferência";
            this.btnIncluirTransferência.UseVisualStyleBackColor = false;
            this.btnIncluirTransferência.Visible = false;
            this.btnIncluirTransferência.Click += new System.EventHandler(this.btnIncluirRequisicaoSaida_Click);
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.BackColor = System.Drawing.Color.Transparent;
            this.lblLegenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.ForeColor = System.Drawing.Color.White;
            this.lblLegenda.Location = new System.Drawing.Point(547, 65);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(350, 18);
            this.lblLegenda.TabIndex = 14;
            this.lblLegenda.Text = "Codigo     Nome                   Quantidade";
            this.lblLegenda.Visible = false;
            // 
            // gpbMateriais
            // 
            this.gpbMateriais.BackColor = System.Drawing.Color.DimGray;
            this.gpbMateriais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbMateriais.Controls.Add(this.btnAdicionarMaterial);
            this.gpbMateriais.Controls.Add(this.txtCodigoMaterial);
            this.gpbMateriais.Controls.Add(this.lblCodigoMaterial);
            this.gpbMateriais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbMateriais.Location = new System.Drawing.Point(41, 263);
            this.gpbMateriais.Name = "gpbMateriais";
            this.gpbMateriais.Size = new System.Drawing.Size(499, 100);
            this.gpbMateriais.TabIndex = 21;
            this.gpbMateriais.TabStop = false;
            this.gpbMateriais.Visible = false;
            // 
            // IncluirTransferenciaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbMateriais);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.btnLixeira);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluirTransferência);
            this.Controls.Add(this.lstboxMateriais);
            this.Controls.Add(this.gpbIncluirTransferencia);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncluirTransferenciaSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Incluir Transferência de saída";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncluirRequisicaoSaida_FormClosing);
            this.Load += new System.EventHandler(this.IncluirRequisicaoSaida_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbIncluirTransferencia.ResumeLayout(false);
            this.gpbIncluirTransferencia.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnLixeira;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.ListBox lstboxMateriais;
        private System.Windows.Forms.GroupBox gpbIncluirTransferencia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluirTransferência;
        private System.Windows.Forms.Button btnAdicionarMaterial;
        private System.Windows.Forms.TextBox txtCodigoMaterial;
        private System.Windows.Forms.Label lblLocalOrigem;
        private System.Windows.Forms.Label lblCodigoMaterial;
        private System.Windows.Forms.ComboBox cmbLocalOrigem;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.GroupBox gpbMateriais;
        private System.Windows.Forms.Label lblTipoTransferencia;
        private System.Windows.Forms.ComboBox cmbTipoTransferencia;
        private System.Windows.Forms.Label lblDataTransferencia;
        private System.Windows.Forms.MaskedTextBox mskDataTransferencia;
        private System.Windows.Forms.Button btnConfirmarTipoTransferencia;
        private System.Windows.Forms.ComboBox cmbLocalDestino;
        private System.Windows.Forms.Label lblLocalDestino;
        private System.Windows.Forms.Button btnConfirmarLocalOrigem;
        private System.Windows.Forms.Button btnConfirmarLocalDestino;
    }
}