

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSamplerYcbcrConversionCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkFormat Format { get; init; }

        public VkSamplerYcbcrModelConversion YcbcrModel { get; init; }

        public VkSamplerYcbcrRange YcbcrRange { get; init; }

        public VkComponentMapping Components { get; init; }

        public VkChromaLocation XChromaOffset { get; init; }

        public VkChromaLocation YChromaOffset { get; init; }

        public VkFilter ChromaFilter { get; init; }

        public VkBool32 ForceExplicitReconstruction { get; init; }
    }
}
