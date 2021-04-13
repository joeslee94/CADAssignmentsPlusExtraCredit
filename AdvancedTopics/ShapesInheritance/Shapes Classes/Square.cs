using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInheritance
{
    class Square : Shapes
    {
        //   F i e l d s

        private double side = 1.0;

        //   C o n s t r u c t o r s

        public Square(double side)
        {
            SetSide(side);
        } // end Square( )

        //   M e t h o d s

        public override double GetArea()
        {
            return side * side;
        } // end GetArea( )

        public override double GetPerimeter()
        {
            return 4 * side;
        } // end GetPerimeter( )

        public double GetSide()
        {
            return side;
        } // end GetSide( )

        public void SetSide(double side)
        {
            if (side > 0)
            {
                this.side = side;
            }
        } // end SetSide( )
    }
}
