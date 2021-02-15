

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineLayoutCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineLayoutCreateFlags Flags { get; init; }

        public uint SetLayoutCount { get; init; }

        public unsafe VkDescriptorSetLayout* SetLayouts { get; init; }

        public uint PushConstantRangeCount { get; init; }

        public unsafe VkPushConstantRange* PushConstantRanges { get; init; }
    }
}
