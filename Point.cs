using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TowerDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Point))
            {
                return false;
            }

            Point that = obj as Point;

            return this.X == that.X && this.Y == that.Y;
        }

        // gets memory address location
        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }

        public int DistanceTo(int x, int y)
        {
            // Using the Cartesian distance formula

            // Broken down format

            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);

            // on one line 
            // return (int)Math.Sqrt(Math.Pow(x - x, 2) + Math.Pow(y - y, 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }

    }
}
