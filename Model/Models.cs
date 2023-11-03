using Microsoft.AspNetCore.Mvc;

namespace API_Development.Controller
{
    public class APP
    {
        public bool isOnLineA;
        public bool isOnLineB;
        static bool IsPointOnLine(Point X, Point Y, Point Z)
        {
            int XYx = Y.X - X.X;
            int XYy = Y.Y - X.Y;
            int XZx = Z.X - X.X;
            int XZy = Z.Y - X.Y;
            int crossProduct = XYx * XZy - XYy * XZx;
            if (crossProduct != 0)
            { return false; }
            int dotProduct = XYx * XZx + XYy * XZy;
            if (dotProduct < 0)
            { return false; }
            int squareLengthAB = XYx * XYx + XYy * XYy;
            if (dotProduct > squareLengthAB)
            { return false; }
            return true;
        }
        public void A()
        {
            Point A = new Point { X = 1, Y = 1 };
            Point B = new Point { X = 20, Y = 20 };
            Point C = new Point { X = 9, Y = 9 };
            isOnLineA = IsPointOnLine(A, B, C);
        }
        public void B()
        {
            Point A = new Point { X = 1, Y = 1 };
            Point B = new Point { X = 20, Y = 20 };
            Point C = new Point { X = 23, Y = 23 };
            isOnLineB = IsPointOnLine(A, B, C);
        }
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
