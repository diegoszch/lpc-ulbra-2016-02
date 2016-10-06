using Agenda.Classes;
using System;
using System.Windows.Forms;
using Utilitarios.Validacao;

namespace Agenda.Formularios.Util
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private bool ValidarFormulario()
        {
            if(!ValidarAlphaNumerico.TemConteudo(txtLogin.Text))
            {
                MessageBox.Show(
                    "Preencha o login",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (!ValidarAlphaNumerico.TemConteudo(txtSenha.Text))
            {
                MessageBox.Show(
                    "Preencha a senha",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                var login = new Usuario();
                if (login.ValidarLoginSenha(txtLogin.Text, txtSenha.Text))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(
                        "Usuário ou senha inválido.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}