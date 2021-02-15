using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkWaylandSurfaceCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkWaylandSurfaceCreateFlags Flags { get; init; }



        public nint Display { get; init; }



        public nint Surface { get; init; }
    }
}
