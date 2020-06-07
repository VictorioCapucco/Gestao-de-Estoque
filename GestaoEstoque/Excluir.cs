using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEstoque
{
    public partial class Excluir : Form
    {
        Form formAnterior;

        public Excluir(Form anterior, int x, int y)
        {
            this.Location = new Point(x, y);
            formAnterior = anterior;
            InitializeComponent();
        }

        private void Excluir_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Close();
        }
    }
}
