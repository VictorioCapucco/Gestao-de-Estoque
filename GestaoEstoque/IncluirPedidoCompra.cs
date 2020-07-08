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
    public partial class IncluirPedidoCompra : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        Boolean xClicked = true;
        int permissaoUsuario;

        public IncluirPedidoCompra(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void IncluirPedidoCompra_Load(object sender, EventArgs e)
        {
            //Criando o DataTable dos Locais
            DataTable oDtLocais = new DataTable();
            oDtLocais.Clear();

            //Criando o DataTable dos Fornecedores
            DataTable oDtFornecedores = new DataTable();
            oDtFornecedores.Clear();
                                                                //filtraStatus, statusFornecedor
            oDtFornecedores = camadaNegocios.DataTableFornecedor(true, true);

            //statusLocal, isObra, statusObra
            oDtLocais = camadaNegocios.DataTableLocais(true, false, false);

            //Preenchendo a ComboBox dos Locais
            cmbLocal.DataSource = null;
            cmbLocal.DataSource = oDtLocais;
            cmbLocal.ValueMember = "id_local";
            cmbLocal.DisplayMember = "descricao_local";
            cmbLocal.SelectedItem = "";
            cmbLocal.Refresh();

            //Preenchendo a ComboBox dos Fornecedores
            cmbFornecedor.DataSource = null;
            cmbFornecedor.DataSource = oDtFornecedores;
            cmbFornecedor.ValueMember = "id_for";
            cmbFornecedor.DisplayMember = "nome_for";
            cmbFornecedor.SelectedItem = "";
            cmbFornecedor.Refresh();
        }

        private void txtCodigoMaterial_Click(object sender, EventArgs e)
        {
            if (txtCodigoMaterial.Text == "  F1 para consultar" && txtCodigoMaterial.ForeColor == Color.Gray)
            {
                txtCodigoMaterial.Text = "";
                txtCodigoMaterial.ForeColor = Color.Black;
            }
        }

        private void txtCodigoMaterial_Enter(object sender, EventArgs e)
        {
            if (txtCodigoMaterial.Text == "  F1 para consultar" && txtCodigoMaterial.ForeColor == Color.Gray)
            {
                txtCodigoMaterial.Text = "";
                txtCodigoMaterial.ForeColor = Color.Black;
            }
        }

        private void txtCodigoMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnAdicionarMaterial.PerformClick();
            }
        }

        private void txtCodigoMaterial_Leave(object sender, EventArgs e)
        {
            if (txtCodigoMaterial.Text == "")
            {
                txtCodigoMaterial.Text = "  F1 para consultar";
                txtCodigoMaterial.ForeColor = Color.Gray;
            }
        }

        private void btnAdicionarMaterial_Click(object sender, EventArgs e)
        {
            int codigoFornecedor = int.Parse(cmbFornecedor.SelectedValue.ToString());
            int codigoLocal = int.Parse(cmbLocal.SelectedValue.ToString());
            string strCodigoMaterial = txtCodigoMaterial.Text.ToString();

            //Fazendo a validação do texto
            Boolean statusCodigoMaterial = validar.Textos(strCodigoMaterial);
            if (statusCodigoMaterial == true)
            {
                //Verificando se é um número inteiro - Se retornar 0, é porque o código é inválido
                int codigoMaterial = validar.IsNumero(strCodigoMaterial);

                if (codigoMaterial != 0)
                {
                    //Verificando se o material existe - Se o nome do material retornar como vazio, então ele não existe
                    string nomeMaterial = camadaNegocios.ExisteMaterial(codigoMaterial);
                    if (nomeMaterial != "")
                    {
                        //Verificando se o material existe no local
                        Boolean existeMaterialLocal = camadaNegocios.ExisteMaterialLocal(codigoMaterial, codigoLocal);

                        if (existeMaterialLocal == true)
                        {
                            //Verificando se o fornecedor pode fornecer este material
                            Boolean statusFornecedorPodeFornecer = camadaNegocios.ExisteMaterialFornecedor(codigoFornecedor, codigoMaterial);

                            if (statusFornecedorPodeFornecer == true)
                            {
                                Boolean encontrouMaterialListBox = false;
                                string item;
                                int index;

                                //Verificando se o material já está na listbox
                                for (index = (lstboxMateriais.Items.Count) - 1; index >= 0; index--)
                                {
                                    item = lstboxMateriais.Items[index].ToString();
                                    var array = item.Split('-');

                                    if (codigoMaterial == int.Parse(array[0]))
                                    {
                                        encontrouMaterialListBox = true;
                                        break;
                                    }
                                }

                                string stringCodigoMaterial = codigoMaterial.ToString();

                                //Formatando os dados para lstbox
                                while (stringCodigoMaterial.Length < 6)
                                    stringCodigoMaterial = '0' + stringCodigoMaterial;

                                while (nomeMaterial.Length < 20)
                                    nomeMaterial = nomeMaterial + ' ';


                                //Caso o material já esteja na listbox, apenas iremos aumentar em 1 a quantidade
                                if (encontrouMaterialListBox == true)
                                {
                                    item = lstboxMateriais.Items[index].ToString();
                                    var array = item.Split('-');
                                    int quantidade = int.Parse(array[2]) + 1;

                                    lstboxMateriais.Items[index] = stringCodigoMaterial + " - " + nomeMaterial + " - " + quantidade.ToString();
                                }

                                //Caso contrário, iremos adicionar o material na listbox com quantidade 1
                                else
                                    lstboxMateriais.Items.Add(stringCodigoMaterial + " - " + nomeMaterial + " - " + "1");

                                txtCodigoMaterial.Text = "";
                                txtCodigoMaterial.Focus();

                            }

                            else
                                MessageBox.Show("Este fornecedor não tem permissão para fornecer este material");
                        }

                        else
                            MessageBox.Show("Material não existe neste local");
                    }
                   
                    else
                        MessageBox.Show("Material não existente");

                }

                else
                    MessageBox.Show("Código de material inválido");

            }

            else
                MessageBox.Show("Código de material inválido");
        }

        private void btnConfirmarFornecedorLocal_Click(object sender, EventArgs e)
        {
            if (cmbFornecedor.SelectedIndex != -1)
            {
                if (cmbLocal.SelectedIndex != -1)
                {
                    btnConfirmarFornecedorLocal.Visible = false;
                    cmbFornecedor.Enabled = false;
                    cmbLocal.Enabled = false;

                    gpbMateriais.Visible = true;
                    lblLegenda.Visible = true;
                    lstboxMateriais.Visible = true;
                    btnMais.Visible = true;
                    btnMenos.Visible = true;
                    btnLixeira.Visible = true;
                    btnIncluirPedidoCompra.Visible = true;

                    //Alterando a localização de alguns componentes
                    lblFornecedor.Location = new Point(lblFornecedor.Location.X, lblFornecedor.Location.Y + 20);
                    cmbFornecedor.Location = new Point(cmbFornecedor.Location.X, cmbFornecedor.Location.Y + 20);
                    cmbLocal.Location = new Point(cmbLocal.Location.X, cmbLocal.Location.Y + 20);
                    lblLocal.Location = new Point(lblLocal.Location.X, lblLocal.Location.Y + 20);
                    btnCancelar.Location = new Point(490, btnCancelar.Location.Y);
                }

                else
                    MessageBox.Show("Selecione um local");
            }

            else
                MessageBox.Show("Selecione um fornecedor");
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (lstboxMateriais.SelectedIndex != -1)
            {
                string item;
                int index = int.Parse(lstboxMateriais.SelectedIndex.ToString());

                item = lstboxMateriais.Items[index].ToString();
                var array = item.Split('-');
                int quantidade = int.Parse(array[2]) + 1;

                lstboxMateriais.Items[index] = array[0] + "-" + array[1] + "- " + quantidade.ToString();
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (lstboxMateriais.SelectedIndex != -1)
            {
                string item;
                int index = int.Parse(lstboxMateriais.SelectedIndex.ToString());

                item = lstboxMateriais.Items[index].ToString();
                var array = item.Split('-');
                int quantidade = int.Parse(array[2]);

                //Caso seja o último, irá excluir o material da lsxbox
                if (quantidade == 1)
                    lstboxMateriais.Items.RemoveAt(index);

                //Caso contrário, retira um da quantidade
                else
                {
                    quantidade = quantidade - 1;
                    lstboxMateriais.Items[index] = array[0] + "-" + array[1] + "- " + quantidade.ToString();
                }
            }
        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (lstboxMateriais.SelectedIndex != -1)
            {
                lstboxMateriais.Items.RemoveAt(lstboxMateriais.SelectedIndex);
            }
        }

        private void btnIncluirPedidoCompra_Click(object sender, EventArgs e)
        {
            int codigoLocal = int.Parse(cmbLocal.SelectedValue.ToString());
            int codigoFornecedor = int.Parse(cmbFornecedor.SelectedValue.ToString());

            //Verificando se a lstbox está vazia
            if (lstboxMateriais.Items.Count > 0)
            {
                int codigoMaterial;
                int quantidadeMaterial;
                Boolean statusInsercaoMaterial = true;

                //Criando a requisição e obtendo o código da mesma - Caso retorne 0, indica que não foi possível criar a requisição
                int codigoPedidoCompra = camadaNegocios.InserirPedidoCompra(codigoFornecedor, codigoLocal);

                if (codigoPedidoCompra != 0)
                {
                    //Inserindo todos os materiais, um a um
                    for (int index = (lstboxMateriais.Items.Count) - 1; index >= 0; index--)
                    {
                        var array = ((lstboxMateriais.Items[index]).ToString()).Split('-');

                        codigoMaterial = int.Parse(array[0]);
                        quantidadeMaterial = int.Parse(array[2]);

                        statusInsercaoMaterial = camadaNegocios.InserirMateriaisPedidoCompra(codigoPedidoCompra, codigoMaterial, quantidadeMaterial);
                        if (statusInsercaoMaterial == false)
                        {
                            MessageBox.Show("Erro inesperado ao inserir a transferencia. Contate o suporte");
                            break;
                        }
                    }

                    if (statusInsercaoMaterial == true)
                    {
                        MessageBox.Show("Pedido de compra inserido com sucesso. \n\n" +
                                        "Codigo do pedido de compra: " + codigoPedidoCompra);

                        //Recarregando a página para atualizar as ComboBox
                        Point posicaoForm = new Point(100, 100);
                        posicaoForm = this.Location;

                        Form formIncluirPedidoCompra = new IncluirPedidoCompra(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
                        xClicked = false;
                        this.Close();
                        formIncluirPedidoCompra.Show();
                    }

                    else
                        MessageBox.Show("Erro ao inserir os materiais do pedido de compra");
                }

                else
                    MessageBox.Show("Não foi possível criar o pedido de compra");
            }

            else
                MessageBox.Show("Adicione pelo menos um material");
        }

        private void IncluirPedidoCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
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



        private void toolStripVoltar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();

            formAnterior.Location = this.Location;
            formAnterior.Show();
        }
    }
}


