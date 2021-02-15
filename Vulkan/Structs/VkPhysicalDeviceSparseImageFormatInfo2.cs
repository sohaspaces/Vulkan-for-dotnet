

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSparseImageFormatInfo2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkFormat Format { get; init; }

        public VkImageType Type { get; init; }

        public VkSampleCountFlags Samples { get; init; }

        public VkImageUsageFlags Usage { get; init; }

        public VkImageTiling Tiling { get; init; }
    }
}
