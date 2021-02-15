

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageSubresourceRange
    {
        public VkImageAspectFlags AspectMask { get; init; }

        public uint BaseMipLevel { get; init; }

        public uint LevelCount { get; init; }

        public uint BaseArrayLayer { get; init; }

        public uint LayerCount { get; init; }
    }
}
