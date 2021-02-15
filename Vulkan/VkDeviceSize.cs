using System.Runtime.InteropServices;
namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceSize
    {
        private ulong rawValue;

        public static explicit operator VkDeviceSize(ulong x)
            => new VkDeviceSize() { rawValue = x };
        public static explicit operator ulong(VkDeviceSize x)
            => x.rawValue;
    }
}
