

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferViewCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBufferViewCreateFlags Flags { get; init; }

        public VkBuffer Buffer { get; init; }

        public VkFormat Format { get; init; }

        public VkDeviceSize Offset { get; init; }

        public VkDeviceSize Range { get; init; }
    }
}
