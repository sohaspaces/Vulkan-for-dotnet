using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceCounter
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPerformanceCounterUnit Unit { get; init; }
        public VkPerformanceCounterScope Scope { get; init; }
        public VkPerformanceCounterStorage Storage { get; init; }

        public UnmanagedArray16<uint> Uuid { get; init; }
    }
}
