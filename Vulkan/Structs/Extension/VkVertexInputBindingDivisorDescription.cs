

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputBindingDivisorDescription
    {
        public uint Binding { get; init; }

        public uint Divisor { get; init; }
    }
}
