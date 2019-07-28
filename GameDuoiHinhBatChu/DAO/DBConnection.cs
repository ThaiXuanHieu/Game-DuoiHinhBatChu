using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
namespace DAO
{
    public class DBConnection
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private SqlCommand command;

        public DBConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        private SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State ==
                        ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public DataTable ExecuteSelectQuery(string query, SqlParameter[] sqlParameters)
        {
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet dataSet = new DataSet();
            using (command = new SqlCommand())
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }

        public void ExecuteInsertQuery(string query, SqlParameter[] sqlParameters)
        {
            using (command = new SqlCommand())
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
        }

        public void ExecuteUpdateQuery(string query, SqlParameter[] sqlParameters)
        {
            using (command = new SqlCommand())
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.UpdateCommand = command;
                command.ExecuteNonQuery();
            }
        }
    }
}
