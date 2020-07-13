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


        private void Incluir_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Close();
        }


        private void Incluir_Load(object sender, EventArgs e)
        {
            if (permissaoUsuario == 1)
            {
                btnOperações.Enabled = false;
            }
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirCadastros = new IncluirCadastros(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirCadastros.Show();
        }
        

        private void btnOperações_Click_1(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formIncluirOperacoes = new IncluirOperacoes_(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            this.Hide();
            formIncluirOperacoes.Show();
        }
    }
}
