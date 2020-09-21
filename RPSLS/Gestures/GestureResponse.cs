using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GestureResponse
    {
        //member Variables 
        public string statement;
        public int player1Point;
        public int player2Point;
        public int tiePoint;
        //Constructor
        public GestureResponse(string statement, int player1Point, int player2Point, int tiePoint)
        {
            this.statement = statement;
            this.player1Point = player1Point;
            this.player2Point = player2Point;
            this.tiePoint = tiePoint;
                           
        }
        //member methods
    }
   
}
