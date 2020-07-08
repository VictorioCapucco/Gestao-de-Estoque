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
    public partial class ConsultarMaterial : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        DataTable oDtMaterial = new DataTable();
        Form formAnterior;
        private Boolean xClicked = true;

        public ConsultarMaterial(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void btnConfirmarMaterial_Click(object sender, EventArgs e)
        {
            if (cmbNome.SelectedIndex != -1)
            {
                btnConfirmarMaterial.Visible = false;
                cmbNome.Enabled = false;

                lblTipo.Visible = true;
                lblUnidade.Visible = true;
                cmbTipoMaterial.Visible = true;
                cmbUnidade.Visible = true;
                gpbLocal.Visible = true;
                panelStatus.Visible = true;
                lblLegendaAdicionar.Visible = true;
                lblLegendaIncluso.Visible = true;
                lstboxLocaisInclusos.Visible = true;
                lstboxLocaisAdicionar.Visible = true;
                btnAlterar.Visible = true;
                btnLixeira.Visible = true;
                btnCancelar.Location = new Point(524, 421);

                //Criando o DataTable da unidade de medida
                DataTable oDtUnidade = new DataTable();
                oDtUnidade.Clear();
                                                        //filtroStatus
                oDtUnidade = camadaNegocios.DataTableUnidade(false);

                //Preenchendo a ComboBox dos tipos de material
                cmbUnidade.DataSource = null;
                cmbUnidade.DataSource = oDtUnidade;
                cmbUnidade.ValueMember = "id_unidade";
                cmbUnidade.DisplayMember = "descricao_unidade";
                cmbUnidade.SelectedItem = "";
                cmbUnidade.Refresh();

                //Criando o DataTable dos tipos de material
                DataTable oDtTipoMaterial = new DataTable();
                oDtTipoMaterial.Clear();
                oDtTipoMaterial = camadaNegocios.DataTableTipoMaterial();

                //Preenchendo a ComboBox dos tipos de material
                cmbTipoMaterial.DataSource = null;
                cmbTipoMaterial.DataSource = oDtTipoMaterial;
                cmbTipoMaterial.ValueMember = "id_tipo_material";
                cmbTipoMaterial.DisplayMember = "descricao_reduzida_tipo_material";
                cmbTipoMaterial.SelectedItem = "";
                cmbTipoMaterial.Refresh();


                int codigoMaterial = int.Parse(cmbNome.SelectedValue.ToString());

                //Colocando os locais na lstbox
                try
                {
                    lstboxLocaisInclusos.Items.Clear();

                    DataTable oDtLocaisInclusos = new DataTable();
                    oDtLocaisInclusos = camadaNegocios.DataTableMaterialLocais(codigoMaterial);

                    string codigoLocal;
                    string descricaoLocal;


                    for (int i = 0; i < oDtLocaisInclusos.Rows.Count; i++)
                    {
                        codigoLocal = oDtLocaisInclusos.Rows[i]["Codigo"].ToString();
                        descricaoLocal = oDtLocaisInclusos.Rows[i]["Descricao"].ToString();

                        //Formatando os dados para lstbox
                        while (codigoLocal.Length < 6)
                            codigoLocal = '0' + codigoLocal;

                        lstboxLocaisInclusos.Items.Add(codigoLocal + " - " + descricaoLocal);
                    }
                }

                catch
                {
                    //nada ocorre
                }


                DataRow[] row;

                row = oDtMaterial.Select("id_material = " + codigoMaterial);

                int rowIndex = oDtMaterial.Rows.IndexOf(row[0]);

                cmbTipoMaterial.SelectedValue = int.Parse(oDtMaterial.Rows[rowIndex]["id_tipo_material"].ToString());
                cmbUnidade.SelectedValue = int.Parse(oDtMaterial.Rows[rowIndex]["id_unidade"].ToString());

                if (oDtMaterial.Rows[rowIndex]["status_material"].ToString() == "True")
                    rdbAtivo.Checked = true;
                else
                    rdbInativo.Checked = true;
            }

            else
                MessageBox.Show("Selecione um material");
        }

        private void ConsultarMaterial_Load(object sender, EventArgs e)
        {
            oDtMaterial.Clear();

            oDtMaterial = camadaNegocios.DataTableMaterial();

            //Preenchendo a ComboBox
            cmbNome.DataSource = null;
            cmbNome.DataSource = oDtMaterial;
            cmbNome.ValueMember = "id_material";
            cmbNome.DisplayMember = "nome_material";
            cmbNome.SelectedItem = "";
            cmbNome.Refresh();
        }

        private void btnAdicionarLocal_Click(object sender, EventArgs e)
        {
            string strCodigoLocal = txtCodigoLocal.Text.ToString();

            //Fazendo a validação do texto
            Boolean statusCodigoLocal = validar.Textos(strCodigoLocal);
            if (statusCodigoLocal == true)
            {
                //Verificando se é um número inteiro - Se retornar 0, é porque o código é inválido
                int codigoLocal = validar.IsNumero(strCodigoLocal);

                if (codigoLocal != 0)
                {
                    //Verificando se o local existe - Se o nome do local retornar como vazio, então ele não existe
                    string nomeLocal = camadaNegocios.ExisteLocal(codigoLocal);
                    if (nomeLocal != "")
                    {
                        Boolean encontrouLocalListBox = false;
                        string item;
                        int index;

                        //Verificando se o local já está na listbox de inclusos
                        for (index = (lstboxLocaisInclusos.Items.Count) - 1; index >= 0; index--)
                        {
                            item = lstboxLocaisInclusos.Items[index].ToString();
                            var array = item.Split('-');

                            if (codigoLocal == int.Parse(array[0]))
                            {
                                encontrouLocalListBox = true;
                                break;
                            }
                        }


                        //Verificando se o local já está na listbox dos adicionados
                        for (index = (lstboxLocaisAdicionar.Items.Count) - 1; index >= 0; index--)
                        {
                            item = lstboxLocaisAdicionar.Items[index].ToString();
                            var array = item.Split('-');

                            if (codigoLocal == int.Parse(array[0]))
                            {
                                encontrouLocalListBox = true;
                                break;
                            }
                        }

                        string stringCodigoLocal = codigoLocal.ToString();

                        //Formatando os dados para lstbox
                        while (stringCodigoLocal.Length < 6)
                            stringCodigoLocal = '0' + stringCodigoLocal;


                        //Caso o local não esteja na listbox, iremos adiciona-lo
                        if (encontrouLocalListBox == false)
                        {
                            lstboxLocaisAdicionar.Items.Add(stringCodigoLocal + " - " + nomeLocal);
                        }

                        //Caso contrário, nada ocorre

                        txtCodigoLocal.Text = "";
                        txtCodigoLocal.Focus();
                    }

                    else
                        MessageBox.Show("Local não existente");
                }

                else
                    MessageBox.Show("Código de local inválido");
            }

            else
                MessageBox.Show("Código de local inválido");
        }

        private void txtCodigoLocal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnAdicionarLocal.PerformClick();
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

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (lstboxLocaisAdicionar.SelectedIndex != -1)
            {
                lstboxLocaisAdicionar.Items.RemoveAt(lstboxLocaisAdicionar.SelectedIndex);
            }
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este material só existirá nos locais que você determinar");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int codigoMaterial = int.Parse(cmbNome.SelectedValue.ToString());
            int codigoTipoMaterial = int.Parse(cmbTipoMaterial.SelectedValue.ToString());
            int codigoUnidade = int.Parse(cmbUnidade.SelectedValue.ToString());
            Boolean statusMaterial = rdbAtivo.Checked == true;

            //Atualizando os registros do material
            Boolean statusAlterarMaterial = camadaNegocios.AlterarMaterial(codigoMaterial, statusMaterial, codigoTipoMaterial, codigoUnidade);

            if (statusAlterarMaterial == true)
            {
                //Incluindo o material nos locais adicionados
                Boolean statusMaterialLocal = true;
                int codigoLocal;

                for (int index = (lstboxLocaisAdicionar.Items.Count) - 1; index >= 0; index--)
                {
                    var array = ((lstboxLocaisAdicionar.Items[index]).ToString()).Split('-');
                    codigoLocal = int.Parse(array[0].ToString());

                    statusMaterialLocal = camadaNegocios.InserirMaterialLocal(codigoMaterial, codigoLocal);

                    if (statusMaterialLocal == false)
                        break;
                }

                if (statusMaterialLocal == true)
                {
                    MessageBox.Show("Material alterado com sucesso!");

                    //Recarregando a página

                    Point posicaoForm = new Point(100, 100);
                    posicaoForm = this.Location;

                    Form formConsultarMaterial = new ConsultarMaterial(formAnterior, posicaoForm.X, posicaoForm.Y);
                    xClicked = false;
                    this.Close();
                    formConsultarMaterial.Show();
                }

                else
                {
                    MessageBox.Show("Material alterado. Erro ao adicionar os materiais nos locais. \n\n");

                    //Recarregando a página

                    Point posicaoForm = new Point(100, 100);
                    posicaoForm = this.Location;

                    Form formConsultarMaterial = new ConsultarMaterial(formAnterior, posicaoForm.X, posicaoForm.Y);
                    xClicked = false;
                    this.Close();
                    formConsultarMaterial.Show();
                }
            }

            else
                MessageBox.Show("Erro ao alterar o material");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarMaterial = new ConsultarMaterial(formAnterior, posicaoForm.X, posicaoForm.Y);
            xClicked = false;
            this.Close();
            formConsultarMaterial.Show();
        }

        private void ConsultarMaterial_FormClosing(object sender, FormClosingEventArgs e)
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
