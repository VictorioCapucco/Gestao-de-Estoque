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
    public partial class IncluirTransferenciaEntrada : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        private Boolean xClicked = true;
        int codigoObra;
        int permissaoUsuario;

        public IncluirTransferenciaEntrada(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void IncluirTransferenciaEntrada_Load(object sender, EventArgs e)
        {
            //Criando o DataTable dos tipos de transferência
            DataTable oDtTipoTransferencia = new DataTable();
            oDtTipoTransferencia.Clear();
                                                                            //statusTipoSaida, saida
            oDtTipoTransferencia = camadaNegocios.DataTableTipoTransferencia(true, false);

            //Preenchendo a ComboBox dos tipos de transferencia
            cmbTipoTransferencia.DataSource = null;
            cmbTipoTransferencia.DataSource = oDtTipoTransferencia;
            cmbTipoTransferencia.ValueMember = "id_tipo_transferencia";
            cmbTipoTransferencia.DisplayMember = "descricao_tipo_transferencia";
            cmbTipoTransferencia.SelectedItem = "";
            cmbTipoTransferencia.Refresh();
        }

        private void btnConfirmarTipoTransferencia_Click(object sender, EventArgs e)
        {
            if (cmbTipoTransferencia.SelectedIndex != -1)
            {
                //Criando o DataTable
                DataTable oDtObraOrigem = new DataTable();
                oDtObraOrigem.Clear();

                                                              //filtraLocal, statusLocal, isObra, statusObra, codigoLocal
                oDtObraOrigem = camadaNegocios.DataTableLocais(false, true, true, true, 0);

                //Preenchendo a ComboBox
                cmbObraOrigem.DataSource = null;
                cmbObraOrigem.DataSource = oDtObraOrigem;
                cmbObraOrigem.ValueMember = "id_local";
                cmbObraOrigem.DisplayMember = "descricao_local";
                cmbObraOrigem.SelectedItem = "";
                cmbObraOrigem.Refresh();

                btnConfirmarTipoTransferencia.Visible = false;
                cmbTipoTransferencia.Enabled = false;

                lblObraOrigem.Visible = true;
                cmbObraOrigem.Visible = true;
                btnConfirmarObraOrigem.Visible = true;
            }

            else
                MessageBox.Show("Selecione um tipo de transferência");
        }

        private void btnConfirmarObraOrigem_Click(object sender, EventArgs e)
        {
            if (cmbObraOrigem.SelectedIndex != -1)
            {
                //Criando o DataTable
                DataTable oDtLocalDestino = new DataTable();
                oDtLocalDestino.Clear();

                                                             //filtraLocal, statusLocal, isObra, statusObra, codigoLocal
                oDtLocalDestino = camadaNegocios.DataTableLocais(false, true, false, false, 0);

                //Preenchendo a ComboBox
                cmbLocalDestino.DataSource = null;
                cmbLocalDestino.DataSource = oDtLocalDestino;
                cmbLocalDestino.ValueMember = "id_local";
                cmbLocalDestino.DisplayMember = "descricao_local";
                cmbLocalDestino.SelectedItem = "";
                cmbLocalDestino.Refresh();

                btnConfirmarObraOrigem.Visible = false;
                cmbObraOrigem.Enabled = false;

                btnConfirmarLocalDestino.Visible = true;
                lblLocalDestino.Visible = true;
                cmbLocalDestino.Visible = true;
            }

            else
                MessageBox.Show("Selecione uma obra origem");
        }

        private void btnConfirmarLocalDestino_Click(object sender, EventArgs e)
        {
            if (cmbLocalDestino.SelectedIndex != -1)
            {
                btnConfirmarLocalDestino.Visible = false;
                cmbLocalDestino.Enabled = false;

                mskDataTransferencia.Visible = true;
                lblDataTransferencia.Visible = true;
                lblMateriaisLocalDestino.Visible = true;
                lblMateriaisObraOrigem.Visible = true;
                lstboxMateriaisDestino.Visible = true;
                lstboxMateriaisObra.Visible = true;
                btnIncluirTransferência.Visible = true;
                btnMandaParaDestino.Visible = true;
                btnMandaParaObra.Visible = true;

                //Ajustando a localização do botão cancelar
                btnCancelar.Location = new Point(468, btnCancelar.Location.Y);

                lblMateriaisObraOrigem.Text = cmbObraOrigem.Text.ToString();
                lblMateriaisLocalDestino.Text = cmbLocalDestino.Text.ToString();

                //Atualizando a lstbox dos materiais da obra
                int codigoObraOrigem = int.Parse(cmbObraOrigem.SelectedValue.ToString());

                DataTable oDtMateriaisObra = new DataTable();
                oDtMateriaisObra = camadaNegocios.DataTableMateriaisTransferencia(codigoObraOrigem);

                string codigoMaterialObra;
                string nomeMaterialObra;
                string quantidadeMaterialObra;

                //Guardando o codigo da obra
                int codigoTransferencia = int.Parse(oDtMateriaisObra.Rows[0]["CodigoTransferencia"].ToString());
                codigoObra = codigoTransferencia;


               for (int i = 0; i < oDtMateriaisObra.Rows.Count; i++)
                {
                    codigoMaterialObra = oDtMateriaisObra.Rows[i]["Codigo"].ToString();
                    nomeMaterialObra = oDtMateriaisObra.Rows[i]["Nome"].ToString();
                    quantidadeMaterialObra = oDtMateriaisObra.Rows[i]["Quantidade"].ToString();

                    //Formatando os dados para lstbox
                    while (codigoMaterialObra.Length < 6)
                        codigoMaterialObra = '0' + codigoMaterialObra;

                    while (nomeMaterialObra.Length < 20)
                        nomeMaterialObra = nomeMaterialObra + ' ';

                    lstboxMateriaisObra.Items.Add(codigoMaterialObra + " - " + nomeMaterialObra + " - " + quantidadeMaterialObra);
                }
            }

            else
                MessageBox.Show("Selecione um local destino");
        }

        private void btnMandaParaDestino_Click(object sender, EventArgs e)
        {
            if (lstboxMateriaisObra.SelectedIndex != -1)
            {
                Boolean encontrouMaterialListBox = false;
                string item;
                int indexMaterialDestino;
                int indexMaterialObra = lstboxMateriaisObra.SelectedIndex;

                item = lstboxMateriaisObra.Items[indexMaterialObra].ToString();
                var array = item.Split('-');

                string codigoMaterialObra = array[0].Trim();
                string nomeMaterialObra = array[1].Trim();
                int quantidadeMaterialObra = int.Parse(array[2]);
                int quantidadeMaterialDestino = 0;

                if (quantidadeMaterialObra != 0)
                {
                    //Verificando se o material já está na listbox
                    for (indexMaterialDestino = (lstboxMateriaisDestino.Items.Count) - 1; indexMaterialDestino >= 0; indexMaterialDestino--)
                    {
                        item = lstboxMateriaisDestino.Items[indexMaterialDestino].ToString();
                        array = item.Split('-');

                        if (int.Parse(codigoMaterialObra) == int.Parse(array[0]))
                        {
                            quantidadeMaterialDestino = int.Parse(array[2]);
                            encontrouMaterialListBox = true;
                            break;
                        }
                    }

                    //Formatando os dados para lstbox
                    while (codigoMaterialObra.Length < 6)
                        codigoMaterialObra = '0' + codigoMaterialObra;

                    while (nomeMaterialObra.Length < 20)
                        nomeMaterialObra = nomeMaterialObra + ' ';

                    //Caso o material já esteja na listbox, apenas iremos aumentar em 1 a quantidade
                    if (encontrouMaterialListBox == true)
                    {
                        quantidadeMaterialDestino = quantidadeMaterialDestino + 1;

                        lstboxMateriaisDestino.Items[indexMaterialDestino] = codigoMaterialObra + " - " + nomeMaterialObra + " - " + quantidadeMaterialDestino.ToString();
                        RetiraMaterialObra();
                    }

                    //Caso contrário, iremos adicionar o material na listbox com quantidade 1
                    else
                    {
                        //Verificando se o material existe no local destino
                        Boolean statusExisteMaterialLocal = camadaNegocios.ExisteMaterialLocal(int.Parse(codigoMaterialObra), int.Parse(cmbLocalDestino.SelectedValue.ToString()));

                        if (statusExisteMaterialLocal == true)
                        {
                            lstboxMateriaisDestino.Items.Add(codigoMaterialObra + " - " + nomeMaterialObra + " - " + "1");
                            RetiraMaterialObra();
                        }

                        else
                            MessageBox.Show("Este material não está cadastrado no local destino");
                    }

                    void RetiraMaterialObra()
                    {
                        quantidadeMaterialObra = quantidadeMaterialObra - 1;

                        lstboxMateriaisObra.Items[lstboxMateriaisObra.SelectedIndex] = codigoMaterialObra + " - " + nomeMaterialObra + " - " + quantidadeMaterialObra.ToString();
                    }
                }
                
            }
        }

        private void btnMandaParaObra_Click(object sender, EventArgs e)
        {
            if (lstboxMateriaisDestino.SelectedIndex != -1)
            {
                Boolean encontrouMaterialListBox = false;
                string item;
                int indexMaterialDestino = lstboxMateriaisDestino.SelectedIndex;
                int indexMaterialObra;

                item = lstboxMateriaisDestino.Items[indexMaterialDestino].ToString();
                var array = item.Split('-');

                string codigoMaterialDestino = array[0].Trim();
                string nomeMaterialDestino = array[1].Trim();
                int quantidadeMaterialDestino = int.Parse(array[2]);
                int quantidadeMaterialObra = 0;


                //Verificando se o material já está na listbox
                for (indexMaterialObra = (lstboxMateriaisObra.Items.Count) - 1; indexMaterialObra >= 0; indexMaterialObra--)
                {
                    item = lstboxMateriaisObra.Items[indexMaterialObra].ToString();
                    array = item.Split('-');

                    if (int.Parse(codigoMaterialDestino) == int.Parse(array[0]))
                    {
                        quantidadeMaterialObra = int.Parse(array[2]);
                        encontrouMaterialListBox = true;
                        break;
                    }
                }

                //Formatando os dados para lstbox
                while (codigoMaterialDestino.Length < 6)
                    codigoMaterialDestino = '0' + codigoMaterialDestino;

                while (nomeMaterialDestino.Length < 20)
                    nomeMaterialDestino = nomeMaterialDestino + ' ';

                //Caso o material já esteja na listbox, apenas iremos aumentar em 1 a quantidade
                if (encontrouMaterialListBox == true)
                {
                    quantidadeMaterialObra = quantidadeMaterialObra + 1;

                    lstboxMateriaisObra.Items[indexMaterialObra] = codigoMaterialDestino + " - " + nomeMaterialDestino + " - " + quantidadeMaterialObra.ToString();
                    RetiraMaterialDestino();
                }

                //Caso contrário, iremos adicionar o material na listbox com quantidade 1
                else
                {   
                    lstboxMateriaisObra.Items.Add(codigoMaterialDestino + " - " + nomeMaterialDestino + " - " + "1");
                    RetiraMaterialDestino();
                }

                void RetiraMaterialDestino()
                {
                    quantidadeMaterialDestino = quantidadeMaterialDestino - 1;

                    if (quantidadeMaterialDestino == 0)
                        lstboxMateriaisDestino.Items.RemoveAt(indexMaterialDestino);
                    else
                        lstboxMateriaisDestino.Items[lstboxMateriaisDestino.SelectedIndex] = codigoMaterialDestino + " - " + nomeMaterialDestino + " - " + quantidadeMaterialDestino.ToString();
                }
            }
        }

        private void btnIncluirTransferência_Click(object sender, EventArgs e)
        {
            if (lstboxMateriaisDestino.Items.Count > 0)
            {
                int codigoObraOrigem = codigoObra;
                int codigoLocalOrigem = int.Parse(cmbObraOrigem.SelectedValue.ToString());
                string dataTransferencia = mskDataTransferencia.Text.ToString();
                Boolean statusDataTransferencia = validar.Data(dataTransferencia);

                if (statusDataTransferencia == true)
                {
                    //Obtendo a data da obra - Caso retorne "0", é que ocorreu algum erro no processo
                    string dataObra = camadaNegocios.ConsultaDataTransferencia(codigoObraOrigem);

                    if (dataObra != "0")
                    {
                        //Formatando a data - Caso retorne "0", é que ocorreu algum erro no processo
                        dataObra = validar.AjustarData(dataObra);

                        if (dataObra != "0")
                        {
                            //Comparando a data da Obra com a data da transferência
                                                                                  //dataMenor, dataMaior
                            Boolean statusComparaData = validar.DataMenorDataMaior(dataObra, dataTransferencia);

                            if (statusComparaData == true)
                            {
                                Boolean statusAtualizacaoObra = true;
                                int codigoMaterialObra;
                                int quantidadeMaterialObra;

                                //Atualizando os materiais da obra
                                for (int i = (lstboxMateriaisObra.Items.Count) - 1; i >= 0; i--)
                                {
                                    var array = ((lstboxMateriaisObra.Items[i]).ToString()).Split('-');

                                    codigoMaterialObra = int.Parse(array[0]);
                                    quantidadeMaterialObra = int.Parse(array[2]);

                                    statusAtualizacaoObra = camadaNegocios.AlteraMateriaisTransferencia(codigoMaterialObra, codigoObra, quantidadeMaterialObra);
                                    if (statusAtualizacaoObra == false)
                                        break;
                                }

                                if (statusAtualizacaoObra == true)
                                {
                                    //Incluindo uma nova transferência, tendo como origem a obra, e como destino o local

                                    int codigoMaterialDestino;
                                    int quantidadeMaterialDestino;

                                    int codigoLocalObra = int.Parse(cmbObraOrigem.SelectedValue.ToString());
                                    int codigoLocalDestino = int.Parse(cmbLocalDestino.SelectedValue.ToString());
                                    int codigoTipoTransferencia = int.Parse(cmbTipoTransferencia.SelectedValue.ToString());

                                    Boolean statusInsercaoMaterial = true;

                                    //Criando a requisição e obtendo o código da mesma - Caso retorne 0, indica que não foi possível criar a requisição
                                    int codigoTransferecia = camadaNegocios.InserirTransferencia(codigoLocalObra, codigoLocalDestino, codigoTipoTransferencia, dataTransferencia);

                                    if (codigoTransferecia != 0)
                                    {
                                        //Inserindo todos os materiais, um a um
                                        for (int index = (lstboxMateriaisDestino.Items.Count) - 1; index >= 0; index--)
                                        {
                                            var array = ((lstboxMateriaisDestino.Items[index]).ToString()).Split('-');

                                            codigoMaterialDestino = int.Parse(array[0]);
                                            quantidadeMaterialDestino = int.Parse(array[2]);

                                            statusInsercaoMaterial = camadaNegocios.InserirMateriaisTransferenciaSaida(codigoTransferecia, codigoMaterialDestino, quantidadeMaterialDestino);
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

                                            //Diminuindo o estoque da obra de origem
                                            for (int i = 0; i < tamanhoDataSet; i++)
                                            {
                                                statusAtualizarEstoque = camadaNegocios.DiminuiEstoque(codigoMateriais[i], codigoLocalOrigem, codigoQuantidades[i]);
                                                if (statusAtualizarEstoque == false)
                                                    break;
                                            }

                                            if (statusAtualizarEstoque == true)
                                            {
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

                                                //Aumentando o estoque do local destino
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

                                                    Form formIncluirRequisicaoSaida = new IncluirTransferenciaSaida(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
                                                    xClicked = false;
                                                    this.Close();
                                                    formIncluirRequisicaoSaida.Show();
                                                }

                                                else
                                                    MessageBox.Show("Erro ao incluir a transferência");
                                            }

                                            else
                                                MessageBox.Show("Erro ao incluir a transferência");
                                        }
                                    }

                                    else
                                        MessageBox.Show("Não foi possível criar a transferência");
                                }

                                else
                                    MessageBox.Show("Não foi possível atualizar os materiais da obra. Contate o suporte");
                            }

                            else
                                MessageBox.Show("A data de transferência não pode ser menor do que a data da obra");
                        }

                        else
                            MessageBox.Show("Erro ao converter a data da obra");
                    }

                    else
                        MessageBox.Show("Erro ao consultar a data da obra");

                }

                else
                    MessageBox.Show("Data de transferência inválida");
            }

            else
                MessageBox.Show("Transfira pelo menos um material para o local destino");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();

            formAnterior.Location = this.Location;
            formAnterior.Show();
        }

        private void IncluirTransferenciaEntrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
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
