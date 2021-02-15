

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCommandBufferAllocateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkCommandPool CommandPool { get; init; }

        public VkCommandBufferLevel Level { get; init; }

        public uint CommandBufferCount { get; init; }
    }
}
