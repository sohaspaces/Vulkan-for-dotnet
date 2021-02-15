

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSampleLocationsProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkSampleCountFlags SampleLocationSampleCounts { get; init; }

        public VkExtent2D MaxSampleLocationGridSize { get; init; }

        public UnmanagedArray2<float> SampleLocationCoordinateRange { get; init; }

        public uint SampleLocationSubPixelBits { get; init; }

        public VkBool32 VariableSampleLocations { get; init; }
    }
}
