using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xystem.Numerics
{
    public struct Vector2Int
    {
        public int X;
        public int Y;

        public Vector2Int(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector2Int Add(Vector2Int a, Vector2Int b)
            => new Vector2Int(a.X + b.X, a.Y + b.Y);

        public static Vector2Int Multiply(Vector2Int a, Vector2Int b)
            => new Vector2Int(a.X * b.X, a.Y * b.Y);

        public static Vector2Int Substract(Vector2Int a, Vector2Int b)
            => new Vector2Int(a.X - b.X, a.Y - b.Y);

        public static Vector2Int Divide(Vector2Int a, Vector2Int b)
            => new Vector2Int(a.X / b.X, a.Y / b.Y);

        public static Vector2Int Negate(Vector2Int x)
            => new Vector2Int(-x.X, -x.Y);

        public static Vector2Int Reciprocate(Vector2Int x)
            => new Vector2Int(1 / x.X, 1 / x.Y);

        public static Vector2Int operator +(Vector2Int x) => x;

        public static Vector2Int operator -(Vector2Int x) => Negate(x);

        public static Vector2Int operator +(Vector2Int a, Vector2Int b) => Add(a, b);

        public static Vector2Int operator -(Vector2Int a, Vector2Int b) => Substract(a, b);

        public static Vector2Int operator *(Vector2Int a, Vector2Int b) => Multiply(a, b);

        public static Vector2Int operator /(Vector2Int a, Vector2Int b) => Divide(a, b);

    }
}
