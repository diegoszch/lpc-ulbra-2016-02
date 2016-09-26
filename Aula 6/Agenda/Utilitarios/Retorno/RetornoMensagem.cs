namespace Utilitarios.Retorno
{
    public class RetornoMensagem
    {
        private TipoMensagem Tipo;
        private string Mensagem;

        public RetornoMensagem(TipoMensagem tipo, string mensagem)
        {
            this.Tipo = tipo;
            this.Mensagem = mensagem;
        }

        public TipoMensagem GetTipo()
        {
            return Tipo;
        }

        public string GetMensagem()
        {
            return Mensagem;
        }
    }
}
