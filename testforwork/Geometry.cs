using System;
namespace Geometry
{
    public class Geometry
    {
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double TriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            // check if triangle is right triangle using pythagorean theorem
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                   Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                   Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2);
        }

        public static double Area(string type, params double[] sides)
        {
            if (type.Equals("circle", StringComparison.OrdinalIgnoreCase))
            {
                return CircleArea(sides[0]);
            }
            else if (type.Equals("triangle", StringComparison.OrdinalIgnoreCase))
            {
                return TriangleArea(sides[0], sides[1], sides[2]);
            }
            else
            {
                throw new ArgumentException("Invalid type of figure");
            }
        }
    }

}
