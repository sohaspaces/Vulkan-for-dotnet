using System.Runtime.InteropServices;
namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFlags
    {
        private uint rawValue;

        public static implicit operator VkFlags(uint x)
            => new VkFlags() { rawValue = x };
        public static implicit operator uint(VkFlags x)
            => x.rawValue;
    }
}
