

using System.Runtime.InteropServices;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCoarseSampleOrderCustom
    {
        public VkShadingRatePaletteEntry ShadingRate { get; init; }

        public uint SampleCount { get; init; }

        public uint SampleLocationCount { get; init; }

        public unsafe VkCoarseSampleLocation* SampleLocations { get; init; }
    }
}
