using System;
using System.Collections.Generic;
using System.Text;

namespace section4.exercises
{
    class Rectangle
    {
        public double width;
        public double height;

        public double Area()
        {
            return width * height;
        }

        public double Perimeter()
        {
            return 2 * (height + width);
        }

        public double Diagonal()
        {
            return Math.Sqrt((height * height) + (width * width));
        }

    }
}
