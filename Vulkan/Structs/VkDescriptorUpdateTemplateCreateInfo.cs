

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorUpdateTemplateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDescriptorUpdateTemplateCreateFlags Flags { get; init; }

        public uint DescriptorUpdateEntryCount { get; init; }

        public unsafe VkDescriptorUpdateTemplateEntry* DescriptorUpdateEntries { get; init; }

        public VkDescriptorUpdateTemplateType TemplateType { get; init; }

        public VkDescriptorSetLayout DescriptorSetLayout { get; init; }

        public VkPipelineBindPoint PipelineBindPoint { get; init; }

        public VkPipelineLayout PipelineLayout { get; init; }

        public uint Set { get; init; }
    }
}
