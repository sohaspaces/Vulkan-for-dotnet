

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Google
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAndroidHardwareBufferFormatProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkFormat Format { get; init; }

        public ulong ExternalFormat { get; init; }

        public VkFormatFeatureFlags FormatFeatures { get; init; }

        public VkComponentMapping SamplerYcbcrConversionComponents { get; init; }

        public VkSamplerYcbcrModelConversion SuggestedYcbcrModel { get; init; }

        public VkSamplerYcbcrRange SuggestedYcbcrRange { get; init; }

        public VkChromaLocation SuggestedXChromaOffset { get; init; }

        public VkChromaLocation SuggestedYChromaOffset { get; init; }
    }
}
