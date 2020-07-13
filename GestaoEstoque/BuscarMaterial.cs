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
    public partial class BuscarMaterial : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();

        public BuscarMaterial(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            formAnterior.Location = new Point(this.Location.X, this.Location.Y);
            formAnterior.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstboxMateriais.Items.Clear();

            string nomeBusca = txtNome.Text.ToString().Trim();

            //Validando a caixa de busca
            Boolean statusDescricao = validar.Textos(nomeBusca);

            if (statusDescricao == true)
            {
                DataTable oDtMateriais = new DataTable();

                oDtMateriais = camadaNegocios.BuscaMaterial(nomeBusca);


                string codigoMaterial;
                string nomeMaterial;


                for (int i = 0; i < oDtMateriais.Rows.Count; i++)
                {
                    codigoMaterial = oDtMateriais.Rows[i]["id_material"].ToString();
                    nomeMaterial = oDtMateriais.Rows[i]["nome_material"].ToString();

                    //Formatando os dados para lstbox
                    while (codigoMaterial.Length < 6)
                        codigoMaterial = '0' + codigoMaterial;


                    lstboxMateriais.Items.Add(codigoMaterial + " - " + nomeMaterial);
                }
            }
        }
    }
}
