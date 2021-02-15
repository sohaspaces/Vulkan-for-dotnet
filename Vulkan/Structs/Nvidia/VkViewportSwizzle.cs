

using System.Runtime.InteropServices;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkViewportSwizzle
    {
        public VkViewportCoordinateSwizzle X { get; init; }

        public VkViewportCoordinateSwizzle Y { get; init; }

        public VkViewportCoordinateSwizzle Z { get; init; }

        public VkViewportCoordinateSwizzle W { get; init; }
    }
}
