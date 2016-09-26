using Agenda.Classes;
using Agenda.Classes.DTO;
using System;
using Utilitarios.Retorno;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utilitarios.Validacao;

namespace Agenda.Formularios.Cadastros
{
    public partial class FrmUsuario : Form
    {
        private bool RegistroNovo;

        public FrmUsuario()
        {
            InitializeComponent();

            LimparTopo();
            HabilitarTopo();
        }

       

        private void HabilitarTopo()
        {
            grpTopo.Enabled = true;
            grpCorpo.Enabled = false;
            RegistroNovo = false;
        }

        private void HabilitarCorpo()
        {
            grpTopo.Enabled = false;
            grpCorpo.Enabled = true;
        }

        private void LimparTopo()
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
        }

        private void LimparCorpo()
        {
            txtNome.Text = "";
            txtLogin.Text = "";            
            txtSenha.Text = "";
            txtEmail.Text = "";
        }

        private void PreparaNovoRegistro()
        {
            txtCodigo.Text = "0";
            txtDescricao.Text = "";
            RegistroNovo = true;
            LimparCorpo();
            btnExcluir.Enabled = false;
            HabilitarCorpo();
        }

        private void PreparaEdicaoRegistro()
        {            
            RegistroNovo = false;
            btnExcluir.Enabled = true;
            HabilitarCorpo();            
        }

        private void InicializarTopo()
        {
            LimparCorpo();
            LimparTopo();
            HabilitarTopo();
        }

        private bool ValidarFormulario()
        {
            #region Parte 1
            if(!ValidarAlphaNumerico.TemSomenteNumeros(txtCodigo.Text, false))
            {
                MessageBox.Show(
                    "O Código tem que ser numérico.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
            #endregion

            #region Parte 2
            var dto = new UsuarioDTO();
            dto.Id = int.Parse(txtCodigo.Text);
            dto.Nome = txtNome.Text;
            dto.Email = txtEmail.Text;
            dto.Login = txtLogin.Text;
            dto.Senha = txtSenha.Text;
            #endregion

            #region Parte 3
            var usuario = new Usuario();
            var resultValidacao = usuario.ValidarEntidade(dto);
            if(resultValidacao.TemTipo(TipoMensagem.Erro))
            {
                var msg = "";
                var erros = resultValidacao.GetMensagens(TipoMensagem.Erro);
                foreach (var erro in erros)
                {
                    msg += erro.GetMensagem() + "\n";
                }

                MessageBox.Show(
                    "Erros encontrados: \n" + msg,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
            else
            {
                return true;
            }
            #endregion
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            PreparaNovoRegistro();            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarTopo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var mensagem = "";

            if (ValidarFormulario())
            {
                var dto = new UsuarioDTO();
                dto.Id = int.Parse(txtCodigo.Text);
                dto.Nome = txtNome.Text;
                dto.Email = txtEmail.Text;
                dto.Login = txtLogin.Text;
                dto.Senha = txtSenha.Text;
                                                
                var usuario = new Usuario();

                if(RegistroNovo)
                {
                    usuario.Salvar(dto);
                    mensagem = "Registro salvo com sucesso";
                }
                else
                {
                    usuario.Atualizar(dto);
                    mensagem = "Registro atualizado com sucesso";
                }

                MessageBox.Show(
                    mensagem,
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                InicializarTopo();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            var objUsuario = usuario.Selecionar(int.Parse(txtCodigo.Text));
            if (objUsuario == null)
            {
                MessageBox.Show(
                    "Registro não encontrado",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                txtCodigo.Text = objUsuario.Id.ToString();
                txtDescricao.Text = objUsuario.Nome;
                txtNome.Text = objUsuario.Nome;
                txtLogin.Text = objUsuario.Login;
                txtSenha.Text = objUsuario.Senha;
                txtEmail.Text = objUsuario.Email;

                PreparaEdicaoRegistro();
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show(
                "Você deseja excluir o arquivo?",
                "Pergunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if(retorno == DialogResult.Yes)
            {
                var usuario = new Usuario();
                usuario.Excluir(int.Parse(txtCodigo.Text));

                InicializarTopo();

                MessageBox.Show(
                    "Exclusão efetuada com sucesso.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }


    }
}
