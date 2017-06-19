using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Calculator
    {
        double Angle;
       double CalculateAlpha(int x1, int y1, int x2, int y2 )
        {
           return  Angle =  Math.Atan2(y2 - y1, x2 - x1) - Math.Atan2(0 - 0, 3 - 0);
        }

        double CalculateBeta(int x1, int y1, int x2, int y2)
        {
            return  Angle = Math.Atan2(y2 - y1, x2 - x1) - Math.Atan2(4 - 0, 0 - 0);
        }
        double CalculateGamma(int x1, int y1, int x2, int y2)
        {
            return  Angle = Math.Atan2(y2 - y1, x2 - x1) - Math.Atan2( 0- 0, 3 - 0);
        }
        double CalculateEpsillon(int x1, int y1, int x2, int y2)
        {
            return  Angle = Math.Atan2(y2 - y1, x2 - x1) - Math.Atan2(0 - 0, 3 - 0);
        }





    }
}
