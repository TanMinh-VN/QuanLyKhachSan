using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;


        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DataProvider() { }
        private string connectStr = @"Data Source=DESKTOP-ST5MBCM;Initial Catalog=QLKS;User ID=. ;Password=123456";
        public DataTable ExecuteQuery(string query)
        {
            DataTable dtTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtTable);
                connection.Close();
            }

            return dtTable;
        }
        public int ExecuteNonQuery(string query)
        {
            int successRows = 0;
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                successRows = command.ExecuteNonQuery();
                connection.Close();
            }


            return successRows;
        }
        public object ExecuteScalar(string query)
        {
            object dtObject = 0;
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                dtObject = command.ExecuteScalar();
                connection.Close();
            }


            return dtObject;
        }

    }
}
