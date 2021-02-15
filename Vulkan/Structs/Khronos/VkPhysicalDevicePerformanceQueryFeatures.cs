

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevicePerformanceQueryFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 PerformanceCounterQueryPools { get; init; }

        public VkBool32 PerformanceCounterMultipleQueryPools { get; init; }
    }
}
