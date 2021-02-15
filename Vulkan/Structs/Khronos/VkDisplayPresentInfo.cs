

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPresentInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkRect2D SrcRect { get; init; }

        public VkRect2D DstRect { get; init; }

        public VkBool32 Persistent { get; init; }
    }
}
