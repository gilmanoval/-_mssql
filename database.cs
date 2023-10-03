using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace pp
{
    class database
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-HT3I2VNS; Initial Catalog = pp; Integrated Security = True");
       
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }


        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }


        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
