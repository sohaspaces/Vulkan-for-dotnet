

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSurfaceInfo2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkSurface Surface { get; init; }
    }
}
