using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class Point : AbstractPoint
    {
        private double A;
        private double r;
        int reprezentare;

        public Point(int t, double x, double y)
        {
            reprezentare = t;
            if (t == (int)PointRepresentation.Polar)
            {
                A = Math.Atan(y/x);
                r = Math.Sqrt(x*x + y*y);
            }
            else if (t == (int)PointRepresentation.Rectangular)
            {
                A = x;
                r = y;
            }
            else
                throw new System.ArgumentException();
        }

        public override double getPointX()
        {
            return A;
        }

        public override double getPointY()
        {
            return r;
        }

        public override void setPointX(double A)
        {
            this.A = A;
        }

        public override void setPointY(double r)
        {
            this.r = r;
        }

        public override void Move(double dx, double dy)
        {
            if (reprezentare == (int)PointRepresentation.Rectangular)
            {
                A += dx;
                r += dy;
            }
            else
                throw new System.ArgumentException();
        }

        public override void Rotate(double angle)
        {
            if (reprezentare == (int)PointRepresentation.Polar)
            {
                A += angle;
            }
            else
                throw new System.ArgumentException();
        }

        public override string ToString()
        {
            if (reprezentare == (int)PointRepresentation.Polar)
            {
                double a = r * Math.Cos(A);
                double b = r * Math.Sin(A);
                return "(" + a + ", " + b + "):[" + r + ", " + A + "]";
            }
            else if (reprezentare == (int)PointRepresentation.Rectangular)
            {
                double a = A;
                double b = r;
                A = Math.Atan(b / a);
                r = Math.Sqrt(a * a + b * b);
                return "(" + a + ", " + b + "):[" + r + ", " + A + "]";
            }
                return "";
        }
    }
}
