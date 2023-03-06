using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    class AreaSorter : IComparer<Shape>
    {
        public int Compare(Shape? x, Shape? y)
        {
           if(x.CountArea() == y.CountArea())
            {
                return 0;
            } else if(x.CountArea() > y.CountArea())
            {
                return 10;
            } 
            return -10;
        }
    }
}
