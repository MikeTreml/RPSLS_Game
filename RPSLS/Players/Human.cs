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
            return InputVerification(1, 5, name + " please select you gester: ");
        }

        //member methods
        public static int InputVerification(int min, int max, string prompt)
        {
            int g;
            Console.Write(prompt);
            do
            {
                if (int.TryParse(Console.ReadLine(), out g))
                {
                    if (g >= min && g <= max)
                        return (g);
                    Console.WriteLine("You entered " + g + ", but your choices are (" + min + " - " + max + ". Please try again...");
                }
                else
                    Console.WriteLine("That is not a real number. Please try again...");
            } while (true);
        }

    }
}
