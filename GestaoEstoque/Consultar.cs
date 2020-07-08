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
    public partial class Consultar : Form
    {
        Form formAnterior;

        public Consultar(Form anterior, int x, int y)
        {
            this.Location = new Point(x, y);
            formAnterior = anterior;
            InitializeComponent();
        }

        private void Consultar_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Close();
        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluir = new Incluir(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formIncluir.Show();
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultar = new Consultar(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formConsultar.Show();
        }


        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formExcluir = new Excluir(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formExcluir.Show();
        }

        private void btnConsultarTipoTransferencia_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarTipoTransferencia = new ConsultarTipoTransferencia(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formConsultarTipoTransferencia.Show();
        }

        private void btnConsultarUnidadeMedida_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarUnidadeMedida = new ConsultarUnidadeMedida(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formConsultarUnidadeMedida.Show();
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarUsuario = new ConsultarUsuario(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formConsultarUsuario.Show();
        }
    }
}
