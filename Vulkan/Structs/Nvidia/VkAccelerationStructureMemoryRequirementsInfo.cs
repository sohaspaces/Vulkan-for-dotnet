

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia;
using Vulkan.Handles.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureMemoryRequirementsInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkAccelerationStructureMemoryRequirementsType Type { get; init; }

        public VkAccelerationStructure AccelerationStructure { get; init; }
    }
}
