using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_Euler
{
    public static class euler6
    {

        /*
         * 
         * The sum of the squares of the first ten natural numbers is,

            1^2 + 2^2 + ... + 10^2 = 385
            The square of the sum of the first ten natural numbers is,

            (1 + 2 + ... + 10)^2 = 552 = 3025
            Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

            Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
         * 
         * 
         */

        public static void diff (int max)
        {
            int sumSquares = 0;
            
            long squareSum = 0;
            
            for(int i=1;i<max+1;i++)
            {
                sumSquares += i * i;
                squareSum+=i;
            }
            squareSum *= squareSum;

            Console.WriteLine("Difference : {0}", squareSum-sumSquares);
        }
    }
}
