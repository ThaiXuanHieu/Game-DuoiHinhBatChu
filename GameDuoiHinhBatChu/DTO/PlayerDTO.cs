using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PlayerDTO
    {
        private int _idPlayer;
        private string _playerName;
        private string _password;
        private int _coin;

        public PlayerDTO()
        {

        }

        public int IDPlayer
        {
            get { return _idPlayer; }
            set { _idPlayer = value; }
        }

        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int Coin
        {
            get { return _coin; }
            set { _coin = value; }
        }
    }
}
