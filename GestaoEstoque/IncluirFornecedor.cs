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
    public partial class IncluirFornecedor : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        private Boolean xClicked = true;
        int permissaoUsuario;

        public IncluirFornecedor(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void btnIncluirFornecedor_Click(object sender, EventArgs e)
        {
            if (lstboxMateriais.Items.Count != 0)
            {
                string nomeFornecedor = txtNome.Text.ToString();
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
                                int codigoFornecedor = camadaNegocios.InserirFornecedor(nomeFornecedor, cnpjFornecedor, telefoneFornecedor, enderecoFornecedor);

                                if (codigoFornecedor != 0)
                                {
                                    int codigoMaterial;
                                    Boolean statusInsercaoMaterial = true;
                                    //Inserindo os materiais que este fornecedor pode fornecer
                                    for (int index = (lstboxMateriais.Items.Count) - 1; index >= 0; index--)
                                    {
                                        var array = ((lstboxMateriais.Items[index]).ToString()).Split('-');

                                        codigoMaterial = int.Parse(array[0]);

                                        statusInsercaoMaterial = camadaNegocios.InserirMateriaisFornecedor(codigoFornecedor, codigoMaterial);
                                        if (statusInsercaoMaterial == false)
                                        {
                                            MessageBox.Show("Erro inesperado ao inserir o fornecedor. Contate o suporte");
                                            break;
                                        }
                                    }

                                    if (statusInsercaoMaterial == true)
                                    {
                                        MessageBox.Show("Fornecedor incluído com sucesso");
                                        txtNome.Text = "";
                                        txtCnpj.Text = "";
                                        txtTelefone.Text = "";
                                        txtEndereco.Text = "";
                                        txtCodigoMaterial.Text = "";
                                        lstboxMateriais.Items.Clear();

                                        txtNome.Focus();
                                    }

                                    else
                                        MessageBox.Show("Materiais do fornecedor não foram incluídos.\n" +
                                                        "Inclua manualmente no cadastro de fornecedores");
                                }

                                else
                                    MessageBox.Show("Não foi possível inserir o fornecedor");
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

            else
                MessageBox.Show("Informe pelo menos um material fornecido por este fornecedor");
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O fornecedor só poderá fornecer os produtos que forem permitidos");
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


                        if (encontrouMaterialListBox == true)
                            MessageBox.Show("Material já adicionado na listbox");

                        else
                            lstboxMateriais.Items.Add(stringCodigoMaterial + " - " + nomeMaterial);

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

        private void txtCodigoMaterial_Click(object sender, EventArgs e)
        {
            if (txtCodigoMaterial.Text == "  F1 para consultar")
            {
                txtCodigoMaterial.Text = "";
                txtCodigoMaterial.ForeColor = Color.Black;
            }
        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (lstboxMateriais.SelectedIndex != -1)
                lstboxMateriais.Items.RemoveAt(lstboxMateriais.SelectedIndex);
        }

        private void txtCodigoMaterial_Enter(object sender, EventArgs e)
        {
            if (txtCodigoMaterial.Text == "  F1 para consultar" && txtCodigoMaterial.ForeColor == Color.Gray)
            {
                txtCodigoMaterial.Text = "";
                txtCodigoMaterial.ForeColor = Color.Black;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();

            formAnterior.Location = this.Location;
            formAnterior.Show();
        }

        private void IncluirFornecedor_FormClosing(object sender, FormClosingEventArgs e)
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
