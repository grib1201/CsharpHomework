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

        public Circle(Point p1) : base()
        {
            this.p1 = p1;   
        }

        private Point p1;

        public override double CountArea()
        {
            var result = Radius * Radius * Math.PI;
            return result;
        }
    }
}
