

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMaintenance3Properties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint MaxPerSetDescriptors { get; init; }

        public VkDeviceSize MaxMemoryAllocationSize { get; init; }
    }
}
