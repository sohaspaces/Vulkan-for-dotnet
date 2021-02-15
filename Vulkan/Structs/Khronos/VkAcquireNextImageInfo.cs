

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
using Vulkan.Handles.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAcquireNextImageInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkSwapchain Swapchain { get; init; }

        public ulong Timeout { get; init; }

        public VkSemaphore Semaphore { get; init; }

        public VkFence Fence { get; init; }

        public uint DeviceMask { get; init; }
    }
}
