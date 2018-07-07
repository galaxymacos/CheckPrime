using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckPrime
{
    public class Solution
    {
        public bool IsPrime(int num)    // O(n^2)
        {
            for (int i = 2; i < num-1; i++)
            {
                for (int j = i; j < num-1; j++)
                {
                    if (num == i * j) 
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }
        public bool IsPrimeMap(int num) // O(sqrt(n))
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}