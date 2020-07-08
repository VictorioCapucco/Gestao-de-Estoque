namespace GestaoEstoque
{
    partial class ConsultarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarFornecedor));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblLegendaAdicionar = new System.Windows.Forms.Label();
            this.lblLegendaIncluso = new System.Windows.Forms.Label();
            this.lstboxMateriaisAdicionar = new System.Windows.Forms.ListBox();
            this.lstboxMateriaisInclusos = new System.Windows.Forms.ListBox();
            this.gpbIncluirMaterial = new System.Windows.Forms.GroupBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.btnConfirmarFornecedor = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.gpbMateriais = new System.Windows.Forms.GroupBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnAdicionarMaterial = new System.Windows.Forms.Button();
            this.txtCodigoMaterial = new System.Windows.Forms.TextBox();
            this.lblCodigoMaterial = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.gpbIncluirMaterial.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.gpbMateriais.SuspendLayout();
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
            // btnLixeira
            // 
            this.btnLixeira.BackgroundImage = global::GestaoEstoque.Properties.Resources.Lixeira;
            this.btnLixeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLixeira.Location = new System.Drawing.Point(803, 403);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(40, 37);
            this.btnLixeira.TabIndex = 47;
            this.btnLixeira.UseVisualStyleBackColor = true;
            this.btnLixeira.Visible = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Navy;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(316, 430);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(154, 32);
            this.btnAlterar.TabIndex = 46;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(413, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 32);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblLegendaAdicionar
            // 
            this.lblLegendaAdicionar.AutoSize = true;
            this.lblLegendaAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendaAdicionar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegendaAdicionar.ForeColor = System.Drawing.Color.White;
            this.lblLegendaAdicionar.Location = new System.Drawing.Point(630, 244);
            this.lblLegendaAdicionar.Name = "lblLegendaAdicionar";
            this.lblLegendaAdicionar.Size = new System.Drawing.Size(180, 18);
            this.lblLegendaAdicionar.TabIndex = 44;
            this.lblLegendaAdicionar.Text = "Materiais a Adicionar";
            this.lblLegendaAdicionar.Visible = false;
            // 
            // lblLegendaIncluso
            // 
            this.lblLegendaIncluso.AutoSize = true;
            this.lblLegendaIncluso.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendaIncluso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegendaIncluso.ForeColor = System.Drawing.Color.White;
            this.lblLegendaIncluso.Location = new System.Drawing.Point(631, 76);
            this.lblLegendaIncluso.Name = "lblLegendaIncluso";
            this.lblLegendaIncluso.Size = new System.Drawing.Size(177, 18);
            this.lblLegendaIncluso.TabIndex = 43;
            this.lblLegendaIncluso.Text = "Materiais já inclusos";
            this.lblLegendaIncluso.Visible = false;
            // 
            // lstboxMateriaisAdicionar
            // 
            this.lstboxMateriaisAdicionar.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxMateriaisAdicionar.FormattingEnabled = true;
            this.lstboxMateriaisAdicionar.ItemHeight = 16;
            this.lstboxMateriaisAdicionar.Location = new System.Drawing.Point(538, 265);
            this.lstboxMateriaisAdicionar.Name = "lstboxMateriaisAdicionar";
            this.lstboxMateriaisAdicionar.Size = new System.Drawing.Size(363, 132);
            this.lstboxMateriaisAdicionar.TabIndex = 42;
            this.lstboxMateriaisAdicionar.Visible = false;
            // 
            // lstboxMateriaisInclusos
            // 
            this.lstboxMateriaisInclusos.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxMateriaisInclusos.FormattingEnabled = true;
            this.lstboxMateriaisInclusos.ItemHeight = 16;
            this.lstboxMateriaisInclusos.Location = new System.Drawing.Point(538, 97);
            this.lstboxMateriaisInclusos.Name = "lstboxMateriaisInclusos";
            this.lstboxMateriaisInclusos.Size = new System.Drawing.Size(363, 132);
            this.lstboxMateriaisInclusos.TabIndex = 41;
            this.lstboxMateriaisInclusos.Visible = false;
            // 
            // gpbIncluirMaterial
            // 
            this.gpbIncluirMaterial.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluirMaterial.Controls.Add(this.txtEndereco);
            this.gpbIncluirMaterial.Controls.Add(this.panelStatus);
            this.gpbIncluirMaterial.Controls.Add(this.txtTelefone);
            this.gpbIncluirMaterial.Controls.Add(this.cmbNome);
            this.gpbIncluirMaterial.Controls.Add(this.txtCnpj);
            this.gpbIncluirMaterial.Controls.Add(this.lblTelefone);
            this.gpbIncluirMaterial.Controls.Add(this.btnConfirmarFornecedor);
            this.gpbIncluirMaterial.Controls.Add(this.lblEndereco);
            this.gpbIncluirMaterial.Controls.Add(this.lblNome);
            this.gpbIncluirMaterial.Controls.Add(this.lblCnpj);
            this.gpbIncluirMaterial.Location = new System.Drawing.Point(39, 93);
            this.gpbIncluirMaterial.Name = "gpbIncluirMaterial";
            this.gpbIncluirMaterial.Size = new System.Drawing.Size(460, 208);
            this.gpbIncluirMaterial.TabIndex = 39;
            this.gpbIncluirMaterial.TabStop = false;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.Gray;
            this.panelStatus.Controls.Add(this.rdbAtivo);
            this.panelStatus.Controls.Add(this.rdbInativo);
            this.panelStatus.Location = new System.Drawing.Point(103, 165);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(257, 33);
            this.panelStatus.TabIndex = 33;
            this.panelStatus.Visible = false;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAtivo.Location = new System.Drawing.Point(48, 7);
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
            this.rdbInativo.Location = new System.Drawing.Point(143, 7);
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
            this.cmbNome.Location = new System.Drawing.Point(185, 19);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(212, 26);
            this.cmbNome.TabIndex = 32;
            // 
            // btnConfirmarFornecedor
            // 
            this.btnConfirmarFornecedor.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarFornecedor.Location = new System.Drawing.Point(134, 53);
            this.btnConfirmarFornecedor.Name = "btnConfirmarFornecedor";
            this.btnConfirmarFornecedor.Size = new System.Drawing.Size(180, 30);
            this.btnConfirmarFornecedor.TabIndex = 31;
            this.btnConfirmarFornecedor.Text = "Confirmar Fornecedor";
            this.btnConfirmarFornecedor.UseVisualStyleBackColor = false;
            this.btnConfirmarFornecedor.Click += new System.EventHandler(this.btnConfirmarFornecedor_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Gray;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(33, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(36, 5, 36, 5);
            this.lblNome.Size = new System.Drawing.Size(127, 28);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(185, 126);
            this.txtEndereco.MaxLength = 45;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(212, 27);
            this.txtEndereco.TabIndex = 53;
            this.txtEndereco.Visible = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(185, 93);
            this.txtTelefone.MaxLength = 20;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(212, 27);
            this.txtTelefone.TabIndex = 52;
            this.txtTelefone.Visible = false;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(185, 56);
            this.txtCnpj.MaxLength = 14;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(212, 27);
            this.txtCnpj.TabIndex = 51;
            this.txtCnpj.Visible = false;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Gray;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(34, 89);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.lblTelefone.Size = new System.Drawing.Size(127, 28);
            this.lblTelefone.TabIndex = 49;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Visible = false;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Gray;
            this.lblEndereco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(34, 125);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Padding = new System.Windows.Forms.Padding(22, 5, 23, 5);
            this.lblEndereco.Size = new System.Drawing.Size(127, 28);
            this.lblEndereco.TabIndex = 50;
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.Visible = false;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.BackColor = System.Drawing.Color.Gray;
            this.lblCnpj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(34, 54);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Padding = new System.Windows.Forms.Padding(40, 5, 39, 5);
            this.lblCnpj.Size = new System.Drawing.Size(127, 28);
            this.lblCnpj.TabIndex = 48;
            this.lblCnpj.Text = "CNPJ";
            this.lblCnpj.Visible = false;
            // 
            // gpbMateriais
            // 
            this.gpbMateriais.BackColor = System.Drawing.Color.DimGray;
            this.gpbMateriais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbMateriais.Controls.Add(this.btnAjuda);
            this.gpbMateriais.Controls.Add(this.btnAdicionarMaterial);
            this.gpbMateriais.Controls.Add(this.txtCodigoMaterial);
            this.gpbMateriais.Controls.Add(this.lblCodigoMaterial);
            this.gpbMateriais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbMateriais.Location = new System.Drawing.Point(39, 307);
            this.gpbMateriais.Name = "gpbMateriais";
            this.gpbMateriais.Size = new System.Drawing.Size(460, 100);
            this.gpbMateriais.TabIndex = 48;
            this.gpbMateriais.TabStop = false;
            this.gpbMateriais.Visible = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Black;
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjuda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.White;
            this.btnAjuda.Location = new System.Drawing.Point(371, 23);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAjuda.Size = new System.Drawing.Size(26, 26);
            this.btnAjuda.TabIndex = 32;
            this.btnAjuda.Text = "? ";
            this.btnAjuda.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarMaterial
            // 
            this.btnAdicionarMaterial.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarMaterial.Location = new System.Drawing.Point(157, 62);
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
            this.txtCodigoMaterial.Location = new System.Drawing.Point(215, 23);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.Size = new System.Drawing.Size(150, 26);
            this.txtCodigoMaterial.TabIndex = 6;
            this.txtCodigoMaterial.Text = "  F1 para consultar";
            this.txtCodigoMaterial.Enter += new System.EventHandler(this.txtCodigoMaterial_Enter);
            this.txtCodigoMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoMaterial_KeyDown);
            this.txtCodigoMaterial.Leave += new System.EventHandler(this.txtCodigoMaterial_Leave);
            // 
            // lblCodigoMaterial
            // 
            this.lblCodigoMaterial.AutoSize = true;
            this.lblCodigoMaterial.BackColor = System.Drawing.Color.Gray;
            this.lblCodigoMaterial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMaterial.Location = new System.Drawing.Point(34, 21);
            this.lblCodigoMaterial.Name = "lblCodigoMaterial";
            this.lblCodigoMaterial.Padding = new System.Windows.Forms.Padding(5);
            this.lblCodigoMaterial.Size = new System.Drawing.Size(174, 28);
            this.lblCodigoMaterial.TabIndex = 19;
            this.lblCodigoMaterial.Text = "Codigo do material";
            // 
            // ConsultarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbMateriais);
            this.Controls.Add(this.btnLixeira);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblLegendaAdicionar);
            this.Controls.Add(this.lblLegendaIncluso);
            this.Controls.Add(this.lstboxMateriaisAdicionar);
            this.Controls.Add(this.lstboxMateriaisInclusos);
            this.Controls.Add(this.gpbIncluirMaterial);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConsultarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar Fornecedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarFornecedor_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarFornecedor_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbIncluirMaterial.ResumeLayout(false);
            this.gpbIncluirMaterial.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.gpbMateriais.ResumeLayout(false);
            this.gpbMateriais.PerformLayout();
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
        private System.Windows.Forms.Button btnLixeira;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblLegendaAdicionar;
        private System.Windows.Forms.Label lblLegendaIncluso;
        private System.Windows.Forms.ListBox lstboxMateriaisAdicionar;
        private System.Windows.Forms.ListBox lstboxMateriaisInclusos;
        private System.Windows.Forms.GroupBox gpbIncluirMaterial;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.Button btnConfirmarFornecedor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.GroupBox gpbMateriais;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnAdicionarMaterial;
        private System.Windows.Forms.TextBox txtCodigoMaterial;
        private System.Windows.Forms.Label lblCodigoMaterial;
    }
}