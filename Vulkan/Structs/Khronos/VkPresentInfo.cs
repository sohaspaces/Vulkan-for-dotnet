

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
using Vulkan.Handles.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPresentInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint WaitSemaphoreCount { get; init; }

        public unsafe VkSemaphore* WaitSemaphores { get; init; }

        public uint SwapchainCount { get; init; }

        public unsafe VkSwapchain* Swapchains { get; init; }

        public unsafe uint* ImageIndices { get; init; }

        public unsafe VkResult* Results { get; init; }
    }
}
