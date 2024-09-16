using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapes
{
    internal class Shape2D
    {
        // _ is (unofficially) used to show member vars
        protected double _width;
        protected double _height;

        /// <summary>
        /// Represents a 2D Shape
        /// </summary>
        /// <param name="width">Width of the shape</param>
        /// <param name="height">Height of the shape</param>
        public Shape2D(double width, double height)
        {
            // this. will refer to the member variables (optional unless name conflict)
            this._width = width;
            this._height = height;
        }
    }
}