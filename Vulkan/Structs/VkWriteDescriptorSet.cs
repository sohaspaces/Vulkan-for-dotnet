

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkWriteDescriptorSet
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDescriptorSet DstSet { get; init; }

        public uint DstBinding { get; init; }

        public uint DstArrayElement { get; init; }

        public uint DescriptorCount { get; init; }

        public VkDescriptorType DescriptorType { get; init; }

        public unsafe VkDescriptorImageInfo* ImageInfo { get; init; }

        public unsafe VkDescriptorBufferInfo* BufferInfo { get; init; }

        public unsafe VkBufferView* TexelBufferView { get; init; }
    }
}
