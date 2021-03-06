

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFeatures2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPhysicalDeviceFeatures Features { get; init; }
    }
}
