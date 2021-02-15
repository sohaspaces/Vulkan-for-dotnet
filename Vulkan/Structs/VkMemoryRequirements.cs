

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryRequirements
    {
        public VkDeviceSize Size { get; init; }

        public VkDeviceSize Alignment { get; init; }

        public uint MemoryTypeBits { get; init; }
    }
}
