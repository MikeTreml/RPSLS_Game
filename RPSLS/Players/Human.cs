using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        //member Variables 

        //Constructor
        public Human(string name) 
            : base(name)
        {
                
        }

        public override int ChooseGesture()
        {
            Console.WriteLine(name + " please select you gester: ");
            return int.Parse(Console.ReadLine());
        }

        //member methods
       

    }
}
