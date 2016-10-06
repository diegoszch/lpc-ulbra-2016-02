using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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

        public DataTable ExecutarDataSet(string querySQL, SqlParameter[] parameters)
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

            var adapter = new SqlDataAdapter(cmd);
            var dsTable = new DataSet();
            adapter.Fill(dsTable);

            if (AutoClose)
            {                
                FecharConexao();
            }

            return dsTable.Tables[0];

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
