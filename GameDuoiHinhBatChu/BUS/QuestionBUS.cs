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
        //private DBConnection dbConnection;

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
            //dbConnection = new DBConnection();
        }

        public void InsertQuestionToDB(int _idQuestion, byte[] _imageQuestion, string _answerQuestion, int _idPlayer)
        {
            QuestionDAO.Instance.Insert(_idQuestion, _imageQuestion, _answerQuestion, _idPlayer);
        }

        public void UpdateQuestion(int _idQuestion, byte[] _imageQuestion, string _answerQuestion, int _idPlayer)
        {
            QuestionDAO.Instance.Update(_idQuestion, _imageQuestion, _answerQuestion, _idPlayer);
        }

        public QuestionDTO GetQuestionByIDPlayer(int _idPlayer)
        {
            QuestionDTO question = new QuestionDTO();
            DataTable dataTable = new DataTable();
            dataTable = QuestionDAO.Instance.Select(_idPlayer);

            foreach(DataRow dataRow in dataTable.Rows)
            {
                question.IDQuestion = Int32.Parse(dataRow["idQuestion"].ToString().Trim());
                question.ImageQuestion = (byte[])dataRow["imageQuestion"];
                question.AnswerQuestion = dataRow["answerQuestion"].ToString().Trim();
                question.IDPlayer = Int32.Parse(dataRow["idPlayer"].ToString().Trim());
            }
            return question;
        }
    }
}
