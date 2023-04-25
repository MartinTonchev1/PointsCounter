using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter.Classes
{
    public class Games
    {
        private string id;
        private string name;
        private DateTime startDate;
        private DateTime endDate;
        private string winnerId;

        public string Id
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
    }
}
