using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInheritance.Shapes_Classes
{
    class Hexagon : Shapes
    {
        //   F i e l d s   ( I n s t a n c e   V a r i a b l e s )

        private double side = 1.0;

        //   C o n s t r u c t o r s

        public Hexagon(double side)
        {
            SetSide(side);
        } // end Hexagon( )

        //   M e t h o d s

        public override double GetArea()
        {
            return (3 * Math.Sqrt(3) * side * side) / 2;
        } // end GetArea( )

        public override double GetPerimeter() //renamed to override the abstract method in the Shapes class
        {
            return 6 * side;
        } // end GetPerimeter( )

        public double GetSide()
        {
            return side;
        } // end GetSide( )

        public void SetSide(double side)
        {
            if (side > 0.0)
            {
                this.side = side;
            }
        } // end SetSide( )
    }
}
