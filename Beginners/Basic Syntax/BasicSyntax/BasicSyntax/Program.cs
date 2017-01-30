using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring  variables and initializing

            double length=12.89;
            double breadth=12.45;

            // Performing math operation

            double area = length * breadth;

            // printing to console

            Console.WriteLine("The area of rectangle having length = {0} and breadth ={1} is {2}", length, breadth, area);
            Console.ReadKey();
            //
        }
    }
}
