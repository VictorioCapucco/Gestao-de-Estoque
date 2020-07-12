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
        int permissaoUsuario;

        public Incluir(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            this.Location = new Point(x, y);
            formAnterior = anterior;
            InitializeComponent();
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


        private void btnIncluirTipoMaterial_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTipoMaterial = new IncluirTipoMaterial(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
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

            Form formIncluirTipoTransferencia = new IncluirTipoTransferencia(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirTipoTransferencia.Show();
        }

        private void btnIncluirLocais_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirLocais = new IncluirLocais(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirLocais.Show();
        }

        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirUsuario = new IncluirUsuario(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirUsuario.Show();
        }

        private void btnIncluirMaterial_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirMaterial = new IncluirMaterial(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirMaterial.Show();
        }

        private void btnIncluirRequisicaoSaida_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTransferenciaSaida = new IncluirTransferenciaSaida(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirTransferenciaSaida.Show();
        }

        private void btnIncluirSaida_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTransferenciaEntrada = new IncluirTransferenciaEntrada(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirTransferenciaEntrada.Show();
        }

        private void btnIncluirFornecedor_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirFornecedor = new IncluirFornecedor(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirFornecedor.Show();
        }

        private void btnIncluirPedidoCompra_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirPedidoCompra = new IncluirPedidoCompra(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirPedidoCompra.Show();
        }

        private void btnIncluirUnidadeMedida_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirUnidadeMedida = new IncluirUnidadeMedida(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirUnidadeMedida.Show();
        }

        private void btnIncluirRecebimento_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirRecebimento = new IncluirRecebimento(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirRecebimento.Show();
        }

        private void Incluir_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            btnCadastros.Visible = false;
            btnOperações.Visible = false;

            if (permissaoUsuario == 2 || permissaoUsuario == 0)
            {
                btnIncluirFornecedor.Visible = true;
                btnIncluirMaterial.Visible = true;
                btnIncluirLocais.Visible = true;
                btnIncluirTipoMaterial.Visible = true;
                btnIncluirUnidadeMedida.Visible = true;
            }

            if (permissaoUsuario == 1 || permissaoUsuario == 0)
            {
                btnIncluirUsuario.Visible = true;
                if (permissaoUsuario == 1)
                    btnIncluirUsuario.Location = new Point(266, 130);
            }

        }

        private void btnOperações_Click(object sender, EventArgs e)
        {


        }

        private void btnOperações_Click_1(object sender, EventArgs e)
        {
            if (permissaoUsuario == 2 || permissaoUsuario == 0)
            {
                btnCadastros.Visible = false;
                btnOperações.Visible = false;


                btnIncluirRecebimento.Visible = true;
                btnIncluirTransferenciaEntrada.Visible = true;
                btnIncluirTipoTransferencia.Visible = true;
                btnIncluirTransferenciaSaida.Visible = true;
                btnIncluirPedidoCompra.Visible = true;
            }
        }
    }
}
