using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class PlayerDAO
    {
        private DBConnection dbConnection;
        private static PlayerDAO instance;

        public static PlayerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PlayerDAO();
                return instance;
            }
        }
        
        public PlayerDAO()
        {
            dbConnection = new DBConnection();
        }

        public DataTable Select(string _playerName)
        {
            string query = "SELECT * FROM Player WHERE playerName = @playerName ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@playerName", SqlDbType.VarChar);
            sqlParameters[0].Value = _playerName;
            return dbConnection.ExecuteSelectQuery(query, sqlParameters);
        }

        public void Insert(string _playerName, string _password, int _coin)
        {
            string query = "INSERT INTO Player(playerName, password, coin) VALUES(@playerName, @password, @coin)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@playerName", SqlDbType.VarChar);
            sqlParameters[0].Value = _playerName;
            sqlParameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            sqlParameters[1].Value = _password;
            sqlParameters[2] = new SqlParameter("@coin", SqlDbType.VarChar);
            sqlParameters[2].Value = _coin;
            dbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

        public void Update(string _playerName, string _password, int _coin)
        {
            string query = "UPDATE Player SET playerName = @playerName, password = @password, coin = @coin " +
                "WHERE playerName = @playerName";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@playerName", SqlDbType.VarChar);
            sqlParameters[0].Value = _playerName;
            sqlParameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            sqlParameters[1].Value = _password;
            sqlParameters[2] = new SqlParameter("@coin", SqlDbType.VarChar);
            sqlParameters[2].Value = _coin;
            dbConnection.ExecuteInsertQuery(query, sqlParameters);
        }
    }
}
