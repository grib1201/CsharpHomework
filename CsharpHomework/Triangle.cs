using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    class Triangle : Shape
    {
        public override string ClassName { get => "Triangle"; }
        public Triangle(Point p1, Point p2, Point p3, Color color, Contour contour) : base(color, contour)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        private Point p1;
        private Point p2;
        private Point p3;

        public override double CountArea()
        {
            
            int result = (1 / 2) * (p1.x * (p2.y - p3.y) 
                + p2.x * (p3.y - p1.y)
                + p3.x * (p1.y - p2.y));
            return result;
        }
    }
}
