

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkAccelerationStructureType Type { get; init; }

        public VkBuildAccelerationStructureFlags Flags { get; init; }

        public uint InstanceCount { get; init; }

        public uint GeometryCount { get; init; }

        public unsafe VkGeometry* Geometries { get; init; }
    }
}
