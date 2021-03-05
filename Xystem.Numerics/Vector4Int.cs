using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xystem.Numerics
{
    public struct Vector4Int
    {
        public int X;
        public int Y;
        public int Z;
        public int W;

        public Vector4Int(int x, int y, int z, int w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public static Vector4Int Add(Vector4Int a, Vector4Int b)
            => new Vector4Int(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);

        public static Vector4Int Multiply(Vector4Int a, Vector4Int b)
            => new Vector4Int(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);

        public static Vector4Int Substract(Vector4Int a, Vector4Int b)
            => new Vector4Int(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);

        public static Vector4Int Divide(Vector4Int a, Vector4Int b)
            => new Vector4Int(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);

        public static Vector4Int Negate(Vector4Int x)
            => new Vector4Int(-x.X, -x.Y, -x.Z, -x.W);

        public static Vector4Int Reciprocate(Vector4Int x)
            => new Vector4Int(1 / x.X, 1 / x.Y, 1 / x.Z, 1 / x.W);

        public static Vector4Int operator +(Vector4Int x) => x;

        public static Vector4Int operator -(Vector4Int x) => Negate(x);

        public static Vector4Int operator +(Vector4Int a, Vector4Int b) => Add(a, b);

        public static Vector4Int operator -(Vector4Int a, Vector4Int b) => Substract(a, b);

        public static Vector4Int operator *(Vector4Int a, Vector4Int b) => Multiply(a, b);

        public static Vector4Int operator /(Vector4Int a, Vector4Int b) => Divide(a, b);

    }
}
