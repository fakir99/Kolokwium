using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Tests
{
    public class KolokwiumTests
    {
        [TestClass]
        public class LineTests
        {
            [TestMethod]
            public void TestMethod1()
            {
                List<Point> Line = new List<Point>
                      {
 +                new Point(0, 0),
 +                new Point(2, 2)
                }

                 Line lin = new Line(2, 4);

                foreach (Point pos in Line.vertices)
                {
                    if (!expectedPoints.Contains(pos))
                    {
                        Assert.Fail();
                    }

                }

            }

            [TestMethod]
            [TestCategory("Logic")]
            public void CheckLine1Angle()
            {
                double expectedAngle = 45;

                Point a = new Point(0, 0);
                Point b = new Point(5, 5);

                Line ang = new Line(a, b);

                if (!expectedAngle.Equals(ang.CheckLine()))
                {
                    Assert.Fail();
                }
            }



        }
    }
}
