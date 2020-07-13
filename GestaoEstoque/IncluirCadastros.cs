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
    public partial class IncluirCadastros : Form
    {
        Form formAnterior;
        Validacao validar = new Validacao();
        private Boolean xClicked = true;
        int permissaoUsuario;

        public IncluirCadastros(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void IncluirCadastros_Load(object sender, EventArgs e)
        {
            if (permissaoUsuario == 2)
            {
                btnIncluirUsuario.Enabled = false;
            }
        }

        private void btnIncluirTipoMaterial_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTipoMaterial = new IncluirTipoMaterial(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirTipoMaterial.Show();
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

        private void btnIncluirFornecedor_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirFornecedor = new IncluirFornecedor(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirFornecedor.Show();
        }

        private void btnIncluirUnidadeMedida_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirUnidadeMedida = new IncluirUnidadeMedida(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirUnidadeMedida.Show();
        }

        private void btnIncluirTipoTransferencia_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirTipoTransferencia = new IncluirTipoTransferencia(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirTipoTransferencia.Show();
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

        private void IncluirCadastros_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }
    }
}
