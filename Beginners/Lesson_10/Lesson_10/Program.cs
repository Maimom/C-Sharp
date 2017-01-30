using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of the Square");
            int L = int.Parse(Console.ReadLine());



            Console.WriteLine("The Area of the Square is {0}", L * L);

            Console.ReadKey();
        }
    }
}
