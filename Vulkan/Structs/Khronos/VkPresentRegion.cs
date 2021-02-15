

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPresentRegion
    {
        public uint RectangleCount { get; init; }

        public unsafe VkRectLayer* Rectangles { get; init; }
    }
}
