using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;

            while (num1 < 10)  //  Pre Check Condition
            {
                Console.WriteLine("First:" + num1.ToString());
                num1++;
            }

            int num2=10;
            do            // Post Condition Check // at least statement will be executed one time
            {
                Console.WriteLine("second : " + num2.ToString());
                num2++;
            } while (num2 < 10);

            Console.ReadKey();
        }
    }
}
