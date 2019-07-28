using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuestionDAO
    {
        private DBConnection dbConnection;
        private static QuestionDAO instance;

        public static QuestionDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuestionDAO();
                return instance;
            }
        }

        public QuestionDAO()
        {
            dbConnection = new DBConnection();
        }

        public DataTable Select(string _playerName)
        {
            string query = "SELECT * FROM Question WHERE playerName = @playerName ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@playerName", SqlDbType.VarChar);
            sqlParameters[0].Value = _playerName;
            return dbConnection.ExecuteSelectQuery(query, sqlParameters);
        }

        public void Insert(string _ordinalOfQuestion, byte[] _imageOfQuestion, string _answerOfQuestion, string _playerName)
        {
            string query = "INSERT INTO Question(ordinalOfQuestion, imageOfQuestion, answerOfQuestion, playerName) " +
                "VALUES(@ordinalOfQuestion, @imageOfQuestion, @answerOfQuestion, @playerName)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@ordinalOfQuestion", SqlDbType.VarChar);
            sqlParameters[0].Value = _ordinalOfQuestion;
            sqlParameters[1] = new SqlParameter("@imageOfQuestion", SqlDbType.Image);
            sqlParameters[1].Value = _imageOfQuestion;
            sqlParameters[2] = new SqlParameter("@answerOfQuestion", SqlDbType.VarChar);
            sqlParameters[2].Value = _answerOfQuestion;
            sqlParameters[3] = new SqlParameter("@playerName", SqlDbType.VarChar);
            sqlParameters[3].Value = _playerName;
            dbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

        public void Update(string _ordinalOfQuestion, byte[] _imageOfQuestion, string _answerOfQuestion, string _playerName)
        {
            string query = "UPDATE Question SET ordinalOfQuestion = @ordinalOfQuestion, imageOfQuestion = @imageOfQuestion, answerOfQuestion = @answerOfQuestion, playerName = @playerName " +
                "WHERE playerName = @playerName";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@ordinalOfQuestion", SqlDbType.VarChar);
            sqlParameters[0].Value = _ordinalOfQuestion;
            sqlParameters[1] = new SqlParameter("@imageOfQuestion", SqlDbType.Image);
            sqlParameters[1].Value = _imageOfQuestion;
            sqlParameters[2] = new SqlParameter("@answerOfQuestion", SqlDbType.VarChar);
            sqlParameters[2].Value = _answerOfQuestion;
            sqlParameters[3] = new SqlParameter("@playerName", SqlDbType.VarChar);
            sqlParameters[3].Value = _playerName;
            dbConnection.ExecuteInsertQuery(query, sqlParameters);
        }
    }
}
