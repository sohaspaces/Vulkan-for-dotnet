

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkImageCreateFlags Flags { get; init; }

        public VkImageType ImageType { get; init; }

        public VkFormat Format { get; init; }

        public VkExtent3D Extent { get; init; }

        public uint MipLevels { get; init; }

        public uint ArrayLayers { get; init; }

        public VkSampleCountFlags Samples { get; init; }

        public VkImageTiling Tiling { get; init; }

        public VkImageUsageFlags Usage { get; init; }

        public VkSharingMode SharingMode { get; init; }

        public uint QueueFamilyIndexCount { get; init; }

        public unsafe uint* QueueFamilyIndices { get; init; }

        public VkImageLayout InitialLayout { get; init; }
    }
}
