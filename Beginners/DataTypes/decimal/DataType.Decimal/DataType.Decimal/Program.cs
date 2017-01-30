using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.Decimal
{
    // decimal - 128-bit precise decimal values with 28-29 significant digits
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.One);
            Console.WriteLine(decimal.Zero);
            Console.WriteLine(decimal.MinusOne);

            Console.WriteLine(decimal.Add(1.1M, 1.3M)); // Add
            Console.WriteLine(decimal.Multiply(5.0M, 2.0M)); // Five times two
            Console.WriteLine(decimal.Subtract(2.0M, 1.0M)); // Two minus one
            Console.WriteLine(decimal.Divide(10M, 2M)); // Ten divided by two

            Console.WriteLine(decimal.Remainder(2.0M, 1.5M));
            Console.WriteLine(decimal.Truncate(4.55M));

            decimal d = 0.00000000000010000m;
            while (d != 0m)
            {
                Console.WriteLine(d);
                d = d / 5m;
            }

            Console.ReadKey();
        }
    }
}
