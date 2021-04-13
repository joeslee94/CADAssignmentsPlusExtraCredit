using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInheritance
{
    class Circle : Shapes
    {
        //   F i e l d s   ( I n s t a n c e   V a r i a b l e s )

        private double radius = 1.0;

        //   C o n s t r u c t o r s

        public Circle(double radius)
        {
            SetRadius(radius);
        } // end Circle( )

        //   M e t h o d s

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        } // end GetArea( )

        public override double GetPerimeter()
        {
            return GetCircumference();
        }

        public double GetCircumference()
        {
            return 2.0 * Math.PI * radius;
        } // end GetCircumference( )

        public double GetRadius()
        {
            return radius;
        } // end GetRadius( )

        public void SetRadius(double radius)
        {
            if (radius > 0.0)
            {
                this.radius = radius;
            }
        } // end SetRadius( )
    }
}
