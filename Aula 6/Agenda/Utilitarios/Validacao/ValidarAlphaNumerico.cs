using System.Text.RegularExpressions;

namespace Utilitarios.Validacao
{
    public class ValidarAlphaNumerico
    {
        #region Metodos

        public static bool TemConteudo(string str)
        {
            return (!string.IsNullOrWhiteSpace(str));
        }

        public static bool EmailValido(string emailInformado)
        {
            return Regex.IsMatch(emailInformado, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public static bool TemSomenteNumeros(string s, bool floatpoint)
        {
            s = s.Trim();
            if (s.Length == 0)
                return false;
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    if (floatpoint && (c == '.' || c == ','))
                        continue;
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}



