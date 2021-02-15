

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSurfaceCapabilities2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint MinImageCount { get; init; }

        public uint MaxImageCount { get; init; }

        public VkExtent2D CurrentExtent { get; init; }

        public VkExtent2D MinImageExtent { get; init; }

        public VkExtent2D MaxImageExtent { get; init; }

        public uint MaxImageArrayLayers { get; init; }

        public VkSurfaceTransformFlags SupportedTransforms { get; init; }

        public VkSurfaceTransformFlags CurrentTransform { get; init; }

        public VkCompositeAlphaFlags SupportedCompositeAlpha { get; init; }

        public VkImageUsageFlags SupportedUsageFlags { get; init; }

        public VkSurfaceCounterFlags SupportedSurfaceCounters { get; init; }
    }
}
