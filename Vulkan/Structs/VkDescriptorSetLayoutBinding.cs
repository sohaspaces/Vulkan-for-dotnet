

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorSetLayoutBinding
    {
        public uint Binding { get; init; }

        public VkDescriptorType DescriptorType { get; init; }

        public uint DescriptorCount { get; init; }

        public VkShaderStageFlags StageFlags { get; init; }

        public unsafe VkSampler* ImmutableSamplers { get; init; }
    }
}
