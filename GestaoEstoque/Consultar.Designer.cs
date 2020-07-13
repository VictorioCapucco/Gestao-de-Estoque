namespace GestaoEstoque
{
    partial class Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbConsultar = new System.Windows.Forms.GroupBox();
            this.btnOperações = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.gpbConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Purple;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripIncluir,
            this.toolStripSeparator1,
            this.toolStripConsultar,
            this.toolStripSeparator2});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(941, 42);
            this.toolStripMenu.TabIndex = 1;
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
            this.gpbConsultar.Controls.Add(this.btnOperações);
            this.gpbConsultar.Controls.Add(this.btnEstoque);
            this.gpbConsultar.Controls.Add(this.btnCadastros);
            this.gpbConsultar.Location = new System.Drawing.Point(123, 126);
            this.gpbConsultar.Name = "gpbConsultar";
            this.gpbConsultar.Size = new System.Drawing.Size(717, 294);
            this.gpbConsultar.TabIndex = 2;
            this.gpbConsultar.TabStop = false;
            // 
            // btnOperações
            // 
            this.btnOperações.BackColor = System.Drawing.Color.Black;
            this.btnOperações.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperações.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperações.ForeColor = System.Drawing.Color.White;
            this.btnOperações.Location = new System.Drawing.Point(238, 121);
            this.btnOperações.Name = "btnOperações";
            this.btnOperações.Size = new System.Drawing.Size(241, 32);
            this.btnOperações.TabIndex = 23;
            this.btnOperações.Text = "Operações";
            this.btnOperações.UseVisualStyleBackColor = false;
            this.btnOperações.Click += new System.EventHandler(this.btnOperações_Click_1);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Black;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Location = new System.Drawing.Point(238, 175);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(241, 32);
            this.btnEstoque.TabIndex = 15;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.Black;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.White;
            this.btnCadastros.Location = new System.Drawing.Point(238, 70);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(241, 32);
            this.btnCadastros.TabIndex = 13;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbConsultar);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Consultar_FormClosing);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbConsultar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox gpbConsultar;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnOperações;
    }
}