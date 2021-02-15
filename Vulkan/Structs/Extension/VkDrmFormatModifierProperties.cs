

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrmFormatModifierProperties
    {
        public ulong DrmFormatModifier { get; init; }

        public uint DrmFormatModifierPlaneCount { get; init; }

        public VkFormatFeatureFlags DrmFormatModifierTilingFeatures { get; init; }
    }
}
