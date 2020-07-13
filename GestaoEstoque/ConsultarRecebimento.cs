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
    public partial class ConsultarRecebimento : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        DataTable oDtRecebimento = new DataTable();
        Validacao validar = new Validacao();
        Form formAnterior;
        private Boolean xClicked = true;
        int permissaoUsuario;

        public ConsultarRecebimento(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void ConsultarRecebimento_Load(object sender, EventArgs e)
        {
            //Criando o DataTable
            DataTable oDtLocal = new DataTable();
            oDtLocal.Clear();

                                                     //filtraLocal, statusLocal, isObra, statusObra, codigoLocal
            oDtLocal = camadaNegocios.DataTableLocais(false, true, false, false, 0);

            //Preenchendo a ComboBox
            cmbLocal.DataSource = null;
            cmbLocal.DataSource = oDtLocal;
            cmbLocal.ValueMember = "id_local";
            cmbLocal.DisplayMember = "descricao_local";
            cmbLocal.SelectedItem = "";
            cmbLocal.Refresh();
        }

        private void btnConfirmarLocal_Click(object sender, EventArgs e)
        {
            if (cmbLocal.SelectedIndex != -1)
            {
                btnConfirmarLocal.Visible = false;
                cmbLocal.Enabled = false;

                lblFornecedor.Visible = true;
                cmbFornecedor.Visible = true;
                btnConfirmarFornecedor.Visible = true;

                //Criando o DataTable
                DataTable oDtFornecedor = new DataTable();
                oDtFornecedor.Clear();

                                                                //filtraStatus, statusFornecedor
                oDtFornecedor = camadaNegocios.DataTableFornecedor(false, false);

                //Preenchendo a ComboBox
                cmbFornecedor.DataSource = null;
                cmbFornecedor.DataSource = oDtFornecedor;
                cmbFornecedor.ValueMember = "id_for";
                cmbFornecedor.DisplayMember = "nome_for";
                cmbFornecedor.SelectedItem = "";
                cmbFornecedor.Refresh();
            }

            else
                MessageBox.Show("Informe um local");
        }

        private void btnConfirmarFornecedor_Click(object sender, EventArgs e)
        {
            if (cmbFornecedor.SelectedIndex != -1)
            {
                btnConfirmarFornecedor.Visible = false;
                cmbFornecedor.Enabled = false;

                lblRecebimento.Visible = true;
                cmbRecebimento.Visible = true;
                btnConsultar.Visible = true;
                
                oDtRecebimento.Clear();

                //filtraStatus, statusFornecedor
                oDtRecebimento = camadaNegocios.DataTableRecebimento();

                //Preenchendo a ComboBox
                cmbRecebimento.DataSource = null;
                cmbRecebimento.DataSource = oDtRecebimento;
                cmbRecebimento.ValueMember = "id_recebimento";
                cmbRecebimento.DisplayMember = "id_recebimento";
                cmbRecebimento.SelectedItem = "";
                cmbRecebimento.Refresh();

            }

            else
                MessageBox.Show("Selecione um fornecedor");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbRecebimento.SelectedIndex != -1)
            {
                btnConsultar.Visible = false;
                cmbRecebimento.Enabled = false;

                lblLegenda.Visible = true;
                lstboxMateriais.Visible = true;
                lblDataRecebimento.Visible = true;
                mskDataRecebimento.Visible = true;

                int codigoRecebimento = int.Parse(cmbRecebimento.SelectedValue.ToString());

                DataRow[] row;

                row = oDtRecebimento.Select("id_recebimento = " + codigoRecebimento);

                int rowIndex = oDtRecebimento.Rows.IndexOf(row[0]);

                string dataRecebimento = oDtRecebimento.Rows[rowIndex]["dt_recebimento"].ToString();
                int codigoPedidoCompra = int.Parse(oDtRecebimento.Rows[rowIndex]["id_pedido_compra"].ToString());

                dataRecebimento = validar.AjustarData(dataRecebimento);

                try
                {
                    lstboxMateriais.Items.Clear();
                    //Atualizando a lstbox dos materiais da obra

                    DataTable oDtMateriaisPedidoCompra = new DataTable();
                    oDtMateriaisPedidoCompra = camadaNegocios.DataTableMateriaisPedidoCompra(codigoPedidoCompra);

                    string codigoMaterial;
                    string nomeMaterial;
                    string quantidadeMaterial;


                    for (int i = 0; i < oDtMateriaisPedidoCompra.Rows.Count; i++)
                    {
                        codigoMaterial = oDtMateriaisPedidoCompra.Rows[i]["Codigo"].ToString();
                        nomeMaterial = oDtMateriaisPedidoCompra.Rows[i]["Nome"].ToString();
                        quantidadeMaterial = oDtMateriaisPedidoCompra.Rows[i]["Quantidade"].ToString();

                        //Formatando os dados para lstbox
                        while (codigoMaterial.Length < 6)
                            codigoMaterial = '0' + codigoMaterial;

                        while (nomeMaterial.Length < 20)
                            nomeMaterial = nomeMaterial + ' ';

                        lstboxMateriais.Items.Add(codigoMaterial + " - " + nomeMaterial + " - " + quantidadeMaterial);

                        mskDataRecebimento.Text = dataRecebimento;
                    }
                }

                catch
                {
                    //nada ocorre
                }
            }

            else
                MessageBox.Show("Selecione um recebimento");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Recarregando a página

            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarRecebimento = new ConsultarRecebimento(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            xClicked = false;
            this.Close();
            formConsultarRecebimento.Show();
        }

        private void ConsultarRecebimento_FormClosing(object sender, FormClosingEventArgs e)
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
