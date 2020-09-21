using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member Variables 
        Gestures gestures;
        Player player1;
        Player player2;
        int roundTies = 0;
        
        //Constructor
        public Game()
        {


        }

        //member methods
        public void RunGame()
        {
            gestures = new Gestures();
            player1 = new Human("Bob");
            player2 = new AI("Tom");
            Intro();
            //menu
            ChoosingPlayers();
            //loop
            int numberOfRounds = PickNumberOfRounds();
            int winningPoint = numberOfRounds/2+1;
            while (true)
            {
                ScoreBoard();
                gestures.DisplayMoves();
                DecideRoundWinner(player1.ChooseGesture(), player2.ChooseGesture());
                
            } 
            




        }
        public void ChoosingPlayers()
        {
            player1 = new Human("Bob");
            player2 = new AI("R2D2");
        }
        public void Intro()
        {
            Console.WriteLine("Welcome");

        }
        public void DecideRoundWinner(int player1Gesture,int player2Gesture)
        {
            int concat = int.Parse(player1Gesture.ToString() + player2Gesture.ToString());
            Console.WriteLine(gestures.gestureResponceDictionary[concat].statement);
            this.player1.numberOfWins += gestures.gestureResponceDictionary[concat].player1Point;
            this.player2.numberOfWins += gestures.gestureResponceDictionary[concat].player2Point;
            roundTies += gestures.gestureResponceDictionary[concat].tiePoint;
        }
        public void ScoreBoard()
        {
            Console.WriteLine("*** Score Board ***");
            Console.WriteLine("-------------------");
            Console.WriteLine(player1.name+"\t\t" + player1.numberOfWins);
            Console.WriteLine(player2.name + "\t\t" + player2.numberOfWins);
            Console.WriteLine("Tied rounds \t " + roundTies);
            Console.WriteLine("-------------------");
        }
        public int PickNumberOfRounds()
        {
            return Human.InputVerification(3, 100, "Please choose the number of rounds: ");
        }
    }
}
