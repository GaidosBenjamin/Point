using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    abstract class AbstractPoint
    {
        public enum PointRepresentation
        {
            Polar = 0,
            Rectangular = 1
        }

        public abstract double getPointX();
        public abstract double getPointY();
        public abstract void setPointX(double A);
        public abstract void setPointY(double r);
        public abstract void Move(double dx, double dy);
        public abstract void Rotate(double angle);
        public abstract override string ToString();
        protected static double polarCartezianA(double r, double A)
        {
            return r * Math.Cos(A);
        }
        protected static double polarCartezianB(double r, double A)
        {
            return r * Math.Sin(A);
        }
        protected static double cartezianPolarR(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
        protected static double cartezianPolarA(double a, double b)
        {
            return Math.Atan(b / a);
        }
    }
}
