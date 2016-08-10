using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle : Parallelogram
    {
        // Implementation of Area for Rectangle
        public override double GetArea()
        {
            return 2 * (this.length * this.height);
        }  
    }
}
