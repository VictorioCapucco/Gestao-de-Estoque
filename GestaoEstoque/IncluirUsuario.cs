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
    public partial class IncluirUsuario : Form
    {
        Form formAnterior;
        CamadaNegocios camadaNegocios = new CamadaNegocios();
        Validacao validar = new Validacao();
        Criptografia criptografar = new Criptografia();
        private Boolean xClicked = true;

        public IncluirUsuario(Form anterior, int x, int y)
        {
            formAnterior = anterior;
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.ToString();
            string senha = txtSenha.Text.ToString();
            string confirmarSenha = txtConfirmarSenha.Text.ToString();

            //Validação dos textos
            Boolean statusNome = validar.Textos(nome);
            Boolean statusSenha = validar.Textos(senha);
            Boolean statusConfirmarSenha = validar.Textos(confirmarSenha);

            if (statusNome == true)
            {
                if (statusSenha == true)
                {
                    if (statusConfirmarSenha == true)
                    {
                        //Verificando se a senha atende os requisitos
                        Boolean statusVerificarSenha = validar.Senha(senha, confirmarSenha);

                        if (statusVerificarSenha == true)
                        {
                            //Criptografando a senha
                            string senhaCriptografada = criptografar.Senha(senha);

                            //Passando o tipo de usuário para um int
                            int tipoUsuario;

                            if (rdbAdmin.Checked == true)
                                tipoUsuario = 0;
                            else if (rdbSupervisor.Checked == true)
                                tipoUsuario = 1;
                            else
                                tipoUsuario = 2;

                            //Verificando se este nome de usuário já existe
                            Boolean existeUsuario = camadaNegocios.ExisteUsuario(nome);

                            if (existeUsuario == false)
                            {
                                //Pedindo à camada de negócios para adicionar o usuário
                                Boolean statusInsercao = camadaNegocios.InserirUsuario(nome, tipoUsuario, true, senhaCriptografada);

                                if (statusInsercao == true)
                                {
                                    MessageBox.Show("Usuário incluído com sucesso!");

                                    //Limpando os campos
                                    txtNome.Text = "";
                                    txtSenha.Text = "";
                                    txtConfirmarSenha.Text = "";
                                    txtNome.Focus();
                                }

                                else
                                    MessageBox.Show("Não foi possível incluir o usuário");
                            }

                            else
                            {
                                MessageBox.Show("Já existe um usuário com este nome");
                                txtNome.Focus();
                            }
         
                        }

                        else
                        {
                            MessageBox.Show("A senha não atende aos requisítos. \n\n" +
                                            "A senha e a confirmação devem ser iguais \n");
                            txtSenha.Focus();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Confirmação de senha inválida. \n\n" +
                                        "Deve ter pelo menos um caractere \n" +
                                        "Não conter caracteres especiais");
                        txtConfirmarSenha.Focus();
                    }
                }

                else
                {
                    MessageBox.Show("Senha inválida. \n\n" +
                                    "Deve ter pelo menos um caractere \n" +
                                    "Não conter caracteres especiais");
                    txtSenha.Focus();
                }
            }

            else
            {
                MessageBox.Show("Nome inválido. \n\n" +
                                "Deve ter pelo menos um caractere \n" +
                                "Não conter caracteres especiais");
                txtNome.Focus();
            }

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



        private void IncluirUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked == true)
                formAnterior.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();

            formAnterior.Location = this.Location;
            formAnterior.Show();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
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

                txtConfirmarSenha.Focus();
            }
        }

        private void txtConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                rdbAdmin.Focus();
            }
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
