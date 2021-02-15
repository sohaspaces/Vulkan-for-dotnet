

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCommandBufferInheritanceInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkRenderPass RenderPass { get; init; }

        public uint Subpass { get; init; }

        public VkFramebuffer Framebuffer { get; init; }

        public VkBool32 OcclusionQueryEnable { get; init; }

        public VkQueryControlFlags QueryFlags { get; init; }

        public VkQueryPipelineStatisticFlags PipelineStatistics { get; init; }
    }
}
