

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMemoryPriorityFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 MemoryPriority { get; init; }
    }
}
