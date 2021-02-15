

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueryPoolCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkQueryPoolCreateFlags Flags { get; init; }

        public VkQueryType QueryType { get; init; }

        public uint QueryCount { get; init; }

        public VkQueryPipelineStatisticFlags PipelineStatistics { get; init; }
    }
}
