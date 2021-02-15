

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRect2D
    {
        public VkOffset2D Offset { get; init; }

        public VkExtent2D Extent { get; init; }
    }
}
