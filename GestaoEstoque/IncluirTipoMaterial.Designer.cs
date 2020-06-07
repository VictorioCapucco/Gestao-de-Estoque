namespace GestaoEstoque
{
    partial class IncluirTipoMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncluirTipoMaterial));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbExcluir = new System.Windows.Forms.GroupBox();
            this.txtDescricaoReduzida = new System.Windows.Forms.TextBox();
            this.txtDescricaoCompleta = new System.Windows.Forms.TextBox();
            this.lblDescricaoReduzida = new System.Windows.Forms.Label();
            this.lblDescricaoCompleta = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.gpbExcluir.SuspendLayout();
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
            this.toolStripMenu.TabIndex = 2;
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
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // gpbExcluir
            // 
            this.gpbExcluir.BackColor = System.Drawing.Color.DimGray;
            this.gpbExcluir.Controls.Add(this.txtDescricaoReduzida);
            this.gpbExcluir.Controls.Add(this.txtDescricaoCompleta);
            this.gpbExcluir.Controls.Add(this.lblDescricaoReduzida);
            this.gpbExcluir.Controls.Add(this.lblDescricaoCompleta);
            this.gpbExcluir.Controls.Add(this.btnCancelar);
            this.gpbExcluir.Controls.Add(this.btnIncluir);
            this.gpbExcluir.Location = new System.Drawing.Point(123, 126);
            this.gpbExcluir.Name = "gpbExcluir";
            this.gpbExcluir.Size = new System.Drawing.Size(717, 294);
            this.gpbExcluir.TabIndex = 4;
            this.gpbExcluir.TabStop = false;
            // 
            // txtDescricaoReduzida
            // 
            this.txtDescricaoReduzida.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoReduzida.Location = new System.Drawing.Point(345, 119);
            this.txtDescricaoReduzida.MaxLength = 15;
            this.txtDescricaoReduzida.Name = "txtDescricaoReduzida";
            this.txtDescricaoReduzida.Size = new System.Drawing.Size(212, 27);
            this.txtDescricaoReduzida.TabIndex = 9;
            this.txtDescricaoReduzida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricaoReduzida_KeyDown);
            // 
            // txtDescricaoCompleta
            // 
            this.txtDescricaoCompleta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoCompleta.Location = new System.Drawing.Point(345, 77);
            this.txtDescricaoCompleta.MaxLength = 40;
            this.txtDescricaoCompleta.Name = "txtDescricaoCompleta";
            this.txtDescricaoCompleta.Size = new System.Drawing.Size(212, 27);
            this.txtDescricaoCompleta.TabIndex = 8;
            this.txtDescricaoCompleta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricaoCompleta_KeyDown);
            // 
            // lblDescricaoReduzida
            // 
            this.lblDescricaoReduzida.AutoSize = true;
            this.lblDescricaoReduzida.BackColor = System.Drawing.Color.Gray;
            this.lblDescricaoReduzida.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoReduzida.Location = new System.Drawing.Point(137, 118);
            this.lblDescricaoReduzida.Name = "lblDescricaoReduzida";
            this.lblDescricaoReduzida.Padding = new System.Windows.Forms.Padding(6, 5, 7, 5);
            this.lblDescricaoReduzida.Size = new System.Drawing.Size(180, 28);
            this.lblDescricaoReduzida.TabIndex = 7;
            this.lblDescricaoReduzida.Text = "Descrição Reduzida";
            // 
            // lblDescricaoCompleta
            // 
            this.lblDescricaoCompleta.AutoSize = true;
            this.lblDescricaoCompleta.BackColor = System.Drawing.Color.Gray;
            this.lblDescricaoCompleta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoCompleta.Location = new System.Drawing.Point(137, 76);
            this.lblDescricaoCompleta.Name = "lblDescricaoCompleta";
            this.lblDescricaoCompleta.Padding = new System.Windows.Forms.Padding(5);
            this.lblDescricaoCompleta.Size = new System.Drawing.Size(180, 28);
            this.lblDescricaoCompleta.TabIndex = 6;
            this.lblDescricaoCompleta.Text = "Descrição Completa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(369, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluir.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(186, 214);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(154, 32);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // IncluirTipoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbExcluir);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncluirTipoMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Incluir Tipo de Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncluirTipoMaterial_FormClosing);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbExcluir.ResumeLayout(false);
            this.gpbExcluir.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtDescricaoReduzida;
        private System.Windows.Forms.TextBox txtDescricaoCompleta;
        private System.Windows.Forms.Label lblDescricaoReduzida;
        private System.Windows.Forms.Label lblDescricaoCompleta;
        private System.Windows.Forms.Button btnCancelar;
    }
}