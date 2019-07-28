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
        private int _ordinalOfQuestion;
        private byte[] _imageOfQuestion;
        private string _answerOfQuestion;
        private string _playerName;

        public QuestionDTO()
        {

        }

        public int OrdinalOfQuestion
        {
            get { return _ordinalOfQuestion; }
            set { _ordinalOfQuestion = value; }
        }

        public byte[] ImageOfQuestion
        {
            get { return _imageOfQuestion; }
            set { _imageOfQuestion = value; }
        }

        public string AnswerOfQuestion
        {
            get { return _answerOfQuestion; }
            set { _answerOfQuestion = value; }
        }

        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

    }
}
