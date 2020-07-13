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
        int permissaoUsuario;

        public Consultar(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
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


        private void btnConsultarTipoTransferencia_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarTipoTransferencia = new ConsultarTipoTransferencia(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarTipoTransferencia.Show();
        }

        private void btnConsultarUnidadeMedida_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarUnidadeMedida = new ConsultarUnidadeMedida(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarUnidadeMedida.Show();
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarUsuario = new ConsultarUsuario(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarUsuario.Show();
        }

        private void btnConsultarRecebimento_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarRecebimento = new ConsultarRecebimento(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarRecebimento.Show();
        }

        private void btnConsultarPedidoCompra_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarPedidoCompra = new ConsultarPedidoCompra(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarPedidoCompra.Show();
        }

        private void btnConsultarMaterial_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarMaterial = new ConsultarMaterial(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarMaterial.Show();
        }

        private void btnConsultarTransferencias_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarTransferencia = new ConsultarTransferencias(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarTransferencia.Show();
        }

        private void btnConsultarFornecedor_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarFornecedor = new ConsultarFornecedor(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarFornecedor.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarEstoque = new ConsultarEstoque(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarEstoque.Show();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            btnCadastros.Visible = false;
            btnOperações.Visible = false;

            btnConsultarFornecedor.Visible = true;
            btnConsultarMaterial.Visible = true;
            btnConsultarLocais.Visible = true;
            btnConsultarUnidadeMedida.Visible = true;

            if  (permissaoUsuario == 1 || permissaoUsuario == 0)
            {
                btnConsultarUsuario.Visible = true;
            }

        }

        private void btnOperações_Click(object sender, EventArgs e)
        {
            btnCadastros.Visible = false;
            btnOperações.Visible = false;

            btnConsultarTransferencias.Visible = true;
            btnConsultarRecebimento.Visible = true;

            if (permissaoUsuario == 2 || permissaoUsuario == 0)
            {
                btnConsultarPedidoCompra.Visible = true;
                btnConsultarTipoTransferencia.Visible = true;
            }
        }

        private void btnConsultarLocais_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarLocais = new ConsultarLocais(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarLocais.Show();
        }
    }
}
