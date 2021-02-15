

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputBindingDescription
    {
        public uint Binding { get; init; }

        public uint Stride { get; init; }

        public VkVertexInputRate InputRate { get; init; }
    }
}
