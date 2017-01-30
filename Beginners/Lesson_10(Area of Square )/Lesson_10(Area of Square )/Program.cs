using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of the Square");
            int L = int.Parse(Console.ReadLine());

            

            Console.WriteLine("The Area of the rectangle is {0}", L*L);

            Console.ReadKey();

        }
    }
}
