

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFramebufferMixedSamplesCombination
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkCoverageReductionMode CoverageReductionMode { get; init; }

        public VkSampleCountFlags RasterizationSamples { get; init; }

        public VkSampleCountFlags DepthStencilSamples { get; init; }

        public VkSampleCountFlags ColorSamples { get; init; }
    }
}
