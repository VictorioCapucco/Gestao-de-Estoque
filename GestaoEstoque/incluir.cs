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
    public partial class Incluir : Form
    {
        Form formAnterior;

        public Incluir(Form anterior, int x, int y)
        {
            this.Location = new Point(x, y);
            formAnterior = anterior;
            InitializeComponent();
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

        private void btnIncluirTipoMaterial_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTipoMaterial = new IncluirTipoMaterial(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formIncluirTipoMaterial.Show();
        }

        private void Incluir_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Close();
        }

        private void btnIncluirTipoSaida_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTipoTransferencia = new IncluirTipoTransferencia(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formIncluirTipoTransferencia.Show();
        }

        private void btnIncluirLocais_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirLocais = new IncluirLocais(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formIncluirLocais.Show();
        }

        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirUsuario = new IncluirUsuario(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formIncluirUsuario.Show();
        }

        private void btnIncluirMaterial_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirMaterial = new IncluirMaterial(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formIncluirMaterial.Show();
        }

        private void btnIncluirRequisicaoSaida_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTransferenciaSaida = new IncluirTransferenciaSaida(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formIncluirTransferenciaSaida.Show();
        }

        private void btnIncluirSaida_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTransferenciaEntrada = new IncluirTransferenciaEntrada(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formIncluirTransferenciaEntrada.Show();
        }

        private void btnIncluirFornecedor_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirFornecedor = new IncluirFornecedor(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formIncluirFornecedor.Show();
        }

        private void btnIncluirPedidoCompra_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirPedidoCompra = new IncluirPedidoCompra(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formIncluirPedidoCompra.Show();
        }
    }
}
