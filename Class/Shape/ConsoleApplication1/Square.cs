using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Square : Parallelogram
    {
        // Implementation of Area for square
        public  override double  GetArea()
        {
            return this.length * this.length;
        }
    }
}
