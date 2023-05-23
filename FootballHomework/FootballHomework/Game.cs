using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballHomework
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<AssistantReferee> assistantReferees { get; set; }
        public string GameResult { get; set; }
        public Team Winner { get; set; }

    }
}
