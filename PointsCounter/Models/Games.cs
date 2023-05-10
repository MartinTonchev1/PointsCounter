using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter.Models
{
    public class Games
    {
        private int id;
        private string name;
        private DateTime startDate;
        private DateTime endDate;
        private string winnerId;
        private List<GamePlayers> gamePlayers = new List<GamePlayers>();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string WinnerId
        {
            get { return winnerId; }
            set { winnerId = value; }
        }
        public List<GamePlayers> GamePlayers
        {
            get { return gamePlayers; }
            set { gamePlayers = value; }
        }
    }
}
