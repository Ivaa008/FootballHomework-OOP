using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballHomework
{
    public abstract class FootballPlayer : Person
    {
        //public string Name { get; set; }
        public int Number { get; set; }
        //public int Age { get; set; }
        public double Height { get; set; }
    }
}
