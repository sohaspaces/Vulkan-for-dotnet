

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineViewportShadingRateImageStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 ShadingRateImageEnable { get; init; }

        public uint ViewportCount { get; init; }

        public unsafe VkShadingRatePalette* ShadingRatePalettes { get; init; }
    }
}
