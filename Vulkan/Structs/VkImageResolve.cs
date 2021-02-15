

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageResolve
    {
        public VkImageSubresourceLayers SrcSubresource { get; init; }

        public VkOffset3D SrcOffset { get; init; }

        public VkImageSubresourceLayers DstSubresource { get; init; }

        public VkOffset3D DstOffset { get; init; }

        public VkExtent3D Extent { get; init; }
    }
}
