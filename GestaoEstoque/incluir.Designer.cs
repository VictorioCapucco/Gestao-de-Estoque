namespace GestaoEstoque
{
    partial class Incluir
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incluir));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpbIncluir = new System.Windows.Forms.GroupBox();
            this.btnOperações = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.gpbIncluir.SuspendLayout();
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
            this.toolStripMenu.TabIndex = 12;
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
            // gpbIncluir
            // 
            this.gpbIncluir.Controls.Add(this.btnOperações);
            this.gpbIncluir.Controls.Add(this.btnCadastros);
            this.gpbIncluir.Location = new System.Drawing.Point(123, 126);
            this.gpbIncluir.Name = "gpbIncluir";
            this.gpbIncluir.Size = new System.Drawing.Size(717, 294);
            this.gpbIncluir.TabIndex = 11;
            this.gpbIncluir.TabStop = false;
            // 
            // btnOperações
            // 
            this.btnOperações.BackColor = System.Drawing.Color.Black;
            this.btnOperações.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperações.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperações.ForeColor = System.Drawing.Color.White;
            this.btnOperações.Location = new System.Drawing.Point(248, 166);
            this.btnOperações.Name = "btnOperações";
            this.btnOperações.Size = new System.Drawing.Size(241, 32);
            this.btnOperações.TabIndex = 16;
            this.btnOperações.Text = "Operações";
            this.btnOperações.UseVisualStyleBackColor = false;
            this.btnOperações.Click += new System.EventHandler(this.btnOperações_Click_1);
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.Black;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.White;
            this.btnCadastros.Location = new System.Drawing.Point(248, 107);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(241, 32);
            this.btnCadastros.TabIndex = 15;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // Incluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::GestaoEstoque.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.gpbIncluir);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Incluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Incluir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Incluir_FormClosing);
            this.Load += new System.EventHandler(this.Incluir_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpbIncluir.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox gpbIncluir;
        private System.Windows.Forms.Button btnOperações;
        private System.Windows.Forms.Button btnCadastros;
    }
}

