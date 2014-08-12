using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace project_Euler
{
    class Program
    {
        //http://projecteuler.net/
        static Stopwatch stopwatch;
        static void Main(string[] args)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();

            //CHALLENGES 1->10

            euler0.challenge1(1000);
            printTime();
            euler0.challenge2(4000000);
            printTime();
            euler0.challenge3(600851475143);
            printTime();
            euler0.challenge4();
            printTime();
            euler0.challenge5(20);
            printTime();
            euler0.challenge6(100);
            printTime();
            euler0.challenge7(10001);
            printTime();
            euler0.challenge8(13);
            printTime();
            euler0.challenge9(1000);
            printTime();
            euler0.challenge10(2000000);
            printTime();

            //CHALLENGES 11->20

            euler1.challenge11(4);
            printTime();
            euler1.challenge12(500);
            printTime();
            euler1.challenge13();
            printTime();
            euler1.challenge14(1000000);
            printTime();
            euler1.challenge16(1000);
            printTime();
            euler1.challenge17();
            printTime();
            euler1.challenge19();
            printTime();
            euler1.challenge20(100);
            printTime();


            Console.WriteLine("\nDONE !");
            Console.ReadLine();
        }
        static void printTime()
        {
            stopwatch.Stop();
            Console.WriteLine(">Execution time : {0} ms",stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
        }
    }
}
