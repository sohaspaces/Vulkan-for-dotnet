

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometryTriangles
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBuffer VertexData { get; init; }

        public VkDeviceSize VertexOffset { get; init; }

        public uint VertexCount { get; init; }

        public VkDeviceSize VertexStride { get; init; }

        public VkFormat VertexFormat { get; init; }

        public VkBuffer IndexData { get; init; }

        public VkDeviceSize IndexOffset { get; init; }

        public uint IndexCount { get; init; }

        public VkIndexType IndexType { get; init; }

        public VkBuffer TransformData { get; init; }

        public VkDeviceSize TransformOffset { get; init; }
    }
}
