﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            //thread.sleep was set to prevent AI vs AI to always tie.
            Thread.Sleep(18);
            int c;
            random = new Random();
            c = random.Next(1, 5);
            Console.WriteLine(name + " please select you gester: "+c);
            
            return c;
        }
    }
}
