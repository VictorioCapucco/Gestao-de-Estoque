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
    public partial class ConsultarEstoque : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        private Boolean xClicked = true;
        int permissaoUsuario;

        public ConsultarEstoque(Form anterior, int x, int y, int permissao)
        {
            permissaoUsuario = permissao;
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void ConsultarEstoque_Load(object sender, EventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbLocal.SelectedIndex != -1)
            {
                btnConsultar.Visible = false;
                cmbLocal.Enabled = false;

                lblLegenda.Visible = true;
                lblMateriais.Visible = true;
                lstboxMateriais.Visible = true;
                txtTotalMateriais.Visible = true;
                txtTotalQuantidade.Visible = true;
                btnCancelar.Visible = true;

                int codigoLocal = int.Parse(cmbLocal.SelectedValue.ToString());

                //Listando os materiais do estoque
                DataTable oDtMateriais = new DataTable();
                oDtMateriais = camadaNegocios.ConsultaEstoque(codigoLocal);

                try
                {
                    int totalQuantidade = 0;
                    int totalMateriais = 0;
                    string codigoMaterial;
                    string nomeMaterial;
                    string quantidadeMaterial;


                    for (int i = 0; i < oDtMateriais.Rows.Count; i++)
                    {
                        codigoMaterial = oDtMateriais.Rows[i]["Codigo"].ToString();
                        nomeMaterial = oDtMateriais.Rows[i]["Nome"].ToString();
                        quantidadeMaterial = oDtMateriais.Rows[i]["Quantidade"].ToString();

                        //Formatando os dados para lstbox
                        while (codigoMaterial.Length < 6)
                            codigoMaterial = '0' + codigoMaterial;

                        while (nomeMaterial.Length < 20)
                            nomeMaterial = nomeMaterial + ' ';

                        lstboxMateriais.Items.Add(codigoMaterial + " - " + nomeMaterial + " - " + quantidadeMaterial);

                        totalMateriais += 1;
                        totalQuantidade += int.Parse(quantidadeMaterial);
                    }

                    txtTotalMateriais.Text = totalMateriais.ToString();
                    txtTotalQuantidade.Text = totalQuantidade.ToString();

                }

                catch
                {
                    //nada ocorre
                }
            }

            else
                MessageBox.Show("Selecione um local");
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            //Recarregando a página

            Point posicaoForm = new Point(100, 100);
            posicaoForm = this.Location;

            Form formConsultarEstoque = new ConsultarEstoque(formAnterior, posicaoForm.X, posicaoForm.Y, permissaoUsuario);
            xClicked = false;
            this.Close();
            formConsultarEstoque.Show();
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

        private void ConsultarEstoque_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }
    }
}
