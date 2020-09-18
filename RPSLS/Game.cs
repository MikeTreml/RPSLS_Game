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
            ChoosingPlayers();
            DisplayMoves(player1.name);
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

        public void DisplayMoves(string name)
        {
            int count = 1;
            foreach (string item in gestures.gestures)
            {
                Console.WriteLine(count + " " + item);
                count++;
            }
            Console.WriteLine(name + " please select you gester: ");
        }
    }
}
