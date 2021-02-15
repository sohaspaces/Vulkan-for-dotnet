using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineExecutableStatistic
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public UnmanagedString256 Name { get; init; }
        public UnmanagedString256 Description { get; init; }

        public VkPipelineExecutableStatisticFormat Format { get; init; }
        public VkPipelineExecutableStatisticsValue Value { get; init; }
    }
}
