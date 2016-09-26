using Agenda.Classes.DTO;
using Utilitarios.Retorno;
using Utilitarios.Validacao;

namespace Agenda.Classes
{
    public class Usuario
    {
        #region Metodos

        public bool ValidarLoginSenha(string login, string senha)
        {
            return (login == "admin" && senha == "1234");            
        }

        public void Salvar(UsuarioDTO usuarioDTO)
        {
            
        }

        public void Atualizar(UsuarioDTO usuarioDTO)
        {

        }

        public void Excluir(int usuarioId)
        {

        }

        public UsuarioDTO Selecionar(int usuarioId)
        {
            return new UsuarioDTO
            {
                Id = 1,
                Login = "admin",
                Senha = "1234",
                Nome = "Administrador do Sistema",
                Email = "admin@agenda.com.br"
            };
        }

        public RetornoMensagens ValidarEntidade(UsuarioDTO usuarioDTO)
        {
            var retorno = new RetornoMensagens();

            if (!ValidarAlphaNumerico.TemConteudo(usuarioDTO.Nome))
            {
                retorno.AddMensagem(new RetornoMensagem(TipoMensagem.Erro, "Preencha o nome"));
            }

            if (!ValidarAlphaNumerico.TemConteudo(usuarioDTO.Login))
            {
                retorno.AddMensagem(new RetornoMensagem(TipoMensagem.Erro, "Preencha o login"));
            }

            if (!ValidarAlphaNumerico.TemConteudo(usuarioDTO.Senha))
            {
                retorno.AddMensagem(new RetornoMensagem(TipoMensagem.Erro, "Preencha a senha"));
            }

            if (!ValidarAlphaNumerico.TemConteudo(usuarioDTO.Email))
            {
                retorno.AddMensagem(new RetornoMensagem(TipoMensagem.Erro, "Preencha o email"));
            }

            if (!ValidarAlphaNumerico.EmailValido(usuarioDTO.Email))
            {
                retorno.AddMensagem(new RetornoMensagem(TipoMensagem.Erro, "Email inválido"));
            }

            return retorno;
        }

        #endregion
    }
}
