

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkD3D12FenceSubmitInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint WaitSemaphoreValuesCount { get; init; }

        public unsafe ulong* WaitSemaphoreValues { get; init; }

        public uint SignalSemaphoreValuesCount { get; init; }

        public unsafe ulong* SignalSemaphoreValues { get; init; }
    }
}
