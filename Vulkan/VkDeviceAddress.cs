using System.Runtime.InteropServices;
namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceAddress
    {
        private ulong rawValue;

        public static explicit operator VkDeviceAddress(ulong x)
            => new VkDeviceAddress() { rawValue = x };
        public static explicit operator ulong(VkDeviceAddress x)
            => x.rawValue;
    }
}
