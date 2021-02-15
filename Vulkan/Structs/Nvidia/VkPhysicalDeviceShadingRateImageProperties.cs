

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShadingRateImageProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkExtent2D ShadingRateTexelSize { get; init; }

        public uint ShadingRatePaletteSize { get; init; }

        public uint ShadingRateMaxCoarseSamples { get; init; }
    }
}
