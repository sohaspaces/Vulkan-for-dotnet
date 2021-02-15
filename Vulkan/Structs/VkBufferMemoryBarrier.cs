

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferMemoryBarrier
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkAccessFlags SrcAccessMask { get; init; }

        public VkAccessFlags DstAccessMask { get; init; }

        public uint SrcQueueFamilyIndex { get; init; }

        public uint DstQueueFamilyIndex { get; init; }

        public VkBuffer Buffer { get; init; }

        public VkDeviceSize Offset { get; init; }

        public VkDeviceSize Size { get; init; }
    }
}
