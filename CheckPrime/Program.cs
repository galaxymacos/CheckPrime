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
            Console.WriteLine("Welcome to using prime checker");
            do
            {
                int testNumber = GetUserInput();
                CheckIfInputIsPrime(testNumber);
            } while (DoesUserWantToContinue());
            
            Console.WriteLine("Bye");
            Console.ReadKey();
        }

        private static bool DoesUserWantToContinue()
        {
            Console.WriteLine("Do you want to continue? Y/N");
            var isContinued = Console.ReadKey(true);
            return isContinued.Key == ConsoleKey.Y;
        }

        private static void CheckIfInputIsPrime(int userInput)
        {
            var solution = new Solution();
            bool result = solution.IsPrimeMap(userInput);
            Console.WriteLine($"{userInput} is " + (result ? "" : "not ") + "a prime number");
        }

        private static int GetUserInput()
        {
            do
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                bool isSucceed = int.TryParse(userInput,out int result);
                if (isSucceed) return result;
                Console.WriteLine("Not accepted");

//                try
//                {
//                    int num = Convert.ToInt32(userInput);
//                    return num;
//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine("Your input is not a number");
//                }
//                catch (OverflowException)
//                {
//                    Console.WriteLine("Your number is too big to calculate");
//                }
            } while (true);
        }
    }
}