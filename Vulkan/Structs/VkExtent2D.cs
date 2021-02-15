

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExtent2D
    {
        public uint Width { get; init; }

        public uint Height { get; init; }
    }
}
