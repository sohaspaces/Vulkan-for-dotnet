

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkWriteDescriptorSetAccelerationStructure
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint AccelerationStructureCount { get; init; }

        public unsafe VkAccelerationStructure* AccelerationStructures { get; init; }
    }
}
