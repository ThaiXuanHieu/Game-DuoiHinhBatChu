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

        public DataTable Select(int _idPlayer)
        {
            string query = "SELECT * FROM Question WHERE idPlayer = @idPlayer ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@idPlayer", SqlDbType.VarChar);
            sqlParameters[0].Value = _idPlayer;
            return dbConnection.ExecuteSelectQuery(query, sqlParameters);
        }

        public void Insert(int _idQuestion, string _imageQuestion, string _answerQuestion, int _idPlayer)
        {
            string query = "INSERT INTO Question(idQuestion, imageQuestion, answerQuestion, idPlayer) " +
                "VALUES(@idQuestion, @imageQuestion, @answerQuestion, @idPlayer)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@idQuestion", SqlDbType.VarChar);
            sqlParameters[0].Value = _idQuestion;
            sqlParameters[1] = new SqlParameter("@imageQuestion", SqlDbType.NVarChar);
            sqlParameters[1].Value = _imageQuestion;
            sqlParameters[2] = new SqlParameter("@answerQuestion", SqlDbType.VarChar);
            sqlParameters[2].Value = _answerQuestion;
            sqlParameters[3] = new SqlParameter("@idPlayer", SqlDbType.VarChar);
            sqlParameters[3].Value = _idPlayer;
            dbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

        public void Update(int _idQuestion, string _imageQuestion, string _answerQuestion, int _idPlayer)
        {
            string query = "UPDATE Question SET idQuestion = @idQuestion, imageQuestion = @imageQuestion, answerQuestion = @answerQuestion " +
                "WHERE idPlayer = @idPlayer";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@idQuestion", SqlDbType.VarChar);
            sqlParameters[0].Value = _idQuestion;
            sqlParameters[1] = new SqlParameter("@imageQuestion", SqlDbType.NVarChar);
            sqlParameters[1].Value = _imageQuestion;
            sqlParameters[2] = new SqlParameter("@answerQuestion", SqlDbType.VarChar);
            sqlParameters[2].Value = _answerQuestion;
            sqlParameters[3] = new SqlParameter("@idPlayer", SqlDbType.VarChar);
            sqlParameters[3].Value = _idPlayer;
            dbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }
    }
}
