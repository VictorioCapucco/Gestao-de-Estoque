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
    public partial class ConsultarTransferencias : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        DataTable oDtTransferencias = new DataTable();
        Form formAnterior;
        private Boolean xClicked = true;
        int permissaoUsuario;

        public ConsultarTransferencias(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void ConsultarTransferencias_Load(object sender, EventArgs e)
        {
            //Criando o DataTable
            DataTable oDtLocal = new DataTable();
            oDtLocal.Clear();

            oDtLocal = camadaNegocios.DataTableTodosLocais();

            //Preenchendo a ComboBox
            cmbLocal.DataSource = null;
            cmbLocal.DataSource = oDtLocal;
            cmbLocal.ValueMember = "id_local";
            cmbLocal.DisplayMember = "descricao_local";
            cmbLocal.SelectedItem = "";
            cmbLocal.Refresh();


            //Criando o DataTable dos tipos de transferência
            DataTable oDtTipoTransferencia = new DataTable();
            oDtTipoTransferencia.Clear();

            oDtTipoTransferencia = camadaNegocios.DataTableTipoTransferencia();

            //Preenchendo a ComboBox dos tipos de transferencia
            cmbTipoTransferencia.DataSource = null;
            cmbTipoTransferencia.DataSource = oDtTipoTransferencia;
            cmbTipoTransferencia.ValueMember = "id_tipo_transferencia";
            cmbTipoTransferencia.DisplayMember = "descricao_tipo_transferencia";
            cmbTipoTransferencia.SelectedItem = "";
            cmbTipoTransferencia.Refresh();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbLocal.SelectedIndex != -1)
            {
                if (cmbTipoTransferencia.SelectedIndex != -1)
                {
                    cmbLocal.Enabled = false;
                    cmbTipoTransferencia.Enabled = false;
                    btnConfirmar.Visible = false;

                    lblTransferencia.Visible = true;
                    cmbTransferencia.Visible = true;
                    btnConsultar.Visible = true;

                    int codigoLocalDestino = int.Parse(cmbLocal.SelectedValue.ToString());
                    int codigoTipoTransferencia = int.Parse(cmbTipoTransferencia.SelectedValue.ToString());

                    //Consultando as transfêrencias com o filtro pedido

                    oDtTransferencias.Clear();

                    oDtTransferencias = camadaNegocios.DataTableTransferencia(codigoLocalDestino, codigoTipoTransferencia);

                    //Preenchendo a ComboBox dos tipos de transferencia
                    cmbTransferencia.DataSource = null;
                    cmbTransferencia.DataSource = oDtTransferencias;
                    cmbTransferencia.ValueMember = "id_transferencia";
                    cmbTransferencia.DisplayMember = "id_transferencia";
                    cmbTransferencia.SelectedItem = "";
                    cmbTransferencia.Refresh();
                    

                }

                else
                    MessageBox.Show("Selecione um tipo de transferência");
            }

            else
                MessageBox.Show("Selecione um local");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbTransferencia.SelectedIndex != -1)
            {
                cmbTransferencia.Enabled = false;
                btnConsultar.Visible = false;

                lstboxMateriais.Visible = true;
                lblLegenda.Visible = true;
                lblOrigem.Visible = true;
                lblDestino.Visible = true;
                txtOrigem.Visible = true;
                txtDestino.Visible = true;
                btnCancelar.Location = new Point(587, 331);

                int codigoTransferencia = int.Parse(cmbTransferencia.SelectedValue.ToString());

                int codigoLocalDestino = int.Parse(cmbLocal.SelectedValue.ToString());

                DataRow[] row;

                row = oDtTransferencias.Select("id_transferencia = " + codigoTransferencia);

                int rowIndex = oDtTransferencias.Rows.IndexOf(row[0]);


                int codigoLocalOrigem = int.Parse(oDtTransferencias.Rows[rowIndex]["id_local_origem"].ToString());

                txtDestino.Text = camadaNegocios.DescricaoLocal(codigoLocalDestino);
                txtOrigem.Text = camadaNegocios.DescricaoLocal(codigoLocalOrigem);

                try
                {
                    lstboxMateriais.Items.Clear();
                    //Atualizando a lstbox dos materiais

                    DataTable oDtMateriaisTransferencia = new DataTable();
                    oDtMateriaisTransferencia = camadaNegocios.DataTableMateriaisCodigoTransferencia(codigoTransferencia);

                    string codigoMaterial;
                    string nomeMaterial;
                    string quantidadeMaterial;


                    for (int i = 0; i < oDtMateriaisTransferencia.Rows.Count; i++)
                    {
                        codigoMaterial = oDtMateriaisTransferencia.Rows[i]["Codigo"].ToString();
                        nomeMaterial = oDtMateriaisTransferencia.Rows[i]["Nome"].ToString();
                        quantidadeMaterial = oDtMateriaisTransferencia.Rows[i]["Quantidade"].ToString();

                        //Formatando os dados para lstbox
                        while (codigoMaterial.Length < 6)
                            codigoMaterial = '0' + codigoMaterial;

                        while (nomeMaterial.Length < 20)
                            nomeMaterial = nomeMaterial + ' ';

                        lstboxMateriais.Items.Add(codigoMaterial + " - " + nomeMaterial + " - " + quantidadeMaterial);
                    }
                }

                catch
                {
                    //nada ocorre
                }
            }

            else
                MessageBox.Show("Selecione uma transferência");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Recarregando a página

            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarTransferencia = new ConsultarTransferencias(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            xClicked = false;
            this.Close();
            formConsultarTransferencia.Show();
        }

        private void ConsultarTransferencias_FormClosing(object sender, FormClosingEventArgs e)
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
