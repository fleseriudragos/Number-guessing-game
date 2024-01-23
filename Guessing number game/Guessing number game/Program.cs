using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random(); ;
            int numarcastig = random.Next(0, 1000);
            bool corect = false;
            Console.WriteLine("Guess a number between 0 and 1000: ");
            string ghicittxt = Console.ReadLine();
            int ghicit = int.Parse(ghicittxt);
            if (ghicit == numarcastig) Console.WriteLine("You are correct from the start. The correct number is " + numarcastig);
            else do
                {
                    if (ghicit == numarcastig) { Console.WriteLine("You are correct. The correct number is " + numarcastig);
                                                 corect = true; }
                    else if (numarcastig > ghicit) Console.WriteLine("Your number is too small. Please guess again.");
                    else Console.WriteLine("Your number is too big. Please guess again.");
                    ghicittxt= Console.ReadLine();
                    ghicit= int.Parse(ghicittxt);

                } while (corect != true);
        }
    }
}