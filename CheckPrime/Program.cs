using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = GetUserInput();
            var solution = new Solution();
            var result = solution.IsPrimeMap(userInput);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static int GetUserInput()
        {
            do
            {
                var userInput = Console.ReadLine();
                try
                {
                    int num = Convert.ToInt32(userInput);
                    return num;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Your input is not a number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Your number is too big to calculate");
                }
            } while (true);
        }
    }
}