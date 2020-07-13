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
        int permissaoUsuario;

        public IncluirRecebimento(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void IncluirRecebimento_Load(object sender, EventArgs e)
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
                lstboxMateriaisPedido.Visible = true;
                lblLegendaPedidoCompra.Visible = true;

                btnConfirmarLocal.Visible = false;
                cmbLocal.Enabled = false;

                try
                {
                    txtFornecedor.Text = oDtPedidoCompra.Rows[0]["Fornecedor"].ToString();
                    lstboxMateriaisPedido.Items.Clear();

                    //Atualizando a lstbox dos materiais pedidos
                    int codigoPedidoCompra = int.Parse(cmbPedidoCompra.SelectedValue.ToString());

                    DataTable oDtMateriaisPedidoCompra = new DataTable();
                    oDtMateriaisPedidoCompra = camadaNegocios.DataTableMateriaisPedidoCompra(codigoPedidoCompra);

                    string codigoMaterial;
                    string nomeMaterial;
                    int quantidadeMaterial;


                    for (int i = 0; i < oDtMateriaisPedidoCompra.Rows.Count; i++)
                    {
                        codigoMaterial = oDtMateriaisPedidoCompra.Rows[i]["Codigo"].ToString();
                        nomeMaterial = oDtMateriaisPedidoCompra.Rows[i]["Nome"].ToString();
                        quantidadeMaterial = int.Parse(oDtMateriaisPedidoCompra.Rows[i]["Quantidade"].ToString()) - int.Parse(oDtMateriaisPedidoCompra.Rows[i]["Quantidade_Recebida"].ToString());

                        if (quantidadeMaterial > 0)
                        {
                            //Formatando os dados para lstbox
                            while (codigoMaterial.Length < 6)
                                codigoMaterial = '0' + codigoMaterial;

                            while (nomeMaterial.Length < 20)
                                nomeMaterial = nomeMaterial + ' ';

                            lstboxMateriaisPedido.Items.Add(codigoMaterial + " - " + nomeMaterial + " - " + quantidadeMaterial.ToString());
                        }
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
            lstboxMateriaisPedido.Items.Clear();
            //Atualizando a lstbox dos materiais da obra
            int codigoPedidoCompra = int.Parse(cmbPedidoCompra.SelectedValue.ToString());

            DataTable oDtMateriaisPedidoCompra = new DataTable();
            oDtMateriaisPedidoCompra = camadaNegocios.DataTableMateriaisPedidoCompra(codigoPedidoCompra);

            string codigoMaterial;
            string nomeMaterial;
            int quantidadeMaterial;


            for (int i = 0; i < oDtMateriaisPedidoCompra.Rows.Count; i++)
            {
                codigoMaterial = oDtMateriaisPedidoCompra.Rows[i]["Codigo"].ToString();
                nomeMaterial = oDtMateriaisPedidoCompra.Rows[i]["Nome"].ToString();
                quantidadeMaterial = int.Parse(oDtMateriaisPedidoCompra.Rows[i]["Quantidade"].ToString()) - int.Parse(oDtMateriaisPedidoCompra.Rows[i]["Quantidade_Recebida"].ToString());

                if (quantidadeMaterial > 0)
                {
                    //Formatando os dados para lstbox
                    while (codigoMaterial.Length < 6)
                        codigoMaterial = '0' + codigoMaterial;

                    while (nomeMaterial.Length < 20)
                        nomeMaterial = nomeMaterial + ' ';

                    lstboxMateriaisPedido.Items.Add(codigoMaterial + " - " + nomeMaterial + " - " + quantidadeMaterial.ToString());
                }
            }
        }

        private void btnUtilizarPedido_Click(object sender, EventArgs e)
        {
            if (cmbPedidoCompra.SelectedIndex != -1)
            {
                cmbPedidoCompra.Enabled = false;
                btnUtilizarPedido.Visible = false;

                btnIncluir.Visible = true;
                lblDataRecebimento.Visible = true;
                mskDataRecebimento.Visible = true;
                lblLegendaRecebimento.Visible = true;
                lstboxMateriaisRecebimento.Visible = true;
                btnMandaPedido.Visible = true;
                btnMandaRecebimento.Visible = true;

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
                Boolean statusAtualizarMaterialPedido = true;
                Boolean statusMaterialRecebimento = true;

                int codigoMaterial;
                int quantidadeMaterial;
                int codigoLocal = int.Parse(cmbLocal.SelectedValue.ToString());
                int codigoPedidoCompra = int.Parse(cmbPedidoCompra.SelectedValue.ToString());

                //Incluindo o recebimento - Se retornar 0, é porque deu erro
                int codigoRecebimento = camadaNegocios.InserirRecebimento(dataRecebimento, codigoPedidoCompra);

                if (codigoRecebimento != 0)
                {
                    if (lstboxMateriaisRecebimento.Items.Count > 0)
                    {
                        //Aumentando o estoque e atualiizando o pedido de compra
                        for (int index = (lstboxMateriaisRecebimento.Items.Count) - 1; index >= 0; index--)
                        {
                            var array = ((lstboxMateriaisRecebimento.Items[index]).ToString()).Split('-');

                            codigoMaterial = int.Parse(array[0]);
                            quantidadeMaterial = int.Parse(array[2]);

                            statusAtualizarEstoque = camadaNegocios.AumentaEstoque(codigoMaterial, codigoLocal, quantidadeMaterial);
                            statusAtualizarMaterialPedido = camadaNegocios.AlterarMateralPedido(codigoPedidoCompra, codigoMaterial, quantidadeMaterial);
                            statusMaterialRecebimento = camadaNegocios.InserirMaterialRecebimento(codigoMaterial, codigoRecebimento, quantidadeMaterial);

                            if (statusAtualizarEstoque == false || statusAtualizarMaterialPedido == false || statusMaterialRecebimento == false)
                                break;
                        }


                        if (statusAtualizarEstoque == true && statusAtualizarMaterialPedido == true && statusMaterialRecebimento == true)
                        {
                            Boolean statusAtualizarPedido = true;

                            //Caso todos os materiais sejam recebidos, então o pedido de compra muda o status para validado 
                            if (lstboxMateriaisPedido.Items.Count == 0)
                                statusAtualizarPedido = camadaNegocios.AtualizarPedidoCopmra(codigoPedidoCompra);

                            if (statusAtualizarPedido == true)
                            {
                                MessageBox.Show("Recebimento incluído com sucesso \n" +
                                                "Código: " + codigoRecebimento);

                                //Recarregando a página

                                Point posicaoForm = new Point(100, 100);
                                posicaoForm = this.Location;

                                Form formIncluiRecebimento = new IncluirRecebimento(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
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
                        MessageBox.Show("Receba pelo menos um material");
                }


                else
                    MessageBox.Show("Não foi possível incluir o recebimento");
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

        private void btnMandaRecebimento_Click(object sender, EventArgs e)
        {
            if (lstboxMateriaisPedido.SelectedIndex != -1)
            {
                Boolean encontrouMaterialListBox = false;
                string item;
                int indexMaterialRecebimento;
                int indexMaterialPedido = lstboxMateriaisPedido.SelectedIndex;

                item = lstboxMateriaisPedido.Items[indexMaterialPedido].ToString();
                var array = item.Split('-');

                string codigoMaterialPedido = array[0].Trim();
                string nomeMaterialPedido = array[1].Trim();
                int quantidadeMaterialPedido = int.Parse(array[2]);
                int quantidadeMaterialRecebimento = 0;

                if (quantidadeMaterialPedido != 0)
                {
                    //Verificando se o material já está na listbox
                    for (indexMaterialRecebimento = (lstboxMateriaisRecebimento.Items.Count) - 1; indexMaterialRecebimento >= 0; indexMaterialRecebimento--)
                    {
                        item = lstboxMateriaisRecebimento.Items[indexMaterialRecebimento].ToString();
                        array = item.Split('-');

                        if (int.Parse(codigoMaterialPedido) == int.Parse(array[0]))
                        {
                            quantidadeMaterialRecebimento = int.Parse(array[2]);
                            encontrouMaterialListBox = true;
                            break;
                        }
                    }

                    //Formatando os dados para lstbox
                    while (codigoMaterialPedido.Length < 6)
                        codigoMaterialPedido = '0' + codigoMaterialPedido;

                    while (nomeMaterialPedido.Length < 20)
                        nomeMaterialPedido = nomeMaterialPedido + ' ';

                    //Caso o material já esteja na listbox, apenas iremos aumentar em 1 a quantidade
                    if (encontrouMaterialListBox == true)
                    {
                        quantidadeMaterialRecebimento = quantidadeMaterialRecebimento + 1;

                        lstboxMateriaisRecebimento.Items[indexMaterialRecebimento] = codigoMaterialPedido + " - " + nomeMaterialPedido + " - " + quantidadeMaterialRecebimento.ToString();
                        RetiraMaterialPedido();
                    }

                    //Caso contrário, iremos adicionar o material na listbox com quantidade 1
                    else
                    {
                        lstboxMateriaisRecebimento.Items.Add(codigoMaterialPedido + " - " + nomeMaterialPedido + " - " + "1");
                        RetiraMaterialPedido();
                    }

                    void RetiraMaterialPedido()
                    {
                        quantidadeMaterialPedido = quantidadeMaterialPedido - 1;

                        lstboxMateriaisPedido.Items[lstboxMateriaisPedido.SelectedIndex] = codigoMaterialPedido + " - " + nomeMaterialPedido + " - " + quantidadeMaterialPedido.ToString();

                        if (quantidadeMaterialPedido == 0)
                            lstboxMateriaisPedido.Items.RemoveAt(indexMaterialPedido);
                    }
                }

            }
        }

        private void btnMandaPedido_Click(object sender, EventArgs e)
        {
            if (lstboxMateriaisRecebimento.SelectedIndex != -1)
            {
                Boolean encontrouMaterialListBox = false;
                string item;
                int indexMaterialRecebimento = lstboxMateriaisRecebimento.SelectedIndex;
                int indexMaterialPedido;

                item = lstboxMateriaisRecebimento.Items[indexMaterialRecebimento].ToString();
                var array = item.Split('-');

                string codigoMaterialRecebimento = array[0].Trim();
                string nomeMaterialRecebimento = array[1].Trim();
                int quantidadeMaterialRecebimento = int.Parse(array[2]);
                int quantidadeMaterialPedido = 0;


                //Verificando se o material já está na listbox
                for (indexMaterialPedido = (lstboxMateriaisPedido.Items.Count) - 1; indexMaterialPedido >= 0; indexMaterialPedido--)
                {
                    item = lstboxMateriaisPedido.Items[indexMaterialPedido].ToString();
                    array = item.Split('-');

                    if (int.Parse(codigoMaterialRecebimento) == int.Parse(array[0]))
                    {
                        quantidadeMaterialPedido = int.Parse(array[2]);
                        encontrouMaterialListBox = true;
                        break;
                    }
                }

                //Formatando os dados para lstbox
                while (codigoMaterialRecebimento.Length < 6)
                    codigoMaterialRecebimento = '0' + codigoMaterialRecebimento;

                while (nomeMaterialRecebimento.Length < 20)
                    nomeMaterialRecebimento = nomeMaterialRecebimento + ' ';

                //Caso o material já esteja na listbox, apenas iremos aumentar em 1 a quantidade
                if (encontrouMaterialListBox == true)
                {
                    quantidadeMaterialPedido = quantidadeMaterialPedido + 1;

                    lstboxMateriaisPedido.Items[indexMaterialPedido] = codigoMaterialRecebimento + " - " + nomeMaterialRecebimento + " - " + quantidadeMaterialPedido.ToString();
                    RetiraMaterialRecebimento();
                }

                //Caso contrário, iremos adicionar o material na listbox com quantidade 1
                else
                {
                    lstboxMateriaisPedido.Items.Add(codigoMaterialRecebimento + " - " + nomeMaterialRecebimento + " - " + "1");
                    RetiraMaterialRecebimento();
                }

                void RetiraMaterialRecebimento()
                {
                    quantidadeMaterialRecebimento = quantidadeMaterialRecebimento - 1;

                    if (quantidadeMaterialRecebimento == 0)
                        lstboxMateriaisRecebimento.Items.RemoveAt(indexMaterialRecebimento);
                    else
                        lstboxMateriaisRecebimento.Items[lstboxMateriaisRecebimento.SelectedIndex] = codigoMaterialRecebimento + " - " + nomeMaterialRecebimento + " - " + quantidadeMaterialRecebimento.ToString();
                }
            }
        }
    }
}
