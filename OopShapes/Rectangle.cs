using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapes
{
    internal class Rectangle : Shape2D, IHasArea
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public double Area()
        {
            return _width * _height;
        }
    }
}
