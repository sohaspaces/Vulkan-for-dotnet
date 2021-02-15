

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueryPoolPerformanceCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint QueueFamilyIndex { get; init; }

        public uint CounterIndexCount { get; init; }

        public unsafe uint* CounterIndices { get; init; }
    }
}
