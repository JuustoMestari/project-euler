using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace project_Euler
{
    public class euler3
    {
        /*
         * 
         *  The prime factors of 13195 are 5, 7, 13 and 29.

            What is the largest prime factor of the number 600851475143 ?
         * 
         */
        public static long m_num;
        public static void prime(long num)
        { 
            // help here: http://www.mathblog.dk/project-euler-problem-3/

            m_num = num;
            Thread t = new Thread(calculatePrime);
            t.Start();
            Console.WriteLine("Calculating...");
        }

        public static void calculatePrime()
        {
            //todo
        }
    }
}
