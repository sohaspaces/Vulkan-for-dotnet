

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkTimelineSemaphoreSubmitInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint WaitSemaphoreValueCount { get; init; }

        public unsafe ulong* WaitSemaphoreValues { get; init; }

        public uint SignalSemaphoreValueCount { get; init; }

        public unsafe ulong* SignalSemaphoreValues { get; init; }
    }
}
