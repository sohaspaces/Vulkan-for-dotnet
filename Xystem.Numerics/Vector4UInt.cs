using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xystem.Numerics
{
    public struct Vector4UInt
    {
        public uint X;
        public uint Y;
        public uint Z;
        public uint W;

        public Vector4UInt(uint x, uint y, uint z, uint w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public static Vector4UInt Add(Vector4UInt a, Vector4UInt b)
            => new Vector4UInt(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);

        public static Vector4UInt Multiply(Vector4UInt a, Vector4UInt b)
            => new Vector4UInt(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);

        public static Vector4UInt Substract(Vector4UInt a, Vector4UInt b)
            => new Vector4UInt(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);

        public static Vector4UInt Divide(Vector4UInt a, Vector4UInt b)
            => new Vector4UInt(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);

        public static Vector4UInt operator +(Vector4UInt x) => x;

        public static Vector4UInt operator +(Vector4UInt a, Vector4UInt b) => Add(a, b);

        public static Vector4UInt operator -(Vector4UInt a, Vector4UInt b) => Substract(a, b);

        public static Vector4UInt operator *(Vector4UInt a, Vector4UInt b) => Multiply(a, b);

        public static Vector4UInt operator /(Vector4UInt a, Vector4UInt b) => Divide(a, b);

    }
}
