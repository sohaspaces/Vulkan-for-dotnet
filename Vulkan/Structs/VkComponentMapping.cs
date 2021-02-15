

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkComponentMapping
    {
        public VkComponentSwizzle R { get; init; }

        public VkComponentSwizzle G { get; init; }

        public VkComponentSwizzle B { get; init; }

        public VkComponentSwizzle A { get; init; }
    }
}
