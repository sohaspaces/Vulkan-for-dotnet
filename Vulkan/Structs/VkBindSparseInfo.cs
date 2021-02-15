

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindSparseInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint WaitSemaphoreCount { get; init; }

        public unsafe VkSemaphore* WaitSemaphores { get; init; }

        public uint BufferBindCount { get; init; }

        public unsafe VkSparseBufferMemoryBindInfo* BufferBinds { get; init; }

        public uint ImageOpaqueBindCount { get; init; }

        public unsafe VkSparseImageOpaqueMemoryBindInfo* ImageOpaqueBinds { get; init; }

        public uint ImageBindCount { get; init; }

        public unsafe VkSparseImageMemoryBindInfo* ImageBinds { get; init; }

        public uint SignalSemaphoreCount { get; init; }

        public unsafe VkSemaphore* SignalSemaphores { get; init; }
    }
}
