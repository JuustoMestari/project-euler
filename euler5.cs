using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_Euler
{
    public static class euler5
    {
        /*
         * 
         *  2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

            What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         * 
         * 
         */
        public static void smallest(int max)
        {
            int smallest=0;
            int num = max;
            bool isContinued = true;
            do
            {
                num++;
                for(int i=1;i<max+1;i++)
                {
                    
                    if (num % i != 0) break;
                    smallest = num;
                   if(i==max-1) isContinued = false;
                }
            } while (isContinued);
            Console.WriteLine("SMALLEST : {0}", smallest);
        }
    }
}
