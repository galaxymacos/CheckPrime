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
            Solution solution = new Solution();
            bool result = solution.IsPrime(17);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
