using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_CS_Ch_7_Circle__Rectangle__Square__Triangle
{
    class Circle
    {
        private double radius { get; set; } = 1;

        public Circle(double Radius)
        {
            radius = Radius;
        }
        public void SetRadius(double Radius)
        {
            if (double.TryParse(Radius.ToString(), out Radius))
                radius = Radius;
            else
            {
                radius = 1;
            }
        }
        public double GetRadius()
        {
            return radius;
        }

        public double GetArea()
        {
            double area = Math.PI * radius;
            return area;
        }

        public double GetCircumference()
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }
}
