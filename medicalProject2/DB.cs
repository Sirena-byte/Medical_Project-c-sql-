using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace medicalProject2
{
     class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-5SKDP8VM\SQLEXPRESS01;Initial Catalog=testDB;Integrated Security=True");

        public void openConnection()
        {
            //если связь с базой данных закрыта, то открываем ее
if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            //если связь с базой данных открыта, то закрываем ее
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
