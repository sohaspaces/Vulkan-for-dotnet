using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceProperties2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }
        public VkPhysicalDeviceProperties Properties { get; init; }
    }
}
