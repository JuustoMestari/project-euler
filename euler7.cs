using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_Euler
{
    public static class euler7
    {
        /*
         * 
         *  By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

            What is the 10 001st prime number?
         * 
         */
        public static void prime(int primePosition)
        {
            int currentNum = 2;
            List<int> primeList = new List<int>();
            bool isPrime;
            do
            {
                isPrime = true;
                //loop through value from 2 to currentNum-1
                for (int j = 2; j < currentNum; j++)
                {
                    if (currentNum % j == 0) isPrime = false;
                }
                if (isPrime) primeList.Add(currentNum);
                currentNum++;

            } while (primeList.Count != primePosition);

            Console.WriteLine(primeList.Last());
        }
    }
}
