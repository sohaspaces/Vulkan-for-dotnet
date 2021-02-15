

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferCopy
    {
        public VkDeviceSize SrcOffset { get; init; }

        public VkDeviceSize DstOffset { get; init; }

        public VkDeviceSize Size { get; init; }
    }
}
