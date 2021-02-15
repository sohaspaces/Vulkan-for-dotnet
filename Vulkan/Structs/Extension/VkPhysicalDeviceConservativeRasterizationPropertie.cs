

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceConservativeRasterizationProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public float PrimitiveOverestimationSize { get; init; }

        public float MaxExtraPrimitiveOverestimationSize { get; init; }

        public float ExtraPrimitiveOverestimationSizeGranularity { get; init; }

        public VkBool32 PrimitiveUnderestimation { get; init; }

        public VkBool32 ConservativePointAndLineRasterization { get; init; }

        public VkBool32 DegenerateTrianglesRasterized { get; init; }

        public VkBool32 DegenerateLinesRasterized { get; init; }

        public VkBool32 FullyCoveredFragmentShaderInputVariable { get; init; }

        public VkBool32 ConservativeRasterizationPostDepthCoverage { get; init; }
    }
}
