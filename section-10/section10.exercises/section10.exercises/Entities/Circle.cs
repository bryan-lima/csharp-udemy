using System;
using System.Collections.Generic;
using System.Text;
using section10.exercises.Entities.Enums;

namespace section10.exercises.Entities
{
    class Circle : Shape
    {
        public double Radios { get; set; }

        public Circle(double radios, Color color) :  base(color)
        {
            Radios = radios;
        }

        public override double Area()
        {
            return Math.PI * Radios * Radios;
        }
    }
}
