

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineMultisampleStateCreateFlags Flags { get; init; }

        public VkSampleCountFlags RasterizationSamples { get; init; }

        public VkBool32 SampleShadingEnable { get; init; }

        public float MinSampleShading { get; init; }

        public unsafe VkSampleMask* SampleMask { get; init; }

        public VkBool32 AlphaToCoverageEnable { get; init; }

        public VkBool32 AlphaToOneEnable { get; init; }
    }
}
