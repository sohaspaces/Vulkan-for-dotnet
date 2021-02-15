

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGraphicsPipelineCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineCreateFlags Flags { get; init; }

        public uint StageCount { get; init; }

        public unsafe VkPipelineShaderStageCreateInfo* Stages { get; init; }

        public unsafe VkPipelineVertexInputStateCreateInfo* VertexInputState { get; init; }

        public unsafe VkPipelineInputAssemblyStateCreateInfo* InputAssemblyState { get; init; }

        public unsafe VkPipelineTessellationStateCreateInfo* TessellationState { get; init; }

        public unsafe VkPipelineViewportStateCreateInfo* ViewportState { get; init; }

        public unsafe VkPipelineRasterizationStateCreateInfo* RasterizationState { get; init; }

        public unsafe VkPipelineMultisampleStateCreateInfo* MultisampleState { get; init; }

        public unsafe VkPipelineDepthStencilStateCreateInfo* DepthStencilState { get; init; }

        public unsafe VkPipelineColorBlendStateCreateInfo* ColorBlendState { get; init; }

        public unsafe VkPipelineDynamicStateCreateInfo* DynamicState { get; init; }

        public VkPipelineLayout Layout { get; init; }

        public VkRenderPass RenderPass { get; init; }

        public uint Subpass { get; init; }

        public VkPipeline BasePipelineHandle { get; init; }

        public int BasePipelineIndex { get; init; }
    }
}
