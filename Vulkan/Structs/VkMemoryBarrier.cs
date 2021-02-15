

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryBarrier
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkAccessFlags SrcAccessMask { get; init; }

        public VkAccessFlags DstAccessMask { get; init; }
    }
}
