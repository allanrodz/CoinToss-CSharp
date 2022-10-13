using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cointoss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******COIN TOSS**********\n");
            string guess;
            int ran;
            string result;

            Random r = new Random();
            ran = r.Next(1,3);

            Console.Write("Enter heads or tails: ");
            guess = Console.ReadLine();

            if (ran == 1 && guess == "heads")
            {
                Console.WriteLine("\nWell Done, you've won! The flip was \"heads\".");
            }

            else if (ran == 2 && guess == "tails")
            {
                Console.Write("\nWell done, you've won! the flip was \"tails\".");
            }
            else
            {
                if (ran == 1)
                {
                    result = "heads";
                }
                else
                {
                    result = "tails";              
                }
                Console.WriteLine("\nThe toss was \"{0}\" so you lose! too bad. better luck next time", result);
            }

            
            Console.ReadLine();

        }
    }
}
