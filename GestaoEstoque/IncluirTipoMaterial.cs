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
    public partial class IncluirTipoMaterial : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();

        public IncluirTipoMaterial(Form anterior, int x, int y)
        {
            this.Location = new Point(x, y);
            formAnterior = anterior;
            InitializeComponent();
        }

        private void IncluirTipoMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string descricaoCompleta = txtDescricaoCompleta.Text.ToString();
            string descricaoReduzida = txtDescricaoReduzida.Text.ToString();

            //Validação dos textos
            Boolean statusDescricaoCompleta = validar.Textos(descricaoCompleta);
            Boolean statusDescricaoReduzida = validar.Textos(descricaoReduzida);

            if (statusDescricaoCompleta == true)
            {
                if (statusDescricaoReduzida == true)
                {
                    //Pedindo à camada de negocios para adicionar o tipo de material
                    Boolean statusInsercao = camadaNegocios.InserirTipoMaterial(descricaoCompleta, descricaoReduzida, true);

                    if (statusInsercao == true)
                    {
                        MessageBox.Show("Tipo de material incluído com sucesso");

                        //Limpando os campos
                        txtDescricaoCompleta.Text = "";
                        txtDescricaoReduzida.Text = "";
                        txtDescricaoCompleta.Focus();
                    }

                    else
                        MessageBox.Show("Não foi possível incluir o tipo de material");
                }

                else
                {
                    MessageBox.Show("Descrição reduzida inválida. \n\n" +
                                    "Deve ter pelo menos um caractere \n" +
                                    "Não conter caracteres especiais");
                    txtDescricaoReduzida.Focus();
                }
            }

            else
            {
                MessageBox.Show("Descrição completa inválida. \n\n" +
                                "Deve ter pelo menos um caractere \n" +
                                "Não conter caracteres especiais");
                txtDescricaoCompleta.Focus();
            }
                
        }

        private void txtDescricaoCompleta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtDescricaoReduzida.Focus();
            }
        }

        private void txtDescricaoReduzida_KeyDown(object sender, KeyEventArgs e)
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
