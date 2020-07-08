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
    public partial class ConsultarUsuario : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        DataTable oDtUsuario = new DataTable();
        Form formAnterior;
        private Boolean xClicked = true;

        public ConsultarUsuario(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            oDtUsuario.Clear();

            oDtUsuario = camadaNegocios.DataTableUsuario();

            //Preenchendo a ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.DataSource = oDtUsuario;
            cmbUsuario.ValueMember = "id_usuario";
            cmbUsuario.DisplayMember = "nome_usuario";
            cmbUsuario.SelectedItem = "";
            cmbUsuario.Refresh();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex != -1)
            {
                cmbUsuario.Enabled = false;
                btnConsultar.Visible = false;

                lblNome.Visible = true;
                lblSenha.Visible = true;
                txtSenha.Visible = true;
                txtNome.Visible = true;
                panelTipoUsuario.Visible = true;
                panelStatus.Visible = true;
                btnCancelar.Visible = true;
                btnAlterar.Visible = true;

                int codigoUsuario = int.Parse(cmbUsuario.SelectedValue.ToString());

                DataRow[] row;

                row = oDtUsuario.Select("id_usuario = " + codigoUsuario);

                int rowIndex = oDtUsuario.Rows.IndexOf(row[0]);

                txtNome.Text = oDtUsuario.Rows[rowIndex]["nome_usuario"].ToString();


                if (oDtUsuario.Rows[rowIndex]["tipo_usuario"].ToString() == "0")
                    rdbAdministrador.Checked = true;
                else if (oDtUsuario.Rows[rowIndex]["tipo_usuario"].ToString() == "1")
                    rdbSupervisor.Checked = true;
                else
                    rdbAuxiliar.Checked = true;


               if (oDtUsuario.Rows[rowIndex]["status_usuario"].ToString() == "True")
                    rdbAtivo.Checked = true;
                else
                    rdbInativo.Checked = true;
            }

            else
                MessageBox.Show("Selecione um usuário");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnConsultar.Visible = true;
            cmbUsuario.Enabled = true;

            btnCancelar.Visible = false;
            panelStatus.Visible = false;
            panelTipoUsuario.Visible = false;
            lblNome.Visible = false;
            lblSenha.Visible = false;
            txtNome.Visible = false;
            txtSenha.Visible = false;
            btnAlterar.Visible = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Validando o texto
            string nomeUsuario = txtNome.Text.ToString().Trim();
            string senhaUsuario = txtSenha.Text.ToString().Trim();
            int codigoUsuario = int.Parse(cmbUsuario.SelectedValue.ToString());
            int tipoUsuario;

            if (rdbAdministrador.Checked == true)
                tipoUsuario = 0;
            else if (rdbSupervisor.Checked == true)
                tipoUsuario = 1;
            else
                tipoUsuario = 2;

            Boolean statusNome = validar.Textos(nomeUsuario);

            if (statusNome == true)
            {
                Boolean statusSenha = validar.Textos(senhaUsuario);
                Boolean statusUsuario = rdbAtivo.Checked == true;

                //Se o tamanho da senha for 0, então a senha será a mesma que o usuário já tinha
                if (statusSenha == true || senhaUsuario.Length == 0)
                {
                    if (senhaUsuario != "")
                    {
                        Criptografia criptografar = new Criptografia();
                        senhaUsuario = criptografar.Senha(senhaUsuario);
                    }

                    //Pedindo à camada de negócios para alterar o usuário
                    Boolean statusAlteracao = camadaNegocios.AlterarUsuario(codigoUsuario, nomeUsuario, tipoUsuario, senhaUsuario, statusUsuario);

                    if (statusAlteracao == true)
                    {
                        MessageBox.Show("Usuário alterado com sucesso");

                        //Recarregando a página para atualizar as ComboBox
                        Point posicaoForm = new Point(100, 100);
                        posicaoForm = this.Location;

                        Form formConsultarUsuario = new ConsultarUsuario(formAnterior, posicaoForm.X, posicaoForm.Y);
                        xClicked = false;
                        this.Close();
                        formConsultarUsuario.Show();
                    }

                    else
                        MessageBox.Show("Erro ao alterar o usuário");

                }


                else
                {
                    MessageBox.Show("Senha inválida. \n\n" +
                                    "Deve ter pelo menos um caractere \n" +
                                    "Não conter caracteres especiais");
                    txtSenha.Focus();
                }
            }

            else
            {
                MessageBox.Show("Nome inválido. \n\n" +
                                "Deve ter pelo menos um caractere \n" +
                                "Não conter caracteres especiais");
                txtNome.Focus();
            }
        }

        private void ConsultarUsuario_FormClosing(object sender, FormClosingEventArgs e)
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
