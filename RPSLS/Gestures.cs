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
        public List<string> gestures;
        //Constructor
        public Gestures()
        {
            gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizzard", "Spock" };
        }
        //member methods


        //Not sure why this not pullling 
        public void DisplayMoves(string name)
        {
            int count = 1;
            foreach (string item in gestures)
            {
                Console.WriteLine(count + " " + item);
                count++;
            }

        }
        
    }
}
