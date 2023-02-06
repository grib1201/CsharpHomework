using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    class Point
    {
        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x;
        public int y;

        public Point Add(Point p1)
        {
            Point point = new Point();
            point.x = x + p1.x;
            point.y = y + p1.y;
            return point;
        }
    }

}
