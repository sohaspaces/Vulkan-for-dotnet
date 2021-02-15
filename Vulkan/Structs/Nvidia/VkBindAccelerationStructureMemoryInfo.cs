

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
using Vulkan.Handles.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindAccelerationStructureMemoryInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkAccelerationStructure AccelerationStructure { get; init; }

        public VkDeviceMemory Memory { get; init; }

        public VkDeviceSize MemoryOffset { get; init; }

        public uint DeviceIndexCount { get; init; }

        public unsafe uint* DeviceIndices { get; init; }
    }
}
