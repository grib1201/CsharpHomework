using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    abstract class Shape: IComparable<Shape>
    {
        public abstract string ClassName { get;}

        public int CompareTo(Shape? other)
        {
            throw new NotImplementedException();
        }

        public abstract double CountArea();

        public Color color;
        public Contour contour;

        public Shape(Color color, Contour contour)
        {
            this.color = color;
            this.contour = contour;
        }

        public override string ToString()
        {
            return ClassName + " of " + this.color.colorValue + " color and "
                + this.contour.contourValue + " contour";
        }
    }
}
