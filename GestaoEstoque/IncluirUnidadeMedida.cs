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
    public partial class IncluirUnidadeMedida : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        Boolean xClicked = true;

        public IncluirUnidadeMedida(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string descricaoUnidade = txtDescricao.Text.ToString().Trim();
            string siglaUnidade = txtSigla.Text.ToString().Trim();

            //Validação dos textos
            Boolean statusDescricao = validar.Textos(descricaoUnidade);
            Boolean statusSigla = validar.Textos(siglaUnidade);

            if (statusDescricao == true)
            {
                if (statusSigla == true)
                {
                    Boolean statusInsercao = camadaNegocios.InserirUnidadeMedida(descricaoUnidade, siglaUnidade);

                    if (statusInsercao == true)
                    {
                        MessageBox.Show("Unidade de medida incluída com sucesso");

                        //Limpando os campos
                        txtDescricao.Text = "";
                        txtSigla.Text = "";

                        txtDescricao.Focus();
                    }

                    else
                        MessageBox.Show("Não foi possível incluir a unidade de medida");
                }

                else
                    MessageBox.Show("Sigla inválida. \n\n" +
                                    "Deve ter pelo menos um caractere \n" +
                                    "Não conter caracteres especiais");
            }

            else
                MessageBox.Show("Descrição inválida. \n\n" +
                                "Deve ter pelo menos um caractere \n" +
                                "Não conter caracteres especiais");
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


        private void IncluirUnidadeMedida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtSigla.Focus();
            }
        }

        private void txtSigla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnIncluir.Focus();
            }
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
