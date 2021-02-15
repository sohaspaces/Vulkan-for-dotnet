

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSurfaceFormat
    {
        public VkFormat Format { get; init; }

        public VkColorSpace ColorSpace { get; init; }
    }
}
