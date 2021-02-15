

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometryData
    {
        public VkGeometryTriangles Triangles { get; init; }

        public VkGeometryAABB Aabbs { get; init; }
    }
}
