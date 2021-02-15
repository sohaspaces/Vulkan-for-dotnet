

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMeshShaderProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint MaxDrawMeshTasksCount { get; init; }

        public uint MaxTaskWorkGroupInvocations { get; init; }

        public UnmanagedArray3<uint> MaxTaskWorkGroupSize { get; init; }

        public uint MaxTaskTotalMemorySize { get; init; }

        public uint MaxTaskOutputCount { get; init; }

        public uint MaxMeshWorkGroupInvocations { get; init; }

        public UnmanagedArray3<uint> MaxMeshWorkGroupSize { get; init; }

        public uint MaxMeshTotalMemorySize { get; init; }

        public uint MaxMeshOutputVertices { get; init; }

        public uint MaxMeshOutputPrimitives { get; init; }

        public uint MaxMeshMultiviewViewCount { get; init; }

        public uint MeshOutputPerVertexGranularity { get; init; }

        public uint MeshOutputPerPrimitiveGranularity { get; init; }
    }
}
