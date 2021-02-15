

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia.Experimental
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceGeneratedCommandsLimits
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint MaxIndirectCommandsLayoutTokenCount { get; init; }

        public uint MaxObjectEntryCounts { get; init; }

        public uint MinSequenceCountBufferOffsetAlignment { get; init; }

        public uint MinSequenceIndexBufferOffsetAlignment { get; init; }

        public uint MinCommandsTokenBufferOffsetAlignment { get; init; }
    }
}
