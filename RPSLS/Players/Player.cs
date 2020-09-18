using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //member Variables 
        public string name;
        public int move;
        public int numberOfWins;
        
        //Constructor
        public Player(string name)
        {
            this.name = name;
            int move;
            int numberOfWins = 0;
            
        }
        //member methods
        public abstract int ChooseGesture();

    }
}
