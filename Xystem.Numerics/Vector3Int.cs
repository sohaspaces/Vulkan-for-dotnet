using System;
using System.Numerics;

namespace Xystem.Numerics
{
    public struct Vector3Int
    {
        public int X;
        public int Y;
        public int Z;

        public Vector3Int(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3Int Add(Vector3Int a, Vector3Int b)
            => new Vector3Int(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static Vector3Int Multiply(Vector3Int a, Vector3Int b)
            => new Vector3Int(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

        public static Vector3Int Substract(Vector3Int a, Vector3Int b)
            => new Vector3Int(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

        public static Vector3Int Divide(Vector3Int a, Vector3Int b)
            => new Vector3Int(a.X / b.X, a.Y / b.Y, a.Z / b.Z);

        public static Vector3Int Negate(Vector3Int x)
            => new Vector3Int(-x.X, -x.Y, -x.Z);

        public static Vector3Int Reciprocate(Vector3Int x)
            => new Vector3Int(1 / x.X, 1 / x.Y, 1 / x.Z);

        public static Vector3Int operator +(Vector3Int x) => x;

        public static Vector3Int operator -(Vector3Int x) => Negate(x);

        public static Vector3Int operator +(Vector3Int a, Vector3Int b) => Add(a, b);

        public static Vector3Int operator -(Vector3Int a, Vector3Int b) => Substract(a, b);

        public static Vector3Int operator *(Vector3Int a, Vector3Int b) => Multiply(a, b);

        public static Vector3Int operator /(Vector3Int a, Vector3Int b) => Divide(a, b);

    }
}
