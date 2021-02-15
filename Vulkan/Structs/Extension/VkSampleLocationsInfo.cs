

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSampleLocationsInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkSampleCountFlags SampleLocationsPerPixel { get; init; }

        public VkExtent2D SampleLocationGridSize { get; init; }

        public uint SampleLocationsCount { get; init; }

        public unsafe VkSampleLocation* SampleLocations { get; init; }
    }
}
