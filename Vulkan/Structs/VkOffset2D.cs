

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkOffset2D
    {
        public int X { get; init; }

        public int Y { get; init; }
    }
}
