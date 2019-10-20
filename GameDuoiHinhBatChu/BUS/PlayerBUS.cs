using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace BUS
{
    public class PlayerBUS
    {
        //private DBConnection dbConnection;

        private static PlayerBUS instance;

        public static PlayerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PlayerBUS();
                return instance;
            }
        }

        public PlayerBUS()
        {
            //dbConnection = new DBConnection();
        }


        public PlayerDTO GetPlayerByIDPlayer(int _idPlayer)
        {
            PlayerDTO player = new PlayerDTO();
            DataTable dataTable = new DataTable();
            dataTable = PlayerDAO.Instance.Select(_idPlayer);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                player.IDPlayer = Int32.Parse(dataRow["idPlayer"].ToString().Trim());
                player.PlayerName = dataRow["playerName"].ToString().Trim();
                player.Password = dataRow["password"].ToString().Trim();
                player.Coin = Int32.Parse(dataRow["coin"].ToString());
            }
            return player;
        }

        public PlayerDTO GetPlayerByPlayerName(string _playerName)
        {
            PlayerDTO player = new PlayerDTO();
            DataTable dataTable = new DataTable();
            dataTable = PlayerDAO.Instance.Select(_playerName);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                player.IDPlayer = Int32.Parse(dataRow["idPlayer"].ToString().Trim());
                player.PlayerName = dataRow["playerName"].ToString().Trim();
                player.Password = dataRow["password"].ToString().Trim();
                player.Coin = Int32.Parse(dataRow["coin"].ToString());
            }
            return player;
        }

        public void InsertPlayerToDB(string _playerName, string _password, int _coin)
        {
            PlayerDAO.Instance.Insert(_playerName, _password, _coin);
        }

        public void UpdatePlayer(int _idPlayer, string _playerName, string _password, int _coin)
        {
            PlayerDAO.Instance.Update(_idPlayer, _playerName, _password, _coin);
        }

        
    }
}
