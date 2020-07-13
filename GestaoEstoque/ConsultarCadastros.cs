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
    public partial class ConsultarCadastros : Form
    {
        Form formAnterior;
        Validacao validar = new Validacao();
        private Boolean xClicked = true;
        int permissaoUsuario;

        public ConsultarCadastros(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void btnConsultarLocais_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarLocais = new ConsultarLocais(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarLocais.Show();
        }

        private void btnConsultarTipoMaterial_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarTipoMaterial = new ConsultarTipoMaterial(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formConsultarTipoMaterial.Show();
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

        private void ConsultarCadastros_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
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

        private void ConsultarCadastros_Load(object sender, EventArgs e)
        {
            if (permissaoUsuario == 1)
            {
                btnConsultarFornecedor.Enabled = false;
                btnConsultarLocais.Enabled = false;
                btnConsultarMaterial.Enabled = false;
                btnConsultarTipoMaterial.Enabled = false;
                btnConsultarTipoMaterial.Enabled = false;
                btnConsultarTipoTransferencia.Enabled = false;
                btnConsultarUnidadeMedida.Enabled = false;
            }

            if (permissaoUsuario == 2)
            {
                btnConsultarUsuario.Enabled = false;
            }
        }
    }
}
