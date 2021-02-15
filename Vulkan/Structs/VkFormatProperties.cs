

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFormatProperties
    {
        public VkFormatFeatureFlags LinearTilingFeatures { get; init; }

        public VkFormatFeatureFlags OptimalTilingFeatures { get; init; }

        public VkFormatFeatureFlags BufferFeatures { get; init; }
    }
}
