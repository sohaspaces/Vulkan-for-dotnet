

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometryAABB
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBuffer AabbData { get; init; }

        public uint NumAABBs { get; init; }

        public uint Stride { get; init; }

        public VkDeviceSize Offset { get; init; }
    }
}
