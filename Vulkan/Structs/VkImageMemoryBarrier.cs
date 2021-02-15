

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageMemoryBarrier
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkAccessFlags SrcAccessMask { get; init; }

        public VkAccessFlags DstAccessMask { get; init; }

        public VkImageLayout OldLayout { get; init; }

        public VkImageLayout NewLayout { get; init; }

        public uint SrcQueueFamilyIndex { get; init; }

        public uint DstQueueFamilyIndex { get; init; }

        public VkImage Image { get; init; }

        public VkImageSubresourceRange SubresourceRange { get; init; }
    }
}
