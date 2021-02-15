using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    public unsafe struct VkPhysicalDeviceGroupProperties
    {
        public VkStructureType StructureType { get; init; }
        public void* Next { get; init; }
        public uint PhysicalDeviceCount { get; init; }
        public UnmanagedArray32<VkPhysicalDevice> PhysicalDevices { get; init; }
        public VkBool32 SubsetAllocation { get; init; }
    }
}
