using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_Euler
{
    public static class euler10
    {
        /*
         * 
         *  The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            Find the sum of all the primes below two million.
         * 
         */

        public static void sumPrime(int max)
        {
            long primeSum=0;

            for(int i=2;i<max;i++)
            {
                
                bool isPrime = true;

                //j<(i/j)+1
                //This is because for example, if -i- can't be divided by 2 without a rest
                //the maximum becomes i/2 (useless to go over that)
                //if -i- can't be divided by 3, the maximum becomes i/3 and so on.
                //this speeds up the process quite fast !
                //+1 is used because a division between 2 int with a rest will round down.
                for(int j=2;j<(i/j)+1;j++)
                {
                    if ((i % j == 0))
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeSum += i;
                    //Console.WriteLine(i);
                }
            }

            Console.WriteLine("The sum of prime number below {0} is {1}", max, primeSum);
        }
    }
}
