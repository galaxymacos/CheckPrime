using System;
using System.Collections.Generic;

namespace NumLibrary
{
    public class ArrayExtension
    {
        public int GetLargest(List<int> NumberList)
        {
            int IntMax = NumberList[0];
            foreach (int TheNumber in NumberList)
            {
                //loop to get the largest number
                if (TheNumber > IntMax)
                {
                    IntMax = TheNumber;
                }
                Console.WriteLine(TheNumber);
            }

            return IntMax;
        }
    }
}