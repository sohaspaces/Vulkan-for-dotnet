

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceInlineUniformBlockProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint MaxInlineUniformBlockSize { get; init; }

        public uint MaxPerStageDescriptorInlineUniformBlocks { get; init; }

        public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks { get; init; }

        public uint MaxDescriptorSetInlineUniformBlocks { get; init; }

        public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks { get; init; }
    }
}
