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
    public partial class IncluirMaterial : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        private Boolean xClicked = true;

        public IncluirMaterial(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void IncluirMaterial_Load(object sender, EventArgs e)
        {
            //Criando o DataTable dos tipos de material
            DataTable oDtTipoMaterial = new DataTable();
            oDtTipoMaterial.Clear();
            oDtTipoMaterial = camadaNegocios.DataTableTipoMaterial();

            //Preenchendo a ComboBox dos tipos de material
            cmbTipoMaterial.DataSource = null;
            cmbTipoMaterial.DataSource = oDtTipoMaterial;
            cmbTipoMaterial.ValueMember = "id_tipo_material";
            cmbTipoMaterial.DisplayMember = "descricao_reduzida_tipo_material";
            cmbTipoMaterial.SelectedItem = "";
            cmbTipoMaterial.Refresh();

            //Criando o DataTable da unidade de medida
            DataTable oDtUnidade = new DataTable();
            oDtUnidade.Clear();
                                                        //filtroStatus
            oDtUnidade = camadaNegocios.DataTableUnidade(true);

            //Preenchendo a ComboBox dos tipos de material
            cmbUnidade.DataSource = null;
            cmbUnidade.DataSource = oDtUnidade;
            cmbUnidade.ValueMember = "id_unidade";
            cmbUnidade.DisplayMember = "descricao_unidade";
            cmbUnidade.SelectedItem = "";
            cmbUnidade.Refresh();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string nomeMaterial = txtNome.Text.ToString();
            int codigoTipoMaterial;
            int codigoUnidade;

            //Fazendo a validação do texto
            Boolean statusNome = validar.Textos(nomeMaterial);

            if (statusNome == true)
            {
                if (cmbTipoMaterial.SelectedIndex != -1)
                {
                    codigoTipoMaterial = int.Parse(cmbTipoMaterial.SelectedValue.ToString());

                    if (cmbUnidade.SelectedIndex != -1)
                    {
                        codigoUnidade = int.Parse(cmbUnidade.SelectedValue.ToString());

                        if (lstboxLocais.Items.Count > 0)
                        {
                            //Pedindo à camda de negocios para incluir o material - se retornar 0, é porque deu erro
                            int codigoMaterial = camadaNegocios.InserirMaterial(nomeMaterial, true, codigoTipoMaterial, codigoUnidade);

                            if (codigoMaterial != 0)
                            {
                                //Incluindo o material nos locais
                                Boolean statusMaterialLocal = true;
                                int codigoLocal;

                                for (int index = (lstboxLocais.Items.Count) - 1; index >= 0; index--)
                                {
                                    var array = ((lstboxLocais.Items[index]).ToString()).Split('-');
                                    codigoLocal = int.Parse(array[0].ToString());

                                    statusMaterialLocal = camadaNegocios.InserirMaterialLocal(codigoMaterial, codigoLocal);

                                    if (statusMaterialLocal == false)
                                        break;
                                }

                                if (statusMaterialLocal == true)
                                {
                                    MessageBox.Show("Material incluído com sucesso!");

                                    //Limpando os campos
                                    txtNome.Text = "";
                                    txtNome.Focus();
                                    lstboxLocais.Items.Clear();
                                }

                                else
                                {
                                    MessageBox.Show("Material incluído. Erro ao adicionar os materiais nos locais. \n\n" +
                                                    "Altere se necessário na consulta do material");

                                    //Limpando os campos
                                    txtNome.Text = "";
                                    txtNome.Focus();
                                    lstboxLocais.Items.Clear();
                                }

                            }

                            else
                                MessageBox.Show("Não foi possível incluir o material");
                        }


                        else
                            MessageBox.Show("Insira pelo menos 1 local");
                    }

                    else
                        MessageBox.Show("Selecione uma unidade de medida");
                   
                }

                else
                    MessageBox.Show("Selecione um tipo de material");
            }

            else
            {
                MessageBox.Show("Nome inválido. \n\n" +
                                "Deve ter pelo menos um caractere \n" +
                                "Não conter caracteres especiais");
                txtNome.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();

            formAnterior.Location = this.Location;
            formAnterior.Show();
        }

        private void IncluirMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
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


        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formExcluir = new Excluir(this, posicaoForm.X, posicaoForm.Y);
            this.Hide();
            formExcluir.Show();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                cmbTipoMaterial.Focus();
            }
        }

        private void cmbTipoMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnIncluir.Focus();
            }
        }

        private void btnAdicionarLocal_Click(object sender, EventArgs e)
        {
            string strCodigoLocal = txtCodigoLocal.Text.ToString();

            //Fazendo a validação do texto
            Boolean statusCodigoLocal = validar.Textos(strCodigoLocal);
            if (statusCodigoLocal == true)
            {
                //Verificando se é um número inteiro - Se retornar 0, é porque o código é inválido
                int codigoLocal = validar.IsNumero(strCodigoLocal);

                if (codigoLocal != 0)
                {
                    //Verificando se o local existe - Se o nome do local retornar como vazio, então ele não existe
                    string nomeLocal = camadaNegocios.ExisteLocal(codigoLocal);
                    if (nomeLocal != "")
                    {
                        Boolean encontrouLocalListBox = false;
                        string item;
                        int index;

                        //Verificando se o local já está na listbox
                        for (index = (lstboxLocais.Items.Count) - 1; index >= 0; index--)
                        {
                            item = lstboxLocais.Items[index].ToString();
                            var array = item.Split('-');

                            if (codigoLocal == int.Parse(array[0]))
                            {
                                encontrouLocalListBox = true;
                                break;
                            }
                        }

                        string stringCodigoLocal = codigoLocal.ToString();

                        //Formatando os dados para lstbox
                        while (stringCodigoLocal.Length < 6)
                            stringCodigoLocal = '0' + stringCodigoLocal;


                        //Caso o local não esteja na listbox, iremos adiciona-lo
                        if (encontrouLocalListBox == false)
                        {
                            lstboxLocais.Items.Add(stringCodigoLocal + " - " + nomeLocal);
                        }

                        //Caso contrário, nada ocorre

                        txtCodigoLocal.Text = "";
                        txtCodigoLocal.Focus();
                    }

                    else
                        MessageBox.Show("Local não existente");
                }

                else
                    MessageBox.Show("Código de local inválido");
            }

            else
                MessageBox.Show("Código de local inválido");
        }

        private void txtCodigoLocal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnAdicionarLocal.PerformClick();
            }
        }

        private void txtCodigoLocal_Enter(object sender, EventArgs e)
        {
            if (txtCodigoLocal.Text == "  F1 para consultar" && txtCodigoLocal.ForeColor == Color.Gray)
            {
                txtCodigoLocal.Text = "";
                txtCodigoLocal.ForeColor = Color.Black;
            }
        }

        private void txtCodigoLocal_Leave(object sender, EventArgs e)
        {
            if (txtCodigoLocal.Text == "")
            {
                txtCodigoLocal.Text = "  F1 para consultar";
                txtCodigoLocal.ForeColor = Color.Gray;
            }
        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (lstboxLocais.SelectedIndex != -1)
            {
                lstboxLocais.Items.RemoveAt(lstboxLocais.SelectedIndex);
            }
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este material só existirá nos locais que você determinar");
        }
    }
}
