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
                        Console.WriteLine($"{num} = {i} * {j}");
                        return false;
                    }
                }
                
            }

            Console.WriteLine($"{num} is not a prime number");
            return true;
        }
        public bool IsPrimeMap(int num) // O(n)
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

        public int CountPrimes(int n)
        {
            int count = 0;
            List<int> primes = new List<int>();
            for (int i = 2; i < n; i++)
            {
                bool isEven = false;
                foreach (int prime in primes)
                {
                    if (i % prime == 0)
                    {
                        isEven = true;
                        break;
                    }
                }
                if (!isEven)
                {
                    primes.Add(i);
                    count++;
                }
            }
            return count;
        }

    }
}