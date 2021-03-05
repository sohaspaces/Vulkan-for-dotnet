using System;
using System.Numerics;

namespace Xystem.Numerics
{
    public struct Vector3UInt
    {
        public uint X;
        public uint Y;
        public uint Z;

        public Vector3UInt(uint x, uint y, uint z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3UInt Add(Vector3UInt a, Vector3UInt b)
            => new Vector3UInt(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static Vector3UInt Multiply(Vector3UInt a, Vector3UInt b)
            => new Vector3UInt(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

        public static Vector3UInt Substract(Vector3UInt a, Vector3UInt b)
            => new Vector3UInt(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

        public static Vector3UInt Divide(Vector3UInt a, Vector3UInt b)
            => new Vector3UInt(a.X / b.X, a.Y / b.Y, a.Z / b.Z);


        public static Vector3UInt operator +(Vector3UInt x) => x;

        public static Vector3UInt operator +(Vector3UInt a, Vector3UInt b) => Add(a, b);

        public static Vector3UInt operator -(Vector3UInt a, Vector3UInt b) => Substract(a, b);

        public static Vector3UInt operator *(Vector3UInt a, Vector3UInt b) => Multiply(a, b);

        public static Vector3UInt operator /(Vector3UInt a, Vector3UInt b) => Divide(a, b);

    }
}
