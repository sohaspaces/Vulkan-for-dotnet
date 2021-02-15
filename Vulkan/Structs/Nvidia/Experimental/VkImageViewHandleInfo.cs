

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs.Nvidia.Experimental
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageViewHandleInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkImageView ImageView { get; init; }

        public VkDescriptorType DescriptorType { get; init; }

        public VkSampler Sampler { get; init; }
    }
}
