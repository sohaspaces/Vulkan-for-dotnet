

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferImageCopy
    {
        public VkDeviceSize BufferOffset { get; init; }

        public uint BufferRowLength { get; init; }

        public uint BufferImageHeight { get; init; }

        public VkImageSubresourceLayers ImageSubresource { get; init; }

        public VkOffset3D ImageOffset { get; init; }

        public VkExtent3D ImageExtent { get; init; }
    }
}
