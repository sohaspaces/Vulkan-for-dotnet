

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageMemoryRequirements
    {
        public VkSparseImageFormatProperties FormatProperties { get; init; }

        public uint ImageMipTailFirstLod { get; init; }

        public VkDeviceSize ImageMipTailSize { get; init; }

        public VkDeviceSize ImageMipTailOffset { get; init; }

        public VkDeviceSize ImageMipTailStride { get; init; }
    }
}
