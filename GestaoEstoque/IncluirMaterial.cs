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
            //Criando o DataTable
            DataTable oDtTipoMaterial = new DataTable();
            oDtTipoMaterial.Clear();
            oDtTipoMaterial = camadaNegocios.DataTableTipoMaterial();

            //Preenchendo a ComboBox
            cmbTipoMaterial.DataSource = null;
            cmbTipoMaterial.DataSource = oDtTipoMaterial;
            cmbTipoMaterial.ValueMember = "id_tipo_material";
            cmbTipoMaterial.DisplayMember = "descricao_reduzida_tipo_material";
            cmbTipoMaterial.SelectedItem = "";
            cmbTipoMaterial.Refresh();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string nomeMaterial = txtNome.Text.ToString();
            int idTipoMaterial;

            //Fazendo a validação do texto
            Boolean statusNome = validar.Textos(nomeMaterial);

            if (statusNome == true)
            {
                if (cmbTipoMaterial.SelectedIndex != -1)
                {
                    idTipoMaterial = int.Parse(cmbTipoMaterial.SelectedValue.ToString());

                    //Pedindo à camda de negocios para incluir o material
                    Boolean statusInsercao = camadaNegocios.InserirMaterial(nomeMaterial, true, idTipoMaterial);

                    if (statusInsercao == true)
                    {
                        MessageBox.Show("Material incluído com sucesso!");

                        //Limpando os campos
                        txtNome.Text = "";
                        txtNome.Focus();
                    }

                    else
                        MessageBox.Show("Não foi possível incluir o material");
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
    }
}
