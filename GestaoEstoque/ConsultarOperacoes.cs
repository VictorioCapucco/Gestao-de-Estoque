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
    public partial class ConsultarOperacoes : Form
    {
        Form formAnterior;
        Validacao validar = new Validacao();
        private Boolean xClicked = true;
        int permissaoUsuario;

        public ConsultarOperacoes(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void btnConsultarRecebimento_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarRecebimento = new ConsultarRecebimento(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarRecebimento.Show();
        }

        private void btnConsultarTransferencias_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarTransferencia = new ConsultarTransferencias(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarTransferencia.Show();
        }

        private void btnConsultarPedidoCompra_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarPedidoCompra = new ConsultarPedidoCompra(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarPedidoCompra.Show();
        }

        private void toolStripVoltar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();

            formAnterior.Location = this.Location;
            formAnterior.Show();
        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluir = new Incluir(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluir.Show();
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultar = new Consultar(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultar.Show();
        }

        private void ConsultarOperacoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }
    }
}
