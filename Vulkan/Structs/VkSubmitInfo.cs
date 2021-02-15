

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubmitInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint WaitSemaphoreCount { get; init; }

        public unsafe VkSemaphore* WaitSemaphores { get; init; }

        public unsafe VkPipelineStageFlags* WaitDstStageMask { get; init; }

        public uint CommandBufferCount { get; init; }

        public unsafe VkCommandBuffer* CommandBuffers { get; init; }

        public uint SignalSemaphoreCount { get; init; }

        public unsafe VkSemaphore* SignalSemaphores { get; init; }
    }
}
