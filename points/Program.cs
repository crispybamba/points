
using System;
using System.Text;

namespace points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2d pt1 = new Point2d(20, 40);
            Point2d pt2 = new Point2d(2, 8);
            double dist = pt1.Distance(pt2);
        }

        public static Point2d[] Closest(Point2d[] points)
        {
            double closestDis = points[0].Distance(points[1]);
            Point2d[] closest = new Point2d[2];
            for (int i = 1; i < points.Length -1 ; i++)
                for (int j = i+1; j < points.Length; j++)
                    if (points[i].Distance(points[j]) < closestDis)
                    {
                        closest[0] = points[i];
                        closest[1] = points[j];
                        closestDis = points[i].Distance(points[j]);
                    }
            return closest;
        }
    }
}
