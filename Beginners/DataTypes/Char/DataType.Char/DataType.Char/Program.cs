using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.Char
{
    class Program
    {
        static void Main(string[] args)
        {
            // DataType Char : 16-bit Unicode character

            char Alphabet = 'A';

            Console.WriteLine("The first letter in english alphabet is : {0}", Alphabet);
           
            // List all the letters in Alphabet

            char alphaStart = char.Parse("A");
            char alphaEnd = char.Parse("Z");
            for (char i = alphaStart; i <= alphaEnd; i++)
            {
                //string anchorLetter = i.ToString();
                Console.Write(i.ToString() + " ");
            }

             Console.ReadKey();

        }
    }
}
