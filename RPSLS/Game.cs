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
        int roundTies;


        //Constructor
        public Game()
        {
        }

        //member methods
        public void RunGame()
        {
            gestures = new Gestures();
            bool exit = true;
            do
            {
                switch (Menu())
                {
                    case 1:
                        Rules();
                        break;
                    case 2:
                        PlayGame();
                        break;
                    case 3:
                        exit = false;
                        break;
                }
            } while (exit);

        }
        public void PlayGame()
        {
            roundTies = 0;

            CreatePlayers();
            double winningPoint = Math.Floor((PickNumberOfRounds() / 2 + 1));
            int round = 0;
            while (player1.numberOfWins < winningPoint && player2.numberOfWins < winningPoint)
            {
                Console.Clear();
                ScoreBoard(++round);
                gestures.DisplayMoves();
                DecideRoundWinner();
                ScoreBoard(round);
                Console.WriteLine("\nany key to continue");
                //Console.ReadLine();
            }
            Console.Clear();
            ScoreBoard(round);
            WhoWon();
        }

        public void CreatePlayers()
        {
            string name;
            int typeOfPlayer;
            Console.Write("Please enter name for player 1: ");
            name = Console.ReadLine();
            Console.WriteLine("Is " + name + " \n1. Human player or \n2 AI ");
            typeOfPlayer = Human.InputVerification(1, 2, "Enter 1 for a human player, 2 for an AI: ");
            switch (typeOfPlayer)
            {
                case 1:
                    player1 = new Human(name);
                    break;
                case 2:
                    player1 = new AI(name);
                    break;
            }
            Console.Write("Please enter name for player 2: ");
            name = Console.ReadLine();
            Console.WriteLine("Is " + name + " \n1. a human player or \n2  an AI? ");
            typeOfPlayer = Human.InputVerification(1, 2, "Enter 1 for a human player, 2 for an AI: ");
            switch (typeOfPlayer)
            {
                case 1:
                    player2 = new Human(name);
                    break;
                case 2:
                    player2 = new AI(name);
                    break;
            }
        }
        
                
        

        public void DecideRoundWinner()
        {
            int concat = int.Parse(player1.ChooseGesture().ToString() + player2.ChooseGesture().ToString());
            Console.WriteLine(gestures.gestureResponceDictionary[concat].statement);
            this.player1.numberOfWins += gestures.gestureResponceDictionary[concat].player1Point;
            this.player2.numberOfWins += gestures.gestureResponceDictionary[concat].player2Point;
            roundTies += gestures.gestureResponceDictionary[concat].tiePoint;
        }

        public double PickNumberOfRounds()
        {
            return Human.InputVerification(3, 100, "Please choose the number of rounds: ");
        }
        public void WhoWon()
        {
            string winnerName;
            if (player1.numberOfWins > player2.numberOfWins)
            {
                winnerName = player1.name;
            }
            else
            {
                winnerName = player2.name;
            }

            Console.WriteLine("\n*** Winner ***");
            Console.WriteLine("-------------------\n");
            Console.WriteLine(winnerName + " won this game.");
            Console.WriteLine("\n-------------------");
            Console.ReadLine();
        }
        public int Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Rock, Paper, Sciccor, Lizard, Spock");
            Console.WriteLine("\n*** Menu ***");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Rules");
            Console.WriteLine("2. Play Game");
            Console.WriteLine("3. Exit");
            return Human.InputVerification(1, 3, "Pick a menu item: ");
        }

        public void Rules()
        {
            Console.Clear();
            Console.WriteLine("This game is just like rock paper scissors but with two more elements to the game.\n");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("\nPress any key to go back to the main menu.");
            Console.ReadLine();

        }
        public void ScoreBoard(int round)
        {
            Console.WriteLine("\n*** Score Board (Round " + round + ") ***");
            Console.WriteLine("-------------------");
            Console.WriteLine(player1.name + "\t\t" + player1.numberOfWins);
            Console.WriteLine(player2.name + "\t\t" + player2.numberOfWins);
            Console.WriteLine("Tied rounds \t " + roundTies);
            Console.WriteLine("-------------------");
        }
    }
}
