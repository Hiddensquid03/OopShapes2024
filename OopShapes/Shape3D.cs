using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapes
{
    internal class Shape3D : Shape2D
    {
        protected double _depth;

        public Shape3D(double width, double height, double depth)
            : base(width, height)
        {
            this._depth = depth;
        }
    }
}
