

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputAttributeDescription
    {
        public uint Location { get; init; }

        public uint Binding { get; init; }

        public VkFormat Format { get; init; }

        public uint Offset { get; init; }
    }
}
