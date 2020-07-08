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
    public partial class IncluirRecebimento : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        DataTable oDtPedidoCompra = new DataTable();
        Validacao validar = new Validacao();
        Form formAnterior;
        private Boolean xClicked = true;

        public IncluirRecebimento(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void IncluirRecebimento_Load(object sender, EventArgs e)
        {
            //Criando o DataTable
            DataTable oDtLocal = new DataTable();
            oDtLocal.Clear();

                                                    //statusLocal, isObra, statusObra
            oDtLocal = camadaNegocios.DataTableLocais(true, false, false);

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
                int codigoLocal = int.Parse(cmbLocal.SelectedValue.ToString());
                //O DataTable de pedidos de compra é uma variável global
                
                oDtPedidoCompra.Clear();

                                                                    //statusPedidoCompra
                oDtPedidoCompra = camadaNegocios.DataTablePedidoCompra(false, codigoLocal);

                //Preenchendo a ComboBox
                cmbPedidoCompra.DataSource = null;
                cmbPedidoCompra.DataSource = oDtPedidoCompra;
                cmbPedidoCompra.ValueMember = "Codigo";
                cmbPedidoCompra.DisplayMember = "Codigo";
                cmbPedidoCompra.SelectedItem = "";
                cmbPedidoCompra.Refresh();

                lblPedidoCompra.Visible = true;
                cmbPedidoCompra.Visible = true;
                lblFornecedor.Visible = true;
                txtFornecedor.Visible = true;
                btnUtilizarPedido.Visible = true;
                lstboxMateriais.Visible = true;
                lblLegenda.Visible = true;

                btnConfirmarLocal.Visible = false;
                cmbLocal.Enabled = false;

                try
                {
                    txtFornecedor.Text = oDtPedidoCompra.Rows[0]["Fornecedor"].ToString();
                    lstboxMateriais.Items.Clear();
                    //Atualizando a lstbox dos materiais da obra
                    int codigoPedidoCompra = int.Parse(cmbPedidoCompra.SelectedValue.ToString());

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
                    }
                }

                catch
                {
                    //nada ocorre
                }
            }

            else
                MessageBox.Show("Selecione um local");
        }

        private void cmbPedidoCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFornecedor.Text = oDtPedidoCompra.Rows[cmbPedidoCompra.SelectedIndex]["Fornecedor"].ToString();
        }

        private void cmbPedidoCompra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtFornecedor.Text = oDtPedidoCompra.Rows[cmbPedidoCompra.SelectedIndex]["Fornecedor"].ToString();
            lstboxMateriais.Items.Clear();
            //Atualizando a lstbox dos materiais da obra
            int codigoPedidoCompra = int.Parse(cmbPedidoCompra.SelectedValue.ToString());

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
            }
        }

        private void btnUtilizarPedido_Click(object sender, EventArgs e)
        {
            if (cmbPedidoCompra.SelectedIndex != -1)
            {
                cmbPedidoCompra.Enabled = false;
                btnUtilizarPedido.Visible = false;

                gpbData.Visible = true;
                btnIncluir.Visible = true;

                //Ajustando a localização do botão cancelar
                btnCancelar.Location = new Point(468, btnCancelar.Location.Y);
            }

            else
                MessageBox.Show("Selecione um pedido de compra");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string dataRecebimento = mskDataRecebimento.Text.ToString();

            Boolean statusData = validar.Data(dataRecebimento);

            if (statusData == true)
            {
                Boolean statusAtualizarEstoque = true;
                int codigoMaterial;
                int quantidadeMaterial;
                int codigoLocal = int.Parse(cmbLocal.SelectedValue.ToString());

                //Aumentando o estoque
                for (int index = (lstboxMateriais.Items.Count) - 1; index >= 0; index--)
                {
                    var array = ((lstboxMateriais.Items[index]).ToString()).Split('-');

                    codigoMaterial = int.Parse(array[0]);
                    quantidadeMaterial = int.Parse(array[2]);

                    statusAtualizarEstoque = camadaNegocios.AumentaEstoque(codigoMaterial, codigoLocal, quantidadeMaterial);
                    if (statusAtualizarEstoque == false)
                        break;
                }

                if (statusAtualizarEstoque == true)
                {
                    //Atualizando status do pedido de compra

                    int codigoPedidoCompra = int.Parse(cmbPedidoCompra.SelectedValue.ToString());
                    Boolean statusAtualizarPedido = camadaNegocios.AtualizarPedidoCopmra(codigoPedidoCompra);

                    if (statusAtualizarPedido == true)
                    {
                        //Incluindo o recebimento
                        camadaNegocios.InserirRecebimento(dataRecebimento, codigoPedidoCompra);

                        MessageBox.Show("Recebimento incluído com sucesso");

                        //Recarregando a página

                        Point posicaoForm = new Point(100, 100);
                        posicaoForm = this.Location;

                        Form formIncluiRecebimento = new IncluirRecebimento(formAnterior, posicaoForm.X, posicaoForm.Y);
                        xClicked = false;
                        this.Close();
                        formIncluiRecebimento.Show();
                    }

                    else
                        MessageBox.Show("Erro ao atualizar o status do pedido de compra");
                }

                else
                    MessageBox.Show("Erro ao incluir o recebimento");
            }

            else
                MessageBox.Show("Data do recebimento inválida");
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


        private void IncluirRecebimento_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
