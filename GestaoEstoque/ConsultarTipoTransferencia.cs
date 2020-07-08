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
    public partial class ConsultarTipoTransferencia : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        DataTable oDtTipoTransferencia = new DataTable();
        Form formAnterior;
        private Boolean xClicked = true;
        int permissaoUsuario;

        public ConsultarTipoTransferencia(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void ConsultarTipoTransferencia_Load(object sender, EventArgs e)
        {
            oDtTipoTransferencia.Clear();
                                            
            oDtTipoTransferencia = camadaNegocios.DataTableTipoTransferencia();

            //Preenchendo a ComboBox
            cmbTipoTransferencia.DataSource = null;
            cmbTipoTransferencia.DataSource = oDtTipoTransferencia;
            cmbTipoTransferencia.ValueMember = "id_tipo_transferencia";
            cmbTipoTransferencia.DisplayMember = "descricao_tipo_transferencia";
            cmbTipoTransferencia.SelectedItem = "";
            cmbTipoTransferencia.Refresh();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbTipoTransferencia.SelectedIndex != -1)
            {
                btnConsultar.Visible = false;
                cmbTipoTransferencia.Enabled = false;

                btnCancelar.Visible = true;
                panelStatus.Visible = true;
                lblDescricao.Visible = true;
                txtDescricao.Visible = true;
                btnAlterar.Visible = true;

                int codigoTipoTransferencia = int.Parse(cmbTipoTransferencia.SelectedValue.ToString());

                if (codigoTipoTransferencia == 1)
                    btnAlterar.Enabled = false;

                DataRow[] row;

                row = oDtTipoTransferencia.Select("id_tipo_transferencia = " + codigoTipoTransferencia);

                int rowIndex = oDtTipoTransferencia.Rows.IndexOf(row[0]);

                txtDescricao.Text = oDtTipoTransferencia.Rows[rowIndex]["descricao_tipo_transferencia"].ToString();          

                if (oDtTipoTransferencia.Rows[rowIndex]["status_tipo_transferencia"].ToString() == "True")
                    rdbAtivo.Checked = true;
                else
                    rdbInativo.Checked = true;
            }

            else
                MessageBox.Show("Selecione um tipo de transferência");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnConsultar.Visible = true;
            cmbTipoTransferencia.Enabled = true;
            btnAlterar.Enabled = true;

            btnCancelar.Visible = false;
            panelStatus.Visible = false;
            lblDescricao.Visible = false;
            txtDescricao.Visible = false;
            btnAlterar.Visible = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Validando o texto
            string descricaoTipoTransferencia = txtDescricao.Text.ToString().Trim();
            int codigoTipoTransferencia = int.Parse(cmbTipoTransferencia.SelectedValue.ToString());

            Boolean statusDescricao = validar.Textos(descricaoTipoTransferencia);

            if (statusDescricao == true)
            {
                Boolean statusTipoTransferencia = rdbAtivo.Checked == true;

                //Pedindo à camada de negócios para alterar o tipo de transferência
                Boolean statusAlteracao = camadaNegocios.AlterarTipoTransferencia(codigoTipoTransferencia, descricaoTipoTransferencia, statusTipoTransferencia);

                if (statusAlteracao == true)
                {
                    MessageBox.Show("Tipo de transferência alterado com sucesso");

                    //Recarregando a página para atualizar as ComboBox
                    Point posicaoForm = new Point(100, 100);
                    posicaoForm = this.Location;

                    Form formConsultarTipoTransferencia = new ConsultarTipoTransferencia(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
                    xClicked = false;
                    this.Close();
                    formConsultarTipoTransferencia.Show();
                }

                else
                    MessageBox.Show("Erro ao alterar o tipo de transferência");


            }

            else
            {
                MessageBox.Show("Descrição inválida. \n\n" +
                                "Deve ter pelo menos um caractere \n" +
                                "Não conter caracteres especiais");
                txtDescricao.Focus();
            }
        }

        private void ConsultarTipoTransferencia_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
