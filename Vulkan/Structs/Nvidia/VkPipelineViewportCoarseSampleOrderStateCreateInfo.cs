

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineViewportCoarseSampleOrderStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkCoarseSampleOrderType SampleOrderType { get; init; }

        public uint CustomSampleOrderCount { get; init; }

        public unsafe VkCoarseSampleOrderCustom* CustomSampleOrders { get; init; }
    }
}
