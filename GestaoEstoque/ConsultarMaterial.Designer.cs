namespace GestaoEstoque
{
    partial class ConsultarMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarMaterial));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lstboxLocaisInclusos = new System.Windows.Forms.ListBox();
            this.gpbLocal = new System.Windows.Forms.GroupBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnAdicionarLocal = new System.Windows.Forms.Button();
            this.txtCodigoLocal = new System.Windows.Forms.TextBox();
            this.lblCodigoLocal = new System.Windows.Forms.Label();
            this.gpbIncluirMaterial = new System.Windows.Forms.GroupBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.btnConfirmarMaterial = new System.Windows.Forms.Button();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.cmbTipoMaterial = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lstboxLocaisAdicionar = new System.Windows.Forms.ListBox();
            this.lblLegendaIncluso = new System.Windows.Forms.Label();
            this.lblLegendaAdicionar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.gpbLocal.SuspendLayout();
            this.gpbIncluirMaterial.SuspendLayout();
            this.panelStatus.SuspendLayout();
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
            this.toolStripMenu.TabIndex = 20;
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
            // lstboxLocaisInclusos
            // 
            this.lstboxLocaisInclusos.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxLocaisInclusos.FormattingEnabled = true;
            this.lstboxLocaisInclusos.ItemHeight = 16;
            this.lstboxLocaisInclusos.Location = new System.Drawing.Point(538, 97);
            this.lstboxLocaisInclusos.Name = "lstboxLocaisInclusos";
            this.lstboxLocaisInclusos.Size = new System.Drawing.Size(363, 132);
            this.lstboxLocaisInclusos.TabIndex = 27;
            this.lstboxLocaisInclusos.Visible = false;
            // 
            // gpbLocal
            // 
            this.gpbLocal.BackColor = System.Drawing.Color.DimGray;
            this.gpbLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbLocal.Controls.Add(this.btnAjuda);
            this.gpbLocal.Controls.Add(this.btnAdicionarLocal);
            this.gpbLocal.Controls.Add(this.txtCodigoLocal);
            this.gpbLocal.Controls.Add(this.lblCodigoLocal);
            this.gpbLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbLocal.Location = new System.Drawing.Point(39, 298);
            this.gpbLocal.Name = "gpbLocal";
            this.gpbLocal.Size = new System.Drawing.Size(460, 100);
            this.gpbLocal.TabIndex = 26;
            this.gpbLocal.TabStop = false;
            this.gpbLocal.Visible = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Black;
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjuda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.White;
            this.btnAjuda.Location = new System.Drawing.Point(399, 19);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAjuda.Size = new System.Drawing.Size(26, 26);
            this.btnAjuda.TabIndex = 33;
            this.btnAjuda.Text = "? ";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnAdicionarLocal
            // 
            this.btnAdicionarLocal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarLocal.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarLocal.Location = new System.Drawing.Point(167, 58);
            this.btnAdicionarLocal.Name = "btnAdicionarLocal";
            this.btnAdicionarLocal.Size = new System.Drawing.Size(138, 30);
            this.btnAdicionarLocal.TabIndex = 7;
            this.btnAdicionarLocal.Text = "Adicionar Local";
            this.btnAdicionarLocal.UseVisualStyleBackColor = false;
            this.btnAdicionarLocal.Click += new System.EventHandler(this.btnAdicionarLocal_Click);
            // 
            // txtCodigoLocal
            // 
            this.txtCodigoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLocal.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigoLocal.Location = new System.Drawing.Point(213, 19);
            this.txtCodigoLocal.Name = "txtCodigoLocal";
            this.txtCodigoLocal.Size = new System.Drawing.Size(174, 26);
            this.txtCodigoLocal.TabIndex = 6;
            this.txtCodigoLocal.Text = "  F1 para consultar";
            this.txtCodigoLocal.Enter += new System.EventHandler(this.txtCodigoLocal_Enter);
            this.txtCodigoLocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoLocal_KeyDown);
            this.txtCodigoLocal.Leave += new System.EventHandler(this.txtCodigoLocal_Leave);
            // 
            // lblCodigoLocal
            // 
            this.lblCodigoLocal.AutoSize = true;
            this.lblCodigoLocal.BackColor = System.Drawing.Color.Gray;
            this.lblCodigoLocal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoLocal.Location = new System.Drawing.Point(33, 16);
            this.lblCodigoLocal.Name = "lblCodigoLocal";
            this.lblCodigoLocal.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblCodigoLocal.Size = new System.Drawing.Size(164, 28);
            this.lblCodigoLocal.TabIndex = 19;
            this.lblCodigoLocal.Text = "Codigo do local";
            // 
            // gpbIncluirMaterial
            // 
            this.gpbIncluirMaterial.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluirMaterial.Controls.Add(this.panelStatus);
            this.gpbIncluirMaterial.Controls.Add(this.cmbNome);
            this.gpbIncluirMaterial.Controls.Add(this.btnConfirmarMaterial);
            this.gpbIncluirMaterial.Controls.Add(this.lblUnidade);
            this.gpbIncluirMaterial.Controls.Add(this.cmbUnidade);
            this.gpbIncluirMaterial.Controls.Add(this.cmbTipoMaterial);
            this.gpbIncluirMaterial.Controls.Add(this.lblTipo);
            this.gpbIncluirMaterial.Controls.Add(this.lblNome);
            this.gpbIncluirMaterial.Location = new System.Drawing.Point(39, 84);
            this.gpbIncluirMaterial.Name = "gpbIncluirMaterial";
            this.gpbIncluirMaterial.Size = new System.Drawing.Size(460, 208);
            this.gpbIncluirMaterial.TabIndex = 25;
            this.gpbIncluirMaterial.TabStop = false;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.Gray;
            this.panelStatus.Controls.Add(this.rdbAtivo);
            this.panelStatus.Controls.Add(this.rdbInativo);
            this.panelStatus.Location = new System.Drawing.Point(103, 146);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(257, 46);
            this.panelStatus.TabIndex = 33;
            this.panelStatus.Visible = false;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAtivo.Location = new System.Drawing.Point(52, 13);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(68, 22);
            this.rdbAtivo.TabIndex = 3;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInativo.Location = new System.Drawing.Point(147, 13);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(84, 22);
            this.rdbInativo.TabIndex = 4;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // cmbNome
            // 
            this.cmbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(213, 18);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(212, 26);
            this.cmbNome.TabIndex = 32;
            // 
            // btnConfirmarMaterial
            // 
            this.btnConfirmarMaterial.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarMaterial.Location = new System.Drawing.Point(134, 56);
            this.btnConfirmarMaterial.Name = "btnConfirmarMaterial";
            this.btnConfirmarMaterial.Size = new System.Drawing.Size(180, 30);
            this.btnConfirmarMaterial.TabIndex = 31;
            this.btnConfirmarMaterial.Text = "Confirmar Material";
            this.btnConfirmarMaterial.UseVisualStyleBackColor = false;
            this.btnConfirmarMaterial.Click += new System.EventHandler(this.btnConfirmarMaterial_Click);
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.BackColor = System.Drawing.Color.Gray;
            this.lblUnidade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(33, 100);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Padding = new System.Windows.Forms.Padding(45, 5, 44, 5);
            this.lblUnidade.Size = new System.Drawing.Size(164, 28);
            this.lblUnidade.TabIndex = 13;
            this.lblUnidade.Text = "Unidade";
            this.lblUnidade.Visible = false;
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(213, 100);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(212, 26);
            this.cmbUnidade.TabIndex = 7;
            this.cmbUnidade.Visible = false;
            // 
            // cmbTipoMaterial
            // 
            this.cmbTipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMaterial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMaterial.FormattingEnabled = true;
            this.cmbTipoMaterial.Location = new System.Drawing.Point(213, 59);
            this.cmbTipoMaterial.Name = "cmbTipoMaterial";
            this.cmbTipoMaterial.Size = new System.Drawing.Size(212, 26);
            this.cmbTipoMaterial.TabIndex = 2;
            this.cmbTipoMaterial.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Gray;
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(33, 59);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Padding = new System.Windows.Forms.Padding(60, 5, 61, 5);
            this.lblTipo.Size = new System.Drawing.Size(164, 28);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Gray;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(33, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(55, 5, 54, 5);
            this.lblNome.Size = new System.Drawing.Size(164, 28);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lstboxLocaisAdicionar
            // 
            this.lstboxLocaisAdicionar.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxLocaisAdicionar.FormattingEnabled = true;
            this.lstboxLocaisAdicionar.ItemHeight = 16;
            this.lstboxLocaisAdicionar.Location = new System.Drawing.Point(538, 265);
            this.lstboxLocaisAdicionar.Name = "lstboxLocaisAdicionar";
            this.lstboxLocaisAdicionar.Size = new System.Drawing.Size(363, 132);
            this.lstboxLocaisAdicionar.TabIndex = 28;
            this.lstboxLocaisAdicionar.Visible = false;
            // 
            // lblLegendaIncluso
            // 
            this.lblLegendaIncluso.AutoSize = true;
            this.lblLegendaIncluso.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendaIncluso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegendaIncluso.ForeColor = System.Drawing.Color.White;
            this.lblLegendaIncluso.Location = new System.Drawing.Point(633, 76);
            this.lblLegendaIncluso.Name = "lblLegendaIncluso";
            this.lblLegendaIncluso.Size = new System.Drawing.Size(153, 18);
            this.lblLegendaIncluso.TabIndex = 29;
            this.lblLegendaIncluso.Text = "Locais já inclusos";
            this.lblLegendaIncluso.Visible = false;
            // 
            // lblLegendaAdicionar
            // 
            this.lblLegendaAdicionar.AutoSize = true;
            this.lblLegendaAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendaAdicionar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegendaAdicionar.ForeColor = System.Drawing.Color.White;
            this.lblLegendaAdicionar.Location = new System.Drawing.Point(636, 244);
            this.lblLegendaAdicionar.Name = "lblLegendaAdicionar";
            this.lblLegendaAdicionar.Size = new System.Drawing.Size(155, 18);
            this.lblLegendaAdicionar.TabIndex = 30;
            this.lblLegendaAdicionar.Text = "Locais a adicionar";
            this.lblLegendaAdicionar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(413, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 32);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Navy;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(316, 421);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(154, 32);
            this.btnAlterar.TabIndex = 37;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLixeira
            // 
            this.btnLixeira.BackgroundImage = global::GestaoEstoque.Properties.Resources.Lixeira;
            this.btnLixeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLixeira.Location = new System.Drawing.Point(803, 403);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(40, 37);
            this.btnLixeira.TabIndex = 38;
            this.btnLixeira.UseVisualStyleBackColor = true;
            this.btnLixeira.Visible = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // ConsultarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.btnLixeira);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblLegendaAdicionar);
            this.Controls.Add(this.lblLegendaIncluso);
            this.Controls.Add(this.lstboxLocaisAdicionar);
            this.Controls.Add(this.lstboxLocaisInclusos);
            this.Controls.Add(this.gpbLocal);
            this.Controls.Add(this.gpbIncluirMaterial);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConsultarMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarMaterial_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarMaterial_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbLocal.ResumeLayout(false);
            this.gpbLocal.PerformLayout();
            this.gpbIncluirMaterial.ResumeLayout(false);
            this.gpbIncluirMaterial.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
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
        private System.Windows.Forms.ListBox lstboxLocaisInclusos;
        private System.Windows.Forms.GroupBox gpbLocal;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnAdicionarLocal;
        private System.Windows.Forms.TextBox txtCodigoLocal;
        private System.Windows.Forms.Label lblCodigoLocal;
        private System.Windows.Forms.GroupBox gpbIncluirMaterial;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.ComboBox cmbTipoMaterial;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListBox lstboxLocaisAdicionar;
        private System.Windows.Forms.Label lblLegendaIncluso;
        private System.Windows.Forms.Label lblLegendaAdicionar;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.Button btnConfirmarMaterial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.Button btnLixeira;
    }
}