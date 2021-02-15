

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageFormatProperties
    {
        public VkExtent3D MaxExtent { get; init; }

        public uint MaxMipLevels { get; init; }

        public uint MaxArrayLayers { get; init; }

        public VkSampleCountFlags SampleCounts { get; init; }

        public VkDeviceSize MaxResourceSize { get; init; }
    }
}
