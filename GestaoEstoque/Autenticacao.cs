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
    public partial class Autenticacao : Form
    {
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        Criptografia criptografar = new Criptografia();
        
        public Autenticacao()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            string senha = txtSenha.Text.ToString();

            Boolean statusSenha = validar.Textos(senha);
            int codigoUsuario = validar.IsNumero(txtCodigo.Text.ToString());

            if (codigoUsuario != 0)
            {
                if (statusSenha == true)
                {
                    senha = criptografar.Senha(senha);

                    int permissaoUsuario = camadaNegocios.AutenticarSenha(codigoUsuario, senha);

                    if (permissaoUsuario != 99)
                    {
                        //Criando a sessão
                        camadaNegocios.AbreSessao(codigoUsuario);


                        Point posicaoForm = new Point(100, 100);
                        posicaoForm = this.Location;

                        Form formIncluir = new Incluir(this, posicaoForm.X, posicaoForm.Y, permissaoUsuario);

                        formIncluir.StartPosition = FormStartPosition.CenterScreen;

                        this.Hide();
                        formIncluir.Show();
                    }

                    else
                        MessageBox.Show("Nome de usuário ou senha inválidos");

                }

                else
                    MessageBox.Show("Nome de usuário ou senha inválidos");
            }

            else
                MessageBox.Show("Nome de usuário ou senha inválidos");

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnEntrar.Focus();
            }
        }
    }
}
