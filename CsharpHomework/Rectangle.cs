using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    class Rectangle : Shape
    {
        public override string ClassName { get => "Rectangle"; }
        public Rectangle(Point p1, Point p2, Color color, Contour contour) : base(color, contour)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        private Point p1;
        private Point p2;

        public override double CountArea()
        {
            int result = (p2.x - p1.x) * (p2.y + p1.y);
            return result;
        }
    }
}
