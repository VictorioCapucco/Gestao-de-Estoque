﻿using System;
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
    public partial class IncluirLocais : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        private Boolean xClicked = true;

        public IncluirLocais(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);

            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text.ToString();
            string endereco = txtEndereco.Text.ToString();

            //Validação dos textos
            Boolean statusDescricao = validar.Textos(descricao);
            Boolean statusEndereco = validar.Textos(endereco);

            if (statusDescricao == true)
            {
                if (statusEndereco == true)
                {
                    ////Pedindo à camada de negócios para adicionar o local
                    Boolean statusInsercao = camadaNegocios.InserirLocais(descricao, endereco, true);

                    if (statusInsercao == true)
                    {
                        MessageBox.Show("Local incluído com sucesso");

                        //Limpando os campos
                        txtDescricao.Text = "";
                        txtEndereco.Text = "";
                        txtDescricao.Focus();
                    }

                    else
                        MessageBox.Show("Não foi possível incluir o local");
                }

                else
                {
                    MessageBox.Show("Endereço inválido. \n\n" +
                                    "Deve ter pelo menos um caractere \n" +
                                    "Não conter caracteres especiais");
                    txtEndereco.Focus();
                }
                    
            }

            else
            {
                MessageBox.Show("Descrição inválida. \n\n" +
                                "Deve ter pelo menos um caractere \n" +
                                "Não conter caracteres especiais");
                txtDescricao.Focus();
            }
                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();

            formAnterior.Show();
        }

        private void IncluirLocais_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtEndereco.Focus();
            }
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
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
