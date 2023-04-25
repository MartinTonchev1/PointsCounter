using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter.Classes
{
    internal class GamePlayers
    {
        private string id;
        private string gameId;
        private string playerName;
        private int playerPoints;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string GameId
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
    }
}
