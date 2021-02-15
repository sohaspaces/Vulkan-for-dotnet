

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFramebufferAttachmentImageInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkImageCreateFlags Flags { get; init; }

        public VkImageUsageFlags Usage { get; init; }

        public uint Width { get; init; }

        public uint Height { get; init; }

        public uint LayerCount { get; init; }

        public uint ViewFormatCount { get; init; }

        public unsafe VkFormat* ViewFormats { get; init; }
    }
}
