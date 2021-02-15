

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorImageInfo
    {
        public VkSampler Sampler { get; init; }

        public VkImageView ImageView { get; init; }

        public VkImageLayout ImageLayout { get; init; }
    }
}
