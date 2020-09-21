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
        public IDictionary<int, GestureResponse> gestureResponseDictionary;
        //Constructor
        public Gestures()
        {
            gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizzard", "Spock" };
            
            //simplifing the input into digits. first digit reresents the player1's responce. second digit is player2. 1 is for Rock,2 for Paper,3 for Scissor, 
            //4 for lizzard and 5 for Spock.
            //I felt that this was a better way toget the resopnce using about 20 lines of code vs around 100 for switch statement.
            gestureResponseDictionary = new Dictionary<int, GestureResponse>()
            {
                { 11, new GestureResponse("Tie, rock vs rock", 0, 0, 1) },// the string is the statement, first int i a point for player 1 second int is a point for player two and the last in is for a tie
                { 12, new GestureResponse("Rock is covered by paper.", 0, 1, 0) },
                { 13, new GestureResponse("Rock samshes scissors.", 1, 0, 0) },
                { 14, new GestureResponse("Rock crushes lizard.", 1, 0, 0) },
                { 15, new GestureResponse("Rock is vaporized by Spock.", 0, 1, 0) },
                { 21, new GestureResponse("Paper Covers rock.", 1, 0, 0) },
                { 22, new GestureResponse("Tie, paper vs paper", 0, 0, 1) },
                { 23, new GestureResponse("Paper is cut by scissors", 0, 1, 0) },
                { 24, new GestureResponse("Paper is eaten by lizard.", 0, 1, 0) },
                { 25, new GestureResponse("Paper disproves Spock.", 1, 0, 0) },
                { 31, new GestureResponse("Scissors is smash by rock.", 0, 1, 0) },
                { 32, new GestureResponse("Scissors cuts paper.", 1, 0, 0) },
                { 33, new GestureResponse("Tie, scissor vs scissor", 0, 0, 1) },
                { 34, new GestureResponse("Scissors decapitates lizard.", 1, 0, 0) },
                { 35, new GestureResponse("Scissors is smashed by Spock", 0, 1, 0) },
                { 41, new GestureResponse("Lizard is crushed by rock.", 0, 1, 0) },
                { 42, new GestureResponse("Lizard eats paper.", 1, 0, 0) },
                { 43, new GestureResponse("Lizard is decapitated by scissors", 0, 1, 0) },
                { 44, new GestureResponse("Tie, lizard vs lizard", 0, 0, 1) },
                { 45, new GestureResponse("Lizard poisons Spock", 1, 0, 0) },
                { 51, new GestureResponse("Spock vaporizes rock", 1, 0, 0) },
                { 52, new GestureResponse("Spock smashes scissors", 1, 0, 0) },
                { 53, new GestureResponse("Spock is disproven by paper", 0, 1, 0) },
                { 54, new GestureResponse("Spock is poisened by lizard", 0, 1, 0) },
                { 55, new GestureResponse("Tie. Two spocks! Someone is playing with an artificial black hole.", 0, 0, 1) }
            };
        }
        //member methods
        public void DisplayMoves()
        {
            int count = 1;
            foreach (string item in gestures)
            {
                Console.WriteLine(count + " " + item);
                count++;
            }

        }
       
    }
}
