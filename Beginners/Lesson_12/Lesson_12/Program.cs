using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class instantiation
            Animal animal = new Animal();

            animal.NoOfEyes = 2;
            animal.NoOflegs = 4;

            Console.WriteLine(animal.NoOfEyes);
            Console.WriteLine(animal.NoOflegs);

            animal.Bray();
            animal.Move();

            Console.ReadKey();
            


        }
    }

    // our class - Animal

    class Animal 
    {
        public int NoOflegs { get; set; }
        public int NoOfEyes { get; set; }

        public void Move()
        {
            Console.WriteLine("Animal can move");
        }

        public void Bray()
        {
            Console.WriteLine("Animal can bray");
        }
        
    }


}
