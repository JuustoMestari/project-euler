using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_Euler
{
    public static class euler9
    {
        /*
         * 
         * 
         * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

            a2 + b2 = c2
            For example, 32 + 42 = 9 + 16 = 25 = 52.

            There exists exactly one Pythagorean triplet for which a + b + c = 1000.
            Find the product abc.
         * 
         * 
         */
        
        public static void pyth(int result)
        {
            bool stop = false;
            int ma=0,mb=0,mc=0;
            for(int a=1;a<result+1;a++)
            {
                ma=a;
                for (int b = 2; b < result + 1; b++)
                {
                    mb=b;
                    for (int c = 3; c < result + 1; c++)
                    {
                        mc=c;
                        //check both condition
                        if (a + b + c == result && ((a*a)+(b*b)==(c*c))) stop = true;
                        if (stop) break;
                    }
                    if (stop) break;
                }
                if (stop) break;
            }
            Console.WriteLine("The triplet is {0},{1},{2} and the product is {3}", ma, mb, mc, ma * mb * mc);
        }
    }
}
