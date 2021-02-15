

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Intel;
namespace Vulkan.Structs.Intel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueryPoolPerformanceQueryCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkQueryPoolSamplingMode PerformanceCountersSampling { get; init; }
    }
}
