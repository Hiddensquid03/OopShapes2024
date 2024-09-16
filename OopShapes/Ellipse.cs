using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapes
{
    internal class Ellipse : Shape2D, IHasArea
    {
        public Ellipse(double width, double height) : base(width, height)
        {
        }

        public double Area()
        {
            return Math.PI * (_width / 2) * (_height / 2);
        }
    }
}
