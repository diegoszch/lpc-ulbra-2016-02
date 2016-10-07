using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Aula11.Exemplo
{
    public partial class FrmAula11 : Form
    {
        private string stringConnection;

        public FrmAula11()
        {
            InitializeComponent();

            stringConnection =
                @"Data Source=DIEGOSZ-PC\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True;MultipleActiveResultSets=True";
        }

        private void btnSqlConnection_Click(object sender, EventArgs e)
        {
            
            var conn = new SqlConnection(stringConnection);
            conn.Open();

            
            if(conn.State == ConnectionState.Open)
                conn.Close();


            using (var conn2 = new SqlConnection(stringConnection))
            {

            }

        }

        private void btnSqlTransaction_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(stringConnection))
            {
                conn.Open();

                var trans = conn.BeginTransaction();

                try
                {

                    trans.Commit();
                }
                catch 
                {
                    trans.Rollback(); 
                }
            }
        }

        private void btnSqlCommand_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                var trans = conn.BeginTransaction();

                try
                {
                    var query = "INSERT INTO Usuario (Login,Nome, Senha,Email) ";
                    query    += "VALUES ('diego.zuge2','Diego Zuge', '1234','diegoszch@gmail.com')";

                    var cmd = new SqlCommand(
                        query,
                        conn,
                        trans
                    );

                    cmd.ExecuteNonQuery();                    
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                }
            }
        }

        private void btnSqlCommandParameter_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                var trans = conn.BeginTransaction();

                try
                {
                    var query = "INSERT INTO Usuario (Login,Nome, Senha,Email) ";
                    query += "VALUES (@Login,@Nome, @Senha, @Email)";

                    var cmd = new SqlCommand(
                        query,
                        conn,
                        trans
                    );

                    cmd.Parameters.Add(new SqlParameter("@Login", "pedro"));
                    cmd.Parameters.Add(new SqlParameter("@Nome", "Pedro"));
                    cmd.Parameters.Add(new SqlParameter("@Senha", "1"));
                    cmd.Parameters.Add(new SqlParameter("@Email", "email@email.com"));

                    cmd.ExecuteNonQuery();
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                }
            }
        }

        private void btnSqlDataAdapter_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                var trans = conn.BeginTransaction();

                try
                {
                    var query = "SELECT Login,Email FROM Usuario WHERE Id = @Id";
                    
                    var cmd = new SqlCommand(query, conn, trans);
                    cmd.Parameters.Add(new SqlParameter("@Id", 1));

                    var adapter = new SqlDataAdapter(cmd);
                    var dsTable = new DataSet();
                    adapter.Fill(dsTable);

                    foreach (DataRow linha in dsTable.Tables[0].Rows)
                    {
                        MessageBox.Show(linha["Login"].ToString());
                    }

                    trans.Commit();
                }
                catch
                {                    
                    trans.Rollback();
                }
            }
        }
    }
}
