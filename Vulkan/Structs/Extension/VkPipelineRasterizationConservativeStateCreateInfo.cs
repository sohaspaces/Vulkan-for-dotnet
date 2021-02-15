

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRasterizationConservativeStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineRasterizationConservativeStateCreateFlags Flags { get; init; }

        public VkConservativeRasterizationMode ConservativeRasterizationMode { get; init; }

        public float ExtraPrimitiveOverestimationSize { get; init; }
    }
}
