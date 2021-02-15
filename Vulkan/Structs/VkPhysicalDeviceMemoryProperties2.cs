using Vulkan.Enums;
namespace Vulkan.Structs
{
    public unsafe struct VkPhysicalDeviceMemoryProperties2
    {
        public VkStructureType StructureType { get; init; }
        public void* Next { get; init; }
        public VkPhysicalDeviceMemoryProperties MemoryProperties { get; init; }
    }
}
