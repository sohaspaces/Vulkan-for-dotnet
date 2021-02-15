

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
using Vulkan.Handles.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplaySurfaceCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDisplaySurfaceCreateFlags Flags { get; init; }

        public VkDisplayMode DisplayMode { get; init; }

        public uint PlaneIndex { get; init; }

        public uint PlaneStackIndex { get; init; }

        public VkSurfaceTransformFlags Transform { get; init; }

        public float GlobalAlpha { get; init; }

        public VkDisplayPlaneAlphaFlags AlphaMode { get; init; }

        public VkExtent2D ImageExtent { get; init; }
    }
}
