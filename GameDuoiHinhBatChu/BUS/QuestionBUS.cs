using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class QuestionBUS
    {
        private DBConnection dbConnection;

        private static QuestionBUS instance;

        public static QuestionBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuestionBUS();
                return instance;
            }
        }

        public QuestionBUS()
        {
            dbConnection = new DBConnection();
        }

        public void SaveQuestionToDB(string _ordinalOfQuestion, byte[] _imageOfQuestion, string _answerOfQuestion, string _playerName)
        {
            QuestionDAO.Instance.Insert(_ordinalOfQuestion, _imageOfQuestion, _answerOfQuestion, _playerName);
        }

        public void UpdateQuestion(string _ordinalOfQuestion, byte[] _imageOfQuestion, string _answerOfQuestion, string _playerName)
        {
            QuestionDAO.Instance.Update(_ordinalOfQuestion, _imageOfQuestion, _answerOfQuestion, _playerName);
        }

        public QuestionDTO GetQuestionByPlayerName(string _playerName)
        {
            QuestionDTO question = new QuestionDTO();
            DataTable dataTable = new DataTable();
            dataTable = QuestionDAO.Instance.Select(_playerName);

            foreach(DataRow dataRow in dataTable.Rows)
            {
                question.OrdinalOfQuestion = Int32.Parse(dataRow["ordinalOfQuestion"].ToString().Trim());
                question.ImageOfQuestion = (byte[])dataRow["imageOfQuestion"];
                question.AnswerOfQuestion = dataRow["answerOfQuestion"].ToString().Trim();
                question.PlayerName = dataRow["playerName"].ToString().Trim();
            }
            return question;
        }
    }
}
