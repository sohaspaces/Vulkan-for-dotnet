

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceGroupBindSparseInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint ResourceDeviceIndex { get; init; }

        public uint MemoryDeviceIndex { get; init; }
    }
}
