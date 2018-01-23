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
            Random generator = new Random();
            int randInt = (generator.Next() % 100) + 1;

            Console.Out.WriteLine("I'm thinking of a number between 1 and 100");
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
