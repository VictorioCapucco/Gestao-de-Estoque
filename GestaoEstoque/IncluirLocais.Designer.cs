namespace GestaoEstoque
{
    partial class IncluirLocais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncluirLocais));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.gpbIncluirTipoDespesa = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.gpbIncluirTipoDespesa.SuspendLayout();
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
            this.toolStripMenu.TabIndex = 7;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
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
            // gpbIncluirTipoDespesa
            // 
            this.gpbIncluirTipoDespesa.BackColor = System.Drawing.Color.DimGray;
            this.gpbIncluirTipoDespesa.Controls.Add(this.txtEndereco);
            this.gpbIncluirTipoDespesa.Controls.Add(this.txtDescricao);
            this.gpbIncluirTipoDespesa.Controls.Add(this.lblEndereco);
            this.gpbIncluirTipoDespesa.Controls.Add(this.lblDescricao);
            this.gpbIncluirTipoDespesa.Controls.Add(this.btnCancelar);
            this.gpbIncluirTipoDespesa.Controls.Add(this.btnIncluir);
            this.gpbIncluirTipoDespesa.Location = new System.Drawing.Point(123, 126);
            this.gpbIncluirTipoDespesa.Name = "gpbIncluirTipoDespesa";
            this.gpbIncluirTipoDespesa.Size = new System.Drawing.Size(717, 294);
            this.gpbIncluirTipoDespesa.TabIndex = 6;
            this.gpbIncluirTipoDespesa.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(370, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 32);
            this.btnCancelar.TabIndex = 3;
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
            this.btnIncluir.Location = new System.Drawing.Point(187, 202);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(154, 32);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(312, 120);
            this.txtEndereco.MaxLength = 45;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(212, 27);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndereco_KeyDown);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(312, 77);
            this.txtDescricao.MaxLength = 15;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(212, 27);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Gray;
            this.lblEndereco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(161, 119);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Padding = new System.Windows.Forms.Padding(22, 5, 22, 5);
            this.lblEndereco.Size = new System.Drawing.Size(126, 28);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Gray;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(161, 76);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblDescricao.Size = new System.Drawing.Size(126, 28);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // IncluirLocais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbIncluirTipoDespesa);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncluirLocais";
            this.Text = "Incluir Locais";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncluirLocais_FormClosing);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbIncluirTipoDespesa.ResumeLayout(false);
            this.gpbIncluirTipoDespesa.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbIncluirTipoDespesa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDescricao;
    }
}