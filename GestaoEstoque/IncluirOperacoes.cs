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
    public partial class IncluirOperacoes_ : Form
    {
        Form formAnterior;
        Validacao validar = new Validacao();
        private Boolean xClicked = true;
        int permissaoUsuario;

        public IncluirOperacoes_(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void btnIncluirRecebimento_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirRecebimento = new IncluirRecebimento(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirRecebimento.Show();
        }

        private void btnIncluirTransferenciaEntrada_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTransferenciaEntrada = new IncluirTransferenciaEntrada(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirTransferenciaEntrada.Show();
        }

        private void btnIncluirTransferenciaSaida_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTransferenciaSaida = new IncluirTransferenciaSaida(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirTransferenciaSaida.Show();
        }

        private void btnIncluirEntradaManual_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirEntradaManual = new IncluirEntradaManual(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirEntradaManual.Show();
        }

        private void btnIncluirPedidoCompra_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirPedidoCompra = new IncluirPedidoCompra(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirPedidoCompra.Show();
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

        private void IncluirOperacoes__FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }
    }
}
