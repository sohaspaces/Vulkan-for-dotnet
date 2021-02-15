

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageBlit
    {
        public VkImageSubresourceLayers SrcSubresource { get; init; }

        public (VkOffset3D, VkOffset3D) SrcOffsets { get; init; }

        public VkImageSubresourceLayers DstSubresource { get; init; }

        public (VkOffset3D, VkOffset3D) DstOffsets { get; init; }
    }
}
