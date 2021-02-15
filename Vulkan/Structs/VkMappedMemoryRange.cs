

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMappedMemoryRange
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDeviceMemory Memory { get; init; }

        public VkDeviceSize Offset { get; init; }

        public VkDeviceSize Size { get; init; }
    }
}
