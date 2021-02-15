

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCopyDescriptorSet
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDescriptorSet SrcSet { get; init; }

        public uint SrcBinding { get; init; }

        public uint SrcArrayElement { get; init; }

        public VkDescriptorSet DstSet { get; init; }

        public uint DstBinding { get; init; }

        public uint DstArrayElement { get; init; }

        public uint DescriptorCount { get; init; }
    }
}
