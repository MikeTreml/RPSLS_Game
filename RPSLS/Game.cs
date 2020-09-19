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
            gestures.DisplayMoves(player1.name);
            player1.move = player1.ChooseGesture() - 1;

            gestures.DisplayMoves(player2.name);
            player2.move = player2.ChooseGesture() - 1;

            Console.WriteLine(1);
            Console.WriteLine(2);
            string statement = RoundWinner(14);
            if (statement.Contains(" by ") == true)
            {
                player2.numberOfWins += 1;
                Console.WriteLine(statement + "\n" + player2.name + " wins this round.");
            }
            else if(statement.Contains("Tie") == true)
            {
                Console.WriteLine(statement+"\nNo one wins this round.");
            }
            else
            {
                player1.numberOfWins += 1;
                Console.WriteLine(statement + "\n" + player1.name + " wins this round.");
            }

            Console.ReadLine();




        }
        public void ChoosingPlayers()
        {
            //request input for computer player or human
            //request for a name

            player1 = new Human("Bob");
            player2 = new AI("R2D2");
        }
        public void Intro()
        {
            Console.WriteLine("Welcome");

        }
        public string RoundWinner(int move)
        {
            string statement = "";
            switch (move)
            {
                case 12:
                    statement = "Rock is covered by paper.";///2
                    break;
                case 13:
                    statement = "Rock samshes scissors.";
                    break;
                case 14:
                    statement = "Rock crushes lizard.";
                    break;
                case 15:
                    statement = "Rock is vaporized by Spock.";//2
                    break;
                case 21:
                    statement = "Paper Covers rock.";
                    break;
                case 23:
                    statement = "Paper is cut by scissors";//2
                    break;
                case 24:
                    statement = "Paper is eaten by lizard.";//2
                    break;
                case 25:
                    statement = "Paper disproves Spock.";
                    break;
                case 31:
                    statement = "Scissors is smash by rock.";//2
                    break;
                case 32:
                    statement = "Scissors cuts paper.";
                    break;
                case 34:
                    statement = "Scissors decapitates lizard.";
                    break;
                case 35:
                    statement = "Scissors is smashed by Spock";//2
                    break;
                case 41:
                    statement = "Lizard is crushed by rock.";//2
                    break;
                case 42:
                    statement = "Lizard eats paper.";
                    break;
                case 43:
                    statement = "Lizard is decapitated by scissors";//2
                    break;
                case 45:
                    statement = "Lizard poisons Spock";
                    break;
                case 51:
                    statement = "Spock vaporizes rock";
                    break;
                case 52:
                    statement = "Spock smashes scissors";
                    break;
                case 53:
                    statement = "Spock is disproven by paper";//2
                    break;
                case 54:
                    statement = "Spock is poisened by lizard";//2
                    break;
                case 11:
                    statement = "Tie, rock vs rock";
                    break;
                case 22:
                    statement = "Tie, paper vs paper";
                    break;
                case 33:
                    statement = "Tie, scissor vs scissor";
                    break;
                case 44:
                    statement = "Tie, lizard vs lizard";
                    break;
                case 55:
                    statement = "Tie. Two spocks! Someone is playing with an artificial black hole. ";
                    break;
            }
            return statement;

        }

    }
}
