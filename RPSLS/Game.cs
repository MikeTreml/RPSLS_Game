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
            double bestOf = PickNumberOfRounds();
            double winningNumber = Math.Floor((bestOf / 2 + 1));
            int round = 0;
            Console.WriteLine("Since you picked best of " + bestOf + " rounds. One player needs to win " + winningNumber + " rounds before the game is complete");
            Console.WriteLine("\nany key to continue");
            Console.ReadLine();
            while (player1.numberOfWins < winningNumber && player2.numberOfWins < winningNumber)
            {
                Console.Clear();
                ScoreBoard(++round);
                gestures.DisplayMoves();
                DecideRoundWinner();
                ScoreBoard(round);
                WhoWon(winningNumber);
                Console.WriteLine("\nany key to continue");
                Console.ReadLine();
            }

        }

        public void CreatePlayers()
        {
            string name;
            int typeOfPlayer;
            int count = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Please enter name for player " + (i+1) + ": ");
                name = Console.ReadLine();
                Console.WriteLine("Is " + name + " \n1. Human player or \n2 AI ");
                typeOfPlayer = Human.InputVerification(1, 2, "Enter 1 for a human player, 2 for an AI: ");
                switch (typeOfPlayer + count)
                {
                    case 1:
                        player1 = new Human(name);
                        break;
                    case 2:
                        player1 = new AI(name);
                        break;
                    case 3:
                        player2 = new Human(name);
                        break;
                    case 4:
                        player2 = new AI(name);
                        break;
                }
                count += 2;
            }

        }
        
        public void DecideRoundWinner()
        {
            int concat = int.Parse(player1.ChooseGesture().ToString() + player2.ChooseGesture().ToString());
            Console.WriteLine(gestures.gestureResponseDictionary[concat].statement);
            this.player1.numberOfWins += gestures.gestureResponseDictionary[concat].player1Point;
            this.player2.numberOfWins += gestures.gestureResponseDictionary[concat].player2Point;
            roundTies += gestures.gestureResponseDictionary[concat].tiePoint;
        }

        public double PickNumberOfRounds()
        {
            return Human.InputVerification(3, 100, "Please choose the number of rounds: ");
        }
        public void WhoWon(double winningNumber)
        {
            string winnerName;
            if (player1.numberOfWins >= winningNumber || player2.numberOfWins >= winningNumber)
            {
                if (player1.numberOfWins >= winningNumber)
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
            }
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
