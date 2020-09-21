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
        public int numberOfWins;
        
        //Constructor
        public Player(string name)
        {
            this.name = name;
            this.numberOfWins = 0;
            
        }
        //member methods
        public abstract int ChooseGesture();

    }
}
