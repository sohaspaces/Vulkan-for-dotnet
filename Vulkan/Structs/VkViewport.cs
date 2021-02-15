

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkViewport
    {
        public float X { get; init; }

        public float Y { get; init; }

        public float Width { get; init; }

        public float Height { get; init; }

        public float MinDepth { get; init; }

        public float MaxDepth { get; init; }
    }
}
