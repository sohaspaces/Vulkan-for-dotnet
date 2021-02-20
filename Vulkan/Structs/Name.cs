using System;
using System.Runtime.InteropServices;
using System.Text;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct UnmanagedString256
    {
        //public const uint MaxSize = 256;

        private readonly UnmanagedString16 k0;
        private readonly UnmanagedString16 k1;
        private readonly UnmanagedString16 k2;
        private readonly UnmanagedString16 k3;
        private readonly UnmanagedString16 k4;
        private readonly UnmanagedString16 k5;
        private readonly UnmanagedString16 k6;
        private readonly UnmanagedString16 k7;
        private readonly UnmanagedString16 k8;
        private readonly UnmanagedString16 k9;
        private readonly UnmanagedString16 kA;
        private readonly UnmanagedString16 kB;
        private readonly UnmanagedString16 kC;
        private readonly UnmanagedString16 kD;
        private readonly UnmanagedString16 kE;
        private readonly UnmanagedString16 kF;

        public static implicit operator string(UnmanagedString256 x) => x.StructureToString(Encoding.UTF8);

        public override string ToString()
            => this;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UnmanagedString16
    {
        //public const uint MaxSize = 16;

        private readonly byte k0;
        private readonly byte k1;
        private readonly byte k2;
        private readonly byte k3;
        private readonly byte k4;
        private readonly byte k5;
        private readonly byte k6;
        private readonly byte k7;
        private readonly byte k8;
        private readonly byte k9;
        private readonly byte kA;
        private readonly byte kB;
        private readonly byte kC;
        private readonly byte kD;
        private readonly byte kE;
        private readonly byte kF;

        public static implicit operator string(UnmanagedString16 x) => x.StructureToString(Encoding.UTF8);

        public override string ToString()
            => this;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UnmanagedArray256<T>
        where T : unmanaged
    {
        public const uint MaxSize = 256;

        private readonly UnmanagedArray16<T> k0;
        private readonly UnmanagedArray16<T> k1;
        private readonly UnmanagedArray16<T> k2;
        private readonly UnmanagedArray16<T> k3;
        private readonly UnmanagedArray16<T> k4;
        private readonly UnmanagedArray16<T> k5;
        private readonly UnmanagedArray16<T> k6;
        private readonly UnmanagedArray16<T> k7;
        private readonly UnmanagedArray16<T> k8;
        private readonly UnmanagedArray16<T> k9;
        private readonly UnmanagedArray16<T> kA;
        private readonly UnmanagedArray16<T> kB;
        private readonly UnmanagedArray16<T> kC;
        private readonly UnmanagedArray16<T> kD;
        private readonly UnmanagedArray16<T> kE;
        private readonly UnmanagedArray16<T> kF;

        public static implicit operator Span<T>(UnmanagedArray256<T> x) => x.Unwrap();
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UnmanagedArray32<T>
        where T : unmanaged
    {
        public const uint MaxSize = 32;

        private readonly UnmanagedArray16<T> k0;
        private readonly UnmanagedArray16<T> k1;

        public static implicit operator Span<T>(UnmanagedArray32<T> x) => x.Unwrap();
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UnmanagedArray16<T>
        where T : unmanaged
    {
        public const uint MaxSize = 16;

        private readonly T k0;
        private readonly T k1;
        private readonly T k2;
        private readonly T k3;
        private readonly T k4;
        private readonly T k5;
        private readonly T k6;
        private readonly T k7;
        private readonly T k8;
        private readonly T k9;
        private readonly T kA;
        private readonly T kB;
        private readonly T kC;
        private readonly T kD;
        private readonly T kE;
        private readonly T kF;

        public static implicit operator Span<T>(UnmanagedArray16<T> x) => x.Unwrap();
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UnmanagedArray2<T>
        where T : unmanaged
    {
        public const uint MaxSize = 2;

        private T k0;
        private T k1;

        public static implicit operator Span<T>(UnmanagedArray2<T> x) => x.Unwrap();
        public static implicit operator UnmanagedArray2<T>((T, T) x) => new UnmanagedArray2<T>()
        {
            k0 = x.Item1,
            k1 = x.Item2
        };
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UnmanagedArray3<T>
        where T : unmanaged
    {
        public const uint MaxSize = 2;

        private T k0;
        private T k1;
        private T k2;

        public static implicit operator Span<T>(UnmanagedArray3<T> x) => x.Unwrap();
        public static implicit operator UnmanagedArray3<T>((T, T, T) x) => new UnmanagedArray3<T>()
        {
            k0 = x.Item1,
            k1 = x.Item2,
            k2 = x.Item3
        };
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct UnmanagedArray4<T>
        where T : unmanaged
    {
        public const uint MaxSize = 2;

        private T k0;
        private T k1;
        private T k2;
        private T k3;

        public static implicit operator Span<T>(UnmanagedArray4<T> x) => x.Unwrap();
        public static implicit operator UnmanagedArray4<T>((T, T, T, T) x) => new UnmanagedArray4<T>()
        {
            k0 = x.Item1,
            k1 = x.Item2,
            k2 = x.Item3,
            k3 = x.Item4
        };
    }

    public static class Extensions
    {
        public static byte[] StructureToByteArray<T>(this T obj)
            where T : unmanaged
        {
            unsafe
            {
                int len = sizeof(T);

                byte[] arr = new byte[len];
                fixed (byte* ptr = arr)
                {
                    Buffer.MemoryCopy(&obj, ptr, len, len);
                    return arr;
                }
            }
        }

        public static T[] Unwrap<T>(this UnmanagedArray4<T> obj)
            where T : unmanaged
        {
            unsafe
            {
                int len = sizeof(UnmanagedArray4<T>);

                T[] arr = new T[4];
                fixed (T* ptr = arr)
                {
                    Buffer.MemoryCopy(&obj, ptr, len, len);
                    return arr;
                }
            }
        }

        public static T[] Unwrap<T>(this UnmanagedArray3<T> obj)
            where T : unmanaged
        {
            unsafe
            {
                int len = sizeof(UnmanagedArray3<T>);

                T[] arr = new T[3];
                fixed (T* ptr = arr)
                {
                    Buffer.MemoryCopy(&obj, ptr, len, len);
                    return arr;
                }
            }
        }


        public static T[] Unwrap<T>(this UnmanagedArray2<T> obj)
            where T : unmanaged
        {
            unsafe
            {
                int len = sizeof(UnmanagedArray2<T>);

                T[] arr = new T[2];
                fixed (T* ptr = arr)
                {
                    Buffer.MemoryCopy(&obj, ptr, len, len);
                    return arr;
                }
            }
        }


        public static T[] Unwrap<T>(this UnmanagedArray16<T> obj)
            where T : unmanaged
        {
            unsafe
            {
                int len = sizeof(UnmanagedArray16<T>);

                T[] arr = new T[16];
                fixed (T* ptr = arr)
                {
                    Buffer.MemoryCopy(&obj, ptr, len, len);
                    return arr;
                }
            }
        }

        public static T[] Unwrap<T>(this UnmanagedArray32<T> obj)
            where T : unmanaged
        {
            unsafe
            {
                int len = sizeof(UnmanagedArray32<T>);

                T[] arr = new T[32];
                fixed (T* ptr = arr)
                {
                    Buffer.MemoryCopy(&obj, ptr, len, len);
                    return arr;
                }
            }
        }

        public static T[] Unwrap<T>(this UnmanagedArray256<T> obj)
            where T : unmanaged
        {
            unsafe
            {
                int len = sizeof(UnmanagedArray256<T>);

                T[] arr = new T[256];
                fixed (T* ptr = arr)
                {
                    Buffer.MemoryCopy(&obj, ptr, len, len);
                    return arr;
                }
            }
        }
        public static string StructureToString<T>(this T obj, Encoding encoding)
            where T : unmanaged
            => encoding.GetString(obj.StructureToByteArray());
    }
}
