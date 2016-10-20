using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes.BancoDeDados
{
    public enum FiltroOperador
    {
        IGUAL,
        MAIOR,
        MAIORIGUAL,
        MENOR,
        MENORIGUAL,
        DIFERENTE,
        LIKE,
        LIKEINICIO,
        LIKEFIM
    }

    public class Filtro
    {
        private List<string> filtros;

        public Filtro()
        {
            filtros = new List<string>();
        }

        public void LimparFiltros()
        {
            filtros.Clear();
        }

        public List<string> GetFiltros()
        {
            return filtros;
        }

        public void AddFiltro(FiltroOperador operador, string chave, string valor)
        {
            switch (operador)
            {
                case FiltroOperador.IGUAL:
                    filtros.Add(string.Format(" {0} = {1}", chave, valor));
                    break;
                case FiltroOperador.MAIOR:
                    filtros.Add(string.Format(" {0} > {1}", chave, valor));
                    break;
                case FiltroOperador.MAIORIGUAL:
                    filtros.Add(string.Format(" {0} >= {1}", chave, valor));
                    break;
                case FiltroOperador.MENOR:
                    filtros.Add(string.Format(" {0} < {1}", chave, valor));
                    break;
                case FiltroOperador.MENORIGUAL:
                    filtros.Add(string.Format(" {0} <= {1}", chave, valor));
                    break;
                case FiltroOperador.DIFERENTE:
                    filtros.Add(string.Format(" {0} <> {1}", chave, valor));
                    break;
                case FiltroOperador.LIKE:
                    filtros.Add(string.Format(" {0} LIKE '%{1}%'", chave, valor));
                    break;
                case FiltroOperador.LIKEINICIO:
                    filtros.Add(string.Format(" {0} LIKE '%{1}'", chave, valor));
                    break;
                case FiltroOperador.LIKEFIM:
                    filtros.Add(string.Format(" {0} LIKE '{1}%'", chave, valor));
                    break;
                default:
                    break;
            }
        }
    }
}
