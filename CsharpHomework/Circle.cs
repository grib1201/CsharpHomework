using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override string ClassName { get => "Circle"; }

        public Point p1; 

        public Circle(Point p1, Color color, Contour contour) : base(color, contour)
        {
            this.p1 = p1;   
        }

        public override double CountArea()
        {
            var result = Radius * Radius * Math.PI;
            return result;
        }

    }
}
