using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 9;
            bool isPrime = true;
            for(int a = 2 ; a < num; a++)
            {
                if (num % a == 0) {
                    isPrime = false;
                    break;
                }
                
            }
            if (isPrime)
            {
                Console.WriteLine("{0} is prime", num);

            }
            else
            {
                Console.WriteLine("{0} is not prime", num);
            }
            Console.ReadKey();
        }
    }
}
