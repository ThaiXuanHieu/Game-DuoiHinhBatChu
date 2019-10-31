using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuestionDTO
    {
        private int _idQuestion;
        private string _imageQuestion;
        private string _answerQuestion;
        private int _idPlayer;

        public QuestionDTO()
        {

        }

        public int IDQuestion
        {
            get { return _idQuestion; }
            set { _idQuestion = value; }
        }

        public string ImageQuestion
        {
            get { return _imageQuestion; }
            set { _imageQuestion = value; }
        }

        public string AnswerQuestion
        {
            get { return _answerQuestion; }
            set { _answerQuestion = value; }
        }

        public int IDPlayer
        {
            get { return _idPlayer; }
            set { _idPlayer = value; }
        }

    }
}
