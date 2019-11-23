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

        public DataTable Select(int _idPlayer)
        {
            string query = "SELECT * FROM Player WHERE idPlayer = @idPlayer ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@idPlayer", SqlDbType.VarChar);
            sqlParameters[0].Value = _idPlayer;
            return dbConnection.ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable Select(string _email, string _password)
        {
            string query = "SELECT * FROM Player WHERE email = @email AND password = @password";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[0].Value = _email;
            sqlParameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            sqlParameters[1].Value = _password;
            return dbConnection.ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable Select(string _email)
        {
            string query = "SELECT * FROM Player WHERE email = @email";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[0].Value = _email;
            return dbConnection.ExecuteSelectQuery(query, sqlParameters);
        }

        public void Insert(string _email, string _password, int _coin)
        {
            string query = "INSERT INTO Player(email, password, coin) VALUES(@email, @password, @coin)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[0].Value = _email;
            sqlParameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            sqlParameters[1].Value = _password;
            sqlParameters[2] = new SqlParameter("@coin", SqlDbType.VarChar);
            sqlParameters[2].Value = _coin;
            dbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

        public void Update(int _idPlayer, int _coin)
        {
            string query = "UPDATE Player SET coin = @coin WHERE idPlayer = @idPlayer";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            
            sqlParameters[0] = new SqlParameter("@coin", SqlDbType.Int);
            sqlParameters[0].Value = _coin;
            sqlParameters[1] = new SqlParameter("@idPlayer", SqlDbType.Int);
            sqlParameters[1].Value = _idPlayer;
            dbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }

        public void Update(string _email, string _password)
        {
            string query = "UPDATE Player SET password = @password WHERE email = @email";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@password", SqlDbType.VarChar);
            sqlParameters[0].Value = _password;
            sqlParameters[1] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[1].Value = _email;
            dbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }
    }
}
