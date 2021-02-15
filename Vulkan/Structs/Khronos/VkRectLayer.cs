

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRectLayer
    {
        public VkOffset2D Offset { get; init; }

        public VkExtent2D Extent { get; init; }

        public uint Layer { get; init; }
    }
}
