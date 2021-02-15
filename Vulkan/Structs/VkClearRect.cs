

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkClearRect
    {
        public VkRect2D Rect { get; init; }

        public uint BaseArrayLayer { get; init; }

        public uint LayerCount { get; init; }
    }
}
