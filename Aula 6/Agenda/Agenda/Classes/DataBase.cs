using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    public abstract class DataBase
    {
        private SqlConnection conn;
        private SqlTransaction trans;

        private int? ExecutarAcao(string querySQL, SqlParameter[] parameters)
        {
            var cmd = new SqlCommand(
                querySQL,
                conn,
                trans
            );

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            var valor = cmd.ExecuteScalar();

            return valor == DBNull.Value ? null : (int?)Convert.ToInt32(valor);
        }
    }
}
