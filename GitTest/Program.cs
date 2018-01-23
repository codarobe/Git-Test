using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Enter a lower bound.");
            int lower = System.Int32.Parse(Console.ReadLine());

            Console.Out.WriteLine("Enter an upper bound.");
            int upper = System.Int32.Parse(Console.ReadLine());

            Random generator = new Random();
            int randInt = (generator.Next() % (upper-lower + 1)) + lower;

            Console.Out.WriteLine("I'm thinking of a number between {0} and {1}", lower, upper);
            Console.Out.WriteLine("Please enter your guess below.");
            
            // Retrieve initial user input
            int guess = System.Int32.Parse(Console.ReadLine());

            int guessCount = 1;

            while (guess != randInt)
            {
                // Provide the user a hint
                if (guess > randInt)
                {
                    Console.Out.WriteLine("Too high.  Try again.");
                }
                else
                {
                    Console.Out.WriteLine("Too low.  Try again.");
                }

                // Retrieve next user input
                guess = System.Int32.Parse(Console.ReadLine());
                guessCount++;
            }

            Console.Out.WriteLine("Congratulations!  You got it right in {0} tries.", guessCount);

            // pause before exit
            Console.In.ReadLine();
            
        }
    }
}
