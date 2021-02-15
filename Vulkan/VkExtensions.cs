using System.Text;
using Vulkan.Enums;
namespace Vulkan
{
    public static class VkExtensions
    {
        public static uint MakeVersion(this (int, int, int) tuple)
            => (uint)((tuple.Item1 << 22) + (tuple.Item2 << 12) + tuple.Item3);

        public static unsafe byte* GetPointer(this string x, Encoding encoding)
        {
            var bytes = encoding.GetBytes(x);
            fixed (byte* ptr = bytes)
                return ptr;
        }

        public static void AssertSuccess(this VkResult result, string function)
        {
            if (result.ToString().StartsWith("Error"))
                throw new VulkanException(function, result);
        }
    }
}
