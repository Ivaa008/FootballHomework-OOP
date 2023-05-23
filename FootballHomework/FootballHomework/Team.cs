using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballHomework
{
    public class Team
    {
        public Coach Ferguson { get; set; }
        public List<FootballPlayer> Players { get; set; }

        //Average age of the players in the team
        public double AvarageAge()
        {
            int sum = 0;
            double avarage = 0; 
            foreach (var player in Players)
            {
                sum = sum + player.Age;
            }
            avarage = sum/Players.Count;
            return avarage;
        }
    }
}
