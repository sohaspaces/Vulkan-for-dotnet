

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSamplerCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkSamplerCreateFlags Flags { get; init; }

        public VkFilter MagFilter { get; init; }

        public VkFilter MinFilter { get; init; }

        public VkSamplerMipmapMode MipmapMode { get; init; }

        public VkSamplerAddressMode AddressModeU { get; init; }

        public VkSamplerAddressMode AddressModeV { get; init; }

        public VkSamplerAddressMode AddressModeW { get; init; }

        public float MipLodBias { get; init; }

        public VkBool32 AnisotropyEnable { get; init; }

        public float MaxAnisotropy { get; init; }

        public VkBool32 CompareEnable { get; init; }

        public VkCompareOp CompareOp { get; init; }

        public float MinLod { get; init; }

        public float MaxLod { get; init; }

        public VkBorderColor BorderColor { get; init; }

        public VkBool32 UnnormalizedCoordinates { get; init; }
    }
}
