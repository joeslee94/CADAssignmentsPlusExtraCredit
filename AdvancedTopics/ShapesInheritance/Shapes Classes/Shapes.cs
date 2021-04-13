using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInheritance
{
    abstract class Shapes
    {
        private string Color { get; set; }

        protected Shapes() { }

        protected Shapes(string color)
        {
            SetColor(color);
        }

        public virtual bool SetColor(string color)
        {
            if (color != null && color.Length > 0)
            {
                this.Color = color;
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual string GetColor()
        {
            return Color;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
