using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_Euler
{
    public static class euler4
    {

        /*
             * 
             *  A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

                Find the largest palindrome made from the product of two 3-digit numbers.
             * 
             * 
             */

        public static void pal()
        {
            
            int biggest = 0;
            for(int i=100;i<1000;i++)
            {
                for(int j=100;j<1000;j++)
                {
                    int product = i * j;
                    
                    //I suck at math so I changed the product to String
                    string sProduct = product.ToString();
                    string part1 = sProduct.Substring(0, sProduct.Length / 2);
                    string part2 = sProduct.Substring(3, sProduct.Length / 2);

                    //I reverse part2 and compare them
                    if (part1.Equals(new string(part2.ToCharArray().Reverse().ToArray()))) 
                    {
                        //because of the 2 -for- loops I loop back to smaller numbers
                        //I need to update biggest only if the answer is bigger
                        if (product > biggest) biggest = product;
                    }
                }
            }
            Console.WriteLine("BIGGEST : {0}", biggest);
        }
    }
}
