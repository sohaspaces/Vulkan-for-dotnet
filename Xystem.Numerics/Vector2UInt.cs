using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xystem.Numerics
{
    public struct Vector2UInt
    {
        public uint X;
        public uint Y;

        public Vector2UInt(uint x, uint y)
        {
            X = x;
            Y = y;
        }

        public static Vector2UInt Add(Vector2UInt a, Vector2UInt b)
            => new Vector2UInt(a.X + b.X, a.Y + b.Y);

        public static Vector2UInt Multiply(Vector2UInt a, Vector2UInt b)
            => new Vector2UInt(a.X * b.X, a.Y * b.Y);

        public static Vector2UInt Substract(Vector2UInt a, Vector2UInt b)
            => new Vector2UInt(a.X - b.X, a.Y - b.Y);

        public static Vector2UInt Divide(Vector2UInt a, Vector2UInt b)
            => new Vector2UInt(a.X / b.X, a.Y / b.Y);

        public static Vector2UInt operator +(Vector2UInt x) => x;

        public static Vector2UInt operator +(Vector2UInt a, Vector2UInt b) => Add(a, b);

        public static Vector2UInt operator -(Vector2UInt a, Vector2UInt b) => Substract(a, b);

        public static Vector2UInt operator *(Vector2UInt a, Vector2UInt b) => Multiply(a, b);

        public static Vector2UInt operator /(Vector2UInt a, Vector2UInt b) => Divide(a, b);

    }
}
