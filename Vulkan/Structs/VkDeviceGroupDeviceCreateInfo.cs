

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceGroupDeviceCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint PhysicalDeviceCount { get; init; }

        public unsafe VkPhysicalDevice* PhysicalDevices { get; init; }
    }
}
