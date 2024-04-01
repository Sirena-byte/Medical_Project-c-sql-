using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicalProject2
{
    class MedicalDB
    {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-5SKDP8VM\SQLEXPRESS01;Initial Catalog=medical_project_DB;Integrated Security=True");

            public void openConnection()
            {
                //если связь с базой данных закрыта, то открываем ее
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
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

