

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRayTracingPipelineCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineCreateFlags Flags { get; init; }

        public uint StageCount { get; init; }

        public unsafe VkPipelineShaderStageCreateInfo* Stages { get; init; }

        public uint GroupCount { get; init; }

        public unsafe VkRayTracingShaderGroupCreateInfo* Groups { get; init; }

        public uint MaxRecursionDepth { get; init; }

        public VkPipelineLayout Layout { get; init; }

        public VkPipeline BasePipelineHandle { get; init; }

        public int BasePipelineIndex { get; init; }
    }
}
