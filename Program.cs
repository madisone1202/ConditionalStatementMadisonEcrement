﻿using System;

namespace ConditionalStatementMadisonEcrement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What score to you expect to receive in ISM 4300 out of 100? This should be an interger value. Your letter grade will be displayed following your response");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer <= 100 && answer >= 98)
            {
                Console.WriteLine("A+");
            }
            else if (answer <= 97 && answer >= 92)
            {
                Console.WriteLine("A");
            }
            else if (answer <= 91 && answer >= 90)
            {
                Console.WriteLine("A-");
            }
            else if (answer <= 89 && answer >= 88)
            {
                Console.WriteLine("B+");
            }
            else if (answer <= 87 && answer >= 82)
            {
                Console.WriteLine("B");
            }
            else if (answer <= 81 && answer >= 80)
            {
                Console.WriteLine("B-");
            }
            else if (answer <= 79 && answer >= 78)
            {
                Console.WriteLine("C+");
            }
            else if (answer <= 77 && answer >= 72)
            {
                Console.WriteLine("C");
            }
            else if (answer <= 71 && answer >= 70)
            {
                Console.WriteLine("C-");
            }
            else if (answer <= 69 && answer >= 68)
            {
                Console.WriteLine("D+");
            }
            else if (answer <= 67 && answer >= 62)
            {
                Console.WriteLine("D");
            }
            else if (answer <= 61 && answer >= 61)
            {
                Console.WriteLine("D-");
            }
            else if (answer <= 60)
            {
                Console.WriteLine("F");
            }



        }
    }
}
