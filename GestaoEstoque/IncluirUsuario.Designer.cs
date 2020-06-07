namespace GestaoEstoque
{
    partial class IncluirUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncluirUsuario));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbIncluirUsuario = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbSupervisor = new System.Windows.Forms.RadioButton();
            this.rdbAuxiliar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripMenu.SuspendLayout();
            this.gpbIncluirUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // gpbIncluirUsuario
            // 
            this.gpbIncluirUsuario.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluirUsuario.Controls.Add(this.panel1);
            this.gpbIncluirUsuario.Controls.Add(this.txtConfirmarSenha);
            this.gpbIncluirUsuario.Controls.Add(this.lblConfirmarSenha);
            this.gpbIncluirUsuario.Controls.Add(this.txtSenha);
            this.gpbIncluirUsuario.Controls.Add(this.lblSenha);
            this.gpbIncluirUsuario.Controls.Add(this.txtNome);
            this.gpbIncluirUsuario.Controls.Add(this.lblNome);
            this.gpbIncluirUsuario.Controls.Add(this.btnCancelar);
            this.gpbIncluirUsuario.Controls.Add(this.btnIncluir);
            this.gpbIncluirUsuario.Location = new System.Drawing.Point(123, 126);
            this.gpbIncluirUsuario.Name = "gpbIncluirUsuario";
            this.gpbIncluirUsuario.Size = new System.Drawing.Size(717, 294);
            this.gpbIncluirUsuario.TabIndex = 12;
            this.gpbIncluirUsuario.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(370, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluir.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(187, 239);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(154, 32);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(345, 36);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 27);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Gray;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(137, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(55, 5, 55, 5);
            this.lblNome.Size = new System.Drawing.Size(165, 28);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Gray;
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(137, 77);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Padding = new System.Windows.Forms.Padding(53, 5, 54, 5);
            this.lblSenha.Size = new System.Drawing.Size(165, 28);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(345, 78);
            this.txtSenha.MaxLength = 40;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(212, 27);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.BackColor = System.Drawing.Color.Gray;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(137, 120);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Padding = new System.Windows.Forms.Padding(6, 5, 7, 5);
            this.lblConfirmarSenha.Size = new System.Drawing.Size(165, 28);
            this.lblConfirmarSenha.TabIndex = 11;
            this.lblConfirmarSenha.Text = "Confirme a senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(345, 121);
            this.txtConfirmarSenha.MaxLength = 40;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(212, 27);
            this.txtConfirmarSenha.TabIndex = 3;
            this.txtConfirmarSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmarSenha_KeyDown);
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdmin.Location = new System.Drawing.Point(19, 11);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(140, 22);
            this.rdbAdmin.TabIndex = 4;
            this.rdbAdmin.Text = "Administrador";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbSupervisor
            // 
            this.rdbSupervisor.AutoSize = true;
            this.rdbSupervisor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSupervisor.Location = new System.Drawing.Point(179, 11);
            this.rdbSupervisor.Name = "rdbSupervisor";
            this.rdbSupervisor.Size = new System.Drawing.Size(111, 22);
            this.rdbSupervisor.TabIndex = 5;
            this.rdbSupervisor.Text = "Supervisor";
            this.rdbSupervisor.UseVisualStyleBackColor = true;
            // 
            // rdbAuxiliar
            // 
            this.rdbAuxiliar.AutoSize = true;
            this.rdbAuxiliar.Checked = true;
            this.rdbAuxiliar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAuxiliar.Location = new System.Drawing.Point(313, 11);
            this.rdbAuxiliar.Name = "rdbAuxiliar";
            this.rdbAuxiliar.Size = new System.Drawing.Size(87, 22);
            this.rdbAuxiliar.TabIndex = 6;
            this.rdbAuxiliar.TabStop = true;
            this.rdbAuxiliar.Text = "Auxiliar";
            this.rdbAuxiliar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.rdbAuxiliar);
            this.panel1.Controls.Add(this.rdbAdmin);
            this.panel1.Controls.Add(this.rdbSupervisor);
            this.panel1.Location = new System.Drawing.Point(140, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 46);
            this.panel1.TabIndex = 12;
            // 
            // IncluirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbIncluirUsuario);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncluirUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Incluir Usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncluirUsuario_FormClosing);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbIncluirUsuario.ResumeLayout(false);
            this.gpbIncluirUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbIncluirUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbAuxiliar;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.RadioButton rdbSupervisor;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenha;
    }
}