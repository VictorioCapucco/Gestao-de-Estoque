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
    public partial class IncluirEntradaManual : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        private Boolean xClicked = true;
        int permissaoUsuario;

        public IncluirEntradaManual(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void EntradaManualEstoque_Load(object sender, EventArgs e)
        {
            //Criando o DataTable
            DataTable oDtLocal = new DataTable();
            oDtLocal.Clear();

                                                    //filtra_local, statusLocal, isObra, statusObra, codigoLocal
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

                lblCodigoMaterial.Visible = true;
                lblLegenda.Visible = true;
                txtCodigoMaterial.Visible = true;
                btnAdicionarMaterial.Visible = true;
                btnMais.Visible = true;
                btnMenos.Visible = true;
                btnIncluir.Visible = true;
                btnLixeira.Visible = true;
                lstboxMateriais.Visible = true;

                btnCancelar.Location = new Point(490, btnCancelar.Location.Y);
            }

            else
                MessageBox.Show("Selecione um local");
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

        private void btnAdicionarMaterial_Click(object sender, EventArgs e)
        {
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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (lstboxMateriais.Items.Count > 0)
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
                    MessageBox.Show("Entrada manual incluída com sucesso!");

                    //Recarregando a página

                    Point posicaoForm = new Point(100, 100);
                    posicaoForm = this.Location;

                    Form formIncluirEntradaManual = new IncluirEntradaManual(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
                    xClicked = false;
                    this.Close();
                    formIncluirEntradaManual.Show();
                }

                else
                    MessageBox.Show("Erro ao atualizar o estoque");
            }

            else
                MessageBox.Show("Insira pelo menos um material");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();

            formAnterior.Location = this.Location;
            formAnterior.Show();
        }

        private void IncluirEntradaManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }
    }
}
