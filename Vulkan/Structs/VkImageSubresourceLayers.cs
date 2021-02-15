

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageSubresourceLayers
    {
        public VkImageAspectFlags AspectMask { get; init; }

        public uint MipLevel { get; init; }

        public uint BaseArrayLayer { get; init; }

        public uint LayerCount { get; init; }
    }
}
