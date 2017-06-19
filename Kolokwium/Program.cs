using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            System.Console.WriteLine("podaj x1");
            x1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("podaj y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("podaj x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("podaj y2");
            y2 = Convert.ToInt32(Console.ReadLine());
            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Calculator calc = new Calculator();
            //Line line = new Line(point1.x, point1.y, point2.x, point2.y);
            Line line = new Line(point1,point2);

            double alpha = calc.CalculateAlpha(line);
            double beta = calc.CalculateBeta(line);
            double gamma = calc.CalculateGamma(line);
            double epsillon = calc.CalculateEpsillon(line);
            System.Console.WriteLine("Kat alfa: { 0} beta: { 1} gamma: {2} epsilon: {3} )", alpha, beta, gamma, epsillon);
            System.Console.ReadKey();
        }
    }
}
