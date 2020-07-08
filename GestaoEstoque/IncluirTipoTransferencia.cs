using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace GestaoEstoque
{
    public partial class IncluirTipoTransferencia : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        private Boolean xClicked = true;

        public IncluirTipoTransferencia(Form anterior, int x, int y)
        {
            this.Location = new Point(x, y);
            formAnterior = anterior;

            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Boolean saida = (rdbSaida.Checked == true);
            string descricao = txtDescricao.Text.ToString();

            //Validação da descrição
            Boolean statusDescricao = validar.Textos(descricao);

            if (statusDescricao == true)
            {
                //Pedindo à camada de negócios para adicionar o tipo de transferencia
                Boolean statusInsercao = camadaNegocios.InserirTipoTransferencia(descricao, true, saida);

                if (statusInsercao == true)
                {
                    MessageBox.Show("Tipo de transferência incluído com sucesso!");

                    //Limpando os campos
                    txtDescricao.Text = "";
                    txtDescricao.Focus();
                }

                else
                    MessageBox.Show("Não foi possível incluir o tipo de transferência");
            }

            else
            {
                MessageBox.Show("Descrição inválida. \n\n" +
                                "Deve ter pelo menos um caractere \n" +
                                "Não conter caracteres especiais");
                txtDescricao.Focus();
            }
                
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnIncluir.Focus();
            }
        }

        private void IncluirTipoSaida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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



        private void rdbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbSupervisor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripVoltar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();

            formAnterior.Location = this.Location;
            formAnterior.Show();
        }
    }
}
