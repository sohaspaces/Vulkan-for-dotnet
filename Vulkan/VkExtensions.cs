using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Vulkan.Enums;
namespace Vulkan
{
    public static class VkExtensions
    {
        private static readonly HashSet<object> pins = new HashSet<object>();

        static VkExtensions()
        {
            AppDomain.CurrentDomain.DomainUnload += Unload;
        }

        private static void Unload(object sender, EventArgs e)
        {
            GC.KeepAlive(pins);
        }

        public static uint MakeVersion(this (int, int, int) tuple)
            => (uint)((tuple.Item1 << 22) + (tuple.Item2 << 12) + tuple.Item3);

        public static unsafe byte* Pin(this string x, Encoding encoding)
        {
            var bytes = encoding.GetBytes(x);
            pins.Add(bytes);
            fixed (byte* ptr = bytes)
                return ptr;
        }

        public static unsafe T* Pin<T>(this T[] x, uint offset = 0)
            where T : unmanaged
        {
            pins.Add(x);
            fixed (T* ptr = x)
                return ptr + offset;
        }


        public static unsafe T** Pin<T>(this T*[] x, uint offset = 0)
            where T : unmanaged
        {
            pins.Add(x);
            fixed (T** ptr = x)
                return ptr + offset;
        }

        public static unsafe T* Pin<T>(ref this T x)
            where T : unmanaged
            => (T*)Unsafe.AsPointer(ref x);

        public static unsafe string ReadCstr(byte* ptr, Encoding encoding)
        {
            var list = new List<byte>();
            while (*ptr != 0)
            {
                list.Add(*ptr);
                ptr++;
            }
            return encoding.GetString(list.ToArray());
        }

        private static readonly HashSet<VkResult> WhitelistResult = new HashSet<VkResult>()
        {
            VkResult.Success,
            //VkResult.Incomplete
        };

        public static void AssertSuccess(this VkResult result, string function)
        {
            if (!WhitelistResult.Contains(result))
                throw new VulkanException(function, result);
            Console.WriteLine($"Success!: {function}");
        }
    }
}
