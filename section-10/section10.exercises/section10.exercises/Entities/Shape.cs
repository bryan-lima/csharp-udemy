using System;
using System.Collections.Generic;
using System.Text;
using section10.exercises.Entities.Enums;

namespace section10.exercises.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
