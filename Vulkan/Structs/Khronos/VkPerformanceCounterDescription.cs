using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceCounterDescription
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPerformanceCounterDescriptionFlags Flags { get; init; }

        public UnmanagedString256 Name { get; init; }
        public UnmanagedString256 Category { get; init; }
        public UnmanagedString256 Description { get; init; }
    }
}
