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
    public partial class ConsultarLocais : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        Form formAnterior;
        private Boolean xClicked = true;
        int permissaoUsuario;

        public ConsultarLocais(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void ConsultarLocais_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Se retornar 0, é porque o código é inválido
            int codigoLocal = validar.IsNumero(txtCodigoLocal.Text.ToString());

            if (codigoLocal != 0)
            {
                DataTable oDtLocais = new DataTable();
                oDtLocais = camadaNegocios.DataTableLocais(true, false, false, false, codigoLocal);

                if (oDtLocais.Rows.Count > 0)
                {
                    btnConfirmar.Visible = false;
                    txtCodigoLocal.Enabled = false;

                    lblDescricao.Visible = true;
                    lblEndereco.Visible = true;
                    txtDescricao.Visible = true;
                    txtEndereco.Visible = true;
                    panelStatus.Visible = true;
                    btnAlterar.Visible = true;
                    btnCancelar.Visible = true;

                    txtDescricao.Text = oDtLocais.Rows[0]["descricao_local"].ToString();
                    txtEndereco.Text = oDtLocais.Rows[0]["endereco_local"].ToString();

                    if (oDtLocais.Rows[0]["status_local"].ToString() == "True")
                        rdbAtivo.Checked = true;
                    else
                        rdbInativo.Checked = true;
                }

                else
                    MessageBox.Show("Local não encontrado");
            }

            else
                MessageBox.Show("Código inválido");
        }

        private void txtCodigoLocal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnConfirmar.PerformClick();
            }

            if (e.KeyCode == Keys.F1)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                Point posicaoForm = new Point(100, 100);
                posicaoForm = this.Location;


                Form formBuscarLocal = new BuscaLocal(this, posicaoForm.X, posicaoForm.Y);
                this.Hide();
                formBuscarLocal.Show();
            }
        }

        private void txtCodigoLocal_Enter(object sender, EventArgs e)
        {
            if (txtCodigoLocal.Text == "  F1 para consultar" && txtCodigoLocal.ForeColor == Color.Gray)
            {
                txtCodigoLocal.Text = "";
                txtCodigoLocal.ForeColor = Color.Black;
            }
        }

        private void txtCodigoLocal_Leave(object sender, EventArgs e)
        {
            if (txtCodigoLocal.Text == "")
            {
                txtCodigoLocal.Text = "  F1 para consultar";
                txtCodigoLocal.ForeColor = Color.Gray;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Validando os textos
            string descricaoLocal = txtDescricao.Text.ToString().Trim();
            string enderecoLocal = txtEndereco.Text.ToString().Trim();

            Boolean statusDescricao = validar.Textos(descricaoLocal);
            Boolean statusEndereco = validar.Textos(enderecoLocal);

            if (statusDescricao == true)
            {
                if (statusEndereco == true)
                {
                    int codigoLocal = int.Parse(txtCodigoLocal.Text.ToString());
                    Boolean statusLocal = rdbAtivo.Checked == true;

                    Boolean statusAlterar = camadaNegocios.AlterarLocal(codigoLocal, descricaoLocal, enderecoLocal, statusLocal);

                    if (statusAlterar == true)
                    {
                        MessageBox.Show("Local alterado com sucesso");

                        //Recarregando a página

                        Point posicaoForm = new Point(100, 100);
                        posicaoForm = this.Location;

                        Form formConsultarLocais = new ConsultarLocais(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
                        xClicked = false;
                        this.Close();
                        formConsultarLocais.Show();
                    }

                    else
                        MessageBox.Show("Erro ao alterar o local");
                }

                else
                    MessageBox.Show("Endereço inválido");
            }

            else
                MessageBox.Show("Descrição inválida");
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

        private void ConsultarLocais_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }
    }
}
