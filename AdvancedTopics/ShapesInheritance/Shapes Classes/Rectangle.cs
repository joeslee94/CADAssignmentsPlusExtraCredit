using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInheritance
{
    class Rectangle : Shapes
    {
        //   F i e l d s

        private double length = 1.0;
        private double width = 1.0;

        //   C o n s t r u c t o r s

        public Rectangle(double length, double width)
        {
            SetDimensions(length, width);
        } // end Rectangle( )

        //   M e t h o d s

        public override double GetArea()
        {
            return length * width;
        } // end GetArea( )

        public override double GetPerimeter()
        {
            return (length + width) * 2;
        } // end GetPerimeter( )

        public double GetLength()
        {
            return length;
        } // end GetLength( )

        public void SetLength(double length)
        {
            if (length > 0)
            {
                this.length = length;
            }
        } // end SetLength( )

        public double GetWidth()
        {
            return width;
        } // end GetWidth( )

        public void SetWidth(double width)
        {
            if (width > 0)
            {
                this.width = width;
            }
        } // end SetWidth( )

        public (double l, double w) GetDimensions()
        {
            return (length, width);
        } // end GetDimensions( )

        public void SetDimensions(double length, double width)
        {
            SetLength(length);
            SetWidth(width);
        } // end SetDimensions( )
    }
}
