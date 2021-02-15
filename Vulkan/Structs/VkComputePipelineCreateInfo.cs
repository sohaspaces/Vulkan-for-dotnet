

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkComputePipelineCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineCreateFlags Flags { get; init; }

        public VkPipelineShaderStageCreateInfo Stage { get; init; }

        public VkPipelineLayout Layout { get; init; }

        public VkPipeline BasePipelineHandle { get; init; }

        public int BasePipelineIndex { get; init; }
    }
}
