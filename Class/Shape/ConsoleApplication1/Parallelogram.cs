using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Parallelogram : IParallelogram
    {
        protected double length;
        protected double width;
        protected double height;
        protected double pbase;

        const int noOfSides = 4;

        public void SetWidth(double Width)
        {
            width = Width;
            pbase = Width;
        }

        public void SetLength(double Lenght)
        {
            length = Lenght;
        }
        public void SetHeight(double Height)
        {
            height = Height;

        }

        public virtual double GetArea()
        {
            return height * pbase;
        }
        //Example of function overloading

        public double GetPerimeter(double a)
        {
            // perimeter of a square
            return a * 4;
        }

        public double GetPerimeter(double a,double b)
        {
            // perimeter of a rectangle / parellelogram
            return (2 * a) + (2 * b);
        }

        public double GetPerimeter(double a, double b,double c, double d)
        {
            //perimeter of a of any quadrilateral
            return a + b + c + d; 
        }



    }
}
