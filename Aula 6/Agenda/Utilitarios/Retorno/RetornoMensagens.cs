using System.Collections.Generic;
using System.Linq;

namespace Utilitarios.Retorno
{
    public class RetornoMensagens
    {
        List<RetornoMensagem> Mensagens;

        #region Metodos

        public RetornoMensagens()
        {
            LimparLista();
        }

        public void AddMensagem(RetornoMensagem msg)
        {
            Mensagens.Add(msg);
        }

        public void LimparLista()
        {
            Mensagens = new List<RetornoMensagem>();
        }

        public List<RetornoMensagem> GetMensagens()
        {
            return Mensagens;
        }

        public List<RetornoMensagem> GetMensagens(TipoMensagem tipo)
        {
            return Mensagens.Where(x => x.GetTipo() == tipo).ToList();
        }

        public bool TemTipo(TipoMensagem tipo)
        {
            return (Mensagens.Where(x => x.GetTipo() == tipo).Count() > 0);
        }

        #endregion
    }
}
