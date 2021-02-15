

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVulkanMemoryModelFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 VulkanMemoryModel { get; init; }

        public VkBool32 VulkanMemoryModelDeviceScope { get; init; }

        public VkBool32 VulkanMemoryModelAvailabilityVisibilityChains { get; init; }
    }
}
