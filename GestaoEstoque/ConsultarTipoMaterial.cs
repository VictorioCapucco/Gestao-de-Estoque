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
    public partial class ConsultarTipoMaterial : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        private Boolean xClicked = true;
        int permissaoUsuario;

        public ConsultarTipoMaterial(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void ConsultarTipoMaterial_Load(object sender, EventArgs e)
        {
            //Criando o DataTable dos tipos de material
            DataTable oDtTipoMaterial = new DataTable();
            oDtTipoMaterial.Clear();
                                                            //filtraCodigo, filtraStatus, codigoTipoMaterial
            oDtTipoMaterial = camadaNegocios.DataTableTipoMaterial(false, false, 0);

            //Preenchendo a ComboBox dos tipos de material
            cmbTipoMaterial.DataSource = null;
            cmbTipoMaterial.DataSource = oDtTipoMaterial;
            cmbTipoMaterial.ValueMember = "id_tipo_material";
            cmbTipoMaterial.DisplayMember = "descricao_reduzida_tipo_material";
            cmbTipoMaterial.SelectedItem = "";
            cmbTipoMaterial.Refresh();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbTipoMaterial.SelectedIndex != -1)
            {
                int codigoTipoMaterial = int.Parse(cmbTipoMaterial.SelectedValue.ToString());

                DataTable oDtTipoMaterial = new DataTable();

                                                                //filtraCodigo, filtraStatus, codigoTipoMaterial
                oDtTipoMaterial = camadaNegocios.DataTableTipoMaterial(true, false, codigoTipoMaterial);

                if (oDtTipoMaterial.Rows.Count > 0)
                {
                    cmbTipoMaterial.Enabled = false;
                    btnConsultar.Visible = false;
                    lblDescricao.Visible = true;
                    lblDescricaoReduzida.Visible = true;
                    txtDescricao.Visible = true;
                    txtDescricaoReduzida.Visible = true;
                    panelStatus.Visible = true;
                    btnAlterar.Visible = true;
                    btnCancelar.Visible = true;

                    txtDescricao.Text = oDtTipoMaterial.Rows[0]["descricao_tipo_material"].ToString();
                    txtDescricaoReduzida.Text = oDtTipoMaterial.Rows[0]["descricao_reduzida_tipo_material"].ToString();

                    if (oDtTipoMaterial.Rows[0]["status_tipo_material"].ToString() == "True")
                        rdbAtivo.Checked = true;
                    else
                        rdbInativo.Checked = true;
                }

                else
                    MessageBox.Show("Tipo de material não encontrado");

            }

            else
                MessageBox.Show("Selecione um tipo de material");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Validando os textos
            string descricao = txtDescricao.Text.ToString().Trim();
            string descricaoReduzida = txtDescricaoReduzida.Text.ToString().Trim();

            Boolean statusDescricao = validar.Textos(descricao);
            Boolean statusDescricaoReduzida = validar.Textos(descricaoReduzida);

            if (statusDescricao == true)
            {
                if (statusDescricaoReduzida == true)
                {
                    int codigoTipoMaterial = int.Parse(cmbTipoMaterial.SelectedValue.ToString());

                    Boolean statusTipoMaterial = rdbAtivo.Checked == true;

                    Boolean statusAlterar = camadaNegocios.AlterarTipoMaterial(codigoTipoMaterial, descricaoReduzida, descricao, statusTipoMaterial);

                    if (statusAlterar == true)
                    {
                        MessageBox.Show("Tipo de material alterado com sucesso");

                        //Recarregando a página

                        Point posicaoForm = new Point(100, 100);
                        posicaoForm = this.Location;

                        Form formConsultarTipoMaterial = new ConsultarTipoMaterial(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
                        xClicked = false;
                        this.Close();
                        formConsultarTipoMaterial.Show();
                    }

                    else
                        MessageBox.Show("Não foi possível alterar o tipo de material");
                }

                else
                    MessageBox.Show("Descrição reduzida inválida");
            }

            else
                MessageBox.Show("Descrição inválida");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Recarregando a página

            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarTipoMaterial = new ConsultarTipoMaterial(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            xClicked = false;
            this.Close();
            formConsultarTipoMaterial.Show();
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

        private void ConsultarTipoMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }
    }
}
