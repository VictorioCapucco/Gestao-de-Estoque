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
    public partial class ConsultarPedidoCompra : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        DataTable oDtTipoTransferencia = new DataTable();
        Form formAnterior;
        private Boolean xClicked = true;

        public ConsultarPedidoCompra(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void ConsultarPedidoCompra_Load(object sender, EventArgs e)
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

                lblPedidoCompra.Visible = true;
                cmbPedidoCompra.Visible = true;
                btnConsultar.Visible = true;

                int codigoLocal = int.Parse(cmbLocal.SelectedValue.ToString());
                int codigoFornecedor = int.Parse(cmbFornecedor.SelectedValue.ToString());


                //Criando o DataTable
                DataTable oDtPedidoCompra = new DataTable();
                oDtPedidoCompra.Clear();

                //filtraStatus, statusFornecedor
                oDtPedidoCompra = camadaNegocios.DataTablePedidoCompraFornecedor(false, codigoLocal, codigoFornecedor);

                //Preenchendo a ComboBox
                cmbPedidoCompra.DataSource = null;
                cmbPedidoCompra.DataSource = oDtPedidoCompra;
                cmbPedidoCompra.ValueMember = "id_pedido_compra";
                cmbPedidoCompra.DisplayMember = "id_pedido_compra";
                cmbPedidoCompra.SelectedItem = "";
                cmbPedidoCompra.Refresh();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbPedidoCompra.SelectedIndex != -1)
            {
                btnConsultar.Visible = false;
                cmbPedidoCompra.Enabled = false;

                lblLegenda.Visible = true;
                lstboxMateriais.Visible = true;
                btnExcluir.Visible = true;

                btnCancelar.Location = new Point(359, 331);

                int codigoPedidoCompra = int.Parse(cmbPedidoCompra.SelectedValue.ToString());

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
                    }
                }

                catch
                {
                    //nada ocorre
                }
            }

            else
                MessageBox.Show("Selecione um pedido de compra");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigoPedidoCompra = int.Parse(cmbPedidoCompra.SelectedValue.ToString());

            //Excluindo o pedido de compra
            Boolean statusExcluirPedido = camadaNegocios.ExcluirPedidoCOmpra(codigoPedidoCompra);

            //Excluindo os materiais deste pedido de compra
            Boolean statusExcluirMateriais = camadaNegocios.ExcluirMateriaisPedidoCompra(codigoPedidoCompra);

            if (statusExcluirMateriais == true && statusExcluirPedido == true)
            {
                MessageBox.Show("Pedido de compra excluído com sucesso");

                //Recarregando a página

                Point posicaoForm = new Point(100, 100);
                posicaoForm = this.Location;

                Form formConsultarPedidoCompra = new ConsultarPedidoCompra(formAnterior, posicaoForm.X, posicaoForm.Y);
                xClicked = false;
                this.Close();
                formConsultarPedidoCompra.Show();
            }

            else
                MessageBox.Show("Erro ao fazer a exclusão");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Recarregando a página

            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarPedidoCompra = new ConsultarPedidoCompra(formAnterior, posicaoForm.X, posicaoForm.Y);
            xClicked = false;
            this.Close();
            formConsultarPedidoCompra.Show();
        }

        private void ConsultarPedidoCompra_FormClosing(object sender, FormClosingEventArgs e)
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
