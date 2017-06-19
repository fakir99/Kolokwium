using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Line
    {
      public  Point X, Y;
       public  int x1, x2, y1, y2;

      public  Line(Point first, Point second)
        {
            x1 = first.x;
            y1 = first.y;
            x2 = second.x;
            y2 = second.y;
        }
    }
}
