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
    public partial class IncluirTransferenciaSaida : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        private Boolean xClicked = true;
        int permissaoUsuario;

        public IncluirTransferenciaSaida(Form anterior, int x, int y, int permisssao)
        {
            permissaoUsuario = permisssao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void txtCodigoMaterial_Click(object sender, EventArgs e)
        {
            if (txtCodigoMaterial.Text == "  F1 para consultar" && txtCodigoMaterial.ForeColor == Color.Gray)
            {
                txtCodigoMaterial.Text = "";
                txtCodigoMaterial.ForeColor = Color.Black;
            }
        }

        private void IncluirRequisicaoSaida_Load(object sender, EventArgs e)
        {
            //Criando o DataTable dos tipos de transferência
            DataTable oDtTipoTransferencia = new DataTable();
            oDtTipoTransferencia.Clear();
                                                                        //statusTipoSaida, saida
            oDtTipoTransferencia = camadaNegocios.DataTableTipoTransferencia(true, true);

            //Preenchendo a ComboBox dos tipos de transferencia
            cmbTipoTransferencia.DataSource = null;
            cmbTipoTransferencia.DataSource = oDtTipoTransferencia;
            cmbTipoTransferencia.ValueMember = "id_tipo_transferencia";
            cmbTipoTransferencia.DisplayMember = "descricao_tipo_transferencia";
            cmbTipoTransferencia.SelectedItem = "";
            cmbTipoTransferencia.Refresh();
        }

        private void btnAdicionarMaterial_Click(object sender, EventArgs e)
        {
            int codigoLocalOrigem = int.Parse(cmbLocalOrigem.SelectedValue.ToString());
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
                        Boolean existeMaterialLocal = camadaNegocios.ExisteMaterialLocal(codigoMaterial, codigoLocalOrigem);

                        if (existeMaterialLocal == true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();

            formAnterior.Location = this.Location;
            formAnterior.Show();
        }

        private void IncluirRequisicaoSaida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }

        private void btnIncluirRequisicaoSaida_Click(object sender, EventArgs e)
        {
            int codigoLocalOrigem = int.Parse(cmbLocalOrigem.SelectedValue.ToString());
            int codigoLocalDestino = int.Parse(cmbLocalDestino.SelectedValue.ToString());

            if (cmbTipoTransferencia.SelectedIndex != -1)
            {
                int codigoTipoTransferencia = int.Parse(cmbTipoTransferencia.SelectedValue.ToString());

                //Verificando se a lstbox está vazia
                if (lstboxMateriais.Items.Count > 0)
                {
                    string dataSaida = mskDataTransferencia.Text.ToString();

                    Boolean statusData = validar.Data(dataSaida);

                    if (statusData == true)
                    {
                        int codigoMaterial;
                        int quantidadeMaterial;
                        Boolean statusInsercaoMaterial = true;

                        //Criando a requisição e obtendo o código da mesma - Caso retorne 0, indica que não foi possível criar a requisição
                        int codigoTransferecia = camadaNegocios.InserirTransferencia(codigoLocalOrigem, codigoLocalDestino, codigoTipoTransferencia, dataSaida);

                        if (codigoTransferecia != 0)
                        {
                            //Inserindo todos os materiais, um a um
                            for (int index = (lstboxMateriais.Items.Count) - 1; index >= 0; index--)
                            {
                                var array = ((lstboxMateriais.Items[index]).ToString()).Split('-');

                                codigoMaterial = int.Parse(array[0]);
                                quantidadeMaterial = int.Parse(array[2]);

                                statusInsercaoMaterial = camadaNegocios.InserirMateriaisTransferenciaSaida(codigoTransferecia, codigoMaterial, quantidadeMaterial);
                                if (statusInsercaoMaterial == false)
                                {
                                    MessageBox.Show("Erro inesperado ao inserir a transferencia. Contate o suporte");
                                    break;
                                }
                            }

                            if (statusInsercaoMaterial == true)
                            {
                                //Retirando do estoque
                                DataSet oDsMateriais = new DataSet();

                                oDsMateriais = camadaNegocios.ConsultaCodigoMateriaisTransferencia(codigoTransferecia);

                                int tamanhoDataSet = 0;

                                //Obtendo o tamanho do dataset para alocar o vetor
                                foreach (DataRow rows in oDsMateriais.Tables[0].Rows)
                                {
                                    tamanhoDataSet++;
                                }

                                //Vetores onde ficarão os ids de material e a quantidade
                                int[] codigoMateriais = new int[tamanhoDataSet + 1];
                                int[] codigoQuantidades = new int[tamanhoDataSet + 1];

                                int contador = 0;
                                foreach (DataRow rows in oDsMateriais.Tables[0].Rows)
                                {
                                    codigoMateriais[contador] = int.Parse((rows["Material"]).ToString());
                                    codigoQuantidades[contador] = int.Parse((rows["Quantidade"]).ToString());
                                    contador++;
                                }

                                Boolean statusAtualizarEstoque = true;

                                //Diminuindo o estoque do local de origem
                                for (int i = 0; i < tamanhoDataSet; i++)
                                {
                                    statusAtualizarEstoque = camadaNegocios.DiminuiEstoque(codigoMateriais[i], codigoLocalOrigem, codigoQuantidades[i]);
                                    if (statusAtualizarEstoque == false)
                                        break;
                                }

                                if (statusAtualizarEstoque == true)
                                {
                                    if (int.Parse(cmbTipoTransferencia.SelectedValue.ToString()) == 1)
                                    {
                                        //Caso a transferência seja de um local para uma obra, é necessário levar o estoque para esta obra                                        

                                        DataSet oDsMateriaisDestino = new DataSet();

                                        oDsMateriaisDestino = camadaNegocios.ConsultaCodigoMateriaisTransferencia(codigoTransferecia);

                                        int tamanhoDataSetDestino = 0;

                                        //Obtendo o tamanho do dataset para alocar o vetor
                                        foreach (DataRow rows in oDsMateriaisDestino.Tables[0].Rows)
                                        {
                                            tamanhoDataSetDestino++;
                                        }

                                        //Vetores onde ficarão os ids de material e a quantidade
                                        int[] codigoMateriaisDestino = new int[tamanhoDataSetDestino + 1];
                                        int[] codigoQuantidadesDestino = new int[tamanhoDataSetDestino + 1];

                                        int contadorDestino = 0;
                                        foreach (DataRow rows in oDsMateriaisDestino.Tables[0].Rows)
                                        {
                                            codigoMateriaisDestino[contadorDestino] = int.Parse((rows["Material"]).ToString());
                                            codigoQuantidadesDestino[contadorDestino] = int.Parse((rows["Quantidade"]).ToString());
                                            contadorDestino++;
                                        }

                                        Boolean statusAtualizarEstoqueDestino = true;

                                        //Aumentando o estoque do local de origem
                                        for (int i = 0; i < tamanhoDataSetDestino; i++)
                                        {
                                            statusAtualizarEstoque = camadaNegocios.AumentaEstoque(codigoMateriaisDestino[i], codigoLocalDestino, codigoQuantidadesDestino[i]);
                                            if (statusAtualizarEstoqueDestino == false)
                                                break;
                                        }


                                        if (statusAtualizarEstoqueDestino == true)
                                        {
                                            Boolean statusValidarObra = camadaNegocios.ValidarObra(codigoLocalDestino);

                                            if (statusValidarObra == true)
                                                MessageBox.Show("Transferência incluída com sucesso");
                                            else
                                                MessageBox.Show("Transferência incluída com sucesso. No entanto, não foi possível atualizar o status da obra");

                                            //Recarregando a página
                                            Point posicaoForm = new Point(100, 100);
                                            posicaoForm = this.Location;

                                            Form formIncluirTransferenciaSaida = new IncluirTransferenciaSaida(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
                                            xClicked = false;
                                            this.Close();
                                            formIncluirTransferenciaSaida.Show();
                                        }

                                        else
                                            MessageBox.Show("Erro ao incluir a transferência");

                                    }

                                    else
                                    {
                                        MessageBox.Show("Transferência incluída com sucesso");

                                        //Recarregando a página
                                        Point posicaoForm = new Point(100, 100);
                                        posicaoForm = this.Location;

                                        Form formIncluirRequisicaoSaida = new IncluirTransferenciaSaida(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
                                        xClicked = false;
                                        this.Close();
                                        formIncluirRequisicaoSaida.Show();
                                    }
                                }

                                else
                                    MessageBox.Show("Erro ao incluir a transferência");

                            }
                        }

                        else
                            MessageBox.Show("Não foi possível criar a transferência");
                    }

                    else
                        MessageBox.Show("Data de saída inválida");
                }

                    else
                        MessageBox.Show("Insira pelo menos um material");
            }

            else
                MessageBox.Show("Informe o tipo de saída");

  

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


        private void txtCodigoMaterial_Leave(object sender, EventArgs e)
        {
            if (txtCodigoMaterial.Text == "")
            {
                txtCodigoMaterial.Text = "  F1 para consultar";
                txtCodigoMaterial.ForeColor = Color.Gray;
            }
        }

        private void btnConfirmarTipoTransferencia_Click(object sender, EventArgs e)
        {
            if (cmbTipoTransferencia.SelectedIndex != -1)
            {

                //Criando o DataTable
                DataTable oDtLocalOrigem = new DataTable();
                oDtLocalOrigem.Clear();

                                                                //statusLocal, isObra, statusObra
                oDtLocalOrigem = camadaNegocios.DataTableLocais(true, false, false);

                //Preenchendo a ComboBox
                cmbLocalOrigem.DataSource = null;
                cmbLocalOrigem.DataSource = oDtLocalOrigem;
                cmbLocalOrigem.ValueMember = "id_local";
                cmbLocalOrigem.DisplayMember = "descricao_local";
                cmbLocalOrigem.SelectedItem = "";
                cmbLocalOrigem.Refresh();

                btnConfirmarTipoTransferencia.Visible = false;
                cmbTipoTransferencia.Enabled = false;

                lblLocalOrigem.Visible = true;
                cmbLocalOrigem.Visible = true;
                btnConfirmarLocalOrigem.Visible = true;
            }

            else
                MessageBox.Show("Selecione um tipo de transferência");
        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {

        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmarLocalOrigem_Click(object sender, EventArgs e)
        {
            if (cmbLocalOrigem.SelectedIndex != -1)
            {
                if (int.Parse(cmbTipoTransferencia.SelectedValue.ToString()) == 1)
                {
                    //Criando o DataTable
                    DataTable oDtLocalDestino = new DataTable();
                    oDtLocalDestino.Clear();

                                                                    //statusLocal, isObra, statusObra
                    oDtLocalDestino = camadaNegocios.DataTableLocais(true, true, false);

                    //Preenchendo a ComboBox
                    cmbLocalDestino.DataSource = null;
                    cmbLocalDestino.DataSource = oDtLocalDestino;
                    cmbLocalDestino.ValueMember = "id_local";
                    cmbLocalDestino.DisplayMember = "descricao_local";
                    cmbLocalDestino.SelectedItem = "";
                    cmbLocalDestino.Refresh();

                    btnConfirmarLocalOrigem.Visible = false;
                    cmbLocalOrigem.Enabled = false;

                    btnConfirmarLocalDestino.Visible = true;
                    lblLocalDestino.Visible = true;
                    cmbLocalDestino.Visible = true;
                }

                else
                {
                    btnConfirmarLocalOrigem.Visible = false;
                    cmbLocalOrigem.Enabled = false;
                    cmbLocalDestino.Enabled = false;

                    lblLocalDestino.Visible = true;
                    cmbLocalDestino.Visible = true;
                    lblDataTransferencia.Visible = true;
                    mskDataTransferencia.Visible = true;

                    btnConfirmarLocalOrigem.Visible = false;
                    cmbLocalOrigem.Enabled = false;

                    lblDataTransferencia.Visible = true;
                    mskDataTransferencia.Visible = true;
                    lblTipoTransferencia.Visible = true;
                    lblLegenda.Visible = true;
                    cmbTipoTransferencia.Visible = true;
                    lstboxMateriais.Visible = true;
                    btnMais.Visible = true;
                    btnMenos.Visible = true;
                    btnLixeira.Visible = true;
                    btnAdicionarMaterial.Visible = true;
                    btnIncluirTransferência.Visible = true;
                    btnCancelar.Visible = true;
                    gpbMateriais.Visible = true;

                    btnCancelar.Location = new Point(478, btnCancelar.Location.Y);
                }
            }

            else
                MessageBox.Show("Selecione um local de origem");
        }

        private void btnConfirmarLocalDestino_Click(object sender, EventArgs e)
        {
            if (cmbLocalDestino.SelectedIndex != -1)
            {
                btnConfirmarLocalDestino.Visible = false;
                cmbLocalDestino.Enabled = false;

                lblDataTransferencia.Visible = true;
                mskDataTransferencia.Visible = true;
                lblTipoTransferencia.Visible = true;
                lblLegenda.Visible = true;
                cmbTipoTransferencia.Visible = true;
                lstboxMateriais.Visible = true;
                btnMais.Visible = true;
                btnMenos.Visible = true;
                btnLixeira.Visible = true;
                btnAdicionarMaterial.Visible = true;
                btnIncluirTransferência.Visible = true;
                btnCancelar.Visible = true;
                gpbMateriais.Visible = true;

                btnCancelar.Location = new Point(486, btnCancelar.Location.Y);
            }

            else
                MessageBox.Show("Selecione um local destino");
        }

        private void txtCodigoMaterial_Enter(object sender, EventArgs e)
        {
            if (txtCodigoMaterial.Text == "  F1 para consultar" && txtCodigoMaterial.ForeColor == Color.Gray)
            {
                txtCodigoMaterial.Text = "";
                txtCodigoMaterial.ForeColor = Color.Black;
            }
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
