using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Cube
    {
        public double Edge { get; set; }

        public double GetVolume()
        {
            return this.Edge * this.Edge * this.Edge;
        }

        // Overload + operator to add two Box objects.
        public static Cube operator +(Cube b, Cube c)
        {
            Cube cube = new Cube();
            cube.Edge = b.Edge + c.Edge;
            return cube;
        }

    }
}
