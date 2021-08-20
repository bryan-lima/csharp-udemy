using System;
using System.Collections.Generic;
using System.Text;
using section10.exercises.Entities.Enums;

namespace section10.exercises.Entities
{
    class Rectangle : Shape
    {
        public double With { get; set; }

        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            With = width;
            Height = height;
        }

        public override double Area()
        {
            return With * Height;
        }
    }
}
