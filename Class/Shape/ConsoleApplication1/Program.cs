using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {

            // Class, Inheritence, proctected, private, internl, public
            Square sqr = new Square();
            sqr.SetLength(12);
            Console.WriteLine("The area of the square is {0}", sqr.GetArea());
           

            Rectangle rectangle = new Rectangle();
            rectangle.SetLength(23);
            rectangle.SetWidth(10);


            Console.WriteLine("The area of the Rectangle is {0}", rectangle.GetArea());

            // Function / Method overloading

            Console.WriteLine("The perimeter of a square is {0}", rectangle.GetPerimeter(12));
            Console.WriteLine("The perimeter of a rectangle is {0}", rectangle.GetPerimeter(12, 14));

            // Static class
            Console.WriteLine("The area of the square is {0}",AreaCalc.GetAreaOfSquare(12));


            // Operator overloading
            Cube cube = new Cube();
            cube.Edge=3;

            Console.WriteLine("The volume of the cube is {0}",cube.GetVolume());

            Cube c1 = new Cube();
            c1.Edge = 10;

            Cube c2 = new Cube();
            c2.Edge = 5;

            Cube c3 = new Cube();
            c3 = c1 + c2;

            Console.WriteLine("The volume of the cube is {0}", c3.GetVolume());

            Console.ReadKey();

        }
    }
}
