using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

    class Gestures
    {
        //member Variables 
        public List<string> gesters;
        //Constructor
        public Gestures()
        {
            gesters = new List<string>();
            gesters.Add("Rock");
            gesters.Add("Paper");
            gesters.Add("Scissors");
            gesters.Add("Lizzard");
            gesters.Add("Spock");

        }
        //member methods
    }
}
