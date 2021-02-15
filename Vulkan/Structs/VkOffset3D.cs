

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkOffset3D
    {
        public int X { get; init; }

        public int Y { get; init; }

        public int Z { get; init; }
    }
}
