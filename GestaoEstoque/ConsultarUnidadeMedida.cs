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
    public partial class ConsultarUnidadeMedida : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        DataTable oDtUnidadeMedida = new DataTable();
        Form formAnterior;
        private Boolean xClicked = true;

        public ConsultarUnidadeMedida(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void ConsultarUnidadeMedida_Load(object sender, EventArgs e)
        {
            oDtUnidadeMedida.Clear();
                                                              //filtroStatus
            oDtUnidadeMedida = camadaNegocios.DataTableUnidade(false);

            //Preenchendo a ComboBox
            cmbUnidadeMedida.DataSource = null;
            cmbUnidadeMedida.DataSource = oDtUnidadeMedida;
            cmbUnidadeMedida.ValueMember = "id_unidade";
            cmbUnidadeMedida.DisplayMember = "descricao_unidade";
            cmbUnidadeMedida.SelectedItem = "";
            cmbUnidadeMedida.Refresh();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbUnidadeMedida.SelectedIndex != -1)
            {
                btnConsultar.Visible = false;
                cmbUnidadeMedida.Enabled = false;

                btnCancelar.Visible = true;
                panelStatus.Visible = true;
                lblDescricao.Visible = true;
                lblSigla.Visible = true;
                txtSigla.Visible = true;
                txtDescricao.Visible = true;
                btnAlterar.Visible = true;

                int codigoUnidadeMedida = int.Parse(cmbUnidadeMedida.SelectedValue.ToString());

                DataRow[] row;

                row = oDtUnidadeMedida.Select("id_unidade = " + codigoUnidadeMedida);

                int rowIndex = oDtUnidadeMedida.Rows.IndexOf(row[0]);

                txtDescricao.Text = oDtUnidadeMedida.Rows[rowIndex]["descricao_unidade"].ToString();
                txtSigla.Text = oDtUnidadeMedida.Rows[rowIndex]["sigla_unidade"].ToString();

                if (oDtUnidadeMedida.Rows[rowIndex]["status_unidade"].ToString() == "True")
                    rdbAtivo.Checked = true;
                else
                    rdbInativo.Checked = true;
            }

            else
                MessageBox.Show("Selecione uma unidade de medida");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnConsultar.Visible = true;
            cmbUnidadeMedida.Enabled = true;
            btnAlterar.Enabled = true;

            btnCancelar.Visible = false;
            panelStatus.Visible = false;
            lblDescricao.Visible = false;
            lblSigla.Visible = false;
            txtSigla.Visible = false;
            txtDescricao.Visible = false;
            btnAlterar.Visible = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Validando o texto
            string descricaoUnidadeMedida = txtDescricao.Text.ToString().Trim();
            string siglaUnidadeMedida = txtSigla.Text.ToString().Trim();
            int codigoUnidadeMedida = int.Parse(cmbUnidadeMedida.SelectedValue.ToString());

            Boolean statusDescricao = validar.Textos(descricaoUnidadeMedida);
            Boolean siglaUnidade = validar.Textos(siglaUnidadeMedida);

            if (statusDescricao == true)
            {
                if (siglaUnidade == true)
                {
                    Boolean statusUnidadeMedida = rdbAtivo.Checked == true;

                    //Pedindo à camada de negócios para alterar a unidade de medida
                    Boolean statusAlteracao = camadaNegocios.AlterarUnidadeMedida(codigoUnidadeMedida, descricaoUnidadeMedida, siglaUnidadeMedida, statusUnidadeMedida);

                    if (statusAlteracao == true)
                    {
                        MessageBox.Show("Unidade de medida alterada com sucesso");

                        //Recarregando a página para atualizar as ComboBox
                        Point posicaoForm = new Point(100, 100);
                        posicaoForm = this.Location;

                        Form formConsultarUnidadeMedida = new ConsultarUnidadeMedida(formAnterior, posicaoForm.X, posicaoForm.Y);
                        xClicked = false;
                        this.Close();
                        formConsultarUnidadeMedida.Show();
                    }

                    else
                        MessageBox.Show("Erro ao alterar a unidade de medida");
                }
                
                else
                {
                    MessageBox.Show("Sigla inválida. \n\n" +
                                    "Deve ter pelo menos um caractere \n" +
                                    "Não conter caracteres especiais");
                    txtSigla.Focus();
                }

            }

            else
            {
                MessageBox.Show("Descrição inválida. \n\n" +
                                "Deve ter pelo menos um caractere \n" +
                                "Não conter caracteres especiais");
                txtDescricao.Focus();
            }
        }

        private void ConsultarUnidadeMedida_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
