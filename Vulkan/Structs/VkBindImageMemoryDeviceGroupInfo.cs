

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindImageMemoryDeviceGroupInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint DeviceIndexCount { get; init; }

        public unsafe uint* DeviceIndices { get; init; }

        public uint SplitInstanceBindRegionCount { get; init; }

        public unsafe VkRect2D* SplitInstanceBindRegions { get; init; }
    }
}
