using System;
using System.Collections.Generic;
using NumLibrary;

namespace FindTheLargestNumber
{
    internal class Program
    {
                static void Main(string[] args)
        {
            List<int> NumberList = new List<int>(); //number list for user input

            //ask user input
            Console.WriteLine("Please enter your first integer: ");
            NumberList.Add(InputDiagnose());
            Console.Write("Please enter your second integer: ");
            NumberList.Add(InputDiagnose());

            // If user wants to input more than two numbers
            OptionFunction(NumberList);

            // Print out the result
            Console.WriteLine("The number in the list:");
            ArrayExtension arrayExtension = new ArrayExtension();
            int IntMax = arrayExtension.GetLargest(NumberList);
            Console.WriteLine("The largest number is :" + IntMax);
            Console.ReadKey();
        }

        
        private static int InputDiagnose()
        {   
            //declare values

            do
            {   
                var input = Console.ReadLine();
                //diagnose the input
                bool result = int.TryParse(input, out var Number);
                if (result)
                {   
                    //add values to list
                    return Number;
                }
                else
                {   
                    //false return
                    Console.WriteLine("Number between -2^31 and 2^31-1 ！");
                }
            } while (true);
        }
        private static void OptionFunction(List<int> list)
        {
            char option = ' ';
            do
            {
                Console.Write("Enter 'y' or 'Y' to enter more number, otherwise show the result.");
                var input = Console.ReadLine();
                //to match char
                if (input == null || input.Length != 1)
                {
                    Console.WriteLine("Need 1 character!");
                    continue;
                }
                option = Convert.ToChar(input);

                if (option == 'y' || option == 'Y')
                {
                    Console.Write("Enter your number : ");
                    list.Add(InputDiagnose());
                }
            } while (option == 'y'||option=='Y');
        }

    }
}