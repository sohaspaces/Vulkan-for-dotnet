using System.Runtime.InteropServices;
namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBool32
    {
        private int rawValue;

        public static explicit operator VkBool32(int x)
            => new VkBool32() { rawValue = x };
        public static explicit operator int(VkBool32 x)
            => x.rawValue;

        public static implicit operator VkBool32(bool x)
            => new VkBool32() { rawValue = x ? 1 : 0 };
        public static implicit operator bool(VkBool32 x)
            => x.rawValue != 0;
    }
}
