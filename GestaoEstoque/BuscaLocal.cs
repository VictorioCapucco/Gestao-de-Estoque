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
    public partial class BuscaLocal : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();

        public BuscaLocal(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstboxLocais.Items.Clear();

            string descricaoBusca = txtDescricao.Text.ToString().Trim();
            
            //Validando a caixa de busca
            Boolean statusDescricao = validar.Textos(descricaoBusca);

            if (statusDescricao == true)
            {
                DataTable oDtLocais = new DataTable();

                oDtLocais = camadaNegocios.BuscaLocais(descricaoBusca);

                string codigoLocal;
                string descricaoLocal;
                string enderecoLocal;


                for (int i = 0; i < oDtLocais.Rows.Count; i++)
                {
                    codigoLocal = oDtLocais.Rows[i]["id_local"].ToString();
                    descricaoLocal = oDtLocais.Rows[i]["descricao_local"].ToString();
                    enderecoLocal = oDtLocais.Rows[i]["endereco_local"].ToString();

                    //Formatando os dados para lstbox
                    while (codigoLocal.Length < 6)
                        codigoLocal = '0' + codigoLocal;

                    while (descricaoLocal.Length < 15)
                        descricaoLocal = descricaoLocal + ' ';

                    
                    lstboxLocais.Items.Add(codigoLocal + " - " + descricaoLocal + " - " + enderecoLocal);
                }
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            formAnterior.Location = new Point(this.Location.X, this.Location.Y);
            formAnterior.Show();
        }
    }
}
