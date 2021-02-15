

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageMemoryBind
    {
        public VkImageSubresource Subresource { get; init; }

        public VkOffset3D Offset { get; init; }

        public VkExtent3D Extent { get; init; }

        public VkDeviceMemory Memory { get; init; }

        public VkDeviceSize MemoryOffset { get; init; }

        public VkSparseMemoryBindFlags Flags { get; init; }
    }
}
