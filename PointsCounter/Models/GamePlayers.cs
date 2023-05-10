using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter.Models
{
    public class GamePlayers
    {
        private int id;
        private int gameId;
        private string playerName;
        private int playerPoints;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int GameId
        {
            get { return gameId; }
            set { gameId = value; }
        }
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public int PlayerPoints
        {
            get { return playerPoints; }
            set { playerPoints = value; }
        }

        public GamePlayers(int id, int gameId, string playerName, int playerPoints)
        {
            this.id = id;
            this.gameId = gameId;
            this.playerName = playerName;
            this.playerPoints = playerPoints;
        }
    }
}
