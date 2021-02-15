using System.Runtime.InteropServices;
namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSampleMask
    {
        private uint rawValue;

        public static implicit operator VkSampleMask(uint x)
            => new VkSampleMask() { rawValue = x };
        public static implicit operator uint(VkSampleMask x)
            => x.rawValue;
    }
}
