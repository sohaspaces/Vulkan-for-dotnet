

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRasterizationStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineRasterizationStateCreateFlags Flags { get; init; }

        public VkBool32 DepthClampEnable { get; init; }

        public VkBool32 RasterizerDiscardEnable { get; init; }

        public VkPolygonMode PolygonMode { get; init; }

        public VkCullModeFlags CullMode { get; init; }

        public VkFrontFace FrontFace { get; init; }

        public VkBool32 DepthBiasEnable { get; init; }

        public float DepthBiasConstantFactor { get; init; }

        public float DepthBiasClamp { get; init; }

        public float DepthBiasSlopeFactor { get; init; }

        public float LineWidth { get; init; }
    }
}
