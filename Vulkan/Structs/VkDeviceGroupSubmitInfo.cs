

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceGroupSubmitInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint WaitSemaphoreCount { get; init; }

        public unsafe uint* WaitSemaphoreDeviceIndices { get; init; }

        public uint CommandBufferCount { get; init; }

        public unsafe uint* CommandBufferDeviceMasks { get; init; }

        public uint SignalSemaphoreCount { get; init; }

        public unsafe uint* SignalSemaphoreDeviceIndices { get; init; }
    }
}
