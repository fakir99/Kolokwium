using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Calculator
    {
         public double Angle;
        public Line Line;
      public double CalculateAlpha(Line line)
        {
           return  Angle =  Math.Atan2(line.y2 - line.y1, line.x2 - line.x1) - Math.Atan2(0 - 0, 3 - 0);
        }

        public double CalculateBeta(Line line)
        {
            return  Angle = Math.Atan2(line.y2 - line.y1, line.x2 - line.x1) - Math.Atan2(4 - 0, 0 - 0);
        }
        public double CalculateGamma(Line line)
        {
            Angle = Math.Atan2(line.y2 - line.y1, line.x2 - line.x1) - Math.Atan2(0 - 0, 3 - 0);
            return 180 - Angle;
        }
        public double CalculateEpsillon(Line line)
        {
            Angle = Math.Atan2(line.y2 - line.y1, line.x2 - line.x1) - Math.Atan2(4 - 0, 0 - 0);
            return 180 - Angle;
        }





    }
}
