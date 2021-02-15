

using System.Runtime.InteropServices;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPlaneCapabilities
    {
        public VkDisplayPlaneAlphaFlags SupportedAlpha { get; init; }

        public VkOffset2D MinSrcPosition { get; init; }

        public VkOffset2D MaxSrcPosition { get; init; }

        public VkExtent2D MinSrcExtent { get; init; }

        public VkExtent2D MaxSrcExtent { get; init; }

        public VkOffset2D MinDstPosition { get; init; }

        public VkOffset2D MaxDstPosition { get; init; }

        public VkExtent2D MinDstExtent { get; init; }

        public VkExtent2D MaxDstExtent { get; init; }
    }
}
