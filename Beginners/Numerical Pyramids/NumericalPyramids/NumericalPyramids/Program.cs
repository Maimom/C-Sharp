using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalPyramids
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            for (int a = 1; a <= num; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write(a);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    

    }
}
