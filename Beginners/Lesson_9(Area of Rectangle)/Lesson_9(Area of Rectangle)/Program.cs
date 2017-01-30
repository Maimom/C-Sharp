using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_9_Area_of_Rectangle_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate area of Rectangle
            // Get Length and breadth of the rectangle
            // Area = L*B

            Console.WriteLine("Enter the Length of the Rectangle");
            int L = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the breadth of the Rectangle");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("The area is {0}", L*B);

            Console.ReadKey();
        }
    }
}
