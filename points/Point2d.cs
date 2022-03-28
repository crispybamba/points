using System;
using System.Text;

namespace points
{
    class Point2d
    {
        private int x;
        private int y;

        public Point2d(){}
        public Point2d(int x, int y) { this.x = x; this.y = y; }


        public int GetX() { return x; }
        public int GetY() { return y; }
        public void SetX(int x) { this.x = x; }
        public void SetY(int y) { this.x = y; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(x,y) = (");
            sb.Append(x.ToString());
            sb.Append(",");
            sb.Append(y.ToString());
            sb.Append(")");
            string str = sb.ToString();
            return str;
        }

        public double Distance(Point2d secPoint)
        {
            double xPart = Math.Pow((x - secPoint.x), 2);
            double yPart = Math.Pow((y - secPoint.y), 2);
            double res = Math.Pow(xPart, 2) + Math.Pow(yPart, 2);
            res = Math.Sqrt(res);
            return res;
        }
            

    }
}
