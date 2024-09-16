using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapes
{
    internal class Triangle : Shape2D, IHasArea
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }



        public double Area()
        {
            return _width * _height / 2;
        }

    }
}
