

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceImageFormatInfo2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkFormat Format { get; init; }

        public VkImageType Type { get; init; }

        public VkImageTiling Tiling { get; init; }

        public VkImageUsageFlags Usage { get; init; }

        public VkImageCreateFlags Flags { get; init; }
    }
}
