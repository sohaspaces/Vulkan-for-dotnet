

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometry
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkGeometryType GeometryType { get; init; }

        public VkGeometryData Geometry { get; init; }

        public VkGeometryFlags Flags { get; init; }
    }
}
