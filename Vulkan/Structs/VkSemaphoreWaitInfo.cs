

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSemaphoreWaitInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkSemaphoreWaitFlags Flags { get; init; }

        public uint SemaphoreCount { get; init; }

        public unsafe VkSemaphore* Semaphores { get; init; }

        public unsafe ulong* Values { get; init; }
    }
}
