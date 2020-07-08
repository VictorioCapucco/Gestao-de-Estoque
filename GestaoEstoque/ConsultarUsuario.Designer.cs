namespace GestaoEstoque
{
    partial class ConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuario));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbConsultar = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.panelTipoUsuario = new System.Windows.Forms.Panel();
            this.rdbAdministrador = new System.Windows.Forms.RadioButton();
            this.rdbSupervisor = new System.Windows.Forms.RadioButton();
            this.rdbAuxiliar = new System.Windows.Forms.RadioButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.gpbConsultar.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelTipoUsuario.SuspendLayout();
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
            // gpbConsultar
            // 
            this.gpbConsultar.BackColor = System.Drawing.Color.DimGray;
            this.gpbConsultar.Controls.Add(this.txtSenha);
            this.gpbConsultar.Controls.Add(this.lblSenha);
            this.gpbConsultar.Controls.Add(this.panelTipoUsuario);
            this.gpbConsultar.Controls.Add(this.btnConsultar);
            this.gpbConsultar.Controls.Add(this.cmbUsuario);
            this.gpbConsultar.Controls.Add(this.lblUsuario);
            this.gpbConsultar.Controls.Add(this.panelStatus);
            this.gpbConsultar.Controls.Add(this.txtNome);
            this.gpbConsultar.Controls.Add(this.lblNome);
            this.gpbConsultar.Controls.Add(this.btnCancelar);
            this.gpbConsultar.Controls.Add(this.btnAlterar);
            this.gpbConsultar.Location = new System.Drawing.Point(112, 79);
            this.gpbConsultar.Name = "gpbConsultar";
            this.gpbConsultar.Size = new System.Drawing.Size(717, 369);
            this.gpbConsultar.TabIndex = 11;
            this.gpbConsultar.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(259, 75);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(180, 30);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(346, 38);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(212, 26);
            this.cmbUsuario.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Gray;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(130, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Padding = new System.Windows.Forms.Padding(63, 5, 64, 5);
            this.lblUsuario.Size = new System.Drawing.Size(197, 28);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuário";
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.Gray;
            this.panelStatus.Controls.Add(this.rdbAtivo);
            this.panelStatus.Controls.Add(this.rdbInativo);
            this.panelStatus.Location = new System.Drawing.Point(133, 221);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(425, 46);
            this.panelStatus.TabIndex = 12;
            this.panelStatus.Visible = false;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAtivo.Location = new System.Drawing.Point(129, 12);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(68, 22);
            this.rdbAtivo.TabIndex = 7;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInativo.Location = new System.Drawing.Point(224, 12);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(84, 22);
            this.rdbInativo.TabIndex = 8;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(346, 95);
            this.txtNome.MaxLength = 15;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 27);
            this.txtNome.TabIndex = 2;
            this.txtNome.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Gray;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(130, 94);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(71, 5, 71, 5);
            this.lblNome.Size = new System.Drawing.Size(197, 28);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome";
            this.lblNome.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(377, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 32);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Navy;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(194, 295);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(154, 32);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // panelTipoUsuario
            // 
            this.panelTipoUsuario.BackColor = System.Drawing.Color.Gray;
            this.panelTipoUsuario.Controls.Add(this.rdbAuxiliar);
            this.panelTipoUsuario.Controls.Add(this.rdbAdministrador);
            this.panelTipoUsuario.Controls.Add(this.rdbSupervisor);
            this.panelTipoUsuario.Location = new System.Drawing.Point(133, 169);
            this.panelTipoUsuario.Name = "panelTipoUsuario";
            this.panelTipoUsuario.Size = new System.Drawing.Size(425, 46);
            this.panelTipoUsuario.TabIndex = 13;
            this.panelTipoUsuario.Visible = false;
            // 
            // rdbAdministrador
            // 
            this.rdbAdministrador.AutoSize = true;
            this.rdbAdministrador.Checked = true;
            this.rdbAdministrador.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdministrador.Location = new System.Drawing.Point(24, 12);
            this.rdbAdministrador.Name = "rdbAdministrador";
            this.rdbAdministrador.Size = new System.Drawing.Size(140, 22);
            this.rdbAdministrador.TabIndex = 4;
            this.rdbAdministrador.TabStop = true;
            this.rdbAdministrador.Text = "Administrador";
            this.rdbAdministrador.UseVisualStyleBackColor = true;
            // 
            // rdbSupervisor
            // 
            this.rdbSupervisor.AutoSize = true;
            this.rdbSupervisor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSupervisor.Location = new System.Drawing.Point(178, 12);
            this.rdbSupervisor.Name = "rdbSupervisor";
            this.rdbSupervisor.Size = new System.Drawing.Size(111, 22);
            this.rdbSupervisor.TabIndex = 5;
            this.rdbSupervisor.Text = "Supervisor";
            this.rdbSupervisor.UseVisualStyleBackColor = true;
            // 
            // rdbAuxiliar
            // 
            this.rdbAuxiliar.AutoSize = true;
            this.rdbAuxiliar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAuxiliar.Location = new System.Drawing.Point(307, 12);
            this.rdbAuxiliar.Name = "rdbAuxiliar";
            this.rdbAuxiliar.Size = new System.Drawing.Size(87, 22);
            this.rdbAuxiliar.TabIndex = 6;
            this.rdbAuxiliar.Text = "Auxiliar";
            this.rdbAuxiliar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(346, 133);
            this.txtSenha.MaxLength = 35;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(212, 27);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Gray;
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(130, 132);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Padding = new System.Windows.Forms.Padding(69, 5, 70, 5);
            this.lblSenha.Size = new System.Drawing.Size(197, 28);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Visible = false;
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbConsultar);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarUsuario_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarUsuario_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbConsultar.ResumeLayout(false);
            this.gpbConsultar.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelTipoUsuario.ResumeLayout(false);
            this.panelTipoUsuario.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panelTipoUsuario;
        private System.Windows.Forms.RadioButton rdbAuxiliar;
        private System.Windows.Forms.RadioButton rdbAdministrador;
        private System.Windows.Forms.RadioButton rdbSupervisor;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
    }
}