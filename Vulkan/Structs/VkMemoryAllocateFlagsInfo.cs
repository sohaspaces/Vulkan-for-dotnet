

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryAllocateFlagsInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkMemoryAllocateFlags Flags { get; init; }

        public uint DeviceMask { get; init; }
    }
}
