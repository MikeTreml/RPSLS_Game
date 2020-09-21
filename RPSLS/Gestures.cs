using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gestures
    {
        //member Variables 
        public List<string> gestures;
        public IDictionary<int, GesterResponce> gestureResponceDictionary;
        //Constructor
        public Gestures()
        {
            gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizzard", "Spock" };
            
            //simplifing the input into digits. first digit reresents the player1's responce. second digit is player2. 1 is for Rock,2 for Paper,3 for Scissor, 
            //4 for lizzard and 5 for Spock.
            gestureResponceDictionary = new Dictionary<int, GesterResponce>()
            {
                { 11, new GesterResponce("Tie, rock vs rock", 0, 0, 1) },
                { 12, new GesterResponce("Rock is covered by paper.", 0, 1, 0) },
                { 13, new GesterResponce("Rock samshes scissors.", 1, 0, 0) },
                { 14, new GesterResponce("Rock crushes lizard.", 1, 0, 0) },
                { 15, new GesterResponce("Rock is vaporized by Spock.", 0, 1, 0) },
                { 21, new GesterResponce("Paper Covers rock.", 1, 0, 0) },
                { 22, new GesterResponce("Tie, paper vs paper", 0, 0, 1) },
                { 23, new GesterResponce("Paper is cut by scissors", 0, 1, 0) },
                { 24, new GesterResponce("Paper is eaten by lizard.", 0, 1, 0) },
                { 25, new GesterResponce("Paper disproves Spock.", 1, 0, 0) },
                { 31, new GesterResponce("Scissors is smash by rock.", 0, 1, 0) },
                { 32, new GesterResponce("Scissors cuts paper.", 1, 0, 0) },
                { 33, new GesterResponce("Tie, scissor vs scissor", 0, 0, 1) },
                { 34, new GesterResponce("Scissors decapitates lizard.", 1, 0, 0) },
                { 35, new GesterResponce("Scissors is smashed by Spock", 0, 1, 0) },
                { 41, new GesterResponce("Lizard is crushed by rock.", 0, 1, 0) },
                { 42, new GesterResponce("Lizard eats paper.", 1, 0, 0) },
                { 43, new GesterResponce("Lizard is decapitated by scissors", 0, 1, 0) },
                { 44, new GesterResponce("Tie, lizard vs lizard", 0, 0, 1) },
                { 45, new GesterResponce("Lizard poisons Spock", 1, 0, 0) },
                { 51, new GesterResponce("Spock vaporizes rock", 1, 0, 0) },
                { 52, new GesterResponce("Spock smashes scissors", 1, 0, 0) },
                { 53, new GesterResponce("Spock is disproven by paper", 0, 1, 0) },
                { 54, new GesterResponce("Spock is poisened by lizard", 0, 1, 0) },
                { 55, new GesterResponce("Tie. Two spocks! Someone is playing with an artificial black hole.", 0, 0, 1) }
            };


        }
        //member methods


        //Not sure why this not pullling 
        public void DisplayMoves()
        {
            int count = 1;
            foreach (string item in gestures)
            {
                Console.WriteLine(count + " " + item);
                count++;
            }

        }
        public string RoundWinner(int move)
        {
            IDictionary<int, string> gestureResponce = new Dictionary<int, string>();

            string statement = "";
            switch (move)
            {

            }
            return statement;

        }
    }
}
