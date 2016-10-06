using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    public class DataBase : IDisposable
    {
        private SqlConnection Connection;
        private SqlTransaction Transaction;
        private string StringConnection;
        public bool AutoClose = false;

        public DataBase(string stringConnection)
        {
            this.StringConnection = stringConnection;

            if(!AutoClose)
                AbrirConexao();
        }

        public DataBase() : this(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {
                        
        }

        public DataBase(bool autoClose) 
        {
            this.StringConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            this.AutoClose = autoClose;
        }

        public void AbrirConexao()
        {
            
            Connection = new SqlConnection(StringConnection);
            Connection.Open();
            Transaction = Connection.BeginTransaction();
        }

        public void Commit()
        {
            Transaction.Commit();
        }

        public void Rollback()
        {
            Transaction.Rollback();
        }

        public void FecharConexao()
        {
            if (Connection != null)
                Connection.Close();
        }

        public SqlDataReader ExecutarDataReader(string querySQL, SqlParameter[] parameters)
        {
            if (AutoClose)
                AbrirConexao();

            var cmd = new SqlCommand(
                querySQL,
                Connection,
                Transaction
            );

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            var reader = cmd.ExecuteReader();

            if (AutoClose)
            {
                Commit();
                FecharConexao();
            }

            return reader;

        }

        public int? ExecutarAcao(string querySQL, SqlParameter[] parameters)
        {
            if (AutoClose)
                AbrirConexao();

            var cmd = new SqlCommand(
                querySQL,
                Connection,
                Transaction
            );

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            var valor = cmd.ExecuteScalar();


            if (AutoClose)
            {
                Commit();
                FecharConexao();
            }
                

            return valor == DBNull.Value ? null : (int?)Convert.ToInt32(valor);
        }

        public void Dispose()
        {
            FecharConexao();
        }
    }
}
