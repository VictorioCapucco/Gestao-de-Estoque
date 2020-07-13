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
    public partial class ConsultarFornecedor : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        DataTable oDtFornecedor = new DataTable();
        Form formAnterior;
        private Boolean xClicked = true;
        int permissaoUsuario;

        public ConsultarFornecedor(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void ConsultarFornecedor_Load(object sender, EventArgs e)
        {
            //Criando o DataTable

            oDtFornecedor.Clear();

                                                               //filtroStatus, statusFornecedor
            oDtFornecedor = camadaNegocios.DataTableFornecedor(false, false);

            //Preenchendo a ComboBox
            cmbNome.DataSource = null;
            cmbNome.DataSource = oDtFornecedor;
            cmbNome.ValueMember = "id_for";
            cmbNome.DisplayMember = "nome_for";
            cmbNome.SelectedItem = "";
            cmbNome.Refresh();
        }

        private void btnConfirmarFornecedor_Click(object sender, EventArgs e)
        {
            if (cmbNome.SelectedIndex != -1)
            {
                btnConfirmarFornecedor.Visible = false;
                cmbNome.Enabled = false;

                lblCnpj.Visible = true;
                txtCnpj.Visible = true;
                lblEndereco.Visible = true;
                txtEndereco.Visible = true;
                lblTelefone.Visible = true;
                txtTelefone.Visible = true;
                gpbIncluirMaterial.Visible = true;
                lblLegendaAdicionar.Visible = true;
                lblLegendaIncluso.Visible = true;
                lstboxMateriaisAdicionar.Visible = true;
                lstboxMateriaisInclusos.Visible = true;
                panelStatus.Visible = true;
                gpbMateriais.Visible = true;
                btnLixeira.Visible = true;
                btnAlterar.Visible = true;
                btnCancelar.Location = new Point(504, 430);

                int codigoFornecedor = int.Parse(cmbNome.SelectedValue.ToString());

                DataRow[] row;

                row = oDtFornecedor.Select("id_for = " + codigoFornecedor);

                int rowIndex = oDtFornecedor.Rows.IndexOf(row[0]);

                txtCnpj.Text = oDtFornecedor.Rows[rowIndex]["cnpj_for"].ToString();
                txtEndereco.Text = oDtFornecedor.Rows[rowIndex]["endereco_for"].ToString();
                txtTelefone.Text = oDtFornecedor.Rows[rowIndex]["telefone_for"].ToString();

                if (oDtFornecedor.Rows[rowIndex]["status_for"].ToString() == "True")
                    rdbAtivo.Checked = true;
                else
                    rdbInativo.Checked = true;

                try
                {
                    lstboxMateriaisInclusos.Items.Clear();


                    DataTable oDtMateriaisFornecedor = new DataTable();
                    oDtMateriaisFornecedor = camadaNegocios.DataTableMateriaisFornecedor(codigoFornecedor);

                    string codigoMaterial;
                    string nomeMaterial;


                    for (int i = 0; i < oDtMateriaisFornecedor.Rows.Count; i++)
                    {
                        codigoMaterial = oDtMateriaisFornecedor.Rows[i]["Codigo"].ToString();
                        nomeMaterial = oDtMateriaisFornecedor.Rows[i]["Nome"].ToString();

                        //Formatando os dados para lstbox
                        while (codigoMaterial.Length < 6)
                            codigoMaterial = '0' + codigoMaterial;


                        lstboxMateriaisInclusos.Items.Add(codigoMaterial + " - " + nomeMaterial);
                    }
                }

                catch
                {
                    //nada ocorre
                }

            }

            else
                MessageBox.Show("Selecione um forncedor");
        }

        private void btnAdicionarMaterial_Click(object sender, EventArgs e)
        {
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
                        Boolean encontrouMaterialListBox = false;
                        string item;
                        int index;

                        //Verificando se o material já está na listbox
                        for (index = (lstboxMateriaisInclusos.Items.Count) - 1; index >= 0; index--)
                        {
                            item = lstboxMateriaisInclusos.Items[index].ToString();
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


                        if (encontrouMaterialListBox == true)
                            MessageBox.Show("Material já adicionado na listbox");

                        else
                            lstboxMateriaisAdicionar.Items.Add(stringCodigoMaterial + " - " + nomeMaterial);

                        txtCodigoMaterial.Text = "";
                        txtCodigoMaterial.Focus();
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

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (lstboxMateriaisAdicionar.SelectedIndex != -1)
                lstboxMateriaisAdicionar.Items.RemoveAt(lstboxMateriaisAdicionar.SelectedIndex);
        }

        private void txtCodigoMaterial_Enter(object sender, EventArgs e)
        {
            if (txtCodigoMaterial.Text == "  F1 para consultar" && txtCodigoMaterial.ForeColor == Color.Gray)
            {
                txtCodigoMaterial.Text = "";
                txtCodigoMaterial.ForeColor = Color.Black;
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

        private void txtCodigoMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnAdicionarMaterial.PerformClick();
            }

            if (e.KeyCode == Keys.F1)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                Point posicaoForm = new Point(100, 100);
                posicaoForm = this.Location;


                Form formBuscaMaterial = new BuscarMaterial(this, posicaoForm.X, posicaoForm.Y);
                this.Hide();
                formBuscaMaterial.Show();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nomeFornecedor = cmbNome.Text.ToString();
            Boolean statusNome = validar.Textos(nomeFornecedor);

            if (statusNome == true)
            {
                string cnpjFornecedor = txtCnpj.Text.ToString();
                Boolean statusCnpj = validar.Cnpj(cnpjFornecedor);

                if (statusCnpj == true)
                {
                    string telefoneFornecedor = txtTelefone.Text.ToString();
                    Boolean statusTelefone = validar.Textos(telefoneFornecedor);

                    if (statusTelefone == true)
                    {
                        string enderecoFornecedor = txtEndereco.Text.ToString();
                        Boolean statusEndereco = validar.Textos(enderecoFornecedor);

                        if (statusEndereco == true)
                        {
                            //Inserindo o fornecedor
                            int codigoFornecedor = int.Parse(cmbNome.SelectedValue.ToString());

                            if (codigoFornecedor != 0)
                            {
                                int codigoMaterial;
                                Boolean statusInsercaoMaterial = true;

                                Boolean statusFornecedor = rdbAtivo.Checked == true;

                                camadaNegocios.AlterarFornecedor(codigoFornecedor, nomeFornecedor, cnpjFornecedor, telefoneFornecedor, enderecoFornecedor, statusFornecedor);

                                //Inserindo os materiais que este fornecedor pode fornecer
                                for (int index = (lstboxMateriaisAdicionar.Items.Count) - 1; index >= 0; index--)
                                {
                                    var array = ((lstboxMateriaisAdicionar.Items[index]).ToString()).Split('-');

                                    codigoMaterial = int.Parse(array[0]);

                                    statusInsercaoMaterial = camadaNegocios.InserirMateriaisFornecedor(codigoFornecedor, codigoMaterial);
                                    if (statusInsercaoMaterial == false)
                                    {
                                        MessageBox.Show("Erro inesperado ao alterar o fornecedor. Contate o suporte");
                                        break;
                                    }
                                }

                                if (statusInsercaoMaterial == true)
                                {
                                    MessageBox.Show("Fornecedor alterado com sucesso");

                                    //Recarregando a página

                                    Point posicaoForm = new Point(100, 100);
                                    posicaoForm = this.Location;

                                    Form formConsultarFornecedor = new ConsultarFornecedor(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
                                    xClicked = false;
                                    this.Close();
                                    formConsultarFornecedor.Show();
                                }

                                else
                                    MessageBox.Show("Materiais do fornecedor não foram incluídos.\n");
                            }

                            else
                                MessageBox.Show("Não foi possível alterar o fornecedor");
                        }

                        else
                            MessageBox.Show("Endereço inválido. \n\n" +
                                            "Deve ter pelo menos um caractere \n" +
                                            "Não conter caracteres especiais");

                    }

                    else
                        MessageBox.Show("Telefone inválido. \n\n" +
                                    "Deve ter pelo menos um caractere \n" +
                                    "Não conter caracteres especiais");
                }

                else
                    MessageBox.Show("CNPJ inválido");

            }

            else
                MessageBox.Show("Nome inválido. \n\n" +
                            "Deve ter pelo menos um caractere \n" +
                            "Não conter caracteres especiais");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Recarregando a página

            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarFornecedor = new ConsultarFornecedor(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            xClicked = false;
            this.Close();
            formConsultarFornecedor.Show();
        }

        private void ConsultarFornecedor_FormClosing(object sender, FormClosingEventArgs e)
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
