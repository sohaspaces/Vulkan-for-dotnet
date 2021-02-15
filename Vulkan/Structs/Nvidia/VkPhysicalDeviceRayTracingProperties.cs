

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRayTracingProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint ShaderGroupHandleSize { get; init; }

        public uint MaxRecursionDepth { get; init; }

        public uint MaxShaderGroupStride { get; init; }

        public uint ShaderGroupBaseAlignment { get; init; }

        public ulong MaxGeometryCount { get; init; }

        public ulong MaxInstanceCount { get; init; }

        public ulong MaxTriangleCount { get; init; }

        public uint MaxDescriptorSetAccelerationStructures { get; init; }
    }
}
