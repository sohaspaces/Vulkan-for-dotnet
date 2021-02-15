

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindBufferMemoryDeviceGroupInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint DeviceIndexCount { get; init; }

        public unsafe uint* DeviceIndices { get; init; }
    }
}
