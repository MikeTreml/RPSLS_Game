using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        //member Variables 
        Random random;
        //Constructor
        public AI(string name)
            : base(name)
        {

        }
        //member methods
       
        public override int ChooseGesture()
        {
            Console.WriteLine(name + " please select you gester: ");
            return random.Next(1,5);
        }
    }
}
