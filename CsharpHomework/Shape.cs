using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    abstract class Shape: IComparable<Shape>
    {
        public int CompareTo(Shape? other)
        {
            throw new NotImplementedException();
        }

        public abstract double CountArea();

    }
}
